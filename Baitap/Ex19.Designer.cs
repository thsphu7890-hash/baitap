namespace Baitap
{
    partial class Ex19
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();

            // 
            // label1 (Mã nhân viên)
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Text = "Mã nhân viên";

            // 
            // tbId (Nhập Mã)
            // 
            this.tbId.Location = new System.Drawing.Point(130, 27);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(150, 27);
            this.tbId.TabIndex = 0;
            this.tbId.Text = "03152482001"; // Giá trị mẫu

            // 
            // label2 (Tên nhân viên)
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 70);
            this.label2.Text = "Tên nhân viên";

            // 
            // tbName (Nhập Tên)
            // 
            this.tbName.Location = new System.Drawing.Point(130, 67);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(250, 27);
            this.tbName.TabIndex = 1;
            this.tbName.Text = "Nguyễn Văn Hùng"; // Giá trị mẫu

            // 
            // label3 (Ảnh 3x4)
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 110);
            this.label3.Text = "Anh 3 x 4";

            // 
            // pbImage (Khung hiển thị ảnh)
            // 
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle; // Viền khung
            this.pbImage.Location = new System.Drawing.Point(130, 110);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(120, 160); // Kích thước chuẩn 3x4
            this.pbImage.TabIndex = 2;
            this.pbImage.TabStop = false;

            // 
            // btFile (Nút Chọn ảnh)
            // 
            this.btFile.Location = new System.Drawing.Point(260, 110);
            this.btFile.Name = "btFile";
            this.btFile.Size = new System.Drawing.Size(100, 35);
            this.btFile.TabIndex = 3;
            this.btFile.Text = "Chọn ảnh ...";
            this.btFile.UseVisualStyleBackColor = true;
            this.btFile.Click += new System.EventHandler(this.btFile_Click); // KẾT NỐI SỰ KIỆN CLICK

            // 
            // Ex19
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 320);
            this.Controls.Add(this.btFile);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label1);
            this.Name = "Ex19";
            this.Text = "Quản lý nhân sự";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        // Khai báo tên biến chuẩn để code logic hoạt động
        private System.Windows.Forms.Label label1, label2, label3;
        private System.Windows.Forms.TextBox tbId, tbName;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btFile;
    }
}