namespace Battle_City
{
    partial class Play_Level
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pnlMap = new Panel();
            pnlInfo = new Panel();
            lblStage = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlMap
            // 
            pnlMap.BackColor = Color.Black;
            pnlMap.Location = new Point(0, 0);
            pnlMap.Name = "pnlMap";
            pnlMap.Size = new Size(600, 600);
            pnlMap.TabIndex = 0;
            // 
            // pnlInfo
            // 
            pnlInfo.BackColor = Color.Silver;
            pnlInfo.Controls.Add(lblStage);
            pnlInfo.Controls.Add(pictureBox2);
            pnlInfo.Controls.Add(pictureBox1);
            pnlInfo.Controls.Add(label2);
            pnlInfo.Controls.Add(label1);
            pnlInfo.Location = new Point(600, 0);
            pnlInfo.Name = "pnlInfo";
            pnlInfo.Size = new Size(200, 600);
            pnlInfo.TabIndex = 1;
            // 
            // lblStage
            // 
            lblStage.AutoSize = true;
            lblStage.Font = new Font("Impact", 20F);
            lblStage.Location = new Point(80, 450);
            lblStage.Name = "lblStage";
            lblStage.Size = new Size(31, 42);
            lblStage.TabIndex = 4;
            lblStage.Text = "1";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.flag_removebg_preview;
            pictureBox2.Location = new Point(30, 450);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.tank_removebg_preview;
            pictureBox1.Location = new Point(30, 300);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14F, FontStyle.Bold);
            label2.Location = new Point(75, 250);
            label2.Name = "label2";
            label2.Size = new Size(42, 29);
            label2.TabIndex = 1;
            label2.Text = "1P";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold);
            label1.Location = new Point(50, 30);
            label1.Name = "label1";
            label1.Size = new Size(98, 24);
            label1.TabIndex = 0;
            label1.Text = "ENEMIES";
            // 
            // Play_Level
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 600);
            Controls.Add(pnlInfo);
            Controls.Add(pnlMap);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Play_Level";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Battle City - Playing";
            pnlInfo.ResumeLayout(false);
            pnlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlMap;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label label1; // Label ENEMIES
        private System.Windows.Forms.Label label2; // Label 1P
        private System.Windows.Forms.PictureBox pictureBox1; // Icon Tank Life
        private System.Windows.Forms.PictureBox pictureBox2; // Icon Flag
        private System.Windows.Forms.Label lblStage; // Số Level
        private System.Windows.Forms.Timer timer1;
    }
}