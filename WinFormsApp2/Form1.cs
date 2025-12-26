namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const string V = @"D:\form.xml";
        string path = V;
        private void Form1_Load(object sender, EventArgs e)
        {
            // Sự kiện chạy khi kết thúc thay đổi kích thước
            void Form1_ResizeEnd(object sender, System.EventArgs e)
            {
                int width = this.Size.Width;   // Lấy chiều rộng
                int height = this.Size.Height; // Lấy chiều cao

                // Gán chuỗi "Chiều rộng - Chiều cao" lên thanh tiêu đề
                this.Text = width.ToString() + " - " + height.ToString();
            }

            // Sự kiện chạy khi Form vừa nạp lên
            void Form1_Load(object sender, System.EventArgs e)
            {
                int width = this.Size.Width;
                int height = this.Size.Height;
                this.Text = width.ToString() + " - " + height.ToString();
            }

            // Đăng ký sự kiện

            this.ResizeEnd += new System.EventHandler(Form1_ResizeEnd);
            this.Load += new System.EventHandler(Form1_Load);
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            // Mở file Key_Logger.txt, tham số 'true' để ghi tiếp vào cuối file (append)
            StreamWriter sw = new StreamWriter(@"D:\Key_Logger.txt", true);
            sw.Write(e.KeyCode); // Ghi mã phím vừa nhấn
            sw.Close();          // Đóng file để lưu thay đổi
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Ex00 ex00 = new Ex00();
            ex00.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ex01 ex01 = new Ex01();
            ex01.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ex02 ex02 = new Ex02();
            ex02.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ex04 ex04 = new Ex04();
            ex04.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Ex05 ex05 = new Ex05();
            ex05.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Ex06 ex06 = new Ex06();
            ex06.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Ex07 ex07 = new Ex07();
            ex07.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Ex08 ex08 = new Ex08();
            ex08.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Ex09 ex09 = new Ex09();
            ex09.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Ex10 ex10 = new Ex10();
            ex10.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Ex11 ex11 = new Ex11();
            ex11.Show();
        }
    }
}
