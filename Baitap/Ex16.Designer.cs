namespace Baitap
{
    partial class Ex16
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.dtpDob = new System.Windows.Forms.DateTimePicker();
            this.cbFaculty = new System.Windows.Forms.ComboBox();
            this.lbInfo = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.btAdd = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();

            // 
            // label1 (Họ tên)
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Text = "Họ và tên:";

            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(130, 27);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(250, 27);
            this.tbName.TabIndex = 0;

            // 
            // label2 (Ngày sinh)
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 70);
            this.label2.Text = "Ngày Sinh:";

            // 
            // dtpDob
            // 
            this.dtpDob.Format = System.Windows.Forms.DateTimePickerFormat.Short; // SỬA: Hiển thị ngày ngắn
            this.dtpDob.Location = new System.Drawing.Point(130, 67);
            this.dtpDob.Name = "dtpDob";
            this.dtpDob.Size = new System.Drawing.Size(250, 27);
            this.dtpDob.TabIndex = 1;

            // 
            // groupBox1 (Giới tính - Đã sửa lỗi chứa RadioButton)
            // 
            this.groupBox1.Controls.Add(this.rbFemale);
            this.groupBox1.Controls.Add(this.rbMale);
            this.groupBox1.Location = new System.Drawing.Point(130, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 70);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giới tính";

            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Location = new System.Drawing.Point(30, 30);
            this.rbMale.Name = "rbMale";
            this.rbMale.Text = "Nam";
            this.rbMale.TabIndex = 0;
            this.rbMale.UseVisualStyleBackColor = true;

            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(130, 30);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Text = "Nữ";
            this.rbFemale.TabIndex = 1;
            this.rbFemale.UseVisualStyleBackColor = true;

            // 
            // label3 (Khoa)
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 190);
            this.label3.Text = "Khoa:";

            // 
            // cbFaculty
            // 
            this.cbFaculty.FormattingEnabled = true;
            this.cbFaculty.Location = new System.Drawing.Point(130, 187);
            this.cbFaculty.Name = "cbFaculty";
            this.cbFaculty.Size = new System.Drawing.Size(250, 28);
            this.cbFaculty.TabIndex = 3;

            // 
            // label4 (Trạng thái)
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 230);
            this.label4.Text = "Trạng thái:";

            // 
            // lbInfo (ListBox hiển thị)
            // 
            this.lbInfo.FormattingEnabled = true;
            this.lbInfo.ItemHeight = 20;
            this.lbInfo.Location = new System.Drawing.Point(130, 230);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(250, 144);
            this.lbInfo.TabIndex = 4;

            // 
            // btAdd (Nút Thêm)
            // 
            this.btAdd.Location = new System.Drawing.Point(130, 400);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(100, 35);
            this.btAdd.TabIndex = 5;
            this.btAdd.Text = "Thêm";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click); // SỬA: Thêm sự kiện Click

            // 
            // btExit (Nút Thoát)
            // 
            this.btExit.Location = new System.Drawing.Point(280, 400);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(100, 35);
            this.btExit.TabIndex = 6;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click); // SỬA: Thêm sự kiện Click

            // 
            // Ex16
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 480);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbFaculty);
            this.Controls.Add(this.dtpDob);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ex16";
            this.Text = "Quản lý sinh viên";
            this.Load += new System.EventHandler(this.Ex16_Load); // SỬA: Thêm sự kiện Load Form
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.DateTimePicker dtpDob;
        private System.Windows.Forms.ComboBox cbFaculty;
        private System.Windows.Forms.ListBox lbInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}