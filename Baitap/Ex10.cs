using System;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Ex10 : Form
    {
        // Khai báo các biến toàn cục để lưu trữ trạng thái máy tính
        decimal workingMemory = 0; // Lưu số thứ nhất được nhập vào
        string opr = "";           // Lưu toán tử (+ hoặc *)

        public Ex10()
        {
            InitializeComponent();
        }
        private void bt0_Click(object sender, EventArgs e) => tbDisplay.Text += "0"; //
        private void bt1_Click(object sender, EventArgs e) => tbDisplay.Text += "1"; //
        private void bt2_Click(object sender, EventArgs e) => tbDisplay.Text += "2";

        private void bt3_Click(object sender, EventArgs e) => tbDisplay.Text += "3"; //

        // Xử lý nút dấu chấm thập phân
        private void btDot_Click(object sender, EventArgs e)
        {
            // Chỉ cho phép thêm dấu chấm nếu trên màn hình chưa có dấu nào
            if (!tbDisplay.Text.Contains("."))
            {
                tbDisplay.Text += ".";
            }
        }

        // --- NHÓM XỬ LÝ TOÁN TỬ ---

        // Khi nhấn nút cộng (+)
        private void btPlus_Click(object sender, EventArgs e)
        {
            opr = "+"; // Lưu toán tử là dấu cộng
            workingMemory = decimal.Parse(tbDisplay.Text); // Lưu số hiện tại vào bộ nhớ
            tbDisplay.Clear(); // Xóa màn hình để nhập số tiếp theo
        }

        // Khi nhấn nút nhân (*)
        private void btMul_Click(object sender, EventArgs e)
        {
            opr = "*"; // Lưu toán tử là dấu nhân
            workingMemory = decimal.Parse(tbDisplay.Text); // Lưu số hiện tại vào bộ nhớ
            tbDisplay.Clear(); // Xóa màn hình để nhập số tiếp theo
        }

        // --- NHÓM XỬ LÝ KẾT QUẢ ---

        // Khi nhấn nút bằng (=)
        private void btEquals_Click(object sender, EventArgs e)
        {
            // Lấy con số thứ hai đang hiển thị trên màn hình
            decimal secondValue = decimal.Parse(tbDisplay.Text);

            // Kiểm tra toán tử đã lưu và thực hiện phép tính tương ứng
            if (opr == "+")
            {
                tbDisplay.Text = (workingMemory + secondValue).ToString(); //
            }
            if (opr == "*")
            {
                tbDisplay.Text = (workingMemory * secondValue).ToString(); //
            }
        }

        // Nút thoát chương trình
        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt4_Click(object sender, EventArgs e)
        {

        }
    }
}