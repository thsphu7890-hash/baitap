namespace Baitap
{
    partial class Ex23
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
            this.btLeft = new System.Windows.Forms.Button();
            this.btRight = new System.Windows.Forms.Button();
            this.btFile = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // btLeft (Nút qua trái)
            // 
            this.btLeft.Location = new System.Drawing.Point(150, 300);
            this.btLeft.Name = "btLeft";
            this.btLeft.Size = new System.Drawing.Size(50, 40);
            this.btLeft.TabIndex = 0;
            this.btLeft.Text = "<";
            this.btLeft.UseVisualStyleBackColor = true;
            this.btLeft.Click += new System.EventHandler(this.btLeft_Click); // GẮN SỰ KIỆN

            // 
            // btRight (Nút qua phải)
            // 
            this.btRight.Location = new System.Drawing.Point(210, 300);
            this.btRight.Name = "btRight";
            this.btRight.Size = new System.Drawing.Size(50, 40);
            this.btRight.TabIndex = 1;
            this.btRight.Text = ">";
            this.btRight.UseVisualStyleBackColor = true;
            this.btRight.Click += new System.EventHandler(this.btRight_Click); // GẮN SỰ KIỆN

            // 
            // btFile (Nút chọn file & tạo ảnh)
            // 
            this.btFile.Location = new System.Drawing.Point(350, 300);
            this.btFile.Name = "btFile";
            this.btFile.Size = new System.Drawing.Size(100, 40);
            this.btFile.TabIndex = 2;
            this.btFile.Text = "File ...";
            this.btFile.UseVisualStyleBackColor = true;
            this.btFile.Click += new System.EventHandler(this.btFile_Click); // GẮN SỰ KIỆN

            // 
            // Ex23
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            // CHỈ CÓ 3 NÚT BẤM, KHÔNG CÓ PICTUREBOX Ở ĐÂY
            this.Controls.Add(this.btFile);
            this.Controls.Add(this.btRight);
            this.Controls.Add(this.btLeft);
            this.Name = "Ex23";
            this.Text = "Simple Game - Dynamic PictureBox";
            this.ResumeLayout(false);
        }

        #endregion

        // Khai báo biến tên chuẩn để code logic hoạt động
        private System.Windows.Forms.Button btLeft;
        private System.Windows.Forms.Button btRight;
        private System.Windows.Forms.Button btFile;
    }
}