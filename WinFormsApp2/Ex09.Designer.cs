namespace WinFormsApp2
{
    partial class Ex09
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbSoX = new TextBox();
            tbSoY = new TextBox();
            tbKetQua = new TextBox();
            btLuu = new Button();
            btCong = new Button();
            btNhan = new Button();
            btThoat = new Button();
            SuspendLayout();

            // label1 (Số X)
            label1.AutoSize = true;
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.Text = "Số x";

            // label2 (Số Y)
            label2.AutoSize = true;
            label2.Location = new Point(20, 60);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.Text = "Số y";

            // label3 (Kết quả)
            label3.AutoSize = true;
            label3.Location = new Point(20, 100);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.Text = "Kết quả";

            // tbSoX (Nhập số X)
            tbSoX.Location = new Point(100, 17);
            tbSoX.Name = "tbSoX";
            tbSoX.Size = new Size(660, 27);
            tbSoX.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // tbSoY (Nhập số Y)
            tbSoY.Location = new Point(100, 57);
            tbSoY.Name = "tbSoY";
            tbSoY.Size = new Size(660, 27);
            tbSoY.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // tbKetQua (Ô lịch sử - MULTILINE)
            tbKetQua.Location = new Point(100, 100);
            tbKetQua.Name = "tbKetQua";
            tbKetQua.Size = new Size(660, 270);
            tbKetQua.Multiline = true; // Cho phép nhiều dòng
            tbKetQua.ScrollBars = ScrollBars.Vertical; // Thêm thanh cuộn dọc
            // Anchor giúp ô này co giãn theo Form
            tbKetQua.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            // btLuu (Nút Lưu)
            btLuu.Location = new Point(100, 390);
            btLuu.Name = "btLuu";
            btLuu.Size = new Size(100, 40);
            btLuu.Text = "Lưu";
            btLuu.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;

            // btCong (Nút Cộng)
            btCong.Location = new Point(430, 390);
            btCong.Name = "btCong";
            btCong.Size = new Size(100, 40);
            btCong.Text = "Cộng";
            btCong.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            // btNhan (Nút Nhân)
            btNhan.Location = new Point(540, 390);
            btNhan.Name = "btNhan";
            btNhan.Size = new Size(100, 40);
            btNhan.Text = "Nhân";
            btNhan.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            // btThoat (Nút Thoát)
            btThoat.Location = new Point(660, 390);
            btThoat.Name = "btThoat";
            btThoat.Size = new Size(100, 40);
            btThoat.Text = "Thoát";
            btThoat.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            // Cấu hình Form chính (Ex09)
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btThoat);
            Controls.Add(btNhan);
            Controls.Add(btCong);
            Controls.Add(btLuu);
            Controls.Add(tbKetQua);
            Controls.Add(tbSoY);
            Controls.Add(tbSoX);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Ex09";
            Text = "Caculato r"; // Tiêu đề Form
            StartPosition = FormStartPosition.CenterScreen; // Hiện giữa màn hình
            ResumeLayout(false);
            PerformLayout();

            // Các dòng này BẮT BUỘC phải có thì nút mới hoạt động
            this.btCong.Click += new System.EventHandler(this.btCong_Click);
            this.btNhan.Click += new System.EventHandler(this.btNhan_Click);
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbSoX;
        private TextBox tbSoY;
        private TextBox tbKetQua;
        private Button btLuu;
        private Button btCong;
        private Button btNhan;
        private Button btThoat;
    }
}