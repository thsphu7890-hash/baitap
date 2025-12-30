using System;
using System.Collections; // Để dùng ArrayList
using System.Windows.Forms;

namespace Baitap
{
    public partial class Ex13 : Form
    {
        public Ex13()
        {
            InitializeComponent();
        }

        // 1. Hàm tạo dữ liệu giả (Slide 100)
        public ArrayList GetData()
        {
            ArrayList lst = new ArrayList();

            Faculty f = new Faculty();
            f.Id = "K01";
            f.Name = "Công nghệ thông tin";
            f.Quantity = 1200;
            lst.Add(f);

            f = new Faculty();
            f.Id = "K02";
            f.Name = "Quản trị kinh doanh";
            f.Quantity = 4200;
            lst.Add(f);

            f = new Faculty();
            f.Id = "K03";
            f.Name = "Kế toán tài chính";
            f.Quantity = 5200;
            lst.Add(f);

            return lst;
        }

        // 2. Sự kiện Load Form (Slide 101)
        private void Ex13_Load(object sender, EventArgs e)
        {
            // Lấy danh sách khoa
            ArrayList lst = GetData();

            // Gán nguồn dữ liệu cho ComboBox
            cb_Faculty.DataSource = lst;

            // DisplayMember: Chọn cột "Name" để HIỂN THỊ lên màn hình
            cb_Faculty.DisplayMember = "Name";
        }

        // 3. Sự kiện khi chọn một dòng (Slide 101)
        private void cb_Faculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Faculty.SelectedValue != null)
            {
                // Slide 101: Khi thay đổi chọn lựa -> Lấy Mã Khoa (Id)
                cb_Faculty.ValueMember = "Id";
                string id = cb_Faculty.SelectedValue.ToString();
                tbDisplay.Text = "Bạn đã chọn khoa có mã : " + id;
            }
        }

        // 4. Sự kiện bấm nút OK (Slide 101)
        private void btOK_Click(object sender, EventArgs e)
        {
            // Slide 101: Khi bấm OK -> Lấy Tên Khoa (Name)
            // (Demo kỹ thuật thay đổi ValueMember động)
            cb_Faculty.ValueMember = "Name";
            string name = cb_Faculty.SelectedValue.ToString();
            tbDisplay.Text = "Bạn đã chọn khoa có tên : " + name;
        }
    }
}