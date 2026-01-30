using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using OfficeOpenXml; // Cần cài NuGet: EPPlus
using OfficeOpenXml.Style;

namespace EmployerMananger
{
    public partial class Employee : Form
    {
        // 1. CẤU HÌNH KẾT NỐI
        private readonly string strConnect = @"Server=DESKTOP-NU0G382\SQLEXPRESS;Database=EmployerDB;Integrated Security=True;TrustServerCertificate=True;Connection Timeout=30";

        public Employee()
        {
            InitializeComponent();
            SetupEvents();
        }

        private void SetupEvents()
        {
            this.Load += Employee_Load;
            this.btnAdd.Click += BtnAdd_Click;
            this.btnEdit.Click += BtnEdit_Click;
            this.btnDelete.Click += BtnDelete_Click;
            this.btnSave.Click += (s, e) => ResetForm();
            this.btnUpload.Click += BtnUpload_Click;
            this.btnExport.Click += BtnExport_Click;
            this.dgvEmployee.CellClick += DgvEmployee_CellClick;
            this.txtSearch.TextChanged += (s, e) => LoadData();
            this.Activated += (s, e) => LoadComboBoxes();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            LoadData();
        }

        // --- 2. LOAD DỮ LIỆU ---
        private void LoadComboBoxes()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(strConnect))
                {
                    conn.Open();
                    // Load Phòng Ban
                    SqlDataAdapter daPb = new SqlDataAdapter("SELECT Id, TenPhongBan FROM PhongBan", conn);
                    DataTable dtPb = new DataTable(); daPb.Fill(dtPb);
                    cboDept.DataSource = dtPb;
                    cboDept.DisplayMember = "TenPhongBan";
                    cboDept.ValueMember = "Id";

                    // Load Chức Vụ
                    SqlDataAdapter daCv = new SqlDataAdapter("SELECT Id, TenChucVu FROM ChucVu", conn);
                    DataTable dtCv = new DataTable(); daCv.Fill(dtCv);
                    cboRole.DataSource = dtCv;
                    cboRole.DisplayMember = "TenChucVu";
                    cboRole.ValueMember = "Id";

                    if (txtId.Tag == null) ResetComboboxSelection();
                }
            }
            catch (Exception ex) { Console.WriteLine("Lỗi load combo: " + ex.Message); }
        }

        private void LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(strConnect))
                {
                    conn.Open();
                    // Lấy dữ liệu hiển thị
                    string sql = @"SELECT nv.Id, nv.MaNV, nv.HoTen, nv.NgaySinh, nv.GioiTinh, 
                                   nv.NgayVaoLam, pb.TenPhongBan, nv.LuongCoBan, nv.SoDienThoai, 
                                   nv.AnhDaiDien, nv.PhongBanId,
                                   cv.TenChucVu, 
                                   cv.Id as ChucVuId
                                   FROM NhanVien nv 
                                   LEFT JOIN PhongBan pb ON nv.PhongBanId = pb.Id
                                   LEFT JOIN NhanVien_ChucVu nvc ON nv.Id = nvc.NhanVienId
                                   LEFT JOIN ChucVu cv ON nvc.ChucVuId = cv.Id";

                    if (!string.IsNullOrEmpty(txtSearch.Text))
                        sql += " WHERE nv.HoTen LIKE N'%" + txtSearch.Text + "%' OR nv.MaNV LIKE '%" + txtSearch.Text + "%'";

                    SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvEmployee.DataSource = dt;

                    // Ẩn các cột không cần thiết
                    string[] hiddenCols = { "Id", "PhongBanId", "ChucVuId", "AnhDaiDien" };
                    foreach (string col in hiddenCols)
                    {
                        if (dgvEmployee.Columns.Contains(col)) dgvEmployee.Columns[col].Visible = false;
                    }

                    if (dgvEmployee.Columns.Contains("LuongCoBan"))
                        dgvEmployee.Columns["LuongCoBan"].DefaultCellStyle.Format = "N0";
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message); }
        }

        // --- 3. SỰ KIỆN CLICK ---
        private void DgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            try
            {
                DataGridViewRow row = dgvEmployee.Rows[e.RowIndex];
                txtId.Tag = row.Cells["Id"].Value;
                txtId.Text = row.Cells["MaNV"].Value?.ToString();
                txtName.Text = row.Cells["HoTen"].Value?.ToString();
                cboGender.Text = row.Cells["GioiTinh"].Value?.ToString();
                txtPhone.Text = row.Cells["SoDienThoai"].Value?.ToString();

                if (dgvEmployee.Columns.Contains("NgayVaoLam") && row.Cells["NgayVaoLam"].Value != DBNull.Value)
                    dtpJoinDate.Value = Convert.ToDateTime(row.Cells["NgayVaoLam"].Value);
                else
                    dtpJoinDate.Value = DateTime.Now;

                if (row.Cells["NgaySinh"].Value != DBNull.Value)
                    dtpDob.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);

                txtSalary.Text = Convert.ToDecimal(row.Cells["LuongCoBan"].Value ?? 0).ToString("N0");

                cboDept.SelectedValue = row.Cells["PhongBanId"].Value ?? -1;
                cboRole.SelectedValue = row.Cells["ChucVuId"].Value ?? -1;

                if (row.Cells["AnhDaiDien"].Value != DBNull.Value)
                    picAvatar.Image = ByteArrayToImage((byte[])row.Cells["AnhDaiDien"].Value);
                else
                    picAvatar.Image = null;
            }
            catch (Exception ex) { Console.WriteLine("Lỗi chọn dòng: " + ex.Message); }
        }

        // --- 4. CHỨC NĂNG THÊM ---
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidInput()) return;
            if (txtId.Tag != null)
            {
                if (MessageBox.Show("Bạn đang chọn một nhân viên cũ. Bạn có muốn xóa form để thêm mới không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ResetForm(); return;
                }
            }

            using (SqlConnection conn = new SqlConnection(strConnect))
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();
                try
                {
                    string sql = @"INSERT INTO NhanVien (MaNV, HoTen, NgaySinh, GioiTinh, NgayVaoLam, PhongBanId, LuongCoBan, SoDienThoai, AnhDaiDien, TenDangNhap, MatKhau) 
                                   VALUES (@Ma, @Ten, @Ngay, @Gioi, @NgayVao, @Pb, @Luong, @Sdt, @Anh, @User, @Pass);
                                   SELECT SCOPE_IDENTITY();";

                    SqlCommand cmd = new SqlCommand(sql, conn, trans);
                    cmd.Parameters.AddWithValue("@Ma", txtId.Text.Trim());
                    cmd.Parameters.AddWithValue("@Ten", txtName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Ngay", dtpDob.Value);
                    cmd.Parameters.AddWithValue("@Gioi", cboGender.Text);
                    cmd.Parameters.AddWithValue("@NgayVao", dtpJoinDate.Value);
                    cmd.Parameters.AddWithValue("@Pb", cboDept.SelectedValue ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Luong", ParseDecimal(txtSalary.Text));
                    cmd.Parameters.AddWithValue("@Sdt", txtPhone.Text.Trim());
                    cmd.Parameters.AddWithValue("@User", txtId.Text.Trim());
                    cmd.Parameters.AddWithValue("@Pass", "123");
                    cmd.Parameters.Add("@Anh", SqlDbType.VarBinary).Value = (object)ImageToByteArray(picAvatar.Image) ?? DBNull.Value;

                    int newId = Convert.ToInt32(cmd.ExecuteScalar());

                    if (cboRole.SelectedValue != null)
                    {
                        SqlCommand cmdCv = new SqlCommand("INSERT INTO NhanVien_ChucVu (NhanVienId, ChucVuId) VALUES (@NvId, @CvId)", conn, trans);
                        cmdCv.Parameters.AddWithValue("@NvId", newId);
                        cmdCv.Parameters.AddWithValue("@CvId", cboRole.SelectedValue);
                        cmdCv.ExecuteNonQuery();
                    }

                    trans.Commit();
                    MessageBox.Show("Thêm nhân viên thành công!", "Thông báo");
                    LoadData(); ResetForm();
                }
                catch (SqlException ex)
                {
                    trans.Rollback();
                    if (ex.Number == 2627 || ex.Number == 2601)
                        MessageBox.Show($"Mã nhân viên '{txtId.Text}' đã tồn tại!", "Trùng dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                        MessageBox.Show("Lỗi SQL: " + ex.Message);
                }
                catch (Exception ex) { trans.Rollback(); MessageBox.Show("Lỗi hệ thống: " + ex.Message); }
            }
        }

        // --- 5. CHỨC NĂNG SỬA ---
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (txtId.Tag == null) { MessageBox.Show("Vui lòng chọn nhân viên cần sửa!"); return; }

            using (SqlConnection conn = new SqlConnection(strConnect))
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();
                try
                {
                    string sql = @"UPDATE NhanVien SET HoTen=@Ten, NgaySinh=@Ngay, GioiTinh=@Gioi, 
                                   NgayVaoLam=@NgayVao, PhongBanId=@Pb, LuongCoBan=@Luong, 
                                   SoDienThoai=@Sdt, AnhDaiDien=@Anh WHERE Id=@Id";

                    SqlCommand cmd = new SqlCommand(sql, conn, trans);
                    cmd.Parameters.AddWithValue("@Id", txtId.Tag);
                    cmd.Parameters.AddWithValue("@Ten", txtName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Ngay", dtpDob.Value);
                    cmd.Parameters.AddWithValue("@Gioi", cboGender.Text);
                    cmd.Parameters.AddWithValue("@NgayVao", dtpJoinDate.Value);
                    cmd.Parameters.AddWithValue("@Pb", cboDept.SelectedValue ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Luong", ParseDecimal(txtSalary.Text));
                    cmd.Parameters.AddWithValue("@Sdt", txtPhone.Text.Trim());
                    cmd.Parameters.Add("@Anh", SqlDbType.VarBinary).Value = (object)ImageToByteArray(picAvatar.Image) ?? DBNull.Value;
                    cmd.ExecuteNonQuery();

                    SqlCommand cmdDel = new SqlCommand("DELETE FROM NhanVien_ChucVu WHERE NhanVienId = @Id", conn, trans);
                    cmdDel.Parameters.AddWithValue("@Id", txtId.Tag);
                    cmdDel.ExecuteNonQuery();

                    if (cboRole.SelectedValue != null)
                    {
                        SqlCommand cmdCv = new SqlCommand("INSERT INTO NhanVien_ChucVu (NhanVienId, ChucVuId) VALUES (@Id, @CvId)", conn, trans);
                        cmdCv.Parameters.AddWithValue("@Id", txtId.Tag);
                        cmdCv.Parameters.AddWithValue("@CvId", cboRole.SelectedValue);
                        cmdCv.ExecuteNonQuery();
                    }

                    trans.Commit();
                    MessageBox.Show("Cập nhật thành công!");
                    LoadData(); ResetForm();
                }
                catch (Exception ex) { trans.Rollback(); MessageBox.Show("Lỗi sửa: " + ex.Message); }
            }
        }

        // --- 6. CHỨC NĂNG XÓA ---
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Tag == null) return;
            if (MessageBox.Show("Bạn có chắc chắn xóa nhân viên này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(strConnect))
                {
                    conn.Open();
                    try
                    {
                        SqlCommand cmd = new SqlCommand("DELETE FROM NhanVien WHERE Id = @Id", conn);
                        cmd.Parameters.AddWithValue("@Id", txtId.Tag);
                        cmd.ExecuteNonQuery();

                        LoadData(); ResetForm();
                    }
                    catch (Exception ex) { MessageBox.Show("Lỗi xóa: " + ex.Message); }
                }
            }
        }

        // --- 7. CHỨC NĂNG XUẤT EXCEL (ĐÃ CẬP NHẬT ĐỊNH DẠNG & TÊN FILE) ---
        private void BtnExport_Click(object sender, EventArgs e)
        {
            ExcelPackage.License.SetNonCommercialPersonal("Hoc Tap");

            // 1. Tự động tạo tên file với ngày giờ hiện tại để tránh trùng lặp
            string autoFileName = $"DS_NhanVien_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx";

            // Gán FileName mặc định vào hộp thoại lưu
            using (SaveFileDialog sfd = new SaveFileDialog { Filter = "Excel File|*.xlsx", FileName = autoFileName })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (ExcelPackage p = new ExcelPackage())
                        {
                            var ws = p.Workbook.Worksheets.Add("NhanVien");
                            DataTable dt = (DataTable)dgvEmployee.DataSource;

                            // Load dữ liệu từ DataTable vào Excel bắt đầu từ ô A1
                            ws.Cells[1, 1].LoadFromDataTable(dt, true);

                            // 2. Xử lý định dạng (Format) từng cột
                            for (int i = 0; i < dt.Columns.Count; i++)
                            {
                                int colIndex = i + 1; // Excel bắt đầu từ 1

                                // Nếu là cột Ngày tháng -> Format dd/MM/yyyy
                                if (dt.Columns[i].DataType == typeof(DateTime))
                                {
                                    ws.Column(colIndex).Style.Numberformat.Format = "dd/MM/yyyy";
                                    ws.Column(colIndex).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                }
                                // Nếu là cột Lương (hoặc Decimal) -> Format tiền tệ (#,##0)
                                else if (dt.Columns[i].DataType == typeof(decimal) || dt.Columns[i].ColumnName.Contains("Luong"))
                                {
                                    ws.Column(colIndex).Style.Numberformat.Format = "#,##0";
                                }
                            }

                            // 3. Trang trí Header (Tiêu đề)
                            using (var range = ws.Cells[1, 1, 1, dt.Columns.Count])
                            {
                                range.Style.Font.Bold = true;
                                range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                range.Style.Fill.BackgroundColor.SetColor(Color.LightBlue); // Màu nền xanh nhạt
                                range.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                            }

                            // Tự động giãn cột cho đẹp
                            ws.Cells.AutoFitColumns();

                            // Lưu file
                            p.SaveAs(new FileInfo(sfd.FileName));
                            MessageBox.Show($"Xuất file thành công!\nĐường dẫn: {sfd.FileName}", "Thông báo");
                        }
                    }
                    catch (Exception ex) { MessageBox.Show("Lỗi xuất Excel: " + ex.Message); }
                }
            }
        }

        // --- CÁC HÀM TIỆN ÍCH ---
        private void BtnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog { Filter = "Ảnh|*.jpg;*.jpeg;*.png;*.bmp" };
            if (op.ShowDialog() == DialogResult.OK)
                picAvatar.Image = new Bitmap(op.FileName);
        }

        private decimal ParseDecimal(string txt)
        {
            return decimal.TryParse(txt.Replace(",", "").Replace(".", ""), out decimal res) ? res : 0;
        }

        private byte[] ImageToByteArray(Image img)
        {
            if (img == null) return null;
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private Image ByteArrayToImage(byte[] arr)
        {
            if (arr == null || arr.Length == 0) return null;
            return Image.FromStream(new MemoryStream(arr));
        }

        private void ResetForm()
        {
            txtId.Clear(); txtId.Tag = null;
            txtName.Clear(); txtSalary.Clear(); txtPhone.Clear();
            ResetComboboxSelection();
            picAvatar.Image = null;
            dtpJoinDate.Value = DateTime.Now;
            txtName.Focus();
        }

        private void ResetComboboxSelection()
        {
            cboDept.SelectedIndex = -1;
            cboRole.SelectedIndex = -1;
            cboGender.SelectedIndex = -1;
        }

        private bool ValidInput()
        {
            if (string.IsNullOrWhiteSpace(txtId.Text) || string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Mã nhân viên và Họ tên không được để trống!");
                return false;
            }
            return true;
        }
    }
} 