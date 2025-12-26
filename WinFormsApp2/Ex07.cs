using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Ex07 : Form
    {
        public Ex07()
        {
            InitializeComponent();
        }

        private void tbYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Nếu phím nhấn KHÔNG phải là phím điều khiển (như Backspace) 
            // VÀ KHÔNG phải là chữ số thì hủy bỏ phím đó.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Chặn ký tự không hợp lệ
            }
        }
        private void tbYear_Validating(object sender, CancelEventArgs e)
        {
            int year = int.Parse(tb_Year.Text); // Chuyển chuỗi thành số

            if (year > 2000)
            {
                // Hủy bỏ việc chuyển sang ô khác, bắt người dùng phải sửa lại
                e.Cancel = true;
            }
        }
    }
}
