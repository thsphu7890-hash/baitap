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
    public partial class Ex11 : Form
    {
        // 1. Khai báo các biến lưu trữ trạng thái (Theo Slide 83)
        decimal memory = 0;        // Biến nhớ (cho các nút M)
        decimal workingMemory = 0; // Biến lưu số hạng thứ nhất
        string opr = "";           // Biến lưu dấu phép tính (+, -, *, /)

        public Ex11()
        {
            InitializeComponent();
        }

        // 2. Hàm xử lý sự kiện Click chung cho TẤT CẢ các nút
        private void Button_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender; // Lấy thông tin nút vừa bấm

            // --- NHÓM 1: NHẬP SỐ VÀ DẤU CHẤM (Slide 84) ---
            if ((char.IsDigit(bt.Text, 0) && bt.Text.Length == 1) || bt.Text == ".")
            {
                // Nếu màn hình đang là 0 và không phải bấm dấu chấm -> Xóa số 0 đi
                if (txtDisplay.Text == "0" && bt.Text != ".")
                {
                    txtDisplay.Clear();
                }

                // Chặn nhập nhiều dấu chấm
                if (bt.Text == "." && txtDisplay.Text.Contains("."))
                {
                    return;
                }

                txtDisplay.Text += bt.Text;
            }

            // --- NHÓM 2: CÁC PHÉP TOÁN CƠ BẢN (+, -, *, /) (Slide 86) ---
            else if (bt.Text == "+" || bt.Text == "-" || bt.Text == "*" || bt.Text == "/")
            {
                opr = bt.Text;
                if (decimal.TryParse(txtDisplay.Text, out decimal val))
                {
                    workingMemory = val;
                }
                txtDisplay.Clear(); // Xóa màn hình để nhập số thứ 2
            }

            // --- NHÓM 3: XỬ LÝ KẾT QUẢ (=) (Slide 87) ---
            else if (bt.Text == "=")
            {
                decimal secondValue = 0;
                if (!decimal.TryParse(txtDisplay.Text, out secondValue)) return;

                switch (opr)
                {
                    case "+":
                        txtDisplay.Text = (workingMemory + secondValue).ToString();
                        break;
                    case "-":
                        txtDisplay.Text = (workingMemory - secondValue).ToString();
                        break;
                    case "*":
                        txtDisplay.Text = (workingMemory * secondValue).ToString();
                        break;
                    case "/":
                        if (secondValue != 0)
                            txtDisplay.Text = (workingMemory / secondValue).ToString();
                        else
                            MessageBox.Show("Không thể chia cho 0");
                        break;
                }
            }

            // --- NHÓM 4: CÁC PHÉP TOÁN MỘT NGÔI (Slide 88) ---
            else if (bt.Text == "±")
            {
                decimal currVal = decimal.Parse(txtDisplay.Text);
                currVal = -currVal;
                txtDisplay.Text = currVal.ToString();
            }
            else if (bt.Text == "√")
            {
                decimal currVal = decimal.Parse(txtDisplay.Text);
                if (currVal >= 0)
                    txtDisplay.Text = ((decimal)Math.Sqrt((double)currVal)).ToString();
            }
            else if (bt.Text == "%")
            {
                decimal currVal = decimal.Parse(txtDisplay.Text);
                txtDisplay.Text = (currVal / 100).ToString();
            }
            else if (bt.Text == "1/x")
            {
                decimal currVal = decimal.Parse(txtDisplay.Text);
                if (currVal != 0)
                    txtDisplay.Text = (1 / currVal).ToString();
            }

            // --- NHÓM 5: XÓA (C, CE, Backspace) (Slide 89-90) ---
            else if (bt.Text == "C") // Xóa tất cả
            {
                workingMemory = 0;
                opr = "";
                txtDisplay.Text = "0"; // Reset về 0 thay vì xóa trắng
            }
            else if (bt.Text == "CE") // Xóa số đang nhập
            {
                txtDisplay.Text = "0";
            }
            else if (bt.Text == "←") // Backspace
            {
                if (txtDisplay.Text.Length > 0)
                {
                    txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
                }
                // Nếu xóa hết thì hiện số 0
                if (txtDisplay.Text == "")
                {
                    txtDisplay.Text = "0";
                }
            }

            // --- NHÓM 6: BỘ NHỚ (M+, M-, MR, MC, MS) (Slide 90) ---
            else if (bt.Text == "MC") // Xóa bộ nhớ
            {
                memory = 0;
            }
            else if (bt.Text == "MR") // Đọc bộ nhớ ra màn hình
            {
                txtDisplay.Text = memory.ToString();
            }
            else if (bt.Text == "MS") // Lưu màn hình vào bộ nhớ
            {
                memory = decimal.Parse(txtDisplay.Text);
                txtDisplay.Text = "0";
            }
            else if (bt.Text == "M+") // Cộng dồn vào bộ nhớ
            {
                memory += decimal.Parse(txtDisplay.Text);
            }
            else if (bt.Text == "M-") // Trừ bớt bộ nhớ
            {
                memory -= decimal.Parse(txtDisplay.Text);
            }
        }
    }
}