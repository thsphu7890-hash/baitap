using System;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.Data.SqlClient;

namespace EmployerMananger
{
    public partial class Dashboard : Form
    {
        // 1. Cấu hình chuỗi kết nối
        private readonly string strConnect = @"Server=.\SQLEXPRESS;Database=EmployerDB;Integrated Security=True;TrustServerCertificate=True";

        // Biến lưu form con đang mở
        private Form activeForm = null;

        public Dashboard()
        {
            InitializeComponent();
            lblDateTime.Text = "Hôm nay: " + DateTime.Now.ToString("dd/MM/yyyy");

            // Gán sự kiện cho các nút Menu
            RegisterMenuEvents();

            // Load dữ liệu khi mở form
            this.Load += async (s, e) => await RefreshDashboardData();
        }

        private void RegisterMenuEvents()
        {
            btnDashboard.Click += btnDashboard_Click;
            btnEmployee.Click += btnEmployee_Click;
            btnPosition.Click += btnPosition_Click;
            btnDepartment.Click += btnDepartment_Click;
            btnAnalytics.Click += btnAnalytics_Click;
            btnSalary.Click += btnSalary_Click;
            btnLeave.Click += btnLeave_Click;
            btnSettings.Click += btnSettings_Click;
        }

        // --- PHẦN 1: LOGIC NẠP DỮ LIỆU BẤT ĐỒNG BỘ (ASYNCHRONOUS) ---

        private async Task RefreshDashboardData()
        {
            try
            {
                // Hiển thị trạng thái đang tải (Tùy chọn)
                lblTitle.Text = "ĐANG TẢI DỮ LIỆU...";

                await Task.WhenAll(
                    LoadDashboardStatsAsync(),
                    LoadChartDataAsync(),
                    LoadRecentEmployeesAsync()
                );

                lblTitle.Text = "DASHBOARD";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi hệ thống: {ex.Message}", "Lỗi Tải Dữ Liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadDashboardStatsAsync()
        {
            using (SqlConnection sqlCon = new SqlConnection(strConnect))
            {
                await sqlCon.OpenAsync();

                // Tổng hợp các lệnh SQL để chạy trong 1 lần kết nối
                string query = @"
                    SELECT COUNT(*) FROM NhanVien;
                    SELECT COUNT(*) FROM NhanVien WHERE MONTH(NgayVaoLam) = MONTH(GETDATE()) AND YEAR(NgayVaoLam) = YEAR(GETDATE());
                    SELECT COUNT(*) FROM DonXinNghi WHERE TrangThai = N'Chờ duyệt';";

                using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                {
                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync()) lblCard1Num.Text = reader[0].ToString();
                        if (await reader.NextResultAsync() && await reader.ReadAsync()) lblCard2Num.Text = reader[0].ToString();
                        if (await reader.NextResultAsync() && await reader.ReadAsync()) lblCard3Num.Text = reader[0].ToString();
                    }
                }
            }
        }

        private async Task LoadChartDataAsync()
        {
            DataTable dt = new DataTable();
            using (SqlConnection sqlCon = new SqlConnection(strConnect))
            {
                string query = @"SELECT pb.TenPhongBan, SUM(nv.LuongCoBan) as TongLuong 
                                 FROM NhanVien nv 
                                 JOIN PhongBan pb ON nv.PhongBanId = pb.Id 
                                 GROUP BY pb.TenPhongBan";

                SqlDataAdapter da = new SqlDataAdapter(query, sqlCon);
                await Task.Run(() => da.Fill(dt));
            }

            // Cập nhật UI biểu đồ
            chartSalary.Series.Clear();
            chartSalary.Titles.Clear();
            chartSalary.Titles.Add("Phân Bổ Quỹ Lương Theo Phòng Ban");

            Series s = new Series("Luong")
            {
                ChartType = SeriesChartType.Doughnut, // Chuyển sang Doughnut cho hiện đại
                IsValueShownAsLabel = true,
                LabelFormat = "#,##0 đ"
            };

            foreach (DataRow row in dt.Rows)
            {
                s.Points.AddXY(row["TenPhongBan"].ToString(), row["TongLuong"]);
            }
            chartSalary.Series.Add(s);
        }

        private async Task LoadRecentEmployeesAsync()
        {
            DataTable dt = new DataTable();
            using (SqlConnection sqlCon = new SqlConnection(strConnect))
            {
                string query = @"SELECT TOP 5 nv.HoTen, cv.TenChucVu, nv.NgayVaoLam 
                                 FROM NhanVien nv 
                                 LEFT JOIN NhanVien_ChucVu nvc ON nv.Id = nvc.NhanVienId
                                 LEFT JOIN ChucVu cv ON nvc.ChucVuId = cv.Id
                                 ORDER BY nv.NgayVaoLam DESC";

                SqlDataAdapter da = new SqlDataAdapter(query, sqlCon);
                await Task.Run(() => da.Fill(dt));
            }

            dgvRecent.DataSource = dt;
            dgvRecent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // --- PHẦN 2: ĐIỀU HƯỚNG VÀ HIỆU ỨNG GIAO DIỆN ---

        private async void btnDashboard_Click(object sender, EventArgs e)
        {
            if (activeForm != null) activeForm.Close();

            tblLayoutCards.Visible = true;
            tblLayoutBody.Visible = true;

            await RefreshDashboardData();
            MoveIndicator((Control)sender);
        }

        private void btnEmployee_Click(object sender, EventArgs e) => OpenChildForm(new Employee(), sender);
        private void btnPosition_Click(object sender, EventArgs e) => OpenChildForm(new Position(), sender);
        private void btnDepartment_Click(object sender, EventArgs e) => OpenChildForm(new Department(), sender);
        private void btnAnalytics_Click(object sender, EventArgs e) => OpenChildForm(new Analytics(), sender);
        private void btnSalary_Click(object sender, EventArgs e) => OpenChildForm(new Salary(), sender);
        private void btnLeave_Click(object sender, EventArgs e) => OpenChildForm(new LeaveRequest(), sender);

        private void btnSettings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phiên bản v2.0 Premium\nThiết kế bởi: AI Assistant", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MoveIndicator((Control)sender);
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null) activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            this.tblLayoutCards.Visible = false;
            this.tblLayoutBody.Visible = false;

            this.panelMain.Controls.Add(childForm);
            this.panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            lblTitle.Text = childForm.Text.ToUpper();
            MoveIndicator((Control)btnSender);
        }

        private void MoveIndicator(Control btn)
        {
            pnlNavIndicator.Top = btn.Top;
            pnlNavIndicator.Height = btn.Height;
        }
    }
}