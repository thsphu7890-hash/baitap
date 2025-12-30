namespace Baitap
{
    partial class Ex21
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
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGender = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.ckGender = new System.Windows.Forms.CheckBox();
            this.btAddNew = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();

            // 
            // dgvEmployee (Bảng hiển thị)
            // 
            this.dgvEmployee.AllowUserToAddRows = false;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            // ĐỊNH NGHĨA 4 CỘT
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colName,
            this.colAge,
            this.colGender});
            this.dgvEmployee.Location = new System.Drawing.Point(12, 12);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.RowHeadersWidth = 51;
            this.dgvEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployee.Size = new System.Drawing.Size(560, 200);
            this.dgvEmployee.TabIndex = 0;
            // KẾT NỐI SỰ KIỆN CHỌN DÒNG (Slide 144)
            this.dgvEmployee.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_RowEnter);

            // Cột 1: Mã
            this.colId.HeaderText = "Mã nhân viên";
            this.colId.Name = "colId";

            // Cột 2: Tên
            this.colName.HeaderText = "Tên nhân viên";
            this.colName.Name = "colName";
            this.colName.Width = 200;

            // Cột 3: Tuổi
            this.colAge.HeaderText = "Tuổi";
            this.colAge.Name = "colAge";

            // Cột 4: Giới tính
            this.colGender.HeaderText = "Giới tính (Nam)";
            this.colGender.Name = "colGender";

            // --- Nhập liệu ---
            // Mã
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 230);
            this.label1.Text = "Mã:";
            this.tbId.Location = new System.Drawing.Point(80, 227);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(150, 27);
            this.tbId.TabIndex = 1;

            // Tên
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 270);
            this.label2.Text = "Tên:";
            this.tbName.Location = new System.Drawing.Point(80, 267);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(250, 27);
            this.tbName.TabIndex = 2;

            // Tuổi
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 310);
            this.label3.Text = "Tuổi:";
            this.tbAge.Location = new System.Drawing.Point(80, 307);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(100, 27);
            this.tbAge.TabIndex = 3;

            // CheckBox Nam
            this.ckGender.AutoSize = true;
            this.ckGender.Location = new System.Drawing.Point(80, 350);
            this.ckGender.Name = "ckGender";
            this.ckGender.Text = "Nam";
            this.ckGender.TabIndex = 4;
            this.ckGender.UseVisualStyleBackColor = true;

            // --- Nút bấm ---
            // Nút Thêm
            this.btAddNew.Location = new System.Drawing.Point(250, 380);
            this.btAddNew.Name = "btAddNew";
            this.btAddNew.Size = new System.Drawing.Size(100, 35);
            this.btAddNew.Text = "Thêm";
            this.btAddNew.UseVisualStyleBackColor = true;
            this.btAddNew.Click += new System.EventHandler(this.btAddNew_Click); // KẾT NỐI CLICK

            // Nút Xóa
            this.btDelete.Location = new System.Drawing.Point(360, 380);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(100, 35);
            this.btDelete.Text = "Xóa";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click); // KẾT NỐI CLICK

            // Nút Thoát
            this.btExit.Location = new System.Drawing.Point(470, 380);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(100, 35);
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click); // KẾT NỐI CLICK

            // Ex21
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btAddNew);
            this.Controls.Add(this.ckGender);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEmployee);
            this.Name = "Ex21";
            this.Text = "Quản lý nhân viên (List)";
            this.Load += new System.EventHandler(this.Ex21_Load); // KẾT NỐI LOAD FORM
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        // Khai báo biến chuẩn để khớp với code Logic
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAge;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colGender;
        private System.Windows.Forms.Label label1, label2, label3;
        private System.Windows.Forms.TextBox tbId, tbName, tbAge;
        private System.Windows.Forms.CheckBox ckGender;
        private System.Windows.Forms.Button btAddNew, btDelete, btExit;
    }
}