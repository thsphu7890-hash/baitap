namespace WinFormsApp2
{
    partial class Ex06
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
            bt_OK = new Button();
            SuspendLayout();
            // 
            // bt_OK
            // 
            bt_OK.Location = new Point(312, 171);
            bt_OK.Name = "bt_OK";
            bt_OK.Size = new Size(94, 29);
            bt_OK.TabIndex = 0;
            bt_OK.Text = "OK";
            bt_OK.UseVisualStyleBackColor = true;
            bt_OK.Click += bt_OK_Click;
            // 
            // Ex06
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bt_OK);
            Name = "Ex06";
            Text = "Ex06";
            ResumeLayout(false);
        }

        #endregion

        private Button bt_OK;
    }
}