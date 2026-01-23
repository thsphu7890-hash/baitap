namespace Battle_City
{
    partial class Main
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnConstruction = new System.Windows.Forms.Button(); // Hết lỗi gạch đỏ ở đây
            this.btnStart = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.AllowDrop = true;
            this.pnlMenu.BackColor = System.Drawing.Color.Black;
            this.pnlMenu.Controls.Add(this.btnConstruction); // Thêm nút Construction
            this.pnlMenu.Controls.Add(this.btnStart);
            this.pnlMenu.Controls.Add(this.pictureBox1);
            this.pnlMenu.Controls.Add(this.label1);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(600, 600);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Black;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Image = Battle_City.Properties.Resources.start;
            this.btnStart.Location = new System.Drawing.Point(190, 310);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(220, 80);
            this.btnStart.TabIndex = 2;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnConstruction (ĐÂY LÀ NÚT BẠN ĐANG LỖI - ĐÃ SỬA)
            // 
            this.btnConstruction.BackColor = System.Drawing.Color.DarkGreen;
            this.btnConstruction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConstruction.FlatAppearance.BorderSize = 0;
            this.btnConstruction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnConstruction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnConstruction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConstruction.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.btnConstruction.ForeColor = System.Drawing.Color.White;
            this.btnConstruction.Location = new System.Drawing.Point(190, 410);
            this.btnConstruction.Name = "btnConstruction"; // Tên biến chuẩn
            this.btnConstruction.Size = new System.Drawing.Size(220, 60);
            this.btnConstruction.TabIndex = 3;
            this.btnConstruction.Text = "CONSTRUCTION";
            this.btnConstruction.UseVisualStyleBackColor = false;
            this.btnConstruction.Click += new System.EventHandler(this.btnConstruction_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = Battle_City.Properties.Resources.tank_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(225, 150);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 48F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(110, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 98);
            this.label1.TabIndex = 0;
            this.label1.Text = "BATTLE CITY";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Battle City";
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer1;

        // --- ĐÂY LÀ DÒNG BẠN BỊ THIẾU Ở HÌNH 3 (Khai báo biến) ---
        private System.Windows.Forms.Button btnConstruction;
    }
}