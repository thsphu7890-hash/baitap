using System;
using System.Windows.Forms;

namespace Baitap
{
    public partial class Ex12 : Form
    {
        public Ex12()
        {
            InitializeComponent();
        }

        // Sự kiện khi Form vừa mở lên (Slide 96)
        private void Ex12_Load(object sender, EventArgs e)
        {
            // Tự động chọn khoa thứ 3 (index = 2 là Quản trị kinh doanh)
            cb_Faculty.SelectedIndex = 2;
        }

        // Sự kiện khi người dùng đổi mục chọn trong ComboBox (Slide 96)
        private void cb_Faculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy số thứ tự (index)
            int index = cb_Faculty.SelectedIndex;

            // Hiển thị ra TextBox
            tbDisplay.Text = "Bạn đã chọn khoa thứ: " + index.ToString();
        }

        // Sự kiện bấm nút OK (Slide 96)
        private void btOK_Click(object sender, EventArgs e)
        {
            // Lấy nội dung chữ (Text) của mục đang chọn
            string item = cb_Faculty.SelectedItem.ToString();

            // Hiển thị ra TextBox
            tbDisplay.Text = "Bạn là sinh viên khoa: " + item;
        }
    }
}