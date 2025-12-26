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
    public partial class Ex06 : Form
    {
        public Ex06()
        {
            InitializeComponent();
        }

        private void bt_OK_Click(object sender, EventArgs e)
        {
            this.Text = "Article for Button"; // Thay đổi tiêu đề thanh Taskbar
            this.Size = new Size(500, 500);    // Thay đổi kích thước Form thành 500x500
        }
    }
}
