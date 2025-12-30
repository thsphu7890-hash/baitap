namespace Baitap
{
    partial class Ex17
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
            this.lbSong = new System.Windows.Forms.ListBox();
            this.lbFavorite = new System.Windows.Forms.ListBox();
            this.btSelect = new System.Windows.Forms.Button();
            this.btSelectAll = new System.Windows.Forms.Button();
            this.btDeselect = new System.Windows.Forms.Button();
            this.btDeselectAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // label1 (Tiêu đề trái)
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Text = "Danh sách bài hát";

            // 
            // lbSong (Danh sách bài hát gốc)
            // 
            this.lbSong.FormattingEnabled = true;
            this.lbSong.ItemHeight = 20;
            // SỬA: Thêm sẵn các bài hát mẫu
            this.lbSong.Items.AddRange(new object[] {
            "Giấc mơ Chapi",
            "Đôi mắt Pleiku",
            "Em Muốn Sống Bên Anh Trọn Đời",
            "H'Zen Lên Rẫy",
            "Ly Cà Phê Ban Mê",
            "Đi tìm lời ru mặt trời"});
            this.lbSong.Location = new System.Drawing.Point(30, 50);
            this.lbSong.Name = "lbSong";
            this.lbSong.Size = new System.Drawing.Size(200, 264);
            this.lbSong.TabIndex = 0;
            // SỬA: Thêm sự kiện Double Click
            this.lbSong.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbSong_MouseDoubleClick);

            // 
            // label2 (Tiêu đề phải)
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 20);
            this.label2.Text = "Danh sách bài hát ưa thích";

            // 
            // lbFavorite (Danh sách ưa thích)
            // 
            this.lbFavorite.FormattingEnabled = true;
            this.lbFavorite.ItemHeight = 20;
            this.lbFavorite.Location = new System.Drawing.Point(330, 50);
            this.lbFavorite.Name = "lbFavorite";
            this.lbFavorite.Size = new System.Drawing.Size(200, 264);
            this.lbFavorite.TabIndex = 1;
            // SỬA: Thêm sự kiện Double Click
            this.lbFavorite.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbFavorite_MouseDoubleClick);

            // 
            // btSelect (Nút >)
            // 
            this.btSelect.Location = new System.Drawing.Point(250, 70);
            this.btSelect.Name = "btSelect";
            this.btSelect.Size = new System.Drawing.Size(50, 30);
            this.btSelect.TabIndex = 2;
            this.btSelect.Text = ">";
            this.btSelect.UseVisualStyleBackColor = true;
            // SỬA: Thêm sự kiện Click
            this.btSelect.Click += new System.EventHandler(this.btSelect_Click);

            // 
            // btSelectAll (Nút >>)
            // 
            this.btSelectAll.Location = new System.Drawing.Point(250, 120);
            this.btSelectAll.Name = "btSelectAll";
            this.btSelectAll.Size = new System.Drawing.Size(50, 30);
            this.btSelectAll.TabIndex = 3;
            this.btSelectAll.Text = ">>";
            this.btSelectAll.UseVisualStyleBackColor = true;
            this.btSelectAll.Click += new System.EventHandler(this.btSelectAll_Click);

            // 
            // btDeselect (Nút <)
            // 
            this.btDeselect.Location = new System.Drawing.Point(250, 170);
            this.btDeselect.Name = "btDeselect";
            this.btDeselect.Size = new System.Drawing.Size(50, 30);
            this.btDeselect.TabIndex = 4;
            this.btDeselect.Text = "<";
            this.btDeselect.UseVisualStyleBackColor = true;
            this.btDeselect.Click += new System.EventHandler(this.btDeselect_Click);

            // 
            // btDeselectAll (Nút <<)
            // 
            this.btDeselectAll.Location = new System.Drawing.Point(250, 220);
            this.btDeselectAll.Name = "btDeselectAll";
            this.btDeselectAll.Size = new System.Drawing.Size(50, 30);
            this.btDeselectAll.TabIndex = 5;
            this.btDeselectAll.Text = "<<";
            this.btDeselectAll.UseVisualStyleBackColor = true;
            this.btDeselectAll.Click += new System.EventHandler(this.btDeselectAll_Click);

            // 
            // Ex17
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 350);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btDeselectAll);
            this.Controls.Add(this.btDeselect);
            this.Controls.Add(this.btSelectAll);
            this.Controls.Add(this.btSelect);
            this.Controls.Add(this.lbFavorite);
            this.Controls.Add(this.lbSong);
            this.Name = "Ex17";
            this.Text = "Ex17 - Music Selector";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        // Khai báo biến với tên chuẩn
        private System.Windows.Forms.ListBox lbSong;      // List trái
        private System.Windows.Forms.ListBox lbFavorite;  // List phải
        private System.Windows.Forms.Button btSelect;     // >
        private System.Windows.Forms.Button btSelectAll;  // >>
        private System.Windows.Forms.Button btDeselect;   // <
        private System.Windows.Forms.Button btDeselectAll;// <<
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}