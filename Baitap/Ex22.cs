using System;
using System.Collections.Generic; // Để dùng List<>
using System.Windows.Forms;

namespace Baitap
{
    public partial class Ex22 : Form
    {
        // 1. Khai báo BindingSource và List (Theo Slide 149)
        // BindingSource đóng vai trò trung gian giữa Dữ liệu (List) và Giao diện (DataGridView)
        BindingSource bs = new BindingSource();
        List<Employee> lstEmp = new List<Employee>();

        public Ex22()
        {
            InitializeComponent();
        }

        // Tạo dữ liệu mẫu ban đầu
        public List<Employee> GetData()
        {
            List<Employee> list = new List<Employee>();
            list.Add(new Employee { Id = "53418", Name = "Trần Tiến", Age = 20, Gender = true });
            list.Add(new Employee { Id = "53416", Name = "Nguyễn Cường", Age = 25, Gender = false });
            list.Add(new Employee { Id = "53417", Name = "Nguyễn Hào", Age = 23, Gender = true });
            return list;
        }

        // 2. Load Form: Thiết lập kết nối Binding (Slide 149)
        private void Ex22_Load(object sender, EventArgs e)
        {
            // Lấy dữ liệu
            lstEmp = GetData();

            // Gán List vào BindingSource
            bs.DataSource = lstEmp;

            // Gán BindingSource vào DataGridView
            // Nhờ bước này, bảng sẽ tự động hiển thị dữ liệu mà không cần thêm từng dòng
            dgvEmployee.DataSource = bs;
        }

        // 3. Nút Thêm: Thêm vào BindingSource (Slide 149)
        private void btAddNew_Click(object sender, EventArgs e)
        {
            // Tạo đối tượng nhân viên từ thông tin nhập
            Employee em = new Employee();
            em.Id = tbId.Text;
            em.Name = tbName.Text;

            int.TryParse(tbAge.Text, out int age);
            em.Age = age;

            em.Gender = ckGender.Checked;

            // QUAN TRỌNG: Thêm vào BindingSource (bs)
            // BindingSource sẽ tự động làm 2 việc:
            // 1. Thêm vào List gốc (lstEmp)
            // 2. Cập nhật giao diện bảng (dgvEmployee)
            bs.Add(em);

            // Xóa trắng ô nhập sau khi thêm
            tbId.Text = ""; tbName.Text = ""; tbAge.Text = ""; ckGender.Checked = false;
            tbId.Focus();
        }

        // 4. Nút Xóa: Dùng RemoveCurrent (Slide 150)
        private void btDelete_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào đang được chọn không
            if (bs.Current != null)
            {
                // Lệnh này xóa dòng hiện tại khỏi BindingSource -> List và Grid tự cập nhật
                bs.RemoveCurrent();
            }
        }

        // 5. Sự kiện RowEnter: Đổ dữ liệu ngược lại TextBox (Slide 150)
        private void dgvEmployee_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra chỉ số dòng hợp lệ
            if (e.RowIndex < 0 || e.RowIndex >= dgvEmployee.Rows.Count) return;

            // Lấy dòng hiện tại
            DataGridViewRow row = dgvEmployee.Rows[e.RowIndex];

            // Lấy giá trị từng ô (Cell) gán vào TextBox
            if (row.Cells[0].Value != null) tbId.Text = row.Cells[0].Value.ToString();
            if (row.Cells[1].Value != null) tbName.Text = row.Cells[1].Value.ToString();
            if (row.Cells[2].Value != null) tbAge.Text = row.Cells[2].Value.ToString();

            // Xử lý CheckBox (Giới tính)
            if (row.Cells[3].Value != null)
            {
                bool isMale;
                if (bool.TryParse(row.Cells[3].Value.ToString(), out isMale))
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