using System;
using System.Collections.Generic; // Cần thư viện này để dùng List<>
using System.Windows.Forms;

namespace Baitap
{
    public partial class Ex21 : Form
    {
        // Khai báo danh sách để lưu trữ dữ liệu nhân viên (Backend)
        List<Employee> lst;

        public Ex21()
        {
            InitializeComponent();
        }

        // 1. Hàm tạo dữ liệu giả (Slide 141)
        public List<Employee> GetData()
        {
            List<Employee> listEm = new List<Employee>();

            Employee em = new Employee();
            em.Id = "53418";
            em.Name = "Trần Tiến";
            em.Age = 20;
            em.Gender = true; // Nam
            listEm.Add(em);

            em = new Employee();
            em.Id = "53416";
            em.Name = "Nguyễn Cường";
            em.Age = 25;
            em.Gender = true;
            listEm.Add(em);

            em = new Employee();
            em.Id = "53417";
            em.Name = "Nguyễn Hào";
            em.Age = 23;
            em.Gender = true;
            listEm.Add(em);

            return listEm;
        }

        // 2. Sự kiện Load Form: Nạp dữ liệu vào List và hiển thị lên Bảng (Slide 142)
        private void Ex21_Load(object sender, EventArgs e)
        {
            lst = GetData(); // Lấy dữ liệu mẫu

            // Duyệt qua từng nhân viên trong List để thêm vào DataGridView
            foreach (Employee em in lst)
            {
                dgvEmployee.Rows.Add(em.Id, em.Name, em.Age, em.Gender);
            }
        }

        // 3. Nút Thêm: Thêm vào cả List và Bảng (Slide 143)
        private void btAddNew_Click(object sender, EventArgs e)
        {
            // Tạo đối tượng nhân viên mới từ dữ liệu nhập
            Employee em = new Employee();
            em.Id = tbId.Text;
            em.Name = tbName.Text;

            int age;
            int.TryParse(tbAge.Text, out age); // Chuyển đổi tuổi sang số
            em.Age = age;

            em.Gender = ckGender.Checked;

            // BƯỚC 1: Thêm vào danh sách quản lý (List)
            lst.Add(em);

            // BƯỚC 2: Thêm hiển thị lên giao diện (DataGridView)
            dgvEmployee.Rows.Add(em.Id, em.Name, em.Age, em.Gender);

            // Xóa trắng ô nhập
            tbId.Text = ""; tbName.Text = ""; tbAge.Text = ""; ckGender.Checked = false;
            tbId.Focus();
        }

        // 4. Nút Xóa: Xóa khỏi cả List và Bảng (Slide 144)
        private void btDelete_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào đang được chọn không
            if (dgvEmployee.CurrentCell != null)
            {
                int idx = dgvEmployee.CurrentCell.RowIndex;

                // Xóa trong danh sách (List) trước
                lst.RemoveAt(idx);

                // Xóa trên bảng (DataGridView) sau
                dgvEmployee.Rows.RemoveAt(idx);
            }
        }

        // 5. Sự kiện khi chọn dòng trên bảng (Slide 144)
        private void dgvEmployee_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;

            // Kiểm tra index hợp lệ (tránh dòng tiêu đề hoặc dòng trống cuối cùng)
            if (idx < 0 || idx >= dgvEmployee.Rows.Count) return;

            // Lấy dòng hiện tại
            DataGridViewRow row = dgvEmployee.Rows[idx];

            // Đổ dữ liệu ngược lại các ô TextBox
            if (row.Cells[0].Value != null) tbId.Text = row.Cells[0].Value.ToString();
            if (row.Cells[1].Value != null) tbName.Text = row.Cells[1].Value.ToString();
            if (row.Cells[2].Value != null) tbAge.Text = row.Cells[2].Value.ToString();

            // Xử lý CheckBox
            if (row.Cells[3].Value != null)
            {
                string genderVal = row.Cells[3].Value.ToString();
                bool isMale;
                if (bool.TryParse(genderVal, out isMale))
                {
                    ckGender.Checked = isMale;
                }
            }
        }

        // 6. Nút Thoát
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}