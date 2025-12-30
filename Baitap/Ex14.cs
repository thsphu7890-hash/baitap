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
    public partial class Ex14 : Form
    {
        public Ex14()
        {
            InitializeComponent();
        }

        // 1. Sự kiện khi tích vào ô "Giảm giá" (Slide 106)
        // Nếu tích -> Cho phép nhập số tiền giảm. Nếu bỏ tích -> Khóa ô nhập.
        private void ckDiscount_CheckedChanged(object sender, EventArgs e)
        {
            if (ckDiscount.Checked == true)
            {
                tbDiscount.Enabled = true; // Mở khóa
            }
            else
            {
                tbDiscount.Enabled = false; // Khóa lại
                tbDiscount.Text = "";       // Xóa số cũ cho sạch
            }
        }

        // 2. Sự kiện bấm nút "Tính tiền" (Slide 106)
        private void btRun_Click(object sender, EventArgs e)
        {
            string msg = "";
            int disc = 0;

            // Kiểm tra RadioButton để xác định giới tính (Ông/Bà)
            if (rbMale.Checked == true)
            {
                msg = "Ông ";
            }
            else if (rbFemale.Checked == true)
            {
                msg = "Bà ";
            }

            // Kiểm tra CheckBox để lấy % giảm giá
            if (ckDiscount.Checked == true)
            {
                // Dùng TryParse để tránh lỗi nếu người dùng nhập chữ cái thay vì số
                int.TryParse(tbDiscount.Text, out disc);
            }

            // Hiển thị kết quả ra TextBox (tbResult)
            // \r\n là ký tự xuống dòng
            tbResult.Text = msg + tbName.Text + " được giảm " + disc.ToString() + "%" + "\r\n";
        }

        // 3. Sự kiện bấm nút "Thoát"
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng Form
        }
    }
}