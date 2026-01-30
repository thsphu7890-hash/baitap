using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace EmployerMananger
{
    public partial class Login : Form
    {
        // Chuỗi kết nối y hệt các Form kia
        string strConnect = @"Server=.\SQLEXPRESS;Database=EmployerDB;Integrated Security=True;TrustServerCertificate=True";

        public Login()
        {
            InitializeComponent();

            // Gán sự kiện click
            btnLogin.Click += BtnLogin_Click;
            btnExit.Click += BtnExit_Click;
            chkShowPass.CheckedChanged += ChkShowPass_CheckedChanged;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tài khoản và mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection sqlCon = new SqlConnection(strConnect))
                {
                    sqlCon.Open();
                    // Kiểm tra tài khoản trong bảng NhanVien (đã tạo ở bước Database)
                    string query = "SELECT COUNT(1) FROM NhanVien WHERE TenDangNhap=@user AND MatKhau=@pass";
                    SqlCommand cmd = new SqlCommand(query, sqlCon);
                    cmd.Parameters.AddWithValue("@user", txtUser.Text.Trim());
                    cmd.Parameters.AddWithValue("@pass", txtPass.Text.Trim());

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count == 1)
                    {
                        // Đăng nhập thành công -> Mở Dashboard
                        Dashboard dash = new Dashboard();
                        this.Hide(); // Ẩn form Login
                        dash.ShowDialog();
                        this.Close(); // Đóng hoàn toàn khi Dashboard tắt
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ChkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            // Logic ẩn hiện mật khẩu
            if (chkShowPass.Checked)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }
    }
}