namespace EmployerMananger
{
    partial class Dashboard
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
            btnReports = new Button();
            btnCalendar = new Button();
            btnAccount = new Button();
            btnMessages = new Button();
            btnDashboard = new Button();
            panelLogo = new Panel();
            picLogo = new PictureBox();
            lblLogo = new Label();
            panelHeader = new Panel();
            picUser = new PictureBox();
            lblUser = new Label();
            txtSearch = new TextBox();
            panelMain = new Panel();
            panelBigMap = new Panel();
            lblMapTitle = new Label();
            panelCard3 = new Panel();
            picIcon3 = new PictureBox();
            lblNum3 = new Label();
            lblTitle3 = new Label();
            panelCard2 = new Panel();
            picIcon2 = new PictureBox();
            lblNum2 = new Label();
            lblTitle2 = new Label();
            panelCard1 = new Panel();
            picIcon1 = new PictureBox();
            lblNum1 = new Label();
            lblTitle1 = new Label();
            lblPageTitle = new Label();
            panelSidebar.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUser).BeginInit();
            panelMain.SuspendLayout();
            panelBigMap.SuspendLayout();
            panelCard3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picIcon3).BeginInit();
            panelCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picIcon2).BeginInit();
            panelCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picIcon1).BeginInit();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(50, 60, 220);
            panelSidebar.Controls.Add(btnReports);
            panelSidebar.Controls.Add(btnCalendar);
            panelSidebar.Controls.Add(btnAccount);
            panelSidebar.Controls.Add(btnMessages);
            panelSidebar.Controls.Add(btnDashboard);
            panelSidebar.Controls.Add(panelLogo);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Margin = new Padding(4, 5, 4, 5);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(293, 923);
            panelSidebar.TabIndex = 0;
            // 
            // btnReports
            // 
            btnReports.Dock = DockStyle.Top;
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Segoe UI", 11F);
            btnReports.ForeColor = Color.White;
            btnReports.Location = new Point(0, 431);
            btnReports.Margin = new Padding(4, 5, 4, 5);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(293, 77);
            btnReports.TabIndex = 0;
            btnReports.Text = "   Đăng xuất";
            btnReports.TextAlign = ContentAlignment.MiddleLeft;
            btnReports.Click += btnThoat_Click;
            // 
            // btnCalendar
            // 
            btnCalendar.Dock = DockStyle.Top;
            btnCalendar.FlatAppearance.BorderSize = 0;
            btnCalendar.FlatStyle = FlatStyle.Flat;
            btnCalendar.Font = new Font("Segoe UI", 11F);
            btnCalendar.ForeColor = Color.White;
            btnCalendar.Location = new Point(0, 354);
            btnCalendar.Margin = new Padding(4, 5, 4, 5);
            btnCalendar.Name = "btnCalendar";
            btnCalendar.Size = new Size(293, 77);
            btnCalendar.TabIndex = 1;
            btnCalendar.Text = "   Lịch làm việc";
            btnCalendar.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnAccount
            // 
            btnAccount.Dock = DockStyle.Top;
            btnAccount.FlatAppearance.BorderSize = 0;
            btnAccount.FlatStyle = FlatStyle.Flat;
            btnAccount.Font = new Font("Segoe UI", 11F);
            btnAccount.ForeColor = Color.White;
            btnAccount.Location = new Point(0, 277);
            btnAccount.Margin = new Padding(4, 5, 4, 5);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new Size(293, 77);
            btnAccount.TabIndex = 2;
            btnAccount.Text = "   Tài khoản";
            btnAccount.TextAlign = ContentAlignment.MiddleLeft;
            btnAccount.Click += btnAccount_Click;
            // 
            // btnMessages
            // 
            btnMessages.Dock = DockStyle.Top;
            btnMessages.FlatAppearance.BorderSize = 0;
            btnMessages.FlatStyle = FlatStyle.Flat;
            btnMessages.Font = new Font("Segoe UI", 11F);
            btnMessages.ForeColor = Color.White;
            btnMessages.Location = new Point(0, 200);
            btnMessages.Margin = new Padding(4, 5, 4, 5);
            btnMessages.Name = "btnMessages";
            btnMessages.Size = new Size(293, 77);
            btnMessages.TabIndex = 3;
            btnMessages.Text = "   Nhân viên";
            btnMessages.TextAlign = ContentAlignment.MiddleLeft;
            btnMessages.Click += btnNhanVien_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 11F);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(0, 123);
            btnDashboard.Margin = new Padding(4, 5, 4, 5);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(293, 77);
            btnDashboard.TabIndex = 4;
            btnDashboard.Text = "   Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(picLogo);
            panelLogo.Controls.Add(lblLogo);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(4, 5, 4, 5);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(293, 123);
            panelLogo.TabIndex = 5;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.White;
            picLogo.Location = new Point(27, 31);
            picLogo.Margin = new Padding(4, 5, 4, 5);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(53, 62);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
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
            lblLogo.TabIndex = 1;
            lblLogo.Text = "HR MANAGER";
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.White;
            panelHeader.Controls.Add(picUser);
            panelHeader.Controls.Add(lblUser);
            panelHeader.Controls.Add(txtSearch);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(293, 0);
            panelHeader.Margin = new Padding(4, 5, 4, 5);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1040, 92);
            panelHeader.TabIndex = 1;
            // 
            // picUser
            // 
            picUser.BackColor = Color.LightGray;
            picUser.Location = new Point(907, 15);
            picUser.Margin = new Padding(4, 5, 4, 5);
            picUser.Name = "picUser";
            picUser.Size = new Size(53, 62);
            picUser.TabIndex = 0;
            picUser.TabStop = false;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUser.ForeColor = Color.Black;
            lblUser.Location = new Point(800, 34);
            lblUser.Margin = new Padding(4, 0, 4, 0);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(92, 23);
            lblUser.TabIndex = 1;
            lblUser.Text = "Hi, Admin";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.ForeColor = Color.Gray;
            txtSearch.Location = new Point(40, 28);
            txtSearch.Margin = new Padding(4, 5, 4, 5);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(399, 30);
            txtSearch.TabIndex = 2;
            txtSearch.Text = "Tìm kiếm...";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.WhiteSmoke;
            panelMain.Controls.Add(panelBigMap);
            panelMain.Controls.Add(panelCard3);
            panelMain.Controls.Add(panelCard2);
            panelMain.Controls.Add(panelCard1);
            panelMain.Controls.Add(lblPageTitle);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(293, 92);
            panelMain.Margin = new Padding(4, 5, 4, 5);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1040, 831);
            panelMain.TabIndex = 0;
            // 
            // panelBigMap
            // 
            panelBigMap.BackColor = Color.White;
            panelBigMap.Controls.Add(lblMapTitle);
            panelBigMap.Location = new Point(47, 338);
            panelBigMap.Margin = new Padding(4, 5, 4, 5);
            panelBigMap.Name = "panelBigMap";
            panelBigMap.Size = new Size(947, 431);
            panelBigMap.TabIndex = 0;
            // 
            // lblMapTitle
            // 
            lblMapTitle.AutoSize = true;
            lblMapTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblMapTitle.ForeColor = Color.Gray;
            lblMapTitle.Location = new Point(27, 31);
            lblMapTitle.Margin = new Padding(4, 0, 4, 0);
            lblMapTitle.Name = "lblMapTitle";
            lblMapTitle.Size = new Size(384, 28);
            lblMapTitle.TabIndex = 0;
            lblMapTitle.Text = "Bản đồ / Danh sách hoạt động gần đây";
            // 
            // panelCard3
            // 
            panelCard3.BackColor = Color.White;
            panelCard3.Controls.Add(picIcon3);
            panelCard3.Controls.Add(lblNum3);
            panelCard3.Controls.Add(lblTitle3);
            panelCard3.Location = new Point(700, 108);
            panelCard3.Margin = new Padding(4, 5, 4, 5);
            panelCard3.Name = "panelCard3";
            panelCard3.Size = new Size(293, 185);
            panelCard3.TabIndex = 1;
            // 
            // picIcon3
            // 
            picIcon3.BackColor = Color.LavenderBlush;
            picIcon3.Location = new Point(213, 23);
            picIcon3.Margin = new Padding(4, 5, 4, 5);
            picIcon3.Name = "picIcon3";
            picIcon3.Size = new Size(53, 62);
            picIcon3.TabIndex = 0;
            picIcon3.TabStop = false;
            // 
            // lblNum3
            // 
            lblNum3.AutoSize = true;
            lblNum3.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblNum3.ForeColor = Color.Purple;
            lblNum3.Location = new Point(20, 92);
            lblNum3.Margin = new Padding(4, 0, 4, 0);
            lblNum3.Name = "lblNum3";
            lblNum3.Size = new Size(87, 37);
            lblNum3.TabIndex = 1;
            lblNum3.Text = "135 k";
            // 
            // lblTitle3
            // 
            lblTitle3.AutoSize = true;
            lblTitle3.Font = new Font("Segoe UI", 10F);
            lblTitle3.ForeColor = Color.Gray;
            lblTitle3.Location = new Point(20, 23);
            lblTitle3.Margin = new Padding(4, 0, 4, 0);
            lblTitle3.Name = "lblTitle3";
            lblTitle3.Size = new Size(83, 23);
            lblTitle3.TabIndex = 2;
            lblTitle3.Text = "Yêu Thích";
            // 
            // panelCard2
            // 
            panelCard2.BackColor = Color.White;
            panelCard2.Controls.Add(picIcon2);
            panelCard2.Controls.Add(lblNum2);
            panelCard2.Controls.Add(lblTitle2);
            panelCard2.Location = new Point(373, 108);
            panelCard2.Margin = new Padding(4, 5, 4, 5);
            panelCard2.Name = "panelCard2";
            panelCard2.Size = new Size(293, 185);
            panelCard2.TabIndex = 2;
            // 
            // picIcon2
            // 
            picIcon2.BackColor = Color.Honeydew;
            picIcon2.Location = new Point(213, 23);
            picIcon2.Margin = new Padding(4, 5, 4, 5);
            picIcon2.Name = "picIcon2";
            picIcon2.Size = new Size(53, 62);
            picIcon2.TabIndex = 0;
            picIcon2.TabStop = false;
            // 
            // lblNum2
            // 
            lblNum2.AutoSize = true;
            lblNum2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblNum2.ForeColor = Color.Green;
            lblNum2.Location = new Point(20, 92);
            lblNum2.Margin = new Padding(4, 0, 4, 0);
            lblNum2.Name = "lblNum2";
            lblNum2.Size = new Size(88, 37);
            lblNum2.TabIndex = 1;
            lblNum2.Text = "1,340";
            // 
            // lblTitle2
            // 
            lblTitle2.AutoSize = true;
            lblTitle2.Font = new Font("Segoe UI", 10F);
            lblTitle2.ForeColor = Color.Gray;
            lblTitle2.Location = new Point(20, 23);
            lblTitle2.Margin = new Padding(4, 0, 4, 0);
            lblTitle2.Name = "lblTitle2";
            lblTitle2.Size = new Size(71, 23);
            lblTitle2.TabIndex = 2;
            lblTitle2.Text = "Lượt Tải";
            // 
            // panelCard1
            // 
            panelCard1.BackColor = Color.White;
            panelCard1.Controls.Add(picIcon1);
            panelCard1.Controls.Add(lblNum1);
            panelCard1.Controls.Add(lblTitle1);
            panelCard1.Location = new Point(47, 108);
            panelCard1.Margin = new Padding(4, 5, 4, 5);
            panelCard1.Name = "panelCard1";
            panelCard1.Size = new Size(293, 185);
            panelCard1.TabIndex = 3;
            // 
            // picIcon1
            // 
            picIcon1.BackColor = Color.Lavender;
            picIcon1.Location = new Point(213, 23);
            picIcon1.Margin = new Padding(4, 5, 4, 5);
            picIcon1.Name = "picIcon1";
            picIcon1.Size = new Size(53, 62);
            picIcon1.TabIndex = 0;
            picIcon1.TabStop = false;
            // 
            // lblNum1
            // 
            lblNum1.AutoSize = true;
            lblNum1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblNum1.ForeColor = Color.Navy;
            lblNum1.Location = new Point(20, 92);
            lblNum1.Margin = new Padding(4, 0, 4, 0);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(111, 37);
            lblNum1.TabIndex = 1;
            lblNum1.Text = "$ 3,124";
            // 
            // lblTitle1
            // 
            lblTitle1.AutoSize = true;
            lblTitle1.Font = new Font("Segoe UI", 10F);
            lblTitle1.ForeColor = Color.Gray;
            lblTitle1.Location = new Point(20, 23);
            lblTitle1.Margin = new Padding(4, 0, 4, 0);
            lblTitle1.Name = "lblTitle1";
            lblTitle1.Size = new Size(86, 23);
            lblTitle1.TabIndex = 2;
            lblTitle1.Text = "Thu Nhập";
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblPageTitle.Location = new Point(40, 31);
            lblPageTitle.Margin = new Padding(4, 0, 4, 0);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(174, 41);
            lblPageTitle.TabIndex = 4;
            lblPageTitle.Text = "Tổng Quan";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1333, 923);
            Controls.Add(panelMain);
            Controls.Add(panelHeader);
            Controls.Add(panelSidebar);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard System";
            panelSidebar.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picUser).EndInit();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            panelBigMap.ResumeLayout(false);
            panelBigMap.PerformLayout();
            panelCard3.ResumeLayout(false);
            panelCard3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picIcon3).EndInit();
            panelCard2.ResumeLayout(false);
            panelCard2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picIcon2).EndInit();
            panelCard1.ResumeLayout(false);
            panelCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picIcon1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        // Khai báo biến
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblLogo;

        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnMessages;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnCalendar;
        private System.Windows.Forms.Button btnReports;

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.PictureBox picUser;

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblPageTitle;

        // 3 Cards
        private System.Windows.Forms.Panel panelCard1;
        private System.Windows.Forms.Label lblTitle1;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.PictureBox picIcon1;

        private System.Windows.Forms.Panel panelCard2;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.PictureBox picIcon2;

        private System.Windows.Forms.Panel panelCard3;
        private System.Windows.Forms.Label lblTitle3;
        private System.Windows.Forms.Label lblNum3;
        private System.Windows.Forms.PictureBox picIcon3;

        private System.Windows.Forms.Panel panelBigMap;
        private System.Windows.Forms.Label lblMapTitle;
    }
}