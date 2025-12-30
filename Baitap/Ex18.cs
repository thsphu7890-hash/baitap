using System;
using System.Collections; // Cần thư viện này để dùng ArrayList
using System.Windows.Forms;

namespace Baitap
{
    public partial class Ex18 : Form
    {
        // Khai báo danh sách bài hát (biến toàn cục để dùng chung cho các hàm)
        ArrayList lstSongs;

        public Ex18()
        {
            InitializeComponent();
        }

        // 1. Hàm tạo dữ liệu giả lập (Theo Slide 123)
        public ArrayList GetData()
        {
            ArrayList lst = new ArrayList();

            Song s = new Song();
            s.Id = 53418;
            s.Name = "Giấc mơ cha pi";
            s.Author = "Trần Tiến";
            lst.Add(s);

            s = new Song();
            s.Id = 52616;
            s.Name = "Đôi mắt pleiku";
            s.Author = "Nguyễn Cường";
            lst.Add(s);

            s = new Song();
            s.Id = 51172;
            s.Name = "Em muốn sống bên anh trọn đời";
            s.Author = "Nguyễn Cường";
            lst.Add(s);

            return lst;
        }

        // 2. Sự kiện Load Form (Theo Slide 124)
        // Đổ dữ liệu từ ArrayList vào ListBox
        private void Ex18_Load(object sender, EventArgs e)
        {
            lstSongs = GetData();

            // Gán nguồn dữ liệu
            lbSong.DataSource = lstSongs;

            // Chọn thuộc tính "Name" của Song để hiển thị lên màn hình
            lbSong.DisplayMember = "Name";

            // (Tùy chọn) Giá trị ẩn là Id
            lbSong.ValueMember = "Id";
        }

        // 3. Nút > : Chọn 1 bài hát (Theo Slide 124)
        private void btSelect_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có bài nào đang được chọn không
            if (lbSong.SelectedItem != null)
            {
                // Vì lbSong chứa Object, ta phải ép kiểu về (Song)
                Song song = (Song)lbSong.SelectedItem;

                // Lấy thông tin chi tiết
                string id = song.Id.ToString();
                string name = song.Name;
                string author = song.Author;

                // Tạo chuỗi hiển thị: "Mã - Tên - Tác giả" và thêm vào danh sách Ưa thích
                lbFavorite.Items.Add(id + " - " + name + " - " + author);
            }
        }

        // 4. Nút >> : Chọn tất cả (Logic tự suy luận)
        private void btSelectAll_Click(object sender, EventArgs e)
        {
            // Duyệt qua tất cả bài hát trong danh sách nguồn
            foreach (Song s in lstSongs)
            {
                string info = s.Id + " - " + s.Name + " - " + s.Author;
                lbFavorite.Items.Add(info);
            }
        }

        // 5. Nút < : Xóa 1 bài khỏi danh sách ưa thích
        private void btDeselect_Click(object sender, EventArgs e)
        {
            if (lbFavorite.SelectedIndex != -1)
            {
                lbFavorite.Items.RemoveAt(lbFavorite.SelectedIndex);
            }
        }

        // 6. Nút << : Xóa hết danh sách ưa thích
        private void btDeselectAll_Click(object sender, EventArgs e)
        {
            lbFavorite.Items.Clear();
        }
    }
}