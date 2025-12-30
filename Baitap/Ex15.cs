using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baitap
{
    public partial class Ex15 : Form
    {
        public Ex15()
        {
            InitializeComponent();
        }

        // 1. Sự kiện khi bạn đổi ngày trên lịch (Slide 110)
        // Yêu cầu: Hiển thị ngày ngắn (ShortDate) lên tiêu đề Form (VD: 30/09/2017)
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // Lấy ngày hiện tại từ DateTimePicker và chuyển thành chuỗi ngắn
            this.Text = dateTimePicker1.Value.ToShortDateString();
        }

        // 2. Sự kiện khi bấm nút OK (Slide 110)
        // Yêu cầu: Hiển thị ngày dài (LongDate) lên tiêu đề Form (VD: Saturday, September 30, 2017)
        private void btn_Ok_Click(object sender, EventArgs e)
        {
            // Lấy ngày hiện tại và chuyển thành chuỗi dài đầy đủ
            this.Text = dateTimePicker1.Value.ToLongDateString();
        }
    }
}