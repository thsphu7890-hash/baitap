namespace Baitap
{
    partial class Ex22
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
            this.components = new System.ComponentModel.Container();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
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

            // Khai báo các cột để cấu hình Binding
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGender = new System.Windows.Forms.DataGridViewCheckBoxColumn();

            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();

            // 
            // dgvEmployee (Bảng lưới)
            // 
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colName,
            this.colAge,
            this.colGender});
            this.dgvEmployee.Location = new System.Drawing.Point(12, 12);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployee.Size = new System.Drawing.Size(560, 200);
            this.dgvEmployee.TabIndex = 0;
            // QUAN TRỌNG: Tắt tự động sinh cột để dùng cột do mình định nghĩa
            this.dgvEmployee.AutoGenerateColumns = false;
            // KẾT NỐI SỰ KIỆN (Slide 150)
            this.dgvEmployee.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_RowEnter);

            // --- CẤU HÌNH CỘT VÀ BINDING (DataPropertyName) ---
            // Phần này cực kỳ quan trọng ở Bài 22

            // Cột Mã
            this.colId.HeaderText = "Mã nhân viên";
            this.colId.DataPropertyName = "Id"; // Phải trùng tên biến trong Class Employee

            // Cột Tên
            this.colName.HeaderText = "Tên nhân viên";
            this.colName.DataPropertyName = "Name"; // Phải trùng tên biến trong Class Employee
            this.colName.Width = 200;

            // Cột Tuổi
            this.colAge.HeaderText = "Tuổi";
            this.colAge.DataPropertyName = "Age"; // Phải trùng tên biến trong Class Employee

            // Cột Giới tính
            this.colGender.HeaderText = "Giới tính (Nam)";
            this.colGender.DataPropertyName = "Gender"; // Phải trùng tên biến trong Class Employee

            // --- Các Control nhập liệu (Đã đổi tên biến cho chuẩn) ---
            // Mã
            this.label1.AutoSize = true; this.label1.Location = new System.Drawing.Point(30, 230); this.label1.Text = "Mã:";
            this.tbId.Location = new System.Drawing.Point(80, 227); this.tbId.Name = "tbId"; this.tbId.Size = new System.Drawing.Size(150, 27); this.tbId.TabIndex = 1;

            // Tên
            this.label2.AutoSize = true; this.label2.Location = new System.Drawing.Point(30, 270); this.label2.Text = "Tên:";
            this.tbName.Location = new System.Drawing.Point(80, 267); this.tbName.Name = "tbName"; this.tbName.Size = new System.Drawing.Size(250, 27); this.tbName.TabIndex = 2;

            // Tuổi
            this.label3.AutoSize = true; this.label3.Location = new System.Drawing.Point(30, 310); this.label3.Text = "Tuổi:";
            this.tbAge.Location = new System.Drawing.Point(80, 307); this.tbAge.Name = "tbAge"; this.tbAge.Size = new System.Drawing.Size(100, 27); this.tbAge.TabIndex = 3;

            // Checkbox Nam
            this.ckGender.AutoSize = true; this.ckGender.Location = new System.Drawing.Point(80, 350); this.ckGender.Name = "ckGender"; this.ckGender.Text = "Nam"; this.ckGender.TabIndex = 4;

            // --- Các Nút bấm (Đã đổi tên và gắn sự kiện) ---
            // Nút Thêm
            this.btAddNew.Location = new System.Drawing.Point(250, 380);
            this.btAddNew.Name = "btAddNew";
            this.btAddNew.Size = new System.Drawing.Size(100, 35);
            this.btAddNew.Text = "Thêm";
            this.btAddNew.Click += new System.EventHandler(this.btAddNew_Click); // Gắn sự kiện Click

            // Nút Xóa
            this.btDelete.Location = new System.Drawing.Point(360, 380);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(100, 35);
            this.btDelete.Text = "Xóa";
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click); // Gắn sự kiện Click

            // Nút Thoát
            this.btExit.Location = new System.Drawing.Point(470, 380);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(100, 35);
            this.btExit.Text = "Thoát";
            this.btExit.Click += new System.EventHandler(this.btExit_Click); // Gắn sự kiện Click

            // Form Ex22
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.btExit); this.Controls.Add(this.btDelete); this.Controls.Add(this.btAddNew);
            this.Controls.Add(this.ckGender); this.Controls.Add(this.tbAge); this.Controls.Add(this.label3);
            this.Controls.Add(this.tbName); this.Controls.Add(this.label2); this.Controls.Add(this.tbId); this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEmployee);
            this.Name = "Ex22";
            this.Text = "Ex22 - BindingSource";
            this.Load += new System.EventHandler(this.Ex22_Load); // QUAN TRỌNG: Sự kiện Load Form
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        // Khai báo biến với tên chuẩn để code logic hoạt động
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.Label label1, label2, label3;
        private System.Windows.Forms.TextBox tbId, tbName, tbAge;
        private System.Windows.Forms.CheckBox ckGender;
        private System.Windows.Forms.Button btAddNew, btDelete, btExit;
        // Các cột của DataGridView
        private System.Windows.Forms.DataGridViewTextBoxColumn colId, colName, colAge;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colGender;
    }
}