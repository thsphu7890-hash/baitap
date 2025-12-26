using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp2
{
    public partial class Ex08 : Form
    {
        public Ex08()
        {
            InitializeComponent();
        }

        private void btCong_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị từ Textbox
                int x = int.Parse(tbSoX.Text);
                int y = int.Parse(tbSoY.Text);

                int kq = x + y; // Thực hiện phép cộng

                // Hiển thị kết quả
                tbKetQua.Text = kq.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng chỉ nhập số vào ô So_X và So_Y!");
            }
        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(tbSoX.Text);
                int y = int.Parse(tbSoY.Text);
                int kq = x * y; // Thực hiện phép nhân
                tbKetQua.Text = kq.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng chỉ nhập số!");
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng ứng dụng an toàn
        }

        
    }
}
