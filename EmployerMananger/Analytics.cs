using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting; // Thư viện biểu đồ
using Microsoft.Data.SqlClient;
using iTextSharp.text; // Thư viện PDF
using iTextSharp.text.pdf;

namespace EmployerMananger
{
    public partial class Analytics : Form
    {
        // 1. CẤU HÌNH KẾT NỐI CHUẨN (Đã tối ưu Connection Timeout)
        private readonly string strConnect = @"Server=DESKTOP-NU0G382\SQLEXPRESS;Database=EmployerDB;Integrated Security=True;TrustServerCertificate=True;Connection Timeout=30";

        public Analytics()
        {
            InitializeComponent();
            SetupEvents();
            ApplyModernUI();
        }

        private void SetupEvents()
        {
            this.Load += Analytics_Load;
            this.btnExport.Click += BtnExport_Click;
        }

        private void Analytics_Load(object sender, EventArgs e)
        {
            // Load toàn bộ dữ liệu khi mở form
            LoadDashboardData();
        }

        private void ApplyModernUI()
        {
            this.BackColor = Color.FromArgb(240, 242, 245); // Màu nền hiện đại
        }

        // --- TRUNG TÂM XỬ LÝ DỮ LIỆU ---
        private void LoadDashboardData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(strConnect))
                {
                    conn.Open();

                    // 1. LOAD THẺ SỐ LIỆU (CARDS)
                    LoadCards(conn);

                    // 2. LOAD BIỂU ĐỒ TRÒN (PHÒNG BAN)
                    LoadChartDept(conn);

                    // 3. LOAD BIỂU ĐỒ KẾT HỢP (CHỨC VỤ)
                    LoadChartRoleCombo(conn);

                    // 4. LOAD BIỂU ĐỒ CỘT (LƯƠNG)
                    LoadChartSalaryByDept(conn);

                    // 5. LOAD BẢNG TOP 5
                    LoadTopHighSalary(conn);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ---------------------------------------------------------
        // 1. LOAD CARDS (SỐ LIỆU TỔNG QUAN)
        // ---------------------------------------------------------
        private void LoadCards(SqlConnection conn)
        {
            // Tổng nhân sự
            using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM NhanVien", conn))
                lblTotalNum.Text = cmd.ExecuteScalar().ToString();

            // Tổng quỹ lương
            using (SqlCommand cmd = new SqlCommand("SELECT ISNULL(SUM(LuongCoBan), 0) FROM NhanVien", conn))
            {
                decimal totalSal = Convert.ToDecimal(cmd.ExecuteScalar());
                lblSalNum.Text = totalSal.ToString("#,##0") + " đ";
            }

            // Số lượng Nam (Có chữ N trước 'Nam' để hiểu tiếng Việt)
            using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM NhanVien WHERE GioiTinh = N'Nam'", conn))
                lblMaleNum.Text = cmd.ExecuteScalar().ToString();

            // Số lượng Nữ
            using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM NhanVien WHERE GioiTinh = N'Nữ'", conn))
                lblFeNum.Text = cmd.ExecuteScalar().ToString();
        }

        // ---------------------------------------------------------
        // 2. BIỂU ĐỒ TRÒN (DEPARTMENT) - FIX MÀU & LEGEND
        // ---------------------------------------------------------
        private void LoadChartDept(SqlConnection conn)
        {
            string sql = @"SELECT pb.TenPhongBan, COUNT(nv.Id) as SoLuong 
                           FROM PhongBan pb LEFT JOIN NhanVien nv ON pb.Id = nv.PhongBanId 
                           GROUP BY pb.TenPhongBan HAVING COUNT(nv.Id) > 0";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            chartDept.Series.Clear();

            // Tạo Series mới
            Series s = new Series("NhanSu");
            s.ChartType = SeriesChartType.Doughnut;
            s["PieLabelStyle"] = "Outside";
            s.BorderColor = Color.White;
            s.BorderWidth = 2;

            // Định dạng hiển thị
            s.Label = "#PERCENT{P0}"; // Trên biểu đồ hiện %
            s.LegendText = "#VALX (#VAL)"; // Chú thích hiện Tên (Số lượng)

            // Tự phối màu để đẹp hơn mặc định
            chartDept.Palette = ChartColorPalette.None;
            Color[] myColors = { Color.FromArgb(65, 140, 240), Color.FromArgb(252, 180, 65), Color.FromArgb(224, 64, 10), Color.FromArgb(5, 100, 146) };

            int i = 0;
            foreach (DataRow row in dt.Rows)
            {
                int idx = s.Points.AddXY(row["TenPhongBan"], row["SoLuong"]);
                s.Points[idx].Color = myColors[i % myColors.Length]; // Gán màu
                i++;
            }

            chartDept.Series.Add(s);
        }

        // ---------------------------------------------------------
        // 3. BIỂU ĐỒ COMBO (CỘT + ĐƯỜNG) - FIX DỒN CỤC
        // ---------------------------------------------------------
        private void LoadChartRoleCombo(SqlConnection conn)
        {
            string sql = @"SELECT cv.TenChucVu, COUNT(nvc.NhanVienId) as SoLuong 
                           FROM ChucVu cv 
                           LEFT JOIN NhanVien_ChucVu nvc ON cv.Id = nvc.ChucVuId 
                           GROUP BY cv.TenChucVu HAVING COUNT(nvc.NhanVienId) > 0";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            chartRole.Series.Clear();

            // Series 1: Cột (Column)
            Series sCol = new Series("Số lượng");
            sCol.ChartType = SeriesChartType.Column;
            sCol.Color = Color.FromArgb(52, 152, 219); // Xanh dương
            sCol.IsXValueIndexed = true; // [QUAN TRỌNG] Fix lỗi dồn cục

            // Series 2: Đường (Spline) tạo hiệu ứng xu hướng
            Series sLine = new Series("Xu hướng");
            sLine.ChartType = SeriesChartType.Spline;
            sLine.Color = Color.Red;
            sLine.BorderWidth = 3;
            sLine.IsXValueIndexed = true; // [QUAN TRỌNG] Phải khớp với cột

            foreach (DataRow row in dt.Rows)
            {
                string tenCV = row["TenChucVu"].ToString();
                int sl = Convert.ToInt32(row["SoLuong"]);
                sCol.Points.AddXY(tenCV, sl);
                sLine.Points.AddXY(tenCV, sl);
            }

            chartRole.Series.Add(sCol);
            chartRole.Series.Add(sLine);
        }

        // ---------------------------------------------------------
        // 4. BIỂU ĐỒ CỘT NGANG (QUỸ LƯƠNG)
        // ---------------------------------------------------------
        private void LoadChartSalaryByDept(SqlConnection conn)
        {
            string sql = @"SELECT pb.TenPhongBan, SUM(ISNULL(nv.LuongCoBan,0)) as TongLuong 
                           FROM PhongBan pb JOIN NhanVien nv ON pb.Id = nv.PhongBanId 
                           GROUP BY pb.TenPhongBan";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            chartSalaryDept.Series.Clear();
            Series s = new Series("Luong");
            s.ChartType = SeriesChartType.Bar; // Cột ngang
            s.Color = Color.FromArgb(46, 204, 113); // Xanh lá
            s.IsValueShownAsLabel = true;
            s.LabelFormat = "#,##0,, tr"; // Format dạng rút gọn (VD: 10 tr)
            s.IsXValueIndexed = true;

            foreach (DataRow row in dt.Rows)
            {
                s.Points.AddXY(row["TenPhongBan"], row["TongLuong"]);
            }
            chartSalaryDept.Series.Add(s);
        }

        // ---------------------------------------------------------
        // 5. BẢNG TOP 5 LƯƠNG CAO
        // ---------------------------------------------------------
        private void LoadTopHighSalary(SqlConnection conn)
        {
            string sql = @"SELECT TOP 5 HoTen, LuongCoBan, 
                          (SELECT TenPhongBan FROM PhongBan WHERE Id = nv.PhongBanId) as Phong 
                          FROM NhanVien nv ORDER BY LuongCoBan DESC";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvTopSalary.DataSource = dt;

            // Định dạng lại tên cột cho đẹp
            if (dgvTopSalary.Columns.Contains("HoTen")) dgvTopSalary.Columns["HoTen"].HeaderText = "HỌ TÊN";
            if (dgvTopSalary.Columns.Contains("LuongCoBan"))
            {
                dgvTopSalary.Columns["LuongCoBan"].HeaderText = "LƯƠNG";
                dgvTopSalary.Columns["LuongCoBan"].DefaultCellStyle.Format = "N0";
            }
            if (dgvTopSalary.Columns.Contains("Phong")) dgvTopSalary.Columns["Phong"].HeaderText = "PHÒNG BAN";
        }

        // ---------------------------------------------------------
        // 6. XUẤT PDF (CHỤP MÀN HÌNH FORM)
        // ---------------------------------------------------------
        private void BtnExport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog { Filter = "PDF Files|*.pdf", FileName = "BaoCao_HRM_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // 1. Tạo Bitmap từ Form hiện tại
                        Bitmap bmp = new Bitmap(this.panelMainLayout.Width + 50, this.Height);
                        this.DrawToBitmap(bmp, new System.Drawing.Rectangle(0, 0, this.Width, this.Height));

                        // 2. Khởi tạo tài liệu PDF (Khổ ngang - Rotate)
                        Document doc = new Document(PageSize.A4.Rotate(), 10, 10, 10, 10);
                        PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                        doc.Open();

                        // 3. Tiêu đề
                        iTextSharp.text.Font titleFont = FontFactory.GetFont("Arial", 18, iTextSharp.text.Font.BOLD);
                        Paragraph title = new Paragraph("BÁO CÁO THỐNG KÊ NHÂN SỰ", titleFont);
                        title.Alignment = Element.ALIGN_CENTER;
                        title.SpacingAfter = 20;
                        doc.Add(title);

                        // 4. Chèn ảnh Form vào PDF
                        iTextSharp.text.Image pdfImg = iTextSharp.text.Image.GetInstance(bmp, System.Drawing.Imaging.ImageFormat.Png);

                        // Tự động căn chỉnh tỷ lệ ảnh cho vừa trang A4
                        float scaler = ((doc.PageSize.Width - doc.LeftMargin - doc.RightMargin) / pdfImg.Width) * 100;
                        pdfImg.ScalePercent(scaler);
                        pdfImg.Alignment = Element.ALIGN_CENTER;

                        doc.Add(pdfImg);
                        doc.Close();

                        MessageBox.Show("Xuất báo cáo PDF thành công!", "Thông báo");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xuất PDF: " + ex.Message);
                    }
                }
            }
        }
    }
}