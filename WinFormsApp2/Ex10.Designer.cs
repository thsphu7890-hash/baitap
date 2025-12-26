namespace WinFormsApp2
{
    partial class Ex10
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
            tbDisplay = new TextBox();
            bt0 = new Button();
            bt1 = new Button();
            bt2 = new Button();
            bt3 = new Button();
            btPlus = new Button();
            btMul = new Button();
            btDot = new Button();
            btEquals = new Button();
            btThoat = new Button();
            SuspendLayout();
            // 
            // tbDisplay
            // 
            tbDisplay.Font = new Font("Segoe UI", 14F);
            tbDisplay.Location = new Point(25, 30);
            tbDisplay.Name = "tbDisplay";
            tbDisplay.Size = new Size(740, 39);
            tbDisplay.TabIndex = 0;
            tbDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // bt0
            // 
            bt0.Location = new Point(25, 100);
            bt0.Name = "bt0";
            bt0.Size = new Size(150, 80);
            bt0.TabIndex = 8;
            bt0.Text = "0";
            bt0.Click += bt1_Click;
            // 
            // bt1
            // 
            bt1.Location = new Point(210, 100);
            bt1.Name = "bt1";
            bt1.Size = new Size(150, 80);
            bt1.TabIndex = 7;
            bt1.Text = "1";
            bt1.Click += bt2_Click;
            // 
            // bt2
            // 
            bt2.Location = new Point(400, 100);
            bt2.Name = "bt2";
            bt2.Size = new Size(150, 80);
            bt2.TabIndex = 6;
            bt2.Text = "2";
            bt2.Click += bt3_Click;
            // 
            // bt3
            // 
            bt3.Location = new Point(590, 100);
            bt3.Name = "bt3";
            bt3.Size = new Size(150, 80);
            bt3.TabIndex = 5;
            bt3.Text = "3";
            bt3.Click += bt4_Click;
            // 
            // btPlus
            // 
            btPlus.Location = new Point(25, 220);
            btPlus.Name = "btPlus";
            btPlus.Size = new Size(150, 80);
            btPlus.TabIndex = 4;
            btPlus.Text = "+";
            btPlus.Click += btPlus_Click;
            // 
            // btMul
            // 
            btMul.Location = new Point(210, 220);
            btMul.Name = "btMul";
            btMul.Size = new Size(150, 80);
            btMul.TabIndex = 3;
            btMul.Text = "*";
            btMul.Click += btMul_Click;
            // 
            // btDot
            // 
            btDot.Location = new Point(400, 220);
            btDot.Name = "btDot";
            btDot.Size = new Size(150, 80);
            btDot.TabIndex = 2;
            btDot.Text = ".";
            btDot.Click += btDot_Click;
            // 
            // btEquals
            // 
            btEquals.Location = new Point(590, 220);
            btEquals.Name = "btEquals";
            btEquals.Size = new Size(150, 80);
            btEquals.TabIndex = 1;
            btEquals.Text = "=";
            btEquals.Click += btEquals_Click;
            // 
            // btThoat
            // 
            btThoat.Location = new Point(590, 330);
            btThoat.Name = "btThoat";
            btThoat.Size = new Size(150, 50);
            btThoat.TabIndex = 0;
            btThoat.Text = "Thoát";
            btThoat.Click += btThoat_Click;
            // 
            // Ex10
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 420);
            Controls.Add(btThoat);
            Controls.Add(btEquals);
            Controls.Add(btDot);
            Controls.Add(btMul);
            Controls.Add(btPlus);
            Controls.Add(bt3);
            Controls.Add(bt2);
            Controls.Add(bt1);
            Controls.Add(bt0);
            Controls.Add(tbDisplay);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Ex10";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Simple Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbDisplay;
        private Button bt0;
        private Button bt1;
        private Button bt2;
        private Button bt3;
        private Button btPlus;
        private Button btMul;
        private Button btDot;
        private Button btEquals;
        private Button btThoat;
    }
}