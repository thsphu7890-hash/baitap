namespace WinFormsApp2
{
    partial class Ex07
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
            Year = new Label();
            PhoneNumber = new Label();
            tb_Year = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // Year
            // 
            Year.AutoSize = true;
            Year.Location = new Point(95, 64);
            Year.Name = "Year";
            Year.Size = new Size(37, 20);
            Year.TabIndex = 0;
            Year.Text = "Year";
            // 
            // PhoneNumber
            // 
            PhoneNumber.AutoSize = true;
            PhoneNumber.Location = new Point(95, 178);
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.Size = new Size(104, 20);
            PhoneNumber.TabIndex = 1;
            PhoneNumber.Text = "PhoneNumber";
            // 
            // tb_Year
            // 
            tb_Year.Location = new Point(326, 57);
            tb_Year.Name = "tb_Year";
            tb_Year.Size = new Size(339, 27);
            tb_Year.TabIndex = 2;
            tb_Year.KeyPress += tbYear_KeyPress;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(326, 171);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(339, 27);
            textBox2.TabIndex = 3;
            // 
            // Ex07
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(tb_Year);
            Controls.Add(PhoneNumber);
            Controls.Add(Year);
            Name = "Ex07";
            Text = "Ex07";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Year;
        private Label PhoneNumber;
        private TextBox tb_Year;
        private TextBox textBox2;
    }
}