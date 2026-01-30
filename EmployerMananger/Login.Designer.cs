namespace EmployerMananger
{
    partial class Login
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
            panelLeft = new Panel();
            lblSlogan = new Label();
            lblLogo = new Label();
            picLogo = new PictureBox();
            panelRight = new Panel();
            chkShowPass = new CheckBox();
            btnExit = new Button();
            btnLogin = new Button();
            panelPass = new Panel();
            txtPass = new TextBox();
            picPass = new PictureBox();
            panelUser = new Panel();
            txtUser = new TextBox();
            picUser = new PictureBox();
            lblTitle = new Label();
            panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            panelRight.SuspendLayout();
            panelPass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPass).BeginInit();
            panelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUser).BeginInit();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(0, 168, 255);
            panelLeft.Controls.Add(lblSlogan);
            panelLeft.Controls.Add(lblLogo);
            panelLeft.Controls.Add(picLogo);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Margin = new Padding(3, 4, 3, 4);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(300, 625);
            panelLeft.TabIndex = 0;
            // 
            // lblSlogan
            // 
            lblSlogan.AutoSize = true;
            lblSlogan.Font = new Font("Segoe UI", 10F);
            lblSlogan.ForeColor = Color.White;
            lblSlogan.Location = new Point(50, 325);
            lblSlogan.Name = "lblSlogan";
            lblSlogan.Size = new Size(209, 46);
            lblSlogan.TabIndex = 2;
            lblSlogan.Text = "Hệ thống quản lý nhân sự\r\nhiệu quả và tin cậy";
            lblSlogan.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblLogo.ForeColor = Color.White;
            lblLogo.Location = new Point(55, 262);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(199, 37);
            lblLogo.TabIndex = 1;
            lblLogo.Text = "HR MANAGER";
            // 
            // picLogo
            // 
            picLogo.Image = Properties.Resources.unnamed_removebg_preview;
            picLogo.Location = new Point(0, 85);
            picLogo.Margin = new Padding(3, 4, 3, 4);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(310, 172);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // panelRight
            // 
            panelRight.BackColor = Color.White;
            panelRight.Controls.Add(chkShowPass);
            panelRight.Controls.Add(btnExit);
            panelRight.Controls.Add(btnLogin);
            panelRight.Controls.Add(panelPass);
            panelRight.Controls.Add(panelUser);
            panelRight.Controls.Add(lblTitle);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(300, 0);
            panelRight.Margin = new Padding(3, 4, 3, 4);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(450, 625);
            panelRight.TabIndex = 1;
            // 
            // chkShowPass
            // 
            chkShowPass.AutoSize = true;
            chkShowPass.Font = new Font("Segoe UI", 9F);
            chkShowPass.ForeColor = Color.Gray;
            chkShowPass.Location = new Point(45, 375);
            chkShowPass.Margin = new Padding(3, 4, 3, 4);
            chkShowPass.Name = "chkShowPass";
            chkShowPass.Size = new Size(148, 24);
            chkShowPass.TabIndex = 5;
            chkShowPass.Text = "Hiển thị mật khẩu";
            chkShowPass.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.White;
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Verdana", 14F, FontStyle.Bold);
            btnExit.ForeColor = Color.FromArgb(0, 168, 255);
            btnExit.Location = new Point(410, 0);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(40, 50);
            btnExit.TabIndex = 4;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(0, 168, 255);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(45, 425);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(360, 62);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "ĐĂNG NHẬP";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // panelPass
            // 
            panelPass.BackColor = Color.WhiteSmoke;
            panelPass.Controls.Add(txtPass);
            panelPass.Controls.Add(picPass);
            panelPass.Location = new Point(45, 288);
            panelPass.Margin = new Padding(3, 4, 3, 4);
            panelPass.Name = "panelPass";
            panelPass.Size = new Size(360, 69);
            panelPass.TabIndex = 2;
            // 
            // txtPass
            // 
            txtPass.BackColor = Color.WhiteSmoke;
            txtPass.BorderStyle = BorderStyle.None;
            txtPass.Font = new Font("Segoe UI", 12F);
            txtPass.ForeColor = Color.FromArgb(64, 64, 64);
            txtPass.Location = new Point(55, 19);
            txtPass.Margin = new Padding(3, 4, 3, 4);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(290, 27);
            txtPass.TabIndex = 1;
            txtPass.UseSystemPasswordChar = true;
            // 
            // picPass
            // 
            picPass.Image = Properties.Resources.locked_padlock_insurance_icon_on_transparent_background_free_png_removebg_preview;
            picPass.Location = new Point(10, 12);
            picPass.Margin = new Padding(3, 4, 3, 4);
            picPass.Name = "picPass";
            picPass.Size = new Size(35, 44);
            picPass.SizeMode = PictureBoxSizeMode.Zoom;
            picPass.TabIndex = 0;
            picPass.TabStop = false;
            // 
            // panelUser
            // 
            panelUser.BackColor = Color.WhiteSmoke;
            panelUser.Controls.Add(txtUser);
            panelUser.Controls.Add(picUser);
            panelUser.Location = new Point(45, 188);
            panelUser.Margin = new Padding(3, 4, 3, 4);
            panelUser.Name = "panelUser";
            panelUser.Size = new Size(360, 69);
            panelUser.TabIndex = 1;
            // 
            // txtUser
            // 
            txtUser.BackColor = Color.WhiteSmoke;
            txtUser.BorderStyle = BorderStyle.None;
            txtUser.Font = new Font("Segoe UI", 12F);
            txtUser.ForeColor = Color.FromArgb(64, 64, 64);
            txtUser.Location = new Point(55, 19);
            txtUser.Margin = new Padding(3, 4, 3, 4);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(290, 27);
            txtUser.TabIndex = 1;
            txtUser.Text = "admin";
            // 
            // picUser
            // 
            picUser.Image = Properties.Resources.hd_man_user_illustration_icon_transparent_png_701751694974843ybexneueic_removebg_preview;
            picUser.Location = new Point(10, 12);
            picUser.Margin = new Padding(3, 4, 3, 4);
            picUser.Name = "picUser";
            picUser.Size = new Size(35, 44);
            picUser.SizeMode = PictureBoxSizeMode.Zoom;
            picUser.TabIndex = 0;
            picUser.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(0, 168, 255);
            lblTitle.Location = new Point(40, 100);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(227, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ĐĂNG NHẬP";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 625);
            ControlBox = false;
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            panelRight.ResumeLayout(false);
            panelRight.PerformLayout();
            panelPass.ResumeLayout(false);
            panelPass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picPass).EndInit();
            panelUser.ResumeLayout(false);
            panelUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picUser).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblSlogan;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.Panel panelPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.PictureBox picPass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckBox chkShowPass;
    }
}