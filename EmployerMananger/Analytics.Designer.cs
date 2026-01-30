namespace EmployerMananger
{
    partial class Analytics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartAreaDept = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legendDept = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series seriesDept = new System.Windows.Forms.DataVisualization.Charting.Series();

            System.Windows.Forms.DataVisualization.Charting.ChartArea chartAreaRole = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legendRole = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series seriesRole = new System.Windows.Forms.DataVisualization.Charting.Series();

            System.Windows.Forms.DataVisualization.Charting.ChartArea chartAreaSal = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legendSal = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series seriesSal = new System.Windows.Forms.DataVisualization.Charting.Series();

            System.Windows.Forms.DataGridViewCellStyle headerStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle rowStyle = new System.Windows.Forms.DataGridViewCellStyle();

            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();

            this.panelCards = new System.Windows.Forms.TableLayoutPanel();
            this.cardTotal = new System.Windows.Forms.Panel();
            this.lblTotalNum = new System.Windows.Forms.Label();
            this.lblTotalText = new System.Windows.Forms.Label();
            this.cardSalary = new System.Windows.Forms.Panel();
            this.lblSalNum = new System.Windows.Forms.Label();
            this.lblSalText = new System.Windows.Forms.Label();
            this.cardMale = new System.Windows.Forms.Panel();
            this.lblMaleNum = new System.Windows.Forms.Label();
            this.lblMaleText = new System.Windows.Forms.Label();
            this.cardFemale = new System.Windows.Forms.Panel();
            this.lblFeNum = new System.Windows.Forms.Label();
            this.lblFeText = new System.Windows.Forms.Label();

            this.panelMainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.pnlChartDept = new System.Windows.Forms.Panel();
            this.chartDept = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblChartDeptTitle = new System.Windows.Forms.Label();
            this.pnlChartRole = new System.Windows.Forms.Panel();
            this.chartRole = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblChartRoleTitle = new System.Windows.Forms.Label();
            this.pnlChartSalary = new System.Windows.Forms.Panel();
            this.chartSalaryDept = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblChartSalaryTitle = new System.Windows.Forms.Label();
            this.pnlTop5 = new System.Windows.Forms.Panel();
            this.dgvTopSalary = new System.Windows.Forms.DataGridView();
            this.lblTop5Title = new System.Windows.Forms.Label();

            this.panelHeader.SuspendLayout();
            this.panelCards.SuspendLayout();
            this.cardTotal.SuspendLayout();
            this.cardSalary.SuspendLayout();
            this.cardMale.SuspendLayout();
            this.cardFemale.SuspendLayout();
            this.panelMainLayout.SuspendLayout();
            this.pnlChartDept.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDept)).BeginInit();
            this.pnlChartRole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRole)).BeginInit();
            this.pnlChartSalary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSalaryDept)).BeginInit();
            this.pnlTop5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopSalary)).BeginInit();
            this.SuspendLayout();

            // --- BỘ MÀU MATERIAL DESIGN ---
            System.Drawing.Color bgColor = System.Drawing.Color.FromArgb(237, 241, 245);
            System.Drawing.Color cardColor = System.Drawing.Color.White;
            System.Drawing.Color textColor = System.Drawing.Color.FromArgb(44, 62, 80);

            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = cardColor;
            this.panelHeader.Controls.Add(this.btnExport);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1000, 70);
            this.panelHeader.TabIndex = 0;

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = textColor;
            this.lblTitle.Location = new System.Drawing.Point(25, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(250, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "BÁO CÁO THỐNG KÊ";

            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(820, 18);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(150, 38);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "Xuất Báo Cáo";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;

            // 
            // panelCards
            // 
            this.panelCards.BackColor = bgColor;
            this.panelCards.ColumnCount = 4;
            this.panelCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelCards.Controls.Add(this.cardTotal, 0, 0);
            this.panelCards.Controls.Add(this.cardSalary, 1, 0);
            this.panelCards.Controls.Add(this.cardMale, 2, 0);
            this.panelCards.Controls.Add(this.cardFemale, 3, 0);
            this.panelCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCards.Location = new System.Drawing.Point(0, 70);
            this.panelCards.Name = "panelCards";
            this.panelCards.Padding = new System.Windows.Forms.Padding(15);
            this.panelCards.RowCount = 1;
            this.panelCards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelCards.Size = new System.Drawing.Size(1000, 160);
            this.panelCards.TabIndex = 1;

            // Setup Helper - Card Trắng trên nền Xám (Hiệu ứng Nổi)
            SetupCard(cardTotal, lblTotalNum, lblTotalText, "TỔNG NHÂN SỰ", "0", System.Drawing.Color.FromArgb(41, 128, 185));
            SetupCard(cardSalary, lblSalNum, lblSalText, "TỔNG QUỸ LƯƠNG", "0", System.Drawing.Color.FromArgb(192, 57, 43));
            SetupCard(cardMale, lblMaleNum, lblMaleText, "NAM", "0", System.Drawing.Color.FromArgb(39, 174, 96));
            SetupCard(cardFemale, lblFeNum, lblFeText, "NỮ", "0", System.Drawing.Color.FromArgb(142, 68, 173));

            // 
            // panelMainLayout
            // 
            this.panelMainLayout.BackColor = bgColor;
            this.panelMainLayout.ColumnCount = 2;
            this.panelMainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelMainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelMainLayout.Controls.Add(this.pnlChartDept, 0, 0);
            this.panelMainLayout.Controls.Add(this.pnlChartRole, 1, 0);
            this.panelMainLayout.Controls.Add(this.pnlChartSalary, 0, 1);
            this.panelMainLayout.Controls.Add(this.pnlTop5, 1, 1);
            this.panelMainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainLayout.Location = new System.Drawing.Point(0, 230);
            this.panelMainLayout.Name = "panelMainLayout";
            this.panelMainLayout.Padding = new System.Windows.Forms.Padding(10);
            this.panelMainLayout.RowCount = 2;
            this.panelMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelMainLayout.Size = new System.Drawing.Size(1000, 370);
            this.panelMainLayout.TabIndex = 2;

            // =========================================================
            // 1. BIỂU ĐỒ TRÒN (ĐÃ CHỈNH SỬA: ĐẨY XUỐNG DƯỚI)
            // =========================================================
            SetupPanelChart(pnlChartDept, chartDept, lblChartDeptTitle, "Tỷ Lệ Nhân Sự Theo Phòng Ban");

            // Cấu hình Chart Area
            chartAreaDept.Name = "ChartArea1";
            chartAreaDept.BackColor = System.Drawing.Color.White;

            // [QUAN TRỌNG]: Tắt Auto để chỉnh tọa độ thủ công
            chartAreaDept.Position.Auto = false;
            // (X=0%, Y=15% -> Đẩy xuống, Width=65% -> Dành chỗ cho Legend, Height=80%)
            chartAreaDept.Position = new System.Windows.Forms.DataVisualization.Charting.ElementPosition(0, 15, 65, 80);

            this.chartDept.ChartAreas.Add(chartAreaDept);

            // Cấu hình Legend (Chú thích)
            legendDept.Name = "Legend1";
            legendDept.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Right; // Để bên phải
            legendDept.Alignment = System.Drawing.StringAlignment.Center;
            legendDept.Font = new System.Drawing.Font("Segoe UI", 9F);
            legendDept.IsTextAutoFit = true;
            this.chartDept.Legends.Add(legendDept);

            // Cấu hình Series
            seriesDept.ChartArea = "ChartArea1";
            seriesDept.Legend = "Legend1";
            seriesDept.Name = "NhanSu";
            seriesDept.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;

            // Style
            seriesDept["PieLabelStyle"] = "Outside";
            seriesDept["DoughnutRadius"] = "50"; // Làm viền bánh dày hơn (nhìn đẹp hơn)
            seriesDept.BorderColor = System.Drawing.Color.White;
            seriesDept.BorderWidth = 2;

            // Hiển thị % trên biểu đồ
            seriesDept.Label = "#PERCENT{P0}";
            seriesDept.LegendText = "#VALX";
            seriesDept.LabelForeColor = System.Drawing.Color.Black;

            // Màu sắc
            this.chartDept.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;

            this.chartDept.Series.Add(seriesDept);

            // =========================================================
            // 2. BIỂU ĐỒ ĐƯỜNG
            // =========================================================
            SetupPanelChart(pnlChartRole, chartRole, lblChartRoleTitle, "Thống Kê Theo Chức Vụ");
            chartAreaRole.Name = "ChartArea1";
            chartAreaRole.BackColor = System.Drawing.Color.White;
            chartAreaRole.AxisX.MajorGrid.Enabled = false;
            chartAreaRole.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartAreaRole.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;

            this.chartRole.ChartAreas.Add(chartAreaRole);

            legendRole.Name = "Legend1";
            legendRole.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legendRole.Alignment = System.Drawing.StringAlignment.Center;
            this.chartRole.Legends.Add(legendRole);

            seriesRole.ChartArea = "ChartArea1";
            seriesRole.Legend = "Legend1";
            seriesRole.Name = "SoLuong";
            seriesRole.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            seriesRole.BorderWidth = 3;
            this.chartRole.Series.Add(seriesRole);

            // =========================================================
            // 3. BIỂU ĐỒ LƯƠNG
            // =========================================================
            SetupPanelChart(pnlChartSalary, chartSalaryDept, lblChartSalaryTitle, "Quỹ Lương Theo Phòng Ban");
            chartAreaSal.Name = "ChartArea1";
            chartAreaSal.BackColor = System.Drawing.Color.White;
            chartAreaSal.AxisX.MajorGrid.Enabled = false;
            chartAreaSal.AxisY.MajorGrid.Enabled = false;
            this.chartSalaryDept.ChartAreas.Add(chartAreaSal);

            legendSal.Name = "Legend1";
            legendSal.Enabled = false;
            this.chartSalaryDept.Legends.Add(legendSal);

            seriesSal.ChartArea = "ChartArea1";
            seriesSal.Legend = "Legend1";
            seriesSal.Name = "Luong";
            seriesSal.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            this.chartSalaryDept.Series.Add(seriesSal);

            // =========================================================
            // 4. BẢNG TOP 5
            // =========================================================
            this.pnlTop5.BackColor = System.Drawing.Color.White;
            this.pnlTop5.Controls.Add(this.dgvTopSalary);
            this.pnlTop5.Controls.Add(this.lblTop5Title);
            this.pnlTop5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTop5.Location = new System.Drawing.Point(510, 195);
            this.pnlTop5.Margin = new System.Windows.Forms.Padding(10);
            this.pnlTop5.Name = "pnlTop5";
            this.pnlTop5.Padding = new System.Windows.Forms.Padding(20);
            this.pnlTop5.Size = new System.Drawing.Size(480, 165);

            this.lblTop5Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTop5Title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTop5Title.ForeColor = textColor;
            this.lblTop5Title.Location = new System.Drawing.Point(20, 20);
            this.lblTop5Title.Name = "lblTop5Title";
            this.lblTop5Title.Size = new System.Drawing.Size(440, 35);
            this.lblTop5Title.TabIndex = 0;
            this.lblTop5Title.Text = "Top 5 Lương Cao Nhất";
            this.lblTop5Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.dgvTopSalary.AllowUserToAddRows = false;
            this.dgvTopSalary.AllowUserToDeleteRows = false;
            this.dgvTopSalary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTopSalary.BackgroundColor = System.Drawing.Color.White;
            this.dgvTopSalary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTopSalary.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTopSalary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTopSalary.Location = new System.Drawing.Point(20, 55);
            this.dgvTopSalary.Name = "dgvTopSalary";
            this.dgvTopSalary.ReadOnly = true;
            this.dgvTopSalary.RowHeadersVisible = false;
            this.dgvTopSalary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTopSalary.Size = new System.Drawing.Size(440, 90);
            this.dgvTopSalary.TabIndex = 1;

            headerStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            headerStyle.BackColor = System.Drawing.Color.White;
            headerStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            headerStyle.ForeColor = System.Drawing.Color.Gray;
            headerStyle.SelectionBackColor = System.Drawing.Color.White;
            headerStyle.SelectionForeColor = System.Drawing.Color.Gray;
            headerStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTopSalary.ColumnHeadersDefaultCellStyle = headerStyle;
            this.dgvTopSalary.ColumnHeadersHeight = 40;
            this.dgvTopSalary.EnableHeadersVisualStyles = false;

            rowStyle.BackColor = System.Drawing.Color.White;
            rowStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            rowStyle.ForeColor = System.Drawing.Color.Black;
            rowStyle.SelectionBackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            rowStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvTopSalary.DefaultCellStyle = rowStyle;

            // Analytics Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = bgColor;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panelMainLayout);
            this.Controls.Add(this.panelCards);
            this.Controls.Add(this.panelHeader);
            this.Name = "Analytics";
            this.Text = "Analytics Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelCards.ResumeLayout(false);
            this.cardTotal.ResumeLayout(false);
            this.cardTotal.PerformLayout();
            this.cardSalary.ResumeLayout(false);
            this.cardSalary.PerformLayout();
            this.cardMale.ResumeLayout(false);
            this.cardMale.PerformLayout();
            this.cardFemale.ResumeLayout(false);
            this.cardFemale.PerformLayout();
            this.panelMainLayout.ResumeLayout(false);
            this.pnlChartDept.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDept)).EndInit();
            this.pnlChartRole.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartRole)).EndInit();
            this.pnlChartSalary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartSalaryDept)).EndInit();
            this.pnlTop5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopSalary)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        // CÁC HÀM HỖ TRỢ SETUP UI (Tạo khối nổi trên nền xám)
        private void SetupCard(System.Windows.Forms.Panel pnl, System.Windows.Forms.Label lblNum, System.Windows.Forms.Label lblText, string title, string num, System.Drawing.Color color)
        {
            pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            pnl.BackColor = System.Drawing.Color.White;
            pnl.Margin = new System.Windows.Forms.Padding(10);
            pnl.Name = "card_" + title;

            // Thanh màu bên trái tạo điểm nhấn
            System.Windows.Forms.Panel pnlBorder = new System.Windows.Forms.Panel();
            pnlBorder.Dock = System.Windows.Forms.DockStyle.Left;
            pnlBorder.Width = 6;
            pnlBorder.BackColor = color;
            pnl.Controls.Add(pnlBorder);

            lblText.Text = title;
            lblText.Location = new System.Drawing.Point(20, 20);
            lblText.AutoSize = true;
            lblText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblText.ForeColor = System.Drawing.Color.Gray;
            pnl.Controls.Add(lblText);

            lblNum.Text = num;
            lblNum.Location = new System.Drawing.Point(20, 50);
            lblNum.AutoSize = true;
            lblNum.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            lblNum.ForeColor = color;
            pnl.Controls.Add(lblNum);
        }

        private void SetupPanelChart(System.Windows.Forms.Panel pnl, System.Windows.Forms.DataVisualization.Charting.Chart chart, System.Windows.Forms.Label lbl, string title)
        {
            pnl.BackColor = System.Drawing.Color.White;
            pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            pnl.Margin = new System.Windows.Forms.Padding(10);
            pnl.Padding = new System.Windows.Forms.Padding(15);
            pnl.Name = "pnl_" + chart.Name;

            lbl.Text = title;
            lbl.Dock = System.Windows.Forms.DockStyle.Top;
            lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lbl.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lbl.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            lbl.Height = 40;
            pnl.Controls.Add(lbl);

            chart.Dock = System.Windows.Forms.DockStyle.Fill;
            pnl.Controls.Add(chart);
        }

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.TableLayoutPanel panelCards;
        private System.Windows.Forms.Panel cardTotal, cardSalary, cardMale, cardFemale;
        private System.Windows.Forms.Label lblTotalNum, lblTotalText, lblSalNum, lblSalText, lblMaleNum, lblMaleText, lblFeNum, lblFeText;
        private System.Windows.Forms.TableLayoutPanel panelMainLayout;
        private System.Windows.Forms.Panel pnlChartDept;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDept;
        private System.Windows.Forms.Label lblChartDeptTitle;
        private System.Windows.Forms.Panel pnlChartRole;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRole;
        private System.Windows.Forms.Label lblChartRoleTitle;
        private System.Windows.Forms.Panel pnlChartSalary;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSalaryDept;
        private System.Windows.Forms.Label lblChartSalaryTitle;
        private System.Windows.Forms.Panel pnlTop5;
        private System.Windows.Forms.DataGridView dgvTopSalary;
        private System.Windows.Forms.Label lblTop5Title;
    }
}