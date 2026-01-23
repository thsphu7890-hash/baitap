using System;
using System.Windows.Forms;

namespace EmployerMananger
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        // --- 1. KHI BẤM NÚT "NHÂN VIÊN" ---
        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMain formNhanVien = new AdminMain();
            formNhanVien.ShowDialog();
            this.Show();
        }

        // --- 2. KHI BẤM NÚT "TÀI KHOẢN" ---
        private void btnAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            Account formTaiKhoan = new Account();
            formTaiKhoan.ShowDialog(); // Mở trang Tài khoản
            this.Show();
        }

        // --- 3. KHI BẤM NÚT "ĐĂNG XUẤT" ---
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát phần mềm không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}