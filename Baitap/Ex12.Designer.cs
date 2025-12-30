namespace Baitap
{
    partial class Ex12
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.cb_Faculty = new System.Windows.Forms.ComboBox();
            this.tbDisplay = new System.Windows.Forms.TextBox();
            this.btOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_Faculty
            // 
            this.cb_Faculty.FormattingEnabled = true;
            // THÊM: Danh sách các khoa theo Slide 95
            this.cb_Faculty.Items.AddRange(new object[] {
            "Công nghệ thông tin",
            "Ngoại ngữ",
            "Quản trị kinh doanh",
            "Cơ khí",
            "Điện",
            "Cơ khí động lực"});
            this.cb_Faculty.Location = new System.Drawing.Point(193, 114);
            this.cb_Faculty.Name = "cb_Faculty";
            this.cb_Faculty.Size = new System.Drawing.Size(235, 28); // Kéo dài ra chút để hiển thị đủ chữ
            this.cb_Faculty.TabIndex = 0;
            // THÊM: Gắn sự kiện thay đổi lựa chọn (Slide 96)
            this.cb_Faculty.SelectedIndexChanged += new System.EventHandler(this.cb_Faculty_SelectedIndexChanged);
            // 
            // tbDisplay
            // 
            this.tbDisplay.Location = new System.Drawing.Point(193, 181);
            this.tbDisplay.Name = "tbDisplay";
            this.tbDisplay.Size = new System.Drawing.Size(300, 27);
            this.tbDisplay.TabIndex = 1;
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(193, 250);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(100, 40);
            this.btOK.TabIndex = 2;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            // THÊM: Gắn sự kiện Click (Slide 96)
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // Ex12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.tbDisplay);
            this.Controls.Add(this.cb_Faculty);
            this.Name = "Ex12";
            this.Text = "ComboBox Example";
            // THÊM: Gắn sự kiện Load form (Slide 96)
            this.Load += new System.EventHandler(this.Ex12_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Faculty;
        private System.Windows.Forms.TextBox tbDisplay;
        private System.Windows.Forms.Button btOK;
    }
}