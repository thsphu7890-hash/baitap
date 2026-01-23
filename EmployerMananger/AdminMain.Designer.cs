namespace EmployerMananger
{
    partial class AdminMain
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
            panelSidebar = new Panel();
            btnBackDashboard = new Button();
            btnLogOut = new Button();
            panelLogo = new Panel();
            lblLogo = new Label();
            picLogo = new PictureBox();
            panelHeader = new Panel();
            lblTitlePage = new Label();
            panelContent = new Panel();
            panelGrid = new Panel();
            dgvNhanVien = new DataGridView();
            labelGridHeader = new Label();
            panelInput = new Panel();
            grpThongTin = new GroupBox();
            txtMaNV = new TextBox();
            labelMaNV = new Label();
            txtHoTen = new TextBox();
            label4 = new Label();
            txtUser = new TextBox();
            label1 = new Label();
            txtPass = new TextBox();
            label2 = new Label();
            txtRole = new TextBox();
            label3 = new Label();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            label5 = new Label();
            panelSidebar.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            panelHeader.SuspendLayout();
            panelContent.SuspendLayout();
            panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            panelInput.SuspendLayout();
            grpThongTin.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(50, 60, 220);
            panelSidebar.Controls.Add(btnBackDashboard);
            panelSidebar.Controls.Add(btnLogOut);
            panelSidebar.Controls.Add(panelLogo);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Margin = new Padding(4, 5, 4, 5);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(293, 1055);
            panelSidebar.TabIndex = 2;
            // 
            // btnBackDashboard
            // 
            btnBackDashboard.Dock = DockStyle.Top;
            btnBackDashboard.FlatAppearance.BorderSize = 0;
            btnBackDashboard.FlatStyle = FlatStyle.Flat;
            btnBackDashboard.Font = new Font("Segoe UI", 11F);
            btnBackDashboard.ForeColor = Color.White;
            btnBackDashboard.Location = new Point(0, 123);
            btnBackDashboard.Margin = new Padding(4, 5, 4, 5);
            btnBackDashboard.Name = "btnBackDashboard";
            btnBackDashboard.Size = new Size(293, 77);
            btnBackDashboard.TabIndex = 0;
            btnBackDashboard.Text = "   << Về Dashboard";
            btnBackDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnBackDashboard.Click += btnThoat_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.Dock = DockStyle.Bottom;
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Segoe UI", 11F);
            btnLogOut.ForeColor = Color.LightCoral;
            btnLogOut.Location = new Point(0, 978);
            btnLogOut.Margin = new Padding(4, 5, 4, 5);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(293, 77);
            btnLogOut.TabIndex = 1;
            btnLogOut.Text = "   Thoát phần mềm";
            btnLogOut.TextAlign = ContentAlignment.MiddleLeft;
            btnLogOut.Click += btnThoat_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(lblLogo);
            panelLogo.Controls.Add(picLogo);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(4, 5, 4, 5);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(293, 123);
            panelLogo.TabIndex = 2;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblLogo.ForeColor = Color.White;
            lblLogo.Location = new Point(93, 43);
            lblLogo.Margin = new Padding(4, 0, 4, 0);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(177, 32);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "HR MANAGER";
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.White;
            picLogo.Location = new Point(27, 31);
            picLogo.Margin = new Padding(4, 5, 4, 5);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(53, 62);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 1;
            picLogo.TabStop = false;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.White;
            panelHeader.Controls.Add(lblTitlePage);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(293, 0);
            panelHeader.Margin = new Padding(4, 5, 4, 5);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1574, 92);
            panelHeader.TabIndex = 1;
            // 
            // lblTitlePage
            // 
            lblTitlePage.AutoSize = true;
            lblTitlePage.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitlePage.ForeColor = Color.Navy;
            lblTitlePage.Location = new Point(27, 23);
            lblTitlePage.Margin = new Padding(4, 0, 4, 0);
            lblTitlePage.Name = "lblTitlePage";
            lblTitlePage.Size = new Size(297, 41);
            lblTitlePage.TabIndex = 0;
            lblTitlePage.Text = "QUẢN LÝ NHÂN SỰ";
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.WhiteSmoke;
            panelContent.Controls.Add(panelGrid);
            panelContent.Controls.Add(panelInput);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(293, 92);
            panelContent.Margin = new Padding(4, 5, 4, 5);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(13, 15, 13, 15);
            panelContent.Size = new Size(1574, 963);
            panelContent.TabIndex = 0;
            // 
            // panelGrid
            // 
            panelGrid.BackColor = Color.White;
            panelGrid.Controls.Add(dgvNhanVien);
            panelGrid.Controls.Add(labelGridHeader);
            panelGrid.Dock = DockStyle.Fill;
            panelGrid.Location = new Point(13, 323);
            panelGrid.Margin = new Padding(4, 5, 4, 5);
            panelGrid.Name = "panelGrid";
            panelGrid.Size = new Size(1548, 625);
            panelGrid.TabIndex = 0;
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.BackgroundColor = Color.White;
            dgvNhanVien.BorderStyle = BorderStyle.None;
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Dock = DockStyle.Fill;
            dgvNhanVien.Location = new Point(0, 62);
            dgvNhanVien.Margin = new Padding(4, 5, 4, 5);
            dgvNhanVien.MultiSelect = false;
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.RowHeadersWidth = 51;
            dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhanVien.Size = new Size(1548, 563);
            dgvNhanVien.TabIndex = 0;
            dgvNhanVien.CellClick += dgvNhanVien_CellClick;
            // 
            // labelGridHeader
            // 
            labelGridHeader.Dock = DockStyle.Top;
            labelGridHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelGridHeader.ForeColor = Color.Gray;
            labelGridHeader.Location = new Point(0, 0);
            labelGridHeader.Margin = new Padding(4, 0, 4, 0);
            labelGridHeader.Name = "labelGridHeader";
            labelGridHeader.Size = new Size(1548, 62);
            labelGridHeader.TabIndex = 1;
            labelGridHeader.Text = "   Danh sách nhân viên";
            labelGridHeader.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelInput
            // 
            panelInput.BackColor = Color.White;
            panelInput.Controls.Add(grpThongTin);
            panelInput.Dock = DockStyle.Top;
            panelInput.Location = new Point(13, 15);
            panelInput.Margin = new Padding(4, 5, 4, 5);
            panelInput.Name = "panelInput";
            panelInput.Size = new Size(1548, 308);
            panelInput.TabIndex = 1;
            // 
            // grpThongTin
            // 
            grpThongTin.Controls.Add(label5);
            grpThongTin.Controls.Add(txtMaNV);
            grpThongTin.Controls.Add(labelMaNV);
            grpThongTin.Controls.Add(txtHoTen);
            grpThongTin.Controls.Add(label4);
            grpThongTin.Controls.Add(txtUser);
            grpThongTin.Controls.Add(label1);
            grpThongTin.Controls.Add(txtPass);
            grpThongTin.Controls.Add(label2);
            grpThongTin.Controls.Add(txtRole);
            grpThongTin.Controls.Add(label3);
            grpThongTin.Controls.Add(btnLamMoi);
            grpThongTin.Controls.Add(btnXoa);
            grpThongTin.Controls.Add(btnSua);
            grpThongTin.Controls.Add(btnThem);
            grpThongTin.Dock = DockStyle.Fill;
            grpThongTin.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            grpThongTin.Location = new Point(0, 0);
            grpThongTin.Margin = new Padding(4, 5, 4, 5);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Padding = new Padding(4, 5, 4, 5);
            grpThongTin.Size = new Size(1548, 308);
            grpThongTin.TabIndex = 0;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông tin & Thao tác";
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(40, 100);
            txtMaNV.Margin = new Padding(4, 5, 4, 5);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(265, 29);
            txtMaNV.TabIndex = 0;
            // 
            // labelMaNV
            // 
            labelMaNV.Location = new Point(40, 62);
            labelMaNV.Margin = new Padding(4, 0, 4, 0);
            labelMaNV.Name = "labelMaNV";
            labelMaNV.Size = new Size(133, 35);
            labelMaNV.TabIndex = 1;
            labelMaNV.Text = "Mã nhân viên:";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(40, 208);
            txtHoTen.Margin = new Padding(4, 5, 4, 5);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(265, 29);
            txtHoTen.TabIndex = 2;
            // 
            // label4
            // 
            label4.Location = new Point(40, 169);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(133, 35);
            label4.TabIndex = 3;
            label4.Text = "Họ và tên:";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(373, 100);
            txtUser.Margin = new Padding(4, 5, 4, 5);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(265, 29);
            txtUser.TabIndex = 4;
            // 
            // label1
            // 
            label1.Location = new Point(373, 62);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(133, 35);
            label1.TabIndex = 5;
            label1.Text = "Tên đăng nhập:";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(373, 208);
            txtPass.Margin = new Padding(4, 5, 4, 5);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(265, 29);
            txtPass.TabIndex = 6;
            txtPass.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.Location = new Point(373, 169);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(133, 35);
            label2.TabIndex = 7;
            label2.Text = "Mật khẩu:";
            // 
            // txtRole
            // 
            txtRole.Location = new Point(707, 100);
            txtRole.Margin = new Padding(4, 5, 4, 5);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(265, 29);
            txtRole.TabIndex = 8;
            // 
            // label3
            // 
            label3.Location = new Point(707, 62);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(133, 35);
            label3.TabIndex = 9;
            label3.Text = "Chức vụ:";
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.Gray;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(1253, 154);
            btnLamMoi.Margin = new Padding(4, 5, 4, 5);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(160, 69);
            btnLamMoi.TabIndex = 10;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Firebrick;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(1067, 154);
            btnXoa.Margin = new Padding(4, 5, 4, 5);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(160, 69);
            btnXoa.TabIndex = 11;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.Goldenrod;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(1253, 62);
            btnSua.Margin = new Padding(4, 5, 4, 5);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(160, 69);
            btnSua.TabIndex = 12;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.ForestGreen;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(1067, 62);
            btnThem.Margin = new Padding(4, 5, 4, 5);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(160, 69);
            btnThem.TabIndex = 13;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(731, 205);
            label5.Name = "label5";
            label5.Size = new Size(0, 23);
            label5.TabIndex = 14;
            // 
            // AdminMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1867, 1055);
            Controls.Add(panelContent);
            Controls.Add(panelHeader);
            Controls.Add(panelSidebar);
            Margin = new Padding(4, 5, 4, 5);
            Name = "AdminMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý nhân viên";
            WindowState = FormWindowState.Maximized;
            Load += AdminMain_Load;
            panelSidebar.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelContent.ResumeLayout(false);
            panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            panelInput.ResumeLayout(false);
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        // Layout Components
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnBackDashboard;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitlePage;

        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label labelGridHeader;

        // BIẾN INPUT
        private System.Windows.Forms.Label labelMaNV; public System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label1; public System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label2; public System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label3; public System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.Label label4; public System.Windows.Forms.TextBox txtHoTen;

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;

        public System.Windows.Forms.DataGridView dgvNhanVien;
        private Label label5;
    }
}