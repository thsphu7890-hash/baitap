using System;
using System.Drawing; // Cần thư viện này để dùng Point và Size cho ảnh
using System.Windows.Forms;

namespace Baitap
{
    public partial class Ex23 : Form
    {
        // 1. Khai báo biến toàn cục (Theo Slide 153)
        // Tạo đối tượng PictureBox bằng code (Dynamic Control)
        PictureBox pb = new PictureBox();

        // Tọa độ ban đầu của ảnh
        int x = 200;
        int y = 50;

        public Ex23()
        {
            InitializeComponent();
        }

        // 2. Nút File: Tạo và hiển thị ảnh (Slide 153)
        private void btFile_Click(object sender, EventArgs e)
        {
            // Mở hộp thoại chọn file ảnh
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"; // Lọc file ảnh
            dlg.Title = "Open Image";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                // Cấu hình PictureBox (Vì ta không có cửa sổ Properties để chỉnh)
                pb.SizeMode = PictureBoxSizeMode.StretchImage; // Co giãn ảnh
                pb.Size = new Size(150, 150); // Kích thước ảnh (Rộng, Cao)
                pb.Location = new Point(x, y); // Vị trí xuất hiện (x, y)

                // Nạp ảnh từ đường dẫn file
                pb.ImageLocation = dlg.FileName;

                // QUAN TRỌNG NHẤT: Thêm PictureBox vào danh sách Controls của Form
                // Nếu thiếu dòng này, ảnh sẽ tồn tại trong bộ nhớ nhưng không hiện lên màn hình
                this.Controls.Add(pb);
            }
        }

        // 3. Nút Qua Trái (Slide 154)
        private void btLeft_Click(object sender, EventArgs e)
        {
            // Giảm tọa độ x (di chuyển sang trái 10 đơn vị)
            x -= 10;

            // Cập nhật lại vị trí mới cho PictureBox
            pb.Location = new Point(x, y);
        }

        // 4. Nút Qua Phải (Slide 154)
        private void btRight_Click(object sender, EventArgs e)
        {
            // Tăng tọa độ x (di chuyển sang phải 10 đơn vị)
            x += 10;

            // Cập nhật lại vị trí mới
            pb.Location = new Point(x, y);
        }
    }
}