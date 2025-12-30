namespace Baitap
{
    partial class Ex14
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
            this.tbResult = new System.Windows.Forms.TextBox();
            this.tbDiscount = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.ckDiscount = new System.Windows.Forms.CheckBox();
            this.btRun = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1 (Nhãn Họ tên)
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Họ tên:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(120, 63);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(300, 27);
            this.tbName.TabIndex = 0;
            // 
            // groupBox1 (Chứa Nam/Nữ)
            // 
            this.groupBox1.Controls.Add(this.rbFemale);
            this.groupBox1.Controls.Add(this.rbMale);
            this.groupBox1.Location = new System.Drawing.Point(50, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 80);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giới tính";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Location = new System.Drawing.Point(40, 30);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(62, 24);
            this.rbMale.TabIndex = 4;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Nam";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(200, 30);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(50, 24);
            this.rbFemale.TabIndex = 5;
            this.rbFemale.Text = "Nữ";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // ckDiscount
            // 
            this.ckDiscount.AutoSize = true;
            this.ckDiscount.Location = new System.Drawing.Point(50, 210);
            this.ckDiscount.Name = "ckDiscount";
            this.ckDiscount.Size = new System.Drawing.Size(91, 24);
            this.ckDiscount.TabIndex = 6;
            this.ckDiscount.Text = "Giảm giá";
            this.ckDiscount.UseVisualStyleBackColor = true;
            // SỬA: Thêm sự kiện CheckedChanged
            this.ckDiscount.CheckedChanged += new System.EventHandler(this.ckDiscount_CheckedChanged);
            // 
            // tbDiscount
            // 
            this.tbDiscount.Enabled = false;
            this.tbDiscount.Location = new System.Drawing.Point(150, 208);
            this.tbDiscount.Name = "tbDiscount";
            this.tbDiscount.Size = new System.Drawing.Size(270, 27);
            this.tbDiscount.TabIndex = 2;
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(50, 260);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(370, 100);
            this.tbResult.TabIndex = 1;
            // 
            // btRun
            // 
            this.btRun.Location = new System.Drawing.Point(150, 380);
            this.btRun.Name = "btRun";
            this.btRun.Size = new System.Drawing.Size(100, 40);
            this.btRun.TabIndex = 7;
            this.btRun.Text = "Tính tiền";
            this.btRun.UseVisualStyleBackColor = true;
            // SỬA: Thêm sự kiện Click
            this.btRun.Click += new System.EventHandler(this.btRun_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(270, 380);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(100, 40);
            this.btExit.TabIndex = 8;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            // SỬA: Thêm sự kiện Click
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // Ex14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btRun);
            this.Controls.Add(this.ckDiscount);
            this.Controls.Add(this.groupBox1); // GroupBox đã chứa RadioButton
            this.Controls.Add(this.tbDiscount);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.tbName);
            this.Name = "Ex14";
            this.Text = "Ex14 - CheckBox RadioButton";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.TextBox tbDiscount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.CheckBox ckDiscount;
        private System.Windows.Forms.Button btRun;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label label1;
    }
}