namespace Baitap
{
    partial class Ex18
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
            this.label1.Text = "Danh sách bài hát (Object)";

            // 
            // lbSong (Danh sách bài hát gốc - Sẽ nạp bằng Code)
            // 
            this.lbSong.FormattingEnabled = true;
            this.lbSong.ItemHeight = 20;
            this.lbSong.Location = new System.Drawing.Point(30, 50);
            this.lbSong.Name = "lbSong";
            this.lbSong.Size = new System.Drawing.Size(200, 264);
            this.lbSong.TabIndex = 0;

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
            this.lbFavorite.Size = new System.Drawing.Size(250, 264);
            this.lbFavorite.TabIndex = 1;

            // 
            // btSelect (Nút >)
            // 
            this.btSelect.Location = new System.Drawing.Point(250, 70);
            this.btSelect.Name = "btSelect";
            this.btSelect.Size = new System.Drawing.Size(50, 30);
            this.btSelect.TabIndex = 2;
            this.btSelect.Text = ">";
            this.btSelect.UseVisualStyleBackColor = true;
            this.btSelect.Click += new System.EventHandler(this.btSelect_Click); // KẾT NỐI CLICK

            // 
            // btSelectAll (Nút >>)
            // 
            this.btSelectAll.Location = new System.Drawing.Point(250, 120);
            this.btSelectAll.Name = "btSelectAll";
            this.btSelectAll.Size = new System.Drawing.Size(50, 30);
            this.btSelectAll.TabIndex = 3;
            this.btSelectAll.Text = ">>";
            this.btSelectAll.UseVisualStyleBackColor = true;
            this.btSelectAll.Click += new System.EventHandler(this.btSelectAll_Click); // KẾT NỐI CLICK

            // 
            // btDeselect (Nút <)
            // 
            this.btDeselect.Location = new System.Drawing.Point(250, 170);
            this.btDeselect.Name = "btDeselect";
            this.btDeselect.Size = new System.Drawing.Size(50, 30);
            this.btDeselect.TabIndex = 4;
            this.btDeselect.Text = "<";
            this.btDeselect.UseVisualStyleBackColor = true;
            this.btDeselect.Click += new System.EventHandler(this.btDeselect_Click); // KẾT NỐI CLICK

            // 
            // btDeselectAll (Nút <<)
            // 
            this.btDeselectAll.Location = new System.Drawing.Point(250, 220);
            this.btDeselectAll.Name = "btDeselectAll";
            this.btDeselectAll.Size = new System.Drawing.Size(50, 30);
            this.btDeselectAll.TabIndex = 5;
            this.btDeselectAll.Text = "<<";
            this.btDeselectAll.UseVisualStyleBackColor = true;
            this.btDeselectAll.Click += new System.EventHandler(this.btDeselectAll_Click); // KẾT NỐI CLICK

            // 
            // Ex18
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 350);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btDeselectAll);
            this.Controls.Add(this.btDeselect);
            this.Controls.Add(this.btSelectAll);
            this.Controls.Add(this.btSelect);
            this.Controls.Add(this.lbFavorite);
            this.Controls.Add(this.lbSong);
            this.Name = "Ex18";
            this.Text = "Ex18 - ListBox Object";
            this.Load += new System.EventHandler(this.Ex18_Load); // QUAN TRỌNG: KẾT NỐI SỰ KIỆN LOAD
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        // Khai báo tên biến chuẩn để code logic hoạt động
        private System.Windows.Forms.ListBox lbSong;
        private System.Windows.Forms.ListBox lbFavorite;
        private System.Windows.Forms.Button btSelect;
        private System.Windows.Forms.Button btSelectAll;
        private System.Windows.Forms.Button btDeselect;
        private System.Windows.Forms.Button btDeselectAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}