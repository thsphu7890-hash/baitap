using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.IO;
using OfficeOpenXml;        // Thư viện Excel (EPPlus)
using OfficeOpenXml.Style;

namespace EmployerMananger
{
    public partial class Salary : Form
    {
        // 1. Cấu hình chuỗi kết nối
        string strConnect = @"Server=.\SQLEXPRESS;Database=EmployerDB;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection sqlCon = null;

        public Salary()
        {
            InitializeComponent();

            // Cấu hình License cho EPPlus
            ExcelPackage.License.SetNonCommercialPersonal("Hoc Tap");

            // Gán các sự kiện
            this.Load += Salary_Load;
            this.btnView.Click += BtnView_Click;
            this.btnSave.Click += BtnSave_Click;
            this.btnPrint.Click += BtnExport_Click;
            this.dgvSalary.CellValueChanged += DgvSalary_CellValueChanged;
        }

        private void Salary_Load(object sender, EventArgs e)
        {
            if (sqlCon == null) sqlCon = new SqlConnection(strConnect);
            if (sqlCon.State == ConnectionState.Closed) sqlCon.Open();

            // Load tháng
            cboMonth.Items.Clear();
            for (int i = 1; i <= 12; i++) cboMonth.Items.Add(i.ToString());

            // Load năm
            cboYear.Items.Clear();
            int curYear = DateTime.Now.Year;
            for (int i = curYear; i >= curYear - 10; i--)
            {
                cboYear.Items.Add(i.ToString());
            }

            cboMonth.Text = DateTime.Now.Month.ToString();
            cboYear.Text = curYear.ToString();
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            LoadSalaryData();
        }

        // --- [QUAN TRỌNG] HÀM LOAD DỮ LIỆU ĐÃ SỬA LOGIC NGÀY VÀO LÀM ---
        private void LoadSalaryData()
        {
            try
            {
                string thang = cboMonth.Text;
                string namString = cboYear.Text;

                if (string.IsNullOrEmpty(thang) || string.IsNullOrEmpty(namString)) return;

                int namChon = int.Parse(namString);
                int namHienTai = DateTime.Now.Year;

                // Tính hệ số lùi lương
                int khoangCachNam = namHienTai - namChon;
                double heSoChia = Math.Pow(1.1, khoangCachNam);
                string heSoSql = heSoChia.ToString(System.Globalization.CultureInfo.InvariantCulture);

                // Kiểm tra dữ liệu đã lưu chưa
                string checkSql = $"SELECT COUNT(*) FROM BangLuong WHERE Thang={thang} AND Nam={namChon}";
                SqlCommand cmdCheck = new SqlCommand(checkSql, sqlCon);
                int count = (int)cmdCheck.ExecuteScalar();

                string sqlQuery = "";

                if (count > 0)
                {
                    // TRƯỜNG HỢP A: Đã có dữ liệu lưu
                    // Thêm điều kiện: WHERE YEAR(nv.NgayVaoLam) <= {namChon}
                    // Nghĩa là: Chỉ lấy nhân viên vào làm TRƯỚC hoặc TRONG năm đang chọn
                    sqlQuery = $@"
                        SELECT 
                            nv.Id as NhanVienId, 
                            nv.MaNV, 
                            nv.HoTen, 
                            nv.NgayVaoLam, 
                            ISNULL(bl.LuongCoBan, CAST((nv.LuongCoBan / {heSoSql}) AS DECIMAL(18,0))) as LuongCoBan, 
                            ISNULL(bl.Thuong, 0) as Thuong, 
                            ISNULL(bl.Phat, 0) as Phat, 
                            ISNULL(bl.ThucLinh, CAST((nv.LuongCoBan / {heSoSql}) AS DECIMAL(18,0))) as ThucLinh
                        FROM NhanVien nv
                        LEFT JOIN BangLuong bl ON nv.Id = bl.NhanVienId AND bl.Thang = {thang} AND bl.Nam = {namChon}
                        WHERE YEAR(nv.NgayVaoLam) <= {namChon} 
                    ";
                }
                else
                {
                    // TRƯỜNG HỢP B: Chưa có dữ liệu lưu (Tính toán giả lập)
                    // Cũng thêm điều kiện WHERE tương tự
                    sqlQuery = $@"
                        SELECT Id as NhanVienId, MaNV, HoTen, NgayVaoLam,
                        CAST((LuongCoBan / {heSoSql}) AS DECIMAL(18,0)) as LuongCoBan, 
                        0 as Thuong, 0 as Phat, 
                        CAST((LuongCoBan / {heSoSql}) AS DECIMAL(18,0)) as ThucLinh
                        FROM NhanVien
                        WHERE YEAR(NgayVaoLam) <= {namChon}
                    ";
                }

                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, sqlCon);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvSalary.DataSource = dt;

                // Ẩn cột ID
                if (dgvSalary.Columns["NhanVienId"] != null) dgvSalary.Columns["NhanVienId"].Visible = false;

                // Cấu hình giao diện
                foreach (DataGridViewColumn col in dgvSalary.Columns)
                {
                    if (col.Name != "Thuong" && col.Name != "Phat") col.ReadOnly = true;
                    if (col.Name == "Thuong" || col.Name == "Phat") col.DefaultCellStyle.BackColor = Color.LightYellow;
                }

                // Định dạng hiển thị Ngày
                if (dgvSalary.Columns["NgayVaoLam"] != null)
                {
                    dgvSalary.Columns["NgayVaoLam"].DefaultCellStyle.Format = "dd/MM/yyyy";
                    dgvSalary.Columns["NgayVaoLam"].HeaderText = "Ngày Vào Làm";
                }

                // Định dạng tiền tệ
                string[] moneyCols = { "LuongCoBan", "Thuong", "Phat", "ThucLinh" };
                foreach (var col in moneyCols)
                    if (dgvSalary.Columns[col] != null) dgvSalary.Columns[col].DefaultCellStyle.Format = "N0";
            }
            catch (Exception ex) { MessageBox.Show("Lỗi hiển thị: " + ex.Message); }
        }

        // --- HÀM LƯU DỮ LIỆU ---
        private void BtnSave_Click(object sender, EventArgs e)
        {
            SqlTransaction transaction = sqlCon.BeginTransaction();
            try
            {
                string thang = cboMonth.Text;
                string nam = cboYear.Text;

                // 1. Xóa dữ liệu cũ
                string delSql = $"DELETE FROM BangLuong WHERE Thang={thang} AND Nam={nam}";
                new SqlCommand(delSql, sqlCon, transaction).ExecuteNonQuery();

                // 2. Chèn dữ liệu mới từ Grid
                foreach (DataGridViewRow row in dgvSalary.Rows)
                {
                    if (row.IsNewRow) continue;
                    string insertSql = @"INSERT INTO BangLuong (NhanVienId, Thang, Nam, LuongCoBan, Thuong, Phat, ThucLinh)
                                         VALUES (@Id, @Thang, @Nam, @Luong, @Thuong, @Phat, @ThucLinh)";

                    SqlCommand cmd = new SqlCommand(insertSql, sqlCon, transaction);
                    cmd.Parameters.AddWithValue("@Id", row.Cells["NhanVienId"].Value);
                    cmd.Parameters.AddWithValue("@Thang", thang);
                    cmd.Parameters.AddWithValue("@Nam", nam);
                    cmd.Parameters.AddWithValue("@Luong", ParseDecimal(row.Cells["LuongCoBan"].Value));
                    cmd.Parameters.AddWithValue("@Thuong", ParseDecimal(row.Cells["Thuong"].Value));
                    cmd.Parameters.AddWithValue("@Phat", ParseDecimal(row.Cells["Phat"].Value));
                    cmd.Parameters.AddWithValue("@ThucLinh", ParseDecimal(row.Cells["ThucLinh"].Value));

                    cmd.ExecuteNonQuery();
                }

                transaction.Commit();
                MessageBox.Show("Đã lưu bảng lương thành công!");
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Lỗi lưu: " + ex.Message);
            }
        }

        private void DgvSalary_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string colName = dgvSalary.Columns[e.ColumnIndex].Name;
            if (colName == "Thuong" || colName == "Phat")
            {
                var row = dgvSalary.Rows[e.RowIndex];
                decimal luong = ParseDecimal(row.Cells["LuongCoBan"].Value);
                decimal thuong = ParseDecimal(row.Cells["Thuong"].Value);
                decimal phat = ParseDecimal(row.Cells["Phat"].Value);
                row.Cells["ThucLinh"].Value = luong + thuong - phat;
            }
        }

        private decimal ParseDecimal(object value)
        {
            if (value == null || value == DBNull.Value) return 0;
            decimal res;
            if (decimal.TryParse(value.ToString().Replace(",", "").Replace(".", ""), out res)) return res;
            return 0;
        }

        // --- HÀM XUẤT EXCEL ---
        private void BtnExport_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel Files (*.xlsx)|*.xlsx";
                sfd.FileName = $"BangLuong_T{cboMonth.Text}_{cboYear.Text}";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (ExcelPackage p = new ExcelPackage())
                    {
                        ExcelWorksheet ws = p.Workbook.Worksheets.Add("Luong");

                        int colIndex = 1;
                        for (int i = 0; i < dgvSalary.Columns.Count; i++)
                        {
                            if (dgvSalary.Columns[i].Visible)
                            {
                                ws.Cells[1, colIndex].Value = dgvSalary.Columns[i].HeaderText;
                                ws.Cells[1, colIndex].Style.Font.Bold = true;
                                ws.Cells[1, colIndex].Style.Fill.PatternType = ExcelFillStyle.Solid;
                                ws.Cells[1, colIndex].Style.Fill.BackgroundColor.SetColor(Color.LightGray);
                                ws.Cells[1, colIndex].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                colIndex++;
                            }
                        }

                        for (int i = 0; i < dgvSalary.Rows.Count; i++)
                        {
                            colIndex = 1;
                            for (int j = 0; j < dgvSalary.Columns.Count; j++)
                            {
                                if (dgvSalary.Columns[j].Visible)
                                {
                                    object cellValue = dgvSalary.Rows[i].Cells[j].Value;
                                    ws.Cells[i + 2, colIndex].Value = cellValue;

                                    if (dgvSalary.Columns[j].Name == "LuongCoBan" || dgvSalary.Columns[j].Name == "Thuong" ||
                                        dgvSalary.Columns[j].Name == "Phat" || dgvSalary.Columns[j].Name == "ThucLinh")
                                    {
                                        ws.Cells[i + 2, colIndex].Style.Numberformat.Format = "#,##0";
                                    }

                                    if (dgvSalary.Columns[j].Name == "NgayVaoLam" && cellValue != null && cellValue != DBNull.Value)
                                    {
                                        ws.Cells[i + 2, colIndex].Style.Numberformat.Format = "dd/MM/yyyy";
                                    }
                                    colIndex++;
                                }
                            }
                        }
                        ws.Cells.AutoFitColumns();
                        p.SaveAs(new FileInfo(sfd.FileName));
                        MessageBox.Show("Xuất file thành công!");
                        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo() { FileName = sfd.FileName, UseShellExecute = true });
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi xuất Excel: " + ex.Message); }
        }
    }
}       