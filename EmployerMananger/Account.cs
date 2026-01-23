using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace EmployerMananger
{
    public partial class Account : Form
    {
        // Nhớ kiểm tra lại chuỗi kết nối này nhé!
        string strKetNoi = @"Server=.\SQLEXPRESS;Database=EmployerDB;Trusted_Connection=True;TrustServerCertificate=True;";
        string currentUser = "admin"; // Giả định đang đăng nhập là admin

        public Account()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close(); // Quay về Dashboard
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra nhập thiếu
            if (string.IsNullOrWhiteSpace(txtMatKhauCu.Text) ||
                string.IsNullOrWhiteSpace(txtMatKhauMoi.Text) ||
                string.IsNullOrWhiteSpace(txtXacNhan.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            // Kiểm tra nhập lại khớp không
            if (txtMatKhauMoi.Text != txtXacNhan.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp!");
                return;
            }

            // Xử lý đổi mật khẩu
            try
            {
                using (SqlConnection conn = new SqlConnection(strKetNoi))
                {
                    conn.Open();
                    // 1. Kiểm tra mật khẩu cũ
                    string sqlCheck = "SELECT COUNT(*) FROM NhanVien WHERE TenDangNhap = @u AND MatKhau = @pOld";
                    SqlCommand cmdCheck = new SqlCommand(sqlCheck, conn);
                    cmdCheck.Parameters.AddWithValue("@u", currentUser);
                    cmdCheck.Parameters.AddWithValue("@pOld", txtMatKhauCu.Text);

                    int count = (int)cmdCheck.ExecuteScalar();

                    if (count > 0)
                    {
                        // 2. Cập nhật mật khẩu mới
                        string sqlUpdate = "UPDATE NhanVien SET MatKhau = @pNew WHERE TenDangNhap = @u";
                        SqlCommand cmdUpdate = new SqlCommand(sqlUpdate, conn);
                        cmdUpdate.Parameters.AddWithValue("@pNew", txtMatKhauMoi.Text);
                        cmdUpdate.Parameters.AddWithValue("@u", currentUser);
                        cmdUpdate.ExecuteNonQuery();

                        MessageBox.Show("Đổi mật khẩu thành công!");
                        txtMatKhauCu.Text = ""; txtMatKhauMoi.Text = ""; txtXacNhan.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu cũ không đúng!");
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }
    }
}