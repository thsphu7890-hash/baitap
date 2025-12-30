using System;
using System.Windows.Forms;

namespace Baitap
{
    public partial class Ex20 : Form
    {
        public Ex20()
        {
            InitializeComponent();
        }

        // 1. Nút Thêm: Lấy dữ liệu nhập và đưa lên bảng (Slide 136)
        private void btAddNew_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu nhập có trống không (tùy chọn)
            if (string.IsNullOrEmpty(tbId.Text) || string.IsNullOrEmpty(tbName.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã và Tên!");
                return;
            }

            // Thêm một dòng mới vào DataGridView
            // Thứ tự tham số phải khớp với thứ tự cột: Mã, Tên, Tuổi, Giới tính
            dgvEmployee.Rows.Add(tbId.Text, tbName.Text, tbAge.Text, ckGender.Checked);

            // Xóa trắng ô nhập sau khi thêm
            tbId.Text = "";
            tbName.Text = "";
            tbAge.Text = "";
            ckGender.Checked = false;
            tbId.Focus(); // Đưa con trỏ về ô Mã
        }

        // 2. Nút Xóa: Xóa dòng đang chọn trên bảng (Slide 137)
        private void btDelete_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng có đang chọn dòng nào không
            // CurrentCell khác null nghĩa là đang có dòng được chọn
            if (dgvEmployee.CurrentCell != null)
            {
                // Lấy chỉ số (index) của dòng hiện tại
                int idx = dgvEmployee.CurrentCell.RowIndex;

                // Kiểm tra lại index hợp lệ (tránh xóa dòng tiêu đề hoặc dòng lỗi)
                if (idx >= 0 && idx < dgvEmployee.Rows.Count)
                {
                    // Thực hiện xóa dòng
                    dgvEmployee.Rows.RemoveAt(idx);
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn một dòng để xóa!");
            }
        }

        // 3. Sự kiện khi bấm vào một dòng trên bảng -> Hiện ngược lại ô nhập (Slide 137)
        // Sự kiện RowEnter xảy ra khi con trỏ chuột "đi vào" một dòng mới
        private void dgvEmployee_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;

            // Nếu index < 0 (là dòng tiêu đề) hoặc vượt quá số dòng dữ liệu thì bỏ qua
            if (idx < 0 || idx >= dgvEmployee.Rows.Count - 1 && dgvEmployee.AllowUserToAddRows)
                return;

            // Lấy dòng hiện tại
            DataGridViewRow row = dgvEmployee.Rows[idx];

            // Lấy giá trị từng ô (Cell) gán ngược lại TextBox
            // Cần kiểm tra null để tránh lỗi nếu ô đó trống
            if (row.Cells[0].Value != null) tbId.Text = row.Cells[0].Value.ToString();
            if (row.Cells[1].Value != null) tbName.Text = row.Cells[1].Value.ToString();
            if (row.Cells[2].Value != null) tbAge.Text = row.Cells[2].Value.ToString();

            // Xử lý cột CheckBox
            if (row.Cells[3].Value != null)
            {
                // Chuyển đổi giá trị trong bảng (True/False) sang trạng thái CheckBox
                string genderValue = row.Cells[3].Value.ToString();
                if (bool.TryParse(genderValue, out bool isMale))
                {
                    ckGender.Checked = isMale;
                }
            }
        }

        // 4. Nút Thoát
        private void btExit_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại xác nhận trước khi thoát
            if (MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}