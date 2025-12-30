using System;
using System.Windows.Forms;

namespace Baitap
{
    public partial class Ex17 : Form
    {
        public Ex17()
        {
            InitializeComponent();
        }

        // 1. Nút > : Chuyển 1 bài hát đang chọn sang phải (Slide 118)
        private void btSelect_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có bài nào đang được chọn không (SelectedIndex != -1)
            if (lbSong.SelectedIndex != -1)
            {
                // Lấy nội dung bài hát
                string song = lbSong.SelectedItem.ToString();

                // Thêm vào danh sách Ưa thích (bên phải)
                lbFavorite.Items.Add(song);

                // Xóa khỏi danh sách gốc (bên trái)
                lbSong.Items.RemoveAt(lbSong.SelectedIndex);
            }
        }

        // 2. Nút >> : Chuyển TẤT CẢ bài hát sang phải (Slide 119)
        private void btSelectAll_Click(object sender, EventArgs e)
        {
            // Duyệt từ cuối lên đầu để tránh lỗi khi xóa phần tử trong lúc duyệt
            // Count - 1 là vị trí phần tử cuối cùng
            for (int i = lbSong.Items.Count - 1; i >= 0; i--)
            {
                string song = lbSong.Items[i].ToString();
                lbFavorite.Items.Add(song);
                lbSong.Items.RemoveAt(i);
            }
        }

        // 3. Nút < : Trả 1 bài hát về lại bên trái
        private void btDeselect_Click(object sender, EventArgs e)
        {
            if (lbFavorite.SelectedIndex != -1)
            {
                string song = lbFavorite.SelectedItem.ToString();
                lbSong.Items.Add(song);
                lbFavorite.Items.RemoveAt(lbFavorite.SelectedIndex);
            }
        }

        // 4. Nút << : Trả TẤT CẢ bài hát về lại bên trái
        private void btDeselectAll_Click(object sender, EventArgs e)
        {
            for (int i = lbFavorite.Items.Count - 1; i >= 0; i--)
            {
                string song = lbFavorite.Items[i].ToString();
                lbSong.Items.Add(song);
                lbFavorite.Items.RemoveAt(i);
            }
        }

        // 5. Sự kiện nhấn đúp chuột vào ListBox Trái (Slide 119)
        private void lbSong_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Kiểm tra xem chuột có click trúng vào dòng chữ nào không
            int index = lbSong.IndexFromPoint(e.Location);

            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                string song = lbSong.Items[index].ToString();
                lbFavorite.Items.Add(song);
                lbSong.Items.RemoveAt(index);
            }
        }

        // 6. Sự kiện nhấn đúp chuột vào ListBox Phải (Slide 119)
        private void lbFavorite_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = lbFavorite.IndexFromPoint(e.Location);

            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                string song = lbFavorite.Items[index].ToString();
                lbSong.Items.Add(song);
                lbFavorite.Items.RemoveAt(index);
            }
        }
    }
}