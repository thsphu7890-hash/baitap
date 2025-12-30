namespace Battle_City
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlMenu = new Panel();
            btnStart = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.AllowDrop = true;
            pnlMenu.BackColor = Color.Black;
            pnlMenu.Controls.Add(btnStart);
            pnlMenu.Controls.Add(pictureBox1);
            pnlMenu.Controls.Add(label1);
            pnlMenu.Dock = DockStyle.Fill;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(600, 600);
            pnlMenu.TabIndex = 0;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.Black;
            btnStart.Cursor = Cursors.Hand;
            btnStart.FlatAppearance.BorderSize = 0;
            btnStart.FlatAppearance.MouseDownBackColor = Color.Black;
            btnStart.FlatAppearance.MouseOverBackColor = Color.Black;
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Image = Properties.Resources.start;
            btnStart.Location = new Point(190, 320);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(220, 90);
            btnStart.TabIndex = 2;
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += this.btnStart_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.tank_removebg_preview;
            pictureBox1.Location = new Point(225, 150);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 48F);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(110, 50);
            label1.Name = "label1";
            label1.Size = new Size(417, 98);
            label1.TabIndex = 0;
            label1.Text = "BATTLE CITY";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 600);
            Controls.Add(pnlMenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Battle City";
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnStart;
    }
}