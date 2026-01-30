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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panelSidebar = new Panel();
            btnSettings = new Button();
            btnLeave = new Button();
            btnSalary = new Button();
            btnAnalytics = new Button();
            btnDepartment = new Button();
            btnPosition = new Button();
            btnEmployee = new Button();
            btnDashboard = new Button();
            pnlNavIndicator = new Panel();
            panelLogo = new Panel();
            lblLogo = new Label();
            picLogo = new PictureBox();
            panelHeader = new Panel();
            panelSearchContainer = new Panel();
            txtSearch = new TextBox();
            lblDateTime = new Label();
            picUser = new PictureBox();
            lblUserName = new Label();
            lblTitle = new Label();
            panelMain = new Panel();
            tblLayoutBody = new TableLayoutPanel();
            panelChartContainer = new Panel();
            chartSalary = new System.Windows.Forms.DataVisualization.Charting.Chart();
            lblChartTitle = new Label();
            panelGridContainer = new Panel();
            dgvRecent = new DataGridView();
            lblGridTitle = new Label();
            tblLayoutCards = new TableLayoutPanel();
            card1 = new Panel();
            lblCard1Num = new Label();
            lblCard1Title = new Label();
            picCard1 = new PictureBox();
            card2 = new Panel();
            lblCard2Num = new Label();
            lblCard2Title = new Label();
            picCard2 = new PictureBox();
            card3 = new Panel();
            lblCard3Num = new Label();
            lblCard3Title = new Label();
            picCard3 = new PictureBox();
            panelSidebar.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            panelHeader.SuspendLayout();
            panelSearchContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUser).BeginInit();
            panelMain.SuspendLayout();
            tblLayoutBody.SuspendLayout();
            panelChartContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartSalary).BeginInit();
            panelGridContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecent).BeginInit();
            tblLayoutCards.SuspendLayout();
            card1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCard1).BeginInit();
            card2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCard2).BeginInit();
            card3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCard3).BeginInit();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(64, 64, 64);
            panelSidebar.Controls.Add(btnSettings);
            panelSidebar.Controls.Add(btnLeave);
            panelSidebar.Controls.Add(btnSalary);
            panelSidebar.Controls.Add(btnAnalytics);
            panelSidebar.Controls.Add(btnDepartment);
            panelSidebar.Controls.Add(btnPosition);
            panelSidebar.Controls.Add(btnEmployee);
            panelSidebar.Controls.Add(btnDashboard);
            panelSidebar.Controls.Add(pnlNavIndicator);
            panelSidebar.Controls.Add(panelLogo);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(220, 661);
            panelSidebar.TabIndex = 0;
            // 
            // btnSettings
            // 
            btnSettings.Dock = DockStyle.Top;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSettings.ForeColor = Color.Gainsboro;
            btnSettings.Location = new Point(0, 520);
            btnSettings.Name = "btnSettings";
            btnSettings.Padding = new Padding(20, 0, 0, 0);
            btnSettings.Size = new Size(220, 60);
            btnSettings.TabIndex = 8;
            btnSettings.Text = "Cài Đặt";
            btnSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnSettings.UseVisualStyleBackColor = true;
            // 
            // btnLeave
            // 
            btnLeave.Dock = DockStyle.Top;
            btnLeave.FlatAppearance.BorderSize = 0;
            btnLeave.FlatStyle = FlatStyle.Flat;
            btnLeave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLeave.ForeColor = Color.Gainsboro;
            btnLeave.Location = new Point(0, 460);
            btnLeave.Name = "btnLeave";
            btnLeave.Padding = new Padding(20, 0, 0, 0);
            btnLeave.Size = new Size(220, 60);
            btnLeave.TabIndex = 7;
            btnLeave.Text = "Nghỉ Phép";
            btnLeave.TextAlign = ContentAlignment.MiddleLeft;
            btnLeave.UseVisualStyleBackColor = true;
            btnLeave.Click += btnLeave_Click;
            // 
            // btnSalary
            // 
            btnSalary.Dock = DockStyle.Top;
            btnSalary.FlatAppearance.BorderSize = 0;
            btnSalary.FlatStyle = FlatStyle.Flat;
            btnSalary.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSalary.ForeColor = Color.Gainsboro;
            btnSalary.Location = new Point(0, 400);
            btnSalary.Name = "btnSalary";
            btnSalary.Padding = new Padding(20, 0, 0, 0);
            btnSalary.Size = new Size(220, 60);
            btnSalary.TabIndex = 6;
            btnSalary.Text = "Tiền Lương";
            btnSalary.TextAlign = ContentAlignment.MiddleLeft;
            btnSalary.UseVisualStyleBackColor = true;
            // 
            // btnAnalytics
            // 
            btnAnalytics.Dock = DockStyle.Top;
            btnAnalytics.FlatAppearance.BorderSize = 0;
            btnAnalytics.FlatStyle = FlatStyle.Flat;
            btnAnalytics.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAnalytics.ForeColor = Color.Gainsboro;
            btnAnalytics.Location = new Point(0, 340);
            btnAnalytics.Name = "btnAnalytics";
            btnAnalytics.Padding = new Padding(20, 0, 0, 0);
            btnAnalytics.Size = new Size(220, 60);
            btnAnalytics.TabIndex = 5;
            btnAnalytics.Text = "Thống Kê";
            btnAnalytics.TextAlign = ContentAlignment.MiddleLeft;
            btnAnalytics.UseVisualStyleBackColor = true;
            // 
            // btnDepartment
            // 
            btnDepartment.Dock = DockStyle.Top;
            btnDepartment.FlatAppearance.BorderSize = 0;
            btnDepartment.FlatStyle = FlatStyle.Flat;
            btnDepartment.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDepartment.ForeColor = Color.Gainsboro;
            btnDepartment.Location = new Point(0, 280);
            btnDepartment.Name = "btnDepartment";
            btnDepartment.Padding = new Padding(20, 0, 0, 0);
            btnDepartment.Size = new Size(220, 60);
            btnDepartment.TabIndex = 4;
            btnDepartment.Text = "Phòng Ban";
            btnDepartment.TextAlign = ContentAlignment.MiddleLeft;
            btnDepartment.UseVisualStyleBackColor = true;
            // 
            // btnPosition
            // 
            btnPosition.Dock = DockStyle.Top;
            btnPosition.FlatAppearance.BorderSize = 0;
            btnPosition.FlatStyle = FlatStyle.Flat;
            btnPosition.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnPosition.ForeColor = Color.Gainsboro;
            btnPosition.Location = new Point(0, 220);
            btnPosition.Name = "btnPosition";
            btnPosition.Padding = new Padding(20, 0, 0, 0);
            btnPosition.Size = new Size(220, 60);
            btnPosition.TabIndex = 3;
            btnPosition.Text = "Chức Vụ";
            btnPosition.TextAlign = ContentAlignment.MiddleLeft;
            btnPosition.UseVisualStyleBackColor = true;
            // 
            // btnEmployee
            // 
            btnEmployee.Dock = DockStyle.Top;
            btnEmployee.FlatAppearance.BorderSize = 0;
            btnEmployee.FlatStyle = FlatStyle.Flat;
            btnEmployee.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEmployee.ForeColor = Color.Gainsboro;
            btnEmployee.Location = new Point(0, 160);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Padding = new Padding(20, 0, 0, 0);
            btnEmployee.Size = new Size(220, 60);
            btnEmployee.TabIndex = 2;
            btnEmployee.Text = "Nhân Viên";
            btnEmployee.TextAlign = ContentAlignment.MiddleLeft;
            btnEmployee.UseVisualStyleBackColor = true;
            btnEmployee.Click += btnEmployee_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDashboard.ForeColor = Color.Gainsboro;
            btnDashboard.Location = new Point(0, 100);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(20, 0, 0, 0);
            btnDashboard.Size = new Size(220, 60);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = true;
            // 
            // pnlNavIndicator
            // 
            pnlNavIndicator.BackColor = Color.FromArgb(0, 168, 255);
            pnlNavIndicator.Location = new Point(0, 100);
            pnlNavIndicator.Name = "pnlNavIndicator";
            pnlNavIndicator.Size = new Size(5, 60);
            pnlNavIndicator.TabIndex = 7;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(0, 168, 255);
            panelLogo.Controls.Add(lblLogo);
            panelLogo.Controls.Add(picLogo);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 100);
            panelLogo.TabIndex = 0;
            // 
            // lblLogo
            // 
            lblLogo.Dock = DockStyle.Bottom;
            lblLogo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblLogo.ForeColor = Color.White;
            lblLogo.Location = new Point(0, 70);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(220, 30);
            lblLogo.TabIndex = 1;
            lblLogo.Text = "HR MANAGER";
            lblLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picLogo
            // 
            picLogo.Image = Properties.Resources.unnamed_removebg_preview;
            picLogo.Location = new Point(29, 10);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(153, 57);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.White;
            panelHeader.Controls.Add(panelSearchContainer);
            panelHeader.Controls.Add(lblDateTime);
            panelHeader.Controls.Add(picUser);
            panelHeader.Controls.Add(lblUserName);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(220, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(962, 60);
            panelHeader.TabIndex = 1;
            // 
            // panelSearchContainer
            // 
            panelSearchContainer.BackColor = Color.WhiteSmoke;
            panelSearchContainer.Controls.Add(txtSearch);
            panelSearchContainer.Location = new Point(400, 12);
            panelSearchContainer.Name = "panelSearchContainer";
            panelSearchContainer.Padding = new Padding(10, 8, 10, 8);
            panelSearchContainer.Size = new Size(350, 35);
            panelSearchContainer.TabIndex = 5;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.WhiteSmoke;
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Dock = DockStyle.Fill;
            txtSearch.Font = new Font("Segoe UI", 11F);
            txtSearch.ForeColor = Color.Gray;
            txtSearch.Location = new Point(10, 8);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(330, 25);
            txtSearch.TabIndex = 1;
            txtSearch.Text = "Tìm kiếm...";
            // 
            // lblDateTime
            // 
            lblDateTime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDateTime.AutoSize = true;
            lblDateTime.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDateTime.ForeColor = Color.FromArgb(0, 168, 255);
            lblDateTime.Location = new Point(600, 22);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(106, 23);
            lblDateTime.TabIndex = 4;
            lblDateTime.Text = "25/01/2026";
            // 
            // picUser
            // 
            picUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picUser.BackColor = Color.LightGray;
            picUser.Image = Properties.Resources._6069202_removebg_preview;
            picUser.Location = new Point(900, 12);
            picUser.Name = "picUser";
            picUser.Size = new Size(35, 35);
            picUser.SizeMode = PictureBoxSizeMode.Zoom;
            picUser.TabIndex = 3;
            picUser.TabStop = false;
            // 
            // lblUserName
            // 
            lblUserName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUserName.Location = new Point(830, 22);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(64, 23);
            lblUserName.TabIndex = 2;
            lblUserName.Text = "Admin";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(64, 64, 64);
            lblTitle.Location = new Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(164, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "DASHBOARD";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(240, 240, 240);
            panelMain.Controls.Add(tblLayoutBody);
            panelMain.Controls.Add(tblLayoutCards);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(220, 60);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(20);
            panelMain.Size = new Size(962, 601);
            panelMain.TabIndex = 2;
            // 
            // tblLayoutBody
            // 
            tblLayoutBody.ColumnCount = 2;
            tblLayoutBody.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblLayoutBody.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblLayoutBody.Controls.Add(panelChartContainer, 0, 0);
            tblLayoutBody.Controls.Add(panelGridContainer, 1, 0);
            tblLayoutBody.Dock = DockStyle.Fill;
            tblLayoutBody.Location = new Point(20, 160);
            tblLayoutBody.Name = "tblLayoutBody";
            tblLayoutBody.Padding = new Padding(0, 20, 0, 0);
            tblLayoutBody.RowCount = 1;
            tblLayoutBody.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblLayoutBody.Size = new Size(922, 421);
            tblLayoutBody.TabIndex = 1;
            // 
            // panelChartContainer
            // 
            panelChartContainer.BackColor = Color.White;
            panelChartContainer.Controls.Add(chartSalary);
            panelChartContainer.Controls.Add(lblChartTitle);
            panelChartContainer.Dock = DockStyle.Fill;
            panelChartContainer.Location = new Point(3, 23);
            panelChartContainer.Margin = new Padding(3, 3, 20, 3);
            panelChartContainer.Name = "panelChartContainer";
            panelChartContainer.Padding = new Padding(10);
            panelChartContainer.Size = new Size(438, 395);
            panelChartContainer.TabIndex = 0;
            // 
            // chartSalary
            // 
            chartArea1.Name = "ChartArea1";
            chartSalary.ChartAreas.Add(chartArea1);
            chartSalary.Dock = DockStyle.Fill;
            chartSalary.Location = new Point(10, 40);
            chartSalary.Name = "chartSalary";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Salary";
            chartSalary.Series.Add(series1);
            chartSalary.Size = new Size(418, 345);
            chartSalary.TabIndex = 1;
            chartSalary.Text = "chart1";
            // 
            // lblChartTitle
            // 
            lblChartTitle.Dock = DockStyle.Top;
            lblChartTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblChartTitle.ForeColor = Color.Gray;
            lblChartTitle.Location = new Point(10, 10);
            lblChartTitle.Name = "lblChartTitle";
            lblChartTitle.Size = new Size(418, 30);
            lblChartTitle.TabIndex = 0;
            lblChartTitle.Text = "Biểu Đồ Lương";
            // 
            // panelGridContainer
            // 
            panelGridContainer.BackColor = Color.White;
            panelGridContainer.Controls.Add(dgvRecent);
            panelGridContainer.Controls.Add(lblGridTitle);
            panelGridContainer.Dock = DockStyle.Fill;
            panelGridContainer.Location = new Point(464, 23);
            panelGridContainer.Name = "panelGridContainer";
            panelGridContainer.Padding = new Padding(10);
            panelGridContainer.Size = new Size(455, 395);
            panelGridContainer.TabIndex = 1;
            // 
            // dgvRecent
            // 
            dgvRecent.BackgroundColor = Color.White;
            dgvRecent.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 168, 255);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRecent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRecent.ColumnHeadersHeight = 40;
            dgvRecent.Dock = DockStyle.Fill;
            dgvRecent.EnableHeadersVisualStyles = false;
            dgvRecent.Location = new Point(10, 40);
            dgvRecent.Name = "dgvRecent";
            dgvRecent.RowHeadersVisible = false;
            dgvRecent.RowHeadersWidth = 51;
            dgvRecent.Size = new Size(435, 345);
            dgvRecent.TabIndex = 1;
            // 
            // lblGridTitle
            // 
            lblGridTitle.Dock = DockStyle.Top;
            lblGridTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblGridTitle.ForeColor = Color.Gray;
            lblGridTitle.Location = new Point(10, 10);
            lblGridTitle.Name = "lblGridTitle";
            lblGridTitle.Size = new Size(435, 30);
            lblGridTitle.TabIndex = 0;
            lblGridTitle.Text = "Nhân Sự Gần Đây";
            // 
            // tblLayoutCards
            // 
            tblLayoutCards.ColumnCount = 3;
            tblLayoutCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tblLayoutCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tblLayoutCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tblLayoutCards.Controls.Add(card1, 0, 0);
            tblLayoutCards.Controls.Add(card2, 1, 0);
            tblLayoutCards.Controls.Add(card3, 2, 0);
            tblLayoutCards.Dock = DockStyle.Top;
            tblLayoutCards.Location = new Point(20, 20);
            tblLayoutCards.Name = "tblLayoutCards";
            tblLayoutCards.RowCount = 1;
            tblLayoutCards.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblLayoutCards.Size = new Size(922, 140);
            tblLayoutCards.TabIndex = 0;
            // 
            // card1
            // 
            card1.BackColor = Color.White;
            card1.Controls.Add(lblCard1Num);
            card1.Controls.Add(lblCard1Title);
            card1.Controls.Add(picCard1);
            card1.Dock = DockStyle.Fill;
            card1.Location = new Point(3, 3);
            card1.Margin = new Padding(3, 3, 20, 3);
            card1.Name = "card1";
            card1.Size = new Size(284, 134);
            card1.TabIndex = 0;
            // 
            // lblCard1Num
            // 
            lblCard1Num.AutoSize = true;
            lblCard1Num.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblCard1Num.ForeColor = Color.FromArgb(0, 168, 255);
            lblCard1Num.Location = new Point(10, 45);
            lblCard1Num.Name = "lblCard1Num";
            lblCard1Num.Size = new Size(92, 54);
            lblCard1Num.TabIndex = 1;
            lblCard1Num.Text = "154";
            // 
            // lblCard1Title
            // 
            lblCard1Title.AutoSize = true;
            lblCard1Title.Font = new Font("Segoe UI", 10F);
            lblCard1Title.ForeColor = Color.Gray;
            lblCard1Title.Location = new Point(15, 15);
            lblCard1Title.Name = "lblCard1Title";
            lblCard1Title.Size = new Size(102, 23);
            lblCard1Title.TabIndex = 0;
            lblCard1Title.Text = "NHÂN VIÊN";
            // 
            // picCard1
            // 
            picCard1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picCard1.Image = Properties.Resources.hd_man_user_illustration_icon_transparent_png_701751694974843ybexneueic_removebg_preview;
            picCard1.Location = new Point(220, 15);
            picCard1.Name = "picCard1";
            picCard1.Size = new Size(50, 50);
            picCard1.SizeMode = PictureBoxSizeMode.Zoom;
            picCard1.TabIndex = 2;
            picCard1.TabStop = false;
            // 
            // card2
            // 
            card2.BackColor = Color.White;
            card2.Controls.Add(lblCard2Num);
            card2.Controls.Add(lblCard2Title);
            card2.Controls.Add(picCard2);
            card2.Dock = DockStyle.Fill;
            card2.Location = new Point(310, 3);
            card2.Margin = new Padding(3, 3, 20, 3);
            card2.Name = "card2";
            card2.Size = new Size(284, 134);
            card2.TabIndex = 1;
            // 
            // lblCard2Num
            // 
            lblCard2Num.AutoSize = true;
            lblCard2Num.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblCard2Num.ForeColor = Color.SeaGreen;
            lblCard2Num.Location = new Point(10, 45);
            lblCard2Num.Name = "lblCard2Num";
            lblCard2Num.Size = new Size(69, 54);
            lblCard2Num.TabIndex = 1;
            lblCard2Num.Text = "12";
            // 
            // lblCard2Title
            // 
            lblCard2Title.AutoSize = true;
            lblCard2Title.Font = new Font("Segoe UI", 10F);
            lblCard2Title.ForeColor = Color.Gray;
            lblCard2Title.Location = new Point(15, 15);
            lblCard2Title.Name = "lblCard2Title";
            lblCard2Title.Size = new Size(93, 23);
            lblCard2Title.TabIndex = 0;
            lblCard2Title.Text = "MỚI THÊM";
            // 
            // picCard2
            // 
            picCard2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picCard2.Image = Properties.Resources.images__2__removebg_preview;
            picCard2.Location = new Point(220, 15);
            picCard2.Name = "picCard2";
            picCard2.Size = new Size(50, 50);
            picCard2.SizeMode = PictureBoxSizeMode.Zoom;
            picCard2.TabIndex = 2;
            picCard2.TabStop = false;
            // 
            // card3
            // 
            card3.BackColor = Color.White;
            card3.Controls.Add(lblCard3Num);
            card3.Controls.Add(lblCard3Title);
            card3.Controls.Add(picCard3);
            card3.Dock = DockStyle.Fill;
            card3.Location = new Point(617, 3);
            card3.Name = "card3";
            card3.Size = new Size(302, 134);
            card3.TabIndex = 2;
            // 
            // lblCard3Num
            // 
            lblCard3Num.AutoSize = true;
            lblCard3Num.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblCard3Num.ForeColor = Color.Crimson;
            lblCard3Num.Location = new Point(10, 45);
            lblCard3Num.Name = "lblCard3Num";
            lblCard3Num.Size = new Size(46, 54);
            lblCard3Num.TabIndex = 1;
            lblCard3Num.Text = "5";
            // 
            // lblCard3Title
            // 
            lblCard3Title.AutoSize = true;
            lblCard3Title.Font = new Font("Segoe UI", 10F);
            lblCard3Title.ForeColor = Color.Gray;
            lblCard3Title.Location = new Point(15, 15);
            lblCard3Title.Name = "lblCard3Title";
            lblCard3Title.Size = new Size(98, 23);
            lblCard3Title.TabIndex = 0;
            lblCard3Title.Text = "NGHỈ PHÉP";
            // 
            // picCard3
            // 
            picCard3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picCard3.Image = Properties.Resources.images__3__removebg_preview;
            picCard3.Location = new Point(160, 17);
            picCard3.Name = "picCard3";
            picCard3.Size = new Size(132, 84);
            picCard3.SizeMode = PictureBoxSizeMode.Zoom;
            picCard3.TabIndex = 2;
            picCard3.TabStop = false;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 661);
            Controls.Add(panelMain);
            Controls.Add(panelHeader);
            Controls.Add(panelSidebar);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HRM Dashboard";
            WindowState = FormWindowState.Maximized;
            panelSidebar.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelSearchContainer.ResumeLayout(false);
            panelSearchContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picUser).EndInit();
            panelMain.ResumeLayout(false);
            tblLayoutBody.ResumeLayout(false);
            panelChartContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartSalary).EndInit();
            panelGridContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRecent).EndInit();
            tblLayoutCards.ResumeLayout(false);
            card1.ResumeLayout(false);
            card1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picCard1).EndInit();
            card2.ResumeLayout(false);
            card2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picCard2).EndInit();
            card3.ResumeLayout(false);
            card3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picCard3).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pnlNavIndicator;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnAnalytics;
        private System.Windows.Forms.Button btnSalary;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panelSearchContainer;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TableLayoutPanel tblLayoutCards;
        private System.Windows.Forms.Panel card1;
        private System.Windows.Forms.Label lblCard1Title;
        private System.Windows.Forms.Label lblCard1Num;
        private System.Windows.Forms.PictureBox picCard1;
        private System.Windows.Forms.Panel card2;
        private System.Windows.Forms.Label lblCard2Title;
        private System.Windows.Forms.Label lblCard2Num;
        private System.Windows.Forms.PictureBox picCard2;
        private System.Windows.Forms.Panel card3;
        private System.Windows.Forms.Label lblCard3Title;
        private System.Windows.Forms.Label lblCard3Num;
        private System.Windows.Forms.PictureBox picCard3;
        private System.Windows.Forms.TableLayoutPanel tblLayoutBody;
        private System.Windows.Forms.Panel panelChartContainer;
        private System.Windows.Forms.Label lblChartTitle;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSalary;
        private System.Windows.Forms.Panel panelGridContainer;
        private System.Windows.Forms.Label lblGridTitle;
        private System.Windows.Forms.DataGridView dgvRecent;
        private System.Windows.Forms.Button btnLeave;
        private System.Windows.Forms.Button btnPosition;
        private System.Windows.Forms.Button btnDepartment;
    }
}