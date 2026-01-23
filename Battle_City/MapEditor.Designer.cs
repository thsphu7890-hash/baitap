namespace Battle_City
{
    partial class MapEditor
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
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.grpTools = new System.Windows.Forms.GroupBox();
            this.rbEraser = new System.Windows.Forms.RadioButton();
            this.rbWater = new System.Windows.Forms.RadioButton();
            this.rbSteel = new System.Windows.Forms.RadioButton();
            this.rbBrick = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGrid
            // 
            this.pnlGrid.BackColor = System.Drawing.Color.Black;
            this.pnlGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGrid.Location = new System.Drawing.Point(20, 20);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(522, 522); // 13 ô * 40px + 2px viền
            this.pnlGrid.TabIndex = 0;
            // 
            // grpTools
            // 
            this.grpTools.Controls.Add(this.rbEraser);
            this.grpTools.Controls.Add(this.rbWater);
            this.grpTools.Controls.Add(this.rbSteel);
            this.grpTools.Controls.Add(this.rbBrick);
            this.grpTools.ForeColor = System.Drawing.Color.White;
            this.grpTools.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.grpTools.Location = new System.Drawing.Point(560, 60);
            this.grpTools.Name = "grpTools";
            this.grpTools.Size = new System.Drawing.Size(200, 220);
            this.grpTools.TabIndex = 1;
            this.grpTools.TabStop = false;
            this.grpTools.Text = "TOOLS";
            // 
            // rbBrick
            // 
            this.rbBrick.AutoSize = true;
            this.rbBrick.Checked = true;
            this.rbBrick.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))); // Màu cam gạch
            this.rbBrick.Location = new System.Drawing.Point(20, 40);
            this.rbBrick.Name = "rbBrick";
            this.rbBrick.Size = new System.Drawing.Size(84, 27);
            this.rbBrick.TabIndex = 0;
            this.rbBrick.TabStop = true;
            this.rbBrick.Tag = "1";
            this.rbBrick.Text = "BRICK";
            this.rbBrick.UseVisualStyleBackColor = true;
            // 
            // rbSteel
            // 
            this.rbSteel.AutoSize = true;
            this.rbSteel.ForeColor = System.Drawing.Color.Silver;
            this.rbSteel.Location = new System.Drawing.Point(20, 80);
            this.rbSteel.Name = "rbSteel";
            this.rbSteel.Size = new System.Drawing.Size(84, 27);
            this.rbSteel.TabIndex = 1;
            this.rbSteel.Tag = "2";
            this.rbSteel.Text = "STEEL";
            this.rbSteel.UseVisualStyleBackColor = true;
            // 
            // rbWater
            // 
            this.rbWater.AutoSize = true;
            this.rbWater.ForeColor = System.Drawing.Color.Cyan;
            this.rbWater.Location = new System.Drawing.Point(20, 120);
            this.rbWater.Name = "rbWater";
            this.rbWater.Size = new System.Drawing.Size(84, 27);
            this.rbWater.TabIndex = 2;
            this.rbWater.Tag = "3";
            this.rbWater.Text = "WATER";
            this.rbWater.UseVisualStyleBackColor = true;
            // 
            // rbEraser
            // 
            this.rbEraser.AutoSize = true;
            this.rbEraser.ForeColor = System.Drawing.Color.White;
            this.rbEraser.Location = new System.Drawing.Point(20, 160);
            this.rbEraser.Name = "rbEraser";
            this.rbEraser.Size = new System.Drawing.Size(95, 27);
            this.rbEraser.TabIndex = 3;
            this.rbEraser.Tag = "0";
            this.rbEraser.Text = "ERASER";
            this.rbEraser.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(560, 300);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(200, 50);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "SAVE MAP";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.OrangeRed;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.btnPlay.ForeColor = System.Drawing.Color.White;
            this.btnPlay.Location = new System.Drawing.Point(560, 360);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(200, 50);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "TEST PLAY";
            this.btnPlay.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(560, 500);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(200, 40);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "BACK TO MENU";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 24F);
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(560, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 48);
            this.label1.TabIndex = 5;
            this.label1.Text = "CONSTRUCT";
            // 
            // MapEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(800, 560);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpTools);
            this.Controls.Add(this.pnlGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MapEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Battle City - Map Construction";
            this.grpTools.ResumeLayout(false);
            this.grpTools.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.GroupBox grpTools;
        private System.Windows.Forms.RadioButton rbBrick;
        private System.Windows.Forms.RadioButton rbSteel;
        private System.Windows.Forms.RadioButton rbWater;
        private System.Windows.Forms.RadioButton rbEraser;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
    }
}