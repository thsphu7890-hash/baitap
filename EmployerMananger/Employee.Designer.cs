namespace EmployerMananger
{
    partial class Employee
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dgvHeaderStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvRowStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvAltRowStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dateCellStyle = new System.Windows.Forms.DataGridViewCellStyle();

            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panelInput = new System.Windows.Forms.Panel();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDob = new System.Windows.Forms.Label();
            this.dtpDob = new System.Windows.Forms.DateTimePicker();
            this.lblGender = new System.Windows.Forms.Label();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblDept = new System.Windows.Forms.Label();
            this.cboDept = new System.Windows.Forms.ComboBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.cboRole = new System.Windows.Forms.ComboBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblJoinDate = new System.Windows.Forms.Label();
            this.dtpJoinDate = new System.Windows.Forms.DateTimePicker();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.panelActions = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();

            // [BỔ SUNG] Khởi tạo các cột
            this.colAvatar = new System.Windows.Forms.DataGridViewImageColumn();
            this.colChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn(); // <--- MỚI
            this.colNgayVaoLam = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();

            this.panelHeader.SuspendLayout();
            this.panelInput.SuspendLayout();
            this.grpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.panelActions.SuspendLayout();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();

            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panelHeader.Controls.Add(this.btnSearch);
            this.panelHeader.Controls.Add(this.txtSearch);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1100, 70);
            this.panelHeader.TabIndex = 0;

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(332, 46);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ NHÂN SỰ";

            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSearch.Location = new System.Drawing.Point(730, 20);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "🔍 Nhập tên hoặc mã nhân viên...";
            this.txtSearch.Size = new System.Drawing.Size(230, 32);
            this.txtSearch.TabIndex = 1;

            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnSearch.Location = new System.Drawing.Point(970, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 34);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "TÌM KIẾM";
            this.btnSearch.UseVisualStyleBackColor = false;

            // 
            // panelInput
            // 
            this.panelInput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelInput.Controls.Add(this.grpInfo);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInput.Location = new System.Drawing.Point(0, 70);
            this.panelInput.Name = "panelInput";
            this.panelInput.Padding = new System.Windows.Forms.Padding(15);
            this.panelInput.Size = new System.Drawing.Size(1100, 300);
            this.panelInput.TabIndex = 1;

            // 
            // grpInfo
            // 
            this.grpInfo.BackColor = System.Drawing.Color.White;
            this.grpInfo.Controls.Add(this.picAvatar);
            this.grpInfo.Controls.Add(this.btnUpload);
            this.grpInfo.Controls.Add(this.lblId);
            this.grpInfo.Controls.Add(this.txtId);
            this.grpInfo.Controls.Add(this.lblName);
            this.grpInfo.Controls.Add(this.txtName);
            this.grpInfo.Controls.Add(this.lblDob);
            this.grpInfo.Controls.Add(this.dtpDob);
            this.grpInfo.Controls.Add(this.lblGender);
            this.grpInfo.Controls.Add(this.cboGender);
            this.grpInfo.Controls.Add(this.lblPhone);
            this.grpInfo.Controls.Add(this.txtPhone);
            this.grpInfo.Controls.Add(this.lblDept);
            this.grpInfo.Controls.Add(this.cboDept);
            this.grpInfo.Controls.Add(this.lblRole);
            this.grpInfo.Controls.Add(this.cboRole);
            this.grpInfo.Controls.Add(this.lblSalary);
            this.grpInfo.Controls.Add(this.txtSalary);
            this.grpInfo.Controls.Add(this.lblJoinDate);
            this.grpInfo.Controls.Add(this.dtpJoinDate);
            this.grpInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grpInfo.Location = new System.Drawing.Point(15, 15);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(1070, 270);
            this.grpInfo.TabIndex = 0;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = " Thông Tin Chi Tiết ";

            // lblId
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblId.Location = new System.Drawing.Point(30, 45);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(103, 21);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Mã nhân viên:";

            // txtId
            this.txtId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtId.Location = new System.Drawing.Point(150, 42);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(200, 30);
            this.txtId.TabIndex = 0;

            // lblName
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblName.Location = new System.Drawing.Point(30, 90);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(79, 21);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Họ và tên:";

            // txtName
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtName.Location = new System.Drawing.Point(150, 87);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 30);
            this.txtName.TabIndex = 1;

            // lblDob
            this.lblDob.AutoSize = true;
            this.lblDob.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDob.Location = new System.Drawing.Point(30, 135);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(83, 21);
            this.lblDob.TabIndex = 4;
            this.lblDob.Text = "Ngày sinh:";

            // dtpDob
            this.dtpDob.CustomFormat = "dd/MM/yyyy";
            this.dtpDob.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpDob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDob.Location = new System.Drawing.Point(150, 132);
            this.dtpDob.Name = "dtpDob";
            this.dtpDob.Size = new System.Drawing.Size(200, 30);
            this.dtpDob.TabIndex = 2;

            // lblGender
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblGender.Location = new System.Drawing.Point(30, 180);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(73, 21);
            this.lblGender.TabIndex = 6;
            this.lblGender.Text = "Giới tính:";

            // cboGender
            this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Items.AddRange(new object[] { "Nam", "Nữ" });
            this.cboGender.Location = new System.Drawing.Point(150, 177);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(200, 31);
            this.cboGender.TabIndex = 3;

            // lblPhone
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblPhone.Location = new System.Drawing.Point(30, 225);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(104, 21);
            this.lblPhone.TabIndex = 8;
            this.lblPhone.Text = "Số điện thoại:";

            // txtPhone
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPhone.Location = new System.Drawing.Point(150, 222);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(200, 30);
            this.txtPhone.TabIndex = 4;

            // lblDept
            this.lblDept.AutoSize = true;
            this.lblDept.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDept.Location = new System.Drawing.Point(400, 45);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(87, 21);
            this.lblDept.TabIndex = 10;
            this.lblDept.Text = "Phòng ban:";

            // cboDept
            this.cboDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDept.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboDept.Location = new System.Drawing.Point(510, 42);
            this.cboDept.Name = "cboDept";
            this.cboDept.Size = new System.Drawing.Size(200, 31);
            this.cboDept.TabIndex = 5;

            // lblRole
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblRole.Location = new System.Drawing.Point(400, 90);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(69, 21);
            this.lblRole.TabIndex = 12;
            this.lblRole.Text = "Chức vụ:";

            // cboRole
            this.cboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboRole.Location = new System.Drawing.Point(510, 87);
            this.cboRole.Name = "cboRole";
            this.cboRole.Size = new System.Drawing.Size(200, 31);
            this.cboRole.TabIndex = 6;

            // lblSalary
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSalary.Location = new System.Drawing.Point(400, 135);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(107, 21);
            this.lblSalary.TabIndex = 14;
            this.lblSalary.Text = "Lương cơ bản:";

            // txtSalary
            this.txtSalary.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSalary.Location = new System.Drawing.Point(510, 132);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(200, 30);
            this.txtSalary.TabIndex = 7;

            // lblJoinDate
            this.lblJoinDate.AutoSize = true;
            this.lblJoinDate.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblJoinDate.Location = new System.Drawing.Point(400, 180);
            this.lblJoinDate.Name = "lblJoinDate";
            this.lblJoinDate.Size = new System.Drawing.Size(107, 21);
            this.lblJoinDate.TabIndex = 16;
            this.lblJoinDate.Text = "Ngày vào làm:";

            // dtpJoinDate
            this.dtpJoinDate.CustomFormat = "dd/MM/yyyy";
            this.dtpJoinDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpJoinDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpJoinDate.Location = new System.Drawing.Point(510, 177);
            this.dtpJoinDate.Name = "dtpJoinDate";
            this.dtpJoinDate.Size = new System.Drawing.Size(200, 30);
            this.dtpJoinDate.TabIndex = 8;

            // picAvatar
            this.picAvatar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAvatar.Location = new System.Drawing.Point(800, 40);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(150, 150);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvatar.TabIndex = 18;
            this.picAvatar.TabStop = false;

            // btnUpload
            this.btnUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnUpload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpload.Location = new System.Drawing.Point(800, 200);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(150, 35);
            this.btnUpload.TabIndex = 9;
            this.btnUpload.Text = "📷 Chọn Ảnh";
            this.btnUpload.UseVisualStyleBackColor = false;

            // 
            // panelActions
            // 
            this.panelActions.BackColor = System.Drawing.Color.White;
            this.panelActions.Controls.Add(this.btnExport);
            this.panelActions.Controls.Add(this.btnSave);
            this.panelActions.Controls.Add(this.btnDelete);
            this.panelActions.Controls.Add(this.btnEdit);
            this.panelActions.Controls.Add(this.btnAdd);
            this.panelActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelActions.Location = new System.Drawing.Point(0, 370);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(1100, 70);
            this.panelActions.TabIndex = 2;

            // btnAdd
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(50, 15);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 40);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "➕ THÊM MỚI";
            this.btnAdd.UseVisualStyleBackColor = false;

            // btnEdit
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(210, 15);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(140, 40);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "✏️ CẬP NHẬT";
            this.btnEdit.UseVisualStyleBackColor = false;

            // btnDelete
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(370, 15);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(140, 40);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "🗑️ XÓA";
            this.btnDelete.UseVisualStyleBackColor = false;

            // btnSave (Reset)
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(530, 15);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 40);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "🔄 LÀM MỚI";
            this.btnSave.UseVisualStyleBackColor = false;

            // btnExport
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(690, 15);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(160, 40);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "📤 XUẤT EXCEL";
            this.btnExport.UseVisualStyleBackColor = false;

            // 
            // panelGrid
            // 
            this.panelGrid.Controls.Add(this.dgvEmployee);
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrid.Location = new System.Drawing.Point(0, 440);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Padding = new System.Windows.Forms.Padding(15, 0, 15, 10);
            this.panelGrid.Size = new System.Drawing.Size(1100, 230);
            this.panelGrid.TabIndex = 3;

            // 
            // dgvEmployee
            // 
            this.dgvEmployee.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmployee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployee.RowHeadersVisible = false;
            this.dgvEmployee.EnableHeadersVisualStyles = false;
            this.dgvEmployee.Dock = System.Windows.Forms.DockStyle.Fill;

            // Style Header
            dgvHeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dgvHeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dgvHeaderStyle.ForeColor = System.Drawing.Color.White;
            dgvHeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dgvHeaderStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgvHeaderStyle.Padding = new System.Windows.Forms.Padding(5);
            this.dgvEmployee.ColumnHeadersDefaultCellStyle = dgvHeaderStyle;
            this.dgvEmployee.ColumnHeadersHeight = 40;

            // [BỔ SUNG] Cột Ảnh đại diện
            this.colAvatar.DataPropertyName = "AnhDaiDien";
            this.colAvatar.HeaderText = "ẢNH";
            this.colAvatar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colAvatar.Name = "colAvatar";
            this.colAvatar.Width = 60;

            // [BỔ SUNG] Cột Chức vụ (MỚI)
            this.colChucVu.DataPropertyName = "TenChucVu"; // Lưu ý: Trong câu SQL ở Logic code, bạn cần JOIN bảng ChucVu để lấy trường TenChucVu
            this.colChucVu.HeaderText = "CHỨC VỤ";
            this.colChucVu.Name = "colChucVu";

            // [BỔ SUNG] Cột Ngày vào làm
            this.colNgayVaoLam.DataPropertyName = "NgayVaoLam";
            this.colNgayVaoLam.HeaderText = "NGÀY VÀO";
            this.colNgayVaoLam.Name = "colNgayVaoLam";
            dateCellStyle.Format = "dd/MM/yyyy";
            this.colNgayVaoLam.DefaultCellStyle = dateCellStyle;

            // Thêm cột vào Grid (Thêm colChucVu vào giữa)
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colAvatar,
                this.colChucVu, // <--- Thêm vào đây
                this.colNgayVaoLam
            });

            // Style Rows
            dgvRowStyle.BackColor = System.Drawing.Color.White;
            dgvRowStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            dgvRowStyle.ForeColor = System.Drawing.Color.Black;
            dgvRowStyle.Padding = new System.Windows.Forms.Padding(3);
            dgvRowStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dgvRowStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvEmployee.DefaultCellStyle = dgvRowStyle;
            this.dgvEmployee.RowTemplate.Height = 60;

            // Alternating Rows
            dgvAltRowStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.dgvEmployee.AlternatingRowsDefaultCellStyle = dgvAltRowStyle;

            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.lblStatus });
            this.statusStrip1.Location = new System.Drawing.Point(0, 674);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1100, 26);
            this.statusStrip1.TabIndex = 4;

            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(160, 20);
            this.lblStatus.Text = "Hệ thống sẵn sàng...";

            // 
            // Employee Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panelActions);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.panelHeader);
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Nhân Sự - HRM Professional";

            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelInput.ResumeLayout(false);
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.panelActions.ResumeLayout(false);
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        // Khai báo biến
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.GroupBox grpInfo;

        // Thông tin cá nhân
        private System.Windows.Forms.Label lblId, lblName, lblDob, lblGender, lblPhone;
        private System.Windows.Forms.TextBox txtId, txtName, txtPhone;
        private System.Windows.Forms.DateTimePicker dtpDob;
        private System.Windows.Forms.ComboBox cboGender;

        // Thông tin công việc
        private System.Windows.Forms.Label lblDept, lblRole, lblSalary, lblJoinDate;
        private System.Windows.Forms.ComboBox cboDept, cboRole;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.DateTimePicker dtpJoinDate;

        // Ảnh
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Button btnUpload;

        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.Button btnAdd, btnEdit, btnDelete, btnSave, btnExport;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.DataGridView dgvEmployee;

        // [BỔ SUNG] Cột dữ liệu
        private System.Windows.Forms.DataGridViewImageColumn colAvatar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChucVu; // <--- MỚI
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayVaoLam;

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
    }
}