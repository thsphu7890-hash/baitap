using System;
using System.IO; // Thư viện bắt buộc để dùng StreamWriter
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Ex09 : Form
    {
        public Ex09()
        {
            InitializeComponent();
        }

        // Xử lý phép Cộng
        private void btCong_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ các Textbox
            int x = int.Parse(tbSoX.Text);
            int y = int.Parse(tbSoY.Text);
            int kq = x + y;

            // Nối kết quả mới vào nội dung cũ trong Textbox Multiline
            // "\r\n" dùng để xuống dòng trong Windows
            tbKetQua.Text = tbKetQua.Text + x.ToString() + " + " + y.ToString() + " = " + kq.ToString() + "\r\n";
        }

        // Xử lý phép Nhân
        private void btNhan_Click(object sender, EventArgs e)
        {
            int x = int.Parse(tbSoX.Text);
            int y = int.Parse(tbSoY.Text);
            int kq = x * y;

            // Nối kết quả phép nhân vào lịch sử
            tbKetQua.Text = tbKetQua.Text + x.ToString() + " * " + y.ToString() + " = " + kq.ToString() + "\r\n";
        }

        // Xử lý nút Lưu vào file .txt
        private void btLuu_Click(object sender, EventArgs e)
        {
            // Mở file "Caculator.txt", tham số 'true' để ghi nối tiếp (append)
            StreamWriter sw = new StreamWriter("Caculator.txt", true);
            sw.Write(tbKetQua.Text); // Ghi toàn bộ nội dung trong ô Kết quả
            sw.Close(); // Đóng file để hoàn tất việc lưu

            MessageBox.Show("Đã lưu lịch sử vào file Caculator.txt!");
        }

        // Xử lý nút Thoát
        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng Form
        }
    }
}