using System;
using System.Data;
using System.Drawing; // Required for Color, Font
using System.Windows.Forms;
using Microsoft.Data.SqlClient; // Required for SQL connection

namespace EmployerMananger
{
    public partial class AdminMain : Form
    {
        // ⚠️ NOTE: Change the connection string if you are using LocalDB
        string strKetNoi = @"Server=.\SQLEXPRESS;Database=EmployerDB;Trusted_Connection=True;TrustServerCertificate=True;";

        int idDangChon = -1; // Variable to store the selected row ID

        public AdminMain()
        {
            InitializeComponent();
        }

        // --- 1. WHEN FORM LOADS ---
        private void AdminMain_Load(object sender, EventArgs e)
        {
            TaiDanhSach();      // Load data
            TrangTriGiaoDien(); // Beautify the grid
        }

        // --- FUNCTION TO LOAD DATA ---
        void TaiDanhSach()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(strKetNoi))
                {
                    conn.Open();
                    // Fetch all columns (even if some like Email, DiaChi are currently NULL)
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM NhanVien", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvNhanVien.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error: " + ex.Message);
            }
        }

        // --- BEAUTIFY INTERFACE (FULL SCREEN FIX - WIDER COLUMNS) ---
        void TrangTriGiaoDien()
        {
            // 1. General Configuration
            dgvNhanVien.BackgroundColor = Color.White;
            dgvNhanVien.BorderStyle = BorderStyle.None;
            dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // IMPORTANT: Disable auto-size to allow horizontal scrolling if needed, but we set wide columns
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Fill the screen width
            // If you prefer scrolling, use: dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            // 2. Colors & Fonts (Flat Style)
            dgvNhanVien.EnableHeadersVisualStyles = false;
            dgvNhanVien.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvNhanVien.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72); // Dark Blue
            dgvNhanVien.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvNhanVien.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvNhanVien.ColumnHeadersHeight = 40;

            // Row Styles
            dgvNhanVien.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvNhanVien.DefaultCellStyle.ForeColor = Color.Black;
            dgvNhanVien.DefaultCellStyle.SelectionBackColor = Color.ForestGreen;
            dgvNhanVien.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvNhanVien.RowTemplate.Height = 35; // Taller rows
            dgvNhanVien.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);

            // 3. Column Settings (Hide/Rename/Resize)

            // Hide ID and Password columns
            if (dgvNhanVien.Columns["Id"] != null) dgvNhanVien.Columns["Id"].Visible = false;
            if (dgvNhanVien.Columns["MatKhau"] != null) dgvNhanVien.Columns["MatKhau"].Visible = false;

            // Rename Headers and Set Widths (Increased for Full Screen)
            if (dgvNhanVien.Columns["MaNV"] != null)
            {
                dgvNhanVien.Columns["MaNV"].HeaderText = "Mã NV";
                // dgvNhanVien.Columns["MaNV"].Width = 100; // AutoFill handles width, but you can set min width
            }
            if (dgvNhanVien.Columns["HoTen"] != null)
            {
                dgvNhanVien.Columns["HoTen"].HeaderText = "Họ và Tên";
            }
            if (dgvNhanVien.Columns["NgaySinh"] != null)
            {
                dgvNhanVien.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            }
            if (dgvNhanVien.Columns["GioiTinh"] != null)
            {
                dgvNhanVien.Columns["GioiTinh"].HeaderText = "Giới tính";
            }
            if (dgvNhanVien.Columns["SoDienThoai"] != null)
            {
                dgvNhanVien.Columns["SoDienThoai"].HeaderText = "SĐT";
            }
            if (dgvNhanVien.Columns["Email"] != null)
            {
                dgvNhanVien.Columns["Email"].HeaderText = "Email";
            }
            if (dgvNhanVien.Columns["DiaChi"] != null)
            {
                dgvNhanVien.Columns["DiaChi"].HeaderText = "Địa chỉ";
            }
            if (dgvNhanVien.Columns["ChucVu"] != null)
            {
                dgvNhanVien.Columns["ChucVu"].HeaderText = "Chức vụ";
            }
            if (dgvNhanVien.Columns["LuongCoBan"] != null)
            {
                dgvNhanVien.Columns["LuongCoBan"].HeaderText = "Lương CB";
                dgvNhanVien.Columns["LuongCoBan"].DefaultCellStyle.Format = "N0";
                dgvNhanVien.Columns["LuongCoBan"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            if (dgvNhanVien.Columns["NgayVaoLam"] != null)
            {
                dgvNhanVien.Columns["NgayVaoLam"].HeaderText = "Ngày vào";
            }
            if (dgvNhanVien.Columns["TenDangNhap"] != null)
            {
                dgvNhanVien.Columns["TenDangNhap"].HeaderText = "Tài khoản";
            }
        }

        // --- 2. ADD BUTTON ---
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNV.Text) || string.IsNullOrWhiteSpace(txtHoTen.Text) || string.IsNullOrWhiteSpace(txtUser.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã NV, Họ tên và Tài khoản!");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(strKetNoi))
                {
                    conn.Open();
                    // Insert data into fields present on the form, leave others (Email, DiaChi) as NULL
                    string query = "INSERT INTO NhanVien (MaNV, HoTen, TenDangNhap, MatKhau, ChucVu) VALUES (@mnv, @ht, @u, @p, @r)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@mnv", txtMaNV.Text);
                        cmd.Parameters.AddWithValue("@ht", txtHoTen.Text);
                        cmd.Parameters.AddWithValue("@u", txtUser.Text);
                        cmd.Parameters.AddWithValue("@p", txtPass.Text);
                        cmd.Parameters.AddWithValue("@r", txtRole.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm thành công: " + txtMaNV.Text);
                        TaiDanhSach();
                        LamMoi();
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UNIQUE")) MessageBox.Show("Lỗi: Mã nhân viên hoặc Tài khoản đã tồn tại!");
                else MessageBox.Show("Lỗi Thêm: " + ex.Message);
            }
        }

        // --- 3. EDIT BUTTON ---
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (idDangChon == -1) { MessageBox.Show("Vui lòng chọn nhân viên cần sửa!"); return; }

            try
            {
                using (SqlConnection conn = new SqlConnection(strKetNoi))
                {
                    conn.Open();
                    string query = "UPDATE NhanVien SET MaNV=@mnv, HoTen=@ht, TenDangNhap=@u, MatKhau=@p, ChucVu=@r WHERE Id=@id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@mnv", txtMaNV.Text);
                        cmd.Parameters.AddWithValue("@ht", txtHoTen.Text);
                        cmd.Parameters.AddWithValue("@u", txtUser.Text);
                        cmd.Parameters.AddWithValue("@p", txtPass.Text);
                        cmd.Parameters.AddWithValue("@r", txtRole.Text);
                        cmd.Parameters.AddWithValue("@id", idDangChon);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cập nhật thành công!");
                        TaiDanhSach();
                        LamMoi();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi Sửa: " + ex.Message); }
        }

        // --- 4. DELETE BUTTON ---
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (idDangChon == -1) { MessageBox.Show("Vui lòng chọn nhân viên cần xóa!"); return; }

            if (MessageBox.Show("Xóa nhân viên này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(strKetNoi))
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand("DELETE FROM NhanVien WHERE Id=@id", conn))
                        {
                            cmd.Parameters.AddWithValue("@id", idDangChon);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Đã xóa!");
                            TaiDanhSach();
                            LamMoi();
                        }
                    }
                }
                catch (Exception ex) { MessageBox.Show("Lỗi Xóa: " + ex.Message); }
            }
        }

        // --- 5. REFRESH BUTTON ---
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        void LamMoi()
        {
            txtMaNV.Text = "";
            txtHoTen.Text = "";
            txtUser.Text = "";
            txtPass.Text = "";
            txtRole.Text = "";
            idDangChon = -1;
            txtMaNV.Focus();
        }

        // --- 6. GRID CLICK EVENT (Populate inputs) ---
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() != "")
                {
                    idDangChon = Convert.ToInt32(row.Cells[0].Value);

                    // Check for nulls before assigning
                    if (row.Cells["MaNV"].Value != null) txtMaNV.Text = row.Cells["MaNV"].Value.ToString();
                    if (row.Cells["HoTen"].Value != null) txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
                    if (row.Cells["TenDangNhap"].Value != null) txtUser.Text = row.Cells["TenDangNhap"].Value.ToString();
                    if (row.Cells["MatKhau"].Value != null) txtPass.Text = row.Cells["MatKhau"].Value.ToString();
                    if (row.Cells["ChucVu"].Value != null) txtRole.Text = row.Cells["ChucVu"].Value.ToString();
                }
            }
        }

        // --- 7. EXIT BUTTON ---
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}