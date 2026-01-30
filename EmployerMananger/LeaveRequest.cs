using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace EmployerMananger
{
    public partial class LeaveRequest : Form
    {
        string strConnect = @"Server=.\SQLEXPRESS;Database=EmployerDB;Integrated Security=True;TrustServerCertificate=True";

        public LeaveRequest()
        {
            InitializeComponent();
            this.Load += LeaveRequest_Load;
            this.btnAdd.Click += BtnAdd_Click;
            this.btnDelete.Click += BtnDelete_Click;
            this.btnApprove.Click += BtnApprove_Click;
            this.btnReject.Click += BtnReject_Click;
            this.dgvLeave.CellClick += DgvLeave_CellClick;
        }

        private void LeaveRequest_Load(object sender, EventArgs e)
        {
            LoadEmployeeComboBox();
            LoadLeaveData();
        }

        // 1. Nạp danh sách nhân viên vào ComboBox
        private void LoadEmployeeComboBox()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(strConnect))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT Id, HoTen FROM NhanVien", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cboEmployee.DataSource = dt;
                    cboEmployee.DisplayMember = "HoTen"; // Hiển thị tên
                    cboEmployee.ValueMember = "Id";      // Lấy giá trị là ID
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi load nhân viên: " + ex.Message); }
        }

        // 2. Hiển thị danh sách nghỉ phép ra bảng
        private void LoadLeaveData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(strConnect))
                {
                    con.Open();
                    string query = @"SELECT d.Id, nv.HoTen, d.TuNgay, d.DenNgay, d.LyDo, d.TrangThai 
                                     FROM DonXinNghi d 
                                     JOIN NhanVien nv ON d.NhanVienId = nv.Id
                                     ORDER BY d.NgayTao DESC";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvLeave.DataSource = dt;

                    // Tô màu trạng thái cho đẹp
                    foreach (DataGridViewRow row in dgvLeave.Rows)
                    {
                        string status = row.Cells["TrangThai"].Value.ToString();
                        if (status == "Đã duyệt") row.DefaultCellStyle.ForeColor = Color.Green;
                        else if (status == "Từ chối") row.DefaultCellStyle.ForeColor = Color.Red;
                        else row.DefaultCellStyle.ForeColor = Color.Orange;
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi load dữ liệu: " + ex.Message); }
        }

        // 3. Gửi đơn (Thêm mới)
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (cboEmployee.SelectedValue == null) return;
            try
            {
                using (SqlConnection con = new SqlConnection(strConnect))
                {
                    con.Open();
                    string query = "INSERT INTO DonXinNghi (NhanVienId, TuNgay, DenNgay, LyDo) VALUES (@Id, @Tu, @Den, @LyDo)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Id", cboEmployee.SelectedValue);
                    cmd.Parameters.AddWithValue("@Tu", dtpStart.Value);
                    cmd.Parameters.AddWithValue("@Den", dtpEnd.Value);
                    cmd.Parameters.AddWithValue("@LyDo", txtReason.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Gửi đơn thành công!", "Thông báo");
                    LoadLeaveData(); // Refresh lại bảng
                    txtReason.Clear();
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        // 4. Xóa đơn
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvLeave.SelectedRows.Count == 0) return;
            int id = Convert.ToInt32(dgvLeave.SelectedRows[0].Cells["Id"].Value);

            if (MessageBox.Show("Bạn có chắc muốn xóa đơn này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ExecuteQuery("DELETE FROM DonXinNghi WHERE Id = " + id);
            }
        }

        // 5. Duyệt đơn
        private void BtnApprove_Click(object sender, EventArgs e)
        {
            UpdateStatus("Đã duyệt");
        }

        // 6. Từ chối đơn
        private void BtnReject_Click(object sender, EventArgs e)
        {
            UpdateStatus("Từ chối");
        }

        // Hàm phụ trợ cập nhật trạng thái
        private void UpdateStatus(string status)
        {
            if (dgvLeave.SelectedRows.Count == 0) return;
            int id = Convert.ToInt32(dgvLeave.SelectedRows[0].Cells["Id"].Value);
            ExecuteQuery($"UPDATE DonXinNghi SET TrangThai = N'{status}' WHERE Id = {id}");
        }

        // Hàm phụ trợ chạy SQL
        private void ExecuteQuery(string query)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(strConnect))
                {
                    con.Open();
                    new SqlCommand(query, con).ExecuteNonQuery();
                    LoadLeaveData();
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        // Khi click vào dòng thì hiện thông tin lên trên (Optional)
        private void DgvLeave_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            // Bạn có thể thêm code để đổ dữ liệu ngược lại ô nhập liệu nếu muốn sửa
        }
    }
}