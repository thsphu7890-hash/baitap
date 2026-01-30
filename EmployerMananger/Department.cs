using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace EmployerMananger
{
    public partial class Department : Form
    {
        // Chuỗi kết nối
        string strConnect = @"Server=.\SQLEXPRESS;Database=EmployerDB;Integrated Security=True;TrustServerCertificate=True";
        int currentId = 0; // Lưu ID đang chọn

        public Department()
        {
            InitializeComponent();
            this.Load += Department_Load;
            this.btnAdd.Click += BtnAdd_Click;
            this.btnEdit.Click += BtnEdit_Click;
            this.btnDelete.Click += BtnDelete_Click;
            this.dgvDepartment.CellClick += DgvDepartment_CellClick;
        }

        private void Department_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(strConnect))
                {
                    con.Open();
                    // Load bảng PhongBan
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM PhongBan", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvDepartment.DataSource = dt;

                    dgvDepartment.Columns["Id"].Visible = false;
                    dgvDepartment.Columns["TenPhongBan"].HeaderText = "Tên Phòng Ban";
                    dgvDepartment.Columns["MoTa"].HeaderText = "Mô Tả";
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void ResetInput()
        {
            txtName.Clear();
            txtDesc.Clear();
            currentId = 0;
        }

        // 1. THÊM PHÒNG BAN
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text)) return;
            ExecuteQuery("INSERT INTO PhongBan (TenPhongBan, MoTa) VALUES (N'" + txtName.Text + "', N'" + txtDesc.Text + "')");
        }

        // 2. SỬA PHÒNG BAN
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (currentId == 0) return;
            ExecuteQuery("UPDATE PhongBan SET TenPhongBan = N'" + txtName.Text + "', MoTa = N'" + txtDesc.Text + "' WHERE Id = " + currentId);
        }

        // 3. XÓA PHÒNG BAN
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (currentId == 0) return;
            if (MessageBox.Show("Xóa phòng ban này có thể ảnh hưởng đến nhân viên thuộc phòng ban. Tiếp tục?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ExecuteQuery("DELETE FROM PhongBan WHERE Id = " + currentId);
            }
        }

        // Hàm chạy SQL chung
        private void ExecuteQuery(string query)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(strConnect))
                {
                    con.Open();
                    new SqlCommand(query, con).ExecuteNonQuery();
                    LoadData();
                    ResetInput();
                    MessageBox.Show("Thao tác thành công!");
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        // Khi click vào bảng -> Đổ dữ liệu lên ô nhập
        private void DgvDepartment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDepartment.Rows[e.RowIndex];
                currentId = Convert.ToInt32(row.Cells["Id"].Value);
                txtName.Text = row.Cells["TenPhongBan"].Value.ToString();
                txtDesc.Text = row.Cells["MoTa"].Value.ToString();
            }
        }
    }
}