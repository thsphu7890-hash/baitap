namespace EmployerMananger
{
    partial class Salary
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();

            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.lblMonth = new System.Windows.Forms.Label();
            this.cboMonth = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.cboYear = new System.Windows.Forms.ComboBox();

            this.btnView = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();

            this.panelGrid = new System.Windows.Forms.Panel();
            this.dgvSalary = new System.Windows.Forms.DataGridView();

            this.panelHeader.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalary)).BeginInit();
            this.SuspendLayout();

            // 
            // 1. PANEL HEADER
            // 
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Height = 60;
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.lblTitle);

            this.lblTitle.Text = "QUẢN LÝ LƯƠNG & THƯỞNG";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(0, 168, 255);
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.AutoSize = true;

            // 
            // 2. PANEL FILTER
            // 
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilter.Height = 60;
            this.panelFilter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelFilter.Controls.Add(this.lblMonth);
            this.panelFilter.Controls.Add(this.cboMonth);
            this.panelFilter.Controls.Add(this.lblYear);
            this.panelFilter.Controls.Add(this.cboYear);
            this.panelFilter.Controls.Add(this.btnView);
            this.panelFilter.Controls.Add(this.btnSave);
            this.panelFilter.Controls.Add(this.btnPrint);

            // Month
            this.lblMonth.Text = "Tháng:";
            this.lblMonth.Location = new System.Drawing.Point(30, 20);
            this.lblMonth.AutoSize = true;

            this.cboMonth.Location = new System.Drawing.Point(90, 17);
            this.cboMonth.Size = new System.Drawing.Size(60, 28);
            this.cboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            // ĐÃ XÓA VÒNG LẶP Ở ĐÂY - Sẽ chuyển sang file Salary.cs

            // Year
            this.lblYear.Text = "Năm:";
            this.lblYear.Location = new System.Drawing.Point(180, 20);
            this.lblYear.AutoSize = true;

            this.cboYear.Location = new System.Drawing.Point(230, 17);
            this.cboYear.Size = new System.Drawing.Size(80, 28);
            this.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            // ĐÃ XÓA VÒNG LẶP Ở ĐÂY

            // Button View
            this.btnView.Text = "XEM BẢNG LƯƠNG";
            this.btnView.Location = new System.Drawing.Point(350, 12);
            this.btnView.Size = new System.Drawing.Size(160, 35);
            this.btnView.BackColor = System.Drawing.Color.Gray;
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            // Button Save
            this.btnSave.Text = "LƯU & TÍNH TOÁN";
            this.btnSave.Location = new System.Drawing.Point(520, 12);
            this.btnSave.Size = new System.Drawing.Size(160, 35);
            this.btnSave.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            // Button Print
            this.btnPrint.Text = "IN PHIẾU";
            this.btnPrint.Location = new System.Drawing.Point(700, 12);
            this.btnPrint.Size = new System.Drawing.Size(160, 35);
            this.btnPrint.BackColor = System.Drawing.Color.Orange;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            // 
            // 3. GRID
            // 
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrid.Controls.Add(this.dgvSalary);
            this.panelGrid.Padding = new System.Windows.Forms.Padding(20);

            this.dgvSalary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSalary.BackgroundColor = System.Drawing.Color.White;
            this.dgvSalary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSalary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(0, 168, 255);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvSalary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSalary.ColumnHeadersHeight = 40;
            this.dgvSalary.RowTemplate.Height = 35;
            this.dgvSalary.AllowUserToAddRows = false;

            // Form Setup
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.panelHeader);
            this.Name = "Salary";
            this.Text = "Bảng Lương";

            this.panelHeader.ResumeLayout(false); this.panelHeader.PerformLayout();
            this.panelFilter.ResumeLayout(false); this.panelFilter.PerformLayout();
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalary)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader, panelFilter, panelGrid;
        private System.Windows.Forms.Label lblTitle, lblMonth, lblYear;
        private System.Windows.Forms.ComboBox cboMonth, cboYear;
        private System.Windows.Forms.Button btnView, btnSave, btnPrint;
        private System.Windows.Forms.DataGridView dgvSalary;
    }
}