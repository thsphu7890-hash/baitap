using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace EmployerMananger
{
    public partial class Position : Form
    {
        string strConnect = @"Server=.\SQLEXPRESS;Database=EmployerDB;Integrated Security=True;TrustServerCertificate=True";
        int currentId = 0; // Lưu ID khi chọn dòng để sửa/xóa

        public Position()
        {
            InitializeComponent();
            this.Load += Position_Load;
            this.btnAdd.Click += BtnAdd_Click;
            this.btnEdit.Click += BtnEdit_Click;
            this.btnDelete.Click += BtnDelete_Click;
            this.dgvPosition.CellClick += DgvPosition_CellClick;
        }

        private void Position_Load(object sender, EventArgs e)
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
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ChucVu", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvPosition.DataSource = dt;

                    dgvPosition.Columns["Id"].Visible = false; // Ẩn cột ID
                    dgvPosition.Columns["TenChucVu"].HeaderText = "Tên Chức Vụ";
                    dgvPosition.Columns["MoTa"].HeaderText = "Mô Tả";
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

        // 1. THÊM
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text)) return;
            ExecuteQuery("INSERT INTO ChucVu (TenChucVu, MoTa) VALUES (N'" + txtName.Text + "', N'" + txtDesc.Text + "')");
        }

        // 2. SỬA
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (currentId == 0) return;
            ExecuteQuery("UPDATE ChucVu SET TenChucVu = N'" + txtName.Text + "', MoTa = N'" + txtDesc.Text + "' WHERE Id = " + currentId);
        }

        // 3. XÓA
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (currentId == 0) return;
            if (MessageBox.Show("Xóa chức vụ này có thể ảnh hưởng đến nhân viên đang giữ chức vụ. Tiếp tục?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ExecuteQuery("DELETE FROM ChucVu WHERE Id = " + currentId);
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
        private void DgvPosition_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPosition.Rows[e.RowIndex];
                currentId = Convert.ToInt32(row.Cells["Id"].Value);
                txtName.Text = row.Cells["TenChucVu"].Value.ToString();
                txtDesc.Text = row.Cells["MoTa"].Value.ToString();
            }
        }
    }
}