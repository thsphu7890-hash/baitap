namespace WinFormsApp2
{
    partial class Ex11
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
            // Cấu hình chung
            int btnW = 75, btnH = 60, gap = 5;
            int startX = 15, startY = 110;

            // Màu sắc & Font
            System.Drawing.Color colorNum = System.Drawing.Color.White;
            System.Drawing.Color colorOp = System.Drawing.Color.FromArgb(245, 245, 245);
            System.Drawing.Color colorEqual = System.Drawing.Color.FromArgb(100, 181, 246);
            System.Drawing.Color colorMem = System.Drawing.Color.Transparent;
            System.Drawing.Font fontNum = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fontOp = new System.Drawing.Font("Segoe UI", 12F);

            // Khởi tạo các biến nút
            this.btMC = new System.Windows.Forms.Button();
            this.btMR = new System.Windows.Forms.Button();
            this.btMS = new System.Windows.Forms.Button();
            this.btMPlus = new System.Windows.Forms.Button();
            this.btMMinus = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.btNegate = new System.Windows.Forms.Button();
            this.btSqrt = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.btDivide = new System.Windows.Forms.Button();
            this.btPercent = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.btMult = new System.Windows.Forms.Button();
            this.btEquals = new System.Windows.Forms.Button();
            this.bt0 = new System.Windows.Forms.Button();
            this.btDot = new System.Windows.Forms.Button();
            this.btMinus = new System.Windows.Forms.Button();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btReciprocal = new System.Windows.Forms.Button();
            this.btPlus = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btClearEntry = new System.Windows.Forms.Button();
            this.btBackspace = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // --- CẤU HÌNH FORM ---
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 520);
            this.Name = "Ex11";
            this.Text = "Calculator";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.BackColor = System.Drawing.Color.FromArgb(227, 227, 227);

            // --- MÀN HÌNH HIỂN THỊ ---
            this.txtDisplay.Location = new System.Drawing.Point(startX, 20);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(395, 50);
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.BackColor = System.Drawing.Color.FromArgb(227, 227, 227);
            this.txtDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDisplay.Font = new System.Drawing.Font("Segoe UI Semibold", 28F, System.Drawing.FontStyle.Bold);
            this.txtDisplay.Text = "0";
            this.Controls.Add(this.txtDisplay);

            // --- HÀM VẼ NÚT ---
            void SetButtonStyle(System.Windows.Forms.Button b, string txt, int x, int y, int w, int h, System.Drawing.Color bg, System.Drawing.Font f)
            {
                b.Text = txt;
                b.Location = new System.Drawing.Point(x, y);
                b.Size = new System.Drawing.Size(w, h);
                b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                b.FlatAppearance.BorderSize = 0;
                b.BackColor = bg;
                b.Font = f;
                b.Click += new System.EventHandler(this.Button_Click); // QUAN TRỌNG: Gắn sự kiện
                this.Controls.Add(b);
            }

            // --- DÒNG 0: MEMORY ---
            int row0 = 75, mH = 30;
            SetButtonStyle(btMC, "MC", startX, row0, btnW, mH, colorMem, new System.Drawing.Font("Segoe UI", 9F));
            SetButtonStyle(btMR, "MR", startX + (btnW + gap) * 1, row0, btnW, mH, colorMem, new System.Drawing.Font("Segoe UI", 9F));
            SetButtonStyle(btMS, "MS", startX + (btnW + gap) * 2, row0, btnW, mH, colorMem, new System.Drawing.Font("Segoe UI", 9F));
            SetButtonStyle(btMPlus, "M+", startX + (btnW + gap) * 3, row0, btnW, mH, colorMem, new System.Drawing.Font("Segoe UI", 9F));
            SetButtonStyle(btMMinus, "M-", startX + (btnW + gap) * 4, row0, btnW, mH, colorMem, new System.Drawing.Font("Segoe UI", 9F));

            // --- DÒNG 1: CHỨC NĂNG ---
            SetButtonStyle(btBackspace, "←", startX, startY, btnW, btnH, colorOp, fontOp);
            SetButtonStyle(btClearEntry, "CE", startX + (btnW + gap) * 1, startY, btnW, btnH, colorOp, fontOp);
            SetButtonStyle(btClear, "C", startX + (btnW + gap) * 2, startY, btnW, btnH, colorOp, fontOp);
            SetButtonStyle(btNegate, "±", startX + (btnW + gap) * 3, startY, btnW, btnH, colorOp, fontOp);
            SetButtonStyle(btSqrt, "√", startX + (btnW + gap) * 4, startY, btnW, btnH, colorOp, fontOp);

            // --- DÒNG 2 ---
            int row2 = startY + btnH + gap;
            SetButtonStyle(bt7, "7", startX, row2, btnW, btnH, colorNum, fontNum);
            SetButtonStyle(bt8, "8", startX + (btnW + gap) * 1, row2, btnW, btnH, colorNum, fontNum);
            SetButtonStyle(bt9, "9", startX + (btnW + gap) * 2, row2, btnW, btnH, colorNum, fontNum);
            SetButtonStyle(btDivide, "/", startX + (btnW + gap) * 3, row2, btnW, btnH, colorOp, fontOp);
            SetButtonStyle(btPercent, "%", startX + (btnW + gap) * 4, row2, btnW, btnH, colorOp, fontOp);

            // --- DÒNG 3 ---
            int row3 = row2 + btnH + gap;
            SetButtonStyle(bt4, "4", startX, row3, btnW, btnH, colorNum, fontNum);
            SetButtonStyle(bt5, "5", startX + (btnW + gap) * 1, row3, btnW, btnH, colorNum, fontNum);
            SetButtonStyle(bt6, "6", startX + (btnW + gap) * 2, row3, btnW, btnH, colorNum, fontNum);
            SetButtonStyle(btMult, "*", startX + (btnW + gap) * 3, row3, btnW, btnH, colorOp, fontOp);
            SetButtonStyle(btReciprocal, "1/x", startX + (btnW + gap) * 4, row3, btnW, btnH, colorOp, fontOp);

            // --- DÒNG 4 ---
            int row4 = row3 + btnH + gap;
            SetButtonStyle(bt1, "1", startX, row4, btnW, btnH, colorNum, fontNum);
            SetButtonStyle(bt2, "2", startX + (btnW + gap) * 1, row4, btnW, btnH, colorNum, fontNum);
            SetButtonStyle(bt3, "3", startX + (btnW + gap) * 2, row4, btnW, btnH, colorNum, fontNum);
            SetButtonStyle(btMinus, "-", startX + (btnW + gap) * 3, row4, btnW, btnH, colorOp, fontOp);
            SetButtonStyle(btEquals, "=", startX + (btnW + gap) * 4, row4, btnW, btnH * 2 + gap, colorEqual, fontNum);
            btEquals.ForeColor = System.Drawing.Color.White;

            // --- DÒNG 5 ---
            int row5 = row4 + btnH + gap;
            SetButtonStyle(bt0, "0", startX, row5, btnW * 2 + gap, btnH, colorNum, fontNum);
            SetButtonStyle(btDot, ".", startX + (btnW + gap) * 2, row5, btnW, btnH, colorNum, fontNum);
            SetButtonStyle(btPlus, "+", startX + (btnW + gap) * 3, row5, btnW, btnH, colorOp, fontOp);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        // Khai báo biến
        private System.Windows.Forms.Button btMC, btMR, btMS, btMPlus, btMMinus;
        private System.Windows.Forms.Button bt7, bt8, bt9, btDivide, btPercent;
        private System.Windows.Forms.Button bt4, bt5, bt6, btMult, btReciprocal;
        private System.Windows.Forms.Button bt1, bt2, bt3, btMinus, btEquals;
        private System.Windows.Forms.Button bt0, btDot, btPlus;
        private System.Windows.Forms.Button btClear, btClearEntry, btBackspace, btNegate, btSqrt;
        private System.Windows.Forms.TextBox txtDisplay;
    }
}