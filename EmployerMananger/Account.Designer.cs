namespace EmployerMananger
{
    partial class Account
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
            // --- 1. KHAI BÁO BIẾN (Tạo các công cụ) ---
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnBackDashboard = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();

            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitlePage = new System.Windows.Forms.Label();

            this.panelContent = new System.Windows.Forms.Panel();

            // Group Đổi mật khẩu
            this.grpDoiMatKhau = new System.Windows.Forms.GroupBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtXacNhan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMatKhauMoi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMatKhauCu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();

            // Group Thông tin
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();

            // --- BẮT ĐẦU SẮP XẾP ---
            this.panelSidebar.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.grpDoiMatKhau.SuspendLayout();
            this.grpThongTin.SuspendLayout();
            this.SuspendLayout();

            // 
            // --- SIDEBAR (MENU TRÁI) ---
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(50, 60, 220); // Màu xanh thương hiệu
            this.panelSidebar.Controls.Add(this.btnBackDashboard);
            this.panelSidebar.Controls.Add(this.btnLogOut);
            this.panelSidebar.Controls.Add(this.panelLogo);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Size = new System.Drawing.Size(220, 600);

            // Logo Area
            this.panelLogo.Controls.Add(this.lblLogo);
            this.panelLogo.Controls.Add(this.picLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Size = new System.Drawing.Size(220, 80);

            this.picLogo.BackColor = System.Drawing.Color.White;
            this.picLogo.Location = new System.Drawing.Point(20, 20);
            this.picLogo.Size = new System.Drawing.Size(40, 40);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(70, 28);
            this.lblLogo.Text = "HR MANAGER";

            // Nút: Về Dashboard
            this.btnBackDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBackDashboard.FlatAppearance.BorderSize = 0;
            this.btnBackDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackDashboard.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnBackDashboard.ForeColor = System.Drawing.Color.White;
            this.btnBackDashboard.Location = new System.Drawing.Point(0, 80);
            this.btnBackDashboard.Size = new System.Drawing.Size(220, 50);
            this.btnBackDashboard.Text = "   << Về Dashboard";
            this.btnBackDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackDashboard.Click += new System.EventHandler(this.btnThoat_Click);

            // Nút: Thoát
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnLogOut.ForeColor = System.Drawing.Color.LightCoral;
            this.btnLogOut.Location = new System.Drawing.Point(0, 550);
            this.btnLogOut.Size = new System.Drawing.Size(220, 50);
            this.btnLogOut.Text = "   Thoát phần mềm";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Click += new System.EventHandler(this.btnThoat_Click);

            // 
            // --- HEADER (THANH TRÊN) ---
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.lblTitlePage);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(220, 0);
            this.panelHeader.Size = new System.Drawing.Size(780, 60);

            this.lblTitlePage.AutoSize = true;
            this.lblTitlePage.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitlePage.ForeColor = System.Drawing.Color.Navy;
            this.lblTitlePage.Location = new System.Drawing.Point(20, 15);
            this.lblTitlePage.Text = "TÀI KHOẢN CÁ NHÂN";

            // 
            // --- MAIN CONTENT (NỘI DUNG CHÍNH) ---
            // 
            this.panelContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelContent.Controls.Add(this.grpDoiMatKhau);
            this.panelContent.Controls.Add(this.grpThongTin);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(220, 60);
            this.panelContent.Padding = new System.Windows.Forms.Padding(20);
            this.panelContent.Size = new System.Drawing.Size(780, 540);

            // GROUP 1: THÔNG TIN (Chỉ hiển thị)
            this.grpThongTin.BackColor = System.Drawing.Color.White;
            this.grpThongTin.Controls.Add(this.lblRole);
            this.grpThongTin.Controls.Add(this.label2);
            this.grpThongTin.Controls.Add(this.lblUsername);
            this.grpThongTin.Controls.Add(this.label1);
            this.grpThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpThongTin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.grpThongTin.Location = new System.Drawing.Point(20, 20);
            this.grpThongTin.Size = new System.Drawing.Size(740, 120);
            this.grpThongTin.TabIndex = 0;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông tin chung";

            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(30, 40);
            this.label1.Text = "Tên đăng nhập:";

            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblUsername.ForeColor = System.Drawing.Color.Black;
            this.lblUsername.Location = new System.Drawing.Point(30, 65);
            this.lblUsername.Text = "admin"; // Tên mặc định

            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(250, 40);
            this.label2.Text = "Chức vụ:";

            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblRole.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblRole.Location = new System.Drawing.Point(250, 65);
            this.lblRole.Text = "Quản trị viên (Admin)";

            // GROUP 2: ĐỔI MẬT KHẨU
            this.grpDoiMatKhau.BackColor = System.Drawing.Color.White;
            this.grpDoiMatKhau.Controls.Add(this.btnLuu);
            this.grpDoiMatKhau.Controls.Add(this.txtXacNhan);
            this.grpDoiMatKhau.Controls.Add(this.label5);
            this.grpDoiMatKhau.Controls.Add(this.txtMatKhauMoi);
            this.grpDoiMatKhau.Controls.Add(this.label4);
            this.grpDoiMatKhau.Controls.Add(this.txtMatKhauCu);
            this.grpDoiMatKhau.Controls.Add(this.label3);
            this.grpDoiMatKhau.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpDoiMatKhau.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.grpDoiMatKhau.Location = new System.Drawing.Point(20, 160); // Nằm dưới Group 1
            this.grpDoiMatKhau.Size = new System.Drawing.Size(740, 300);
            this.grpDoiMatKhau.TabIndex = 1;
            this.grpDoiMatKhau.TabStop = false;
            this.grpDoiMatKhau.Text = "Đổi mật khẩu";

            // Nhập Mật khẩu cũ
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(30, 40);
            this.label3.Text = "Mật khẩu hiện tại:";

            this.txtMatKhauCu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMatKhauCu.Location = new System.Drawing.Point(34, 65);
            this.txtMatKhauCu.Size = new System.Drawing.Size(300, 25);
            this.txtMatKhauCu.UseSystemPasswordChar = true;

            // Nhập Mật khẩu mới
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.Location = new System.Drawing.Point(30, 100);
            this.label4.Text = "Mật khẩu mới:";

            this.txtMatKhauMoi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMatKhauMoi.Location = new System.Drawing.Point(34, 125);
            this.txtMatKhauMoi.Size = new System.Drawing.Size(300, 25);
            this.txtMatKhauMoi.UseSystemPasswordChar = true;

            // Nhập lại Mật khẩu
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.Location = new System.Drawing.Point(30, 160);
            this.label5.Text = "Nhập lại mật khẩu mới:";

            this.txtXacNhan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtXacNhan.Location = new System.Drawing.Point(34, 185);
            this.txtXacNhan.Size = new System.Drawing.Size(300, 25);
            this.txtXacNhan.UseSystemPasswordChar = true;

            // Nút Lưu thay đổi
            this.btnLuu.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(34, 230);
            this.btnLuu.Size = new System.Drawing.Size(150, 40);
            this.btnLuu.Text = "Lưu thay đổi";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);

            // 
            // Account Form Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tài khoản cá nhân";

            this.panelSidebar.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.grpDoiMatKhau.ResumeLayout(false);
            this.grpDoiMatKhau.PerformLayout();
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        // Biến Giao diện
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnBackDashboard;
        private System.Windows.Forms.Button btnLogOut;

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitlePage;

        private System.Windows.Forms.Panel panelContent;

        // Biến Group Thông tin
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRole;

        // Biến Group Đổi mật khẩu (Quan trọng để code logic)
        private System.Windows.Forms.GroupBox grpDoiMatKhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMatKhauCu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMatKhauMoi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtXacNhan;
        private System.Windows.Forms.Button btnLuu;
    }
}