using System;
using System.Windows.Forms;

namespace Baitap
{
    public partial class Ex19 : Form
    {
        public Ex19()
        {
            InitializeComponent();
        }

        // Sự kiện khi bấm nút "Chọn ảnh ..." (Slide 129)
        private void btFile_Click(object sender, EventArgs e)
        {
            // 1. Chỉnh chế độ hiển thị ảnh: Co giãn cho vừa khung (StretchImage)
            // Nếu không có dòng này, ảnh to sẽ bị cắt bớt hoặc ảnh nhỏ sẽ bị lọt thỏm
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;

            // 2. Khởi tạo hộp thoại mở file của Windows
            OpenFileDialog dlg = new OpenFileDialog();

            // Đặt tiêu đề cho cửa sổ chọn file
            dlg.Title = "Open Image";

            // Lọc file: Chỉ cho phép chọn file có đuôi .jpg
            // Cú pháp: "Tên hiển thị|*.duoimorong"
            dlg.Filter = "JPEG files (*.jpg)|*.jpg";

            // 3. Hiển thị hộp thoại và kiểm tra kết quả
            // Nếu người dùng chọn file và bấm OK (DialogResult.OK) thì mới xử lý
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn file ảnh vừa chọn gán vào PictureBox để hiển thị
                pbImage.ImageLocation = dlg.FileName;
            }
        }
    }
}