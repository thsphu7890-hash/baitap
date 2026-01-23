namespace Battle_City
{
    partial class Play_Level
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlMap = new System.Windows.Forms.Panel();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblStage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);

            this.pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();

            // pnlMap
            this.pnlMap.BackColor = System.Drawing.Color.Black;
            this.pnlMap.Location = new System.Drawing.Point(0, 0);
            this.pnlMap.Name = "pnlMap";
            this.pnlMap.Size = new System.Drawing.Size(600, 600);
            this.pnlMap.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMap_Paint);

            // pnlInfo
            this.pnlInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.pnlInfo.Controls.Add(this.lblStage);
            this.pnlInfo.Controls.Add(this.pictureBox2);
            this.pnlInfo.Controls.Add(this.pictureBox1);
            this.pnlInfo.Controls.Add(this.label2);
            this.pnlInfo.Controls.Add(this.label1);
            this.pnlInfo.Location = new System.Drawing.Point(600, 0);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(200, 600);

            // label1 (ENEMIES)
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 30);
            this.label1.Text = "ENEMIES";

            // label2 (1P)
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(85, 245);
            this.label2.Text = "1P";

            // pictureBox1 (Tank Icon)
            this.pictureBox1.Image = global::Battle_City.Properties.Resources.tank_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(50, 301);
            this.pictureBox1.Size = new System.Drawing.Size(100, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            // pictureBox2 (Flag Icon)
            this.pictureBox2.Image = global::Battle_City.Properties.Resources.flag_removebg_preview;
            this.pictureBox2.Location = new System.Drawing.Point(50, 439);
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            // lblStage
            this.lblStage.AutoSize = true;
            this.lblStage.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold);
            this.lblStage.ForeColor = System.Drawing.Color.Yellow;
            this.lblStage.Location = new System.Drawing.Point(115, 442);
            this.lblStage.Text = "1";

            // Play_Level Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.pnlMap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Play_Level";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Battle City - Pro Version";

            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlMap;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblStage;
        private System.Windows.Forms.Timer timer1;
    }
}