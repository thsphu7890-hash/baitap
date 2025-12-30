using System;
using System.Collections; // Để dùng ArrayList
using System.Windows.Forms;

namespace Baitap
{
    public partial class Ex16 : Form
    {
        public Ex16()
        {
            InitializeComponent();
        }

        // 1. Hàm tạo dữ liệu giả cho Khoa
        private ArrayList GetData()
        {
            ArrayList lst = new ArrayList();
            lst.Add("Công nghệ thông tin");
            lst.Add("Kế toán");
            lst.Add("Cơ khí");
            lst.Add("Điện");
            lst.Add("Hóa");
            return lst;
        }

        // 2. Sự kiện khi Form vừa mở lên (Load)
        private void Ex16_Load(object sender, EventArgs e)
        {
            // Đổ danh sách khoa vào ComboBox
            cbFaculty.DataSource = GetData();
        }

        // 3. Sự kiện bấm nút "Thêm"
        private void btAdd_Click(object sender, EventArgs e)
        {
            // B1: Lấy thông tin từ giao diện
            string name = tbName.Text;
            string dob = dtpDob.Value.ToShortDateString(); // Lấy ngày ngắn
            string sex = rbMale.Checked ? "Nam" : "Nữ";    // Kiểm tra giới tính
            string faculty = cbFaculty.SelectedValue.ToString(); // Lấy tên khoa

            // B2: Thêm từng dòng vào ListBox để hiển thị đẹp như Slide 112
            // Dòng 1: Họ tên
            lbInfo.Items.Add(name);
            // Dòng 2: Giới tính (thụt đầu dòng cho đẹp)
            lbInfo.Items.Add("   -Giới tính: " + sex);
            // Dòng 3: Ngày sinh
            lbInfo.Items.Add("   -Ngày Sinh: " + dob);
            // Dòng 4: Khoa
            lbInfo.Items.Add("   -Khoa: " + faculty);

            // Thêm dòng gạch ngang phân cách giữa các sinh viên
            lbInfo.Items.Add("-------------------------------");
        }

        // 4. Sự kiện bấm nút "Thoát"
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng Form
        }
    }
}