namespace WinFormsApp2
{
    partial class Ex08
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
            x = new Label();
            y = new Label();
            KetQua = new Label();
            tbSoX = new TextBox();
            tbSoY = new TextBox();
            textBox3 = new TextBox();
            btCong = new Button();
            tbKetQua = new TextBox();
            btNhan = new Button();
            btThoat = new Button();
            SuspendLayout();
            // 
            // x
            // 
            x.AutoSize = true;
            x.BackColor = Color.Transparent;
            x.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            x.Location = new Point(115, 38);
            x.Name = "x";
            x.Size = new Size(41, 20);
            x.TabIndex = 0;
            x.Text = "So_X";
            // 
            // y
            // 
            y.AutoSize = true;
            y.Location = new Point(115, 125);
            y.Name = "y";
            y.Size = new Size(40, 20);
            y.TabIndex = 1;
            y.Text = "So_Y";
            // 
            // KetQua
            // 
            KetQua.AutoSize = true;
            KetQua.Location = new Point(115, 227);
            KetQua.Name = "KetQua";
            KetQua.Size = new Size(62, 20);
            KetQua.TabIndex = 2;
            KetQua.Text = "Ket Qua";
            // 
            // tbSoX
            // 
            tbSoX.Location = new Point(233, 31);
            tbSoX.Name = "tbSoX";
            tbSoX.Size = new Size(335, 27);
            tbSoX.TabIndex = 3;
            // 
            // tbSoY
            // 
            tbSoY.Location = new Point(233, 118);
            tbSoY.Name = "tbSoY";
            tbSoY.Size = new Size(335, 27);
            tbSoY.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(233, 220);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(335, 27);
            textBox3.TabIndex = 5;
            // 
            // btCong
            // 
            btCong.Location = new Point(115, 311);
            btCong.Name = "btCong";
            btCong.Size = new Size(121, 55);
            btCong.TabIndex = 6;
            btCong.Text = "Cộng";
            btCong.UseVisualStyleBackColor = true;
            btCong.Click += btCong_Click;
            // 
            // tbKetQua
            // 
            tbKetQua.Location = new Point(233, 212);
            tbKetQua.Name = "tbKetQua";
            tbKetQua.Size = new Size(335, 27);
            tbKetQua.TabIndex = 7;
            // 
            // btNhan
            // 
            btNhan.Location = new Point(347, 311);
            btNhan.Name = "btNhan";
            btNhan.Size = new Size(121, 55);
            btNhan.TabIndex = 8;
            btNhan.Text = "Nhân";
            btNhan.UseVisualStyleBackColor = true;
            btNhan.Click += btNhan_Click;
            // 
            // btThoat
            // 
            btThoat.Location = new Point(590, 311);
            btThoat.Name = "btThoat";
            btThoat.Size = new Size(121, 55);
            btThoat.TabIndex = 9;
            btThoat.Text = "Thoát";
            btThoat.UseVisualStyleBackColor = true;
            // 
            // Ex08
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btThoat);
            Controls.Add(btNhan);
            Controls.Add(tbKetQua);
            Controls.Add(btCong);
            Controls.Add(textBox3);
            Controls.Add(tbSoY);
            Controls.Add(tbSoX);
            Controls.Add(KetQua);
            Controls.Add(y);
            Controls.Add(x);
            Name = "Ex08";
            Text = "Ex08";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label x;
        private Label y;
        private Label KetQua;
        private TextBox tbSoX;
        private TextBox tbSoY;
        private TextBox textBox3;
        private Button btCong;
        private TextBox tbKetQua;
        private Button btNhan;
        private Button btThoat;
    }
}