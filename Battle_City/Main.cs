using System;
using System.Drawing;
using System.Windows.Forms;
using Battle_City.Class_game; // Bắt buộc có dòng này để dùng SoundManager

namespace Battle_City
{
    public partial class Main : Form
    {
        private System.Windows.Forms.Timer blinkTimer;
        private bool isTextVisible = true;
        private Label lblPressStart;

        public Main()
        {
            InitializeComponent();
            CustomDesign();
        }

        private void CustomDesign()
        {
            // 1. Cấu hình Form cơ bản
            this.Text = "BATTLE CITY - TANK 1990";
            this.Icon = SystemIcons.Application;
            this.BackColor = Color.Black;
            this.DoubleBuffered = true;
            this.StartPosition = FormStartPosition.CenterScreen;

            // Tìm container
            Control container = null;
            try
            {
                Control[] found = this.Controls.Find("pnlMenu", true);
                if (found.Length > 0) container = found[0];
            }
            catch { }

            if (container == null) container = this;

            // 2. Hiệu ứng bóng đổ
            if (this.Controls.Find("label1", true).Length > 0 || label1 != null)
            {
                Label shadow = new Label();
                shadow.Text = label1.Text;
                shadow.Font = label1.Font;
                shadow.ForeColor = Color.DarkRed;
                shadow.AutoSize = true;
                shadow.Location = new Point(label1.Location.X + 4, label1.Location.Y + 4);
                shadow.BackColor = Color.Transparent;

                container.Controls.Add(shadow);
                shadow.SendToBack();
            }

            // 3. Label nhấp nháy
            lblPressStart = new Label();
            lblPressStart.Text = "PRESS ENTER TO START";
            lblPressStart.Font = new Font("Consolas", 14, FontStyle.Bold);
            lblPressStart.ForeColor = Color.White;
            lblPressStart.AutoSize = true;

            int xPos = (this.ClientSize.Width - lblPressStart.PreferredWidth) / 2;
            int yPos = this.ClientSize.Height - 100;

            lblPressStart.Location = new Point(xPos > 0 ? xPos : 100, yPos);
            lblPressStart.BackColor = Color.Transparent;
            container.Controls.Add(lblPressStart);

            // 4. Timer
            blinkTimer = new System.Windows.Forms.Timer();
            blinkTimer.Interval = 500;
            blinkTimer.Tick += (s, e) => {
                isTextVisible = !isTextVisible;
                lblPressStart.Visible = isTextVisible;
            };
            blinkTimer.Start();

            // 5. Phím tắt
            this.KeyPreview = true;
            this.KeyDown += Main_KeyDown;

            // --- THÊM NHẠC INTRO ---
            // Hãy chắc chắn file nhạc tên là "intro.wav" hoặc "intro.mp3" trong thư mục Debug
            SoundManager.PlayMusic("intro.mp3");
        }

        // --- CÁC SỰ KIỆN NÚT BẤM ---

        private void btnStart_Click(object sender, EventArgs e)
        {
            blinkTimer.Stop();

            // --- DỪNG NHẠC KHI VÀO GAME ---
            SoundManager.StopMusic();

            this.Hide();

            // --- LOGIC QUA MÀN MỚI ---
            int currentLevel = 1;

            while (true) // Vòng lặp chơi game
            {
                // Tạo màn chơi với tên tăng dần: Level1, Level2, Level3...
                Play_Level gameForm = new Play_Level("Level" + currentLevel);

                // Mở game và chờ kết quả trả về
                DialogResult result = gameForm.ShowDialog();

                // Kiểm tra kết quả:
                // - DialogResult.OK: Thắng -> Qua màn
                // - DialogResult.Cancel: Thua/Thoát -> Dừng
                if (result == DialogResult.OK)
                {
                    currentLevel++; // Tăng level lên
                }
                else
                {
                    break; // Thua hoặc thoát thì dừng vòng lặp
                }
            }

            // Sau khi thoát vòng lặp (nghĩa là đã thua), tắt ứng dụng
            Application.Exit();
        }

        private void btnConstruction_Click(object sender, EventArgs e)
        {
            this.Hide();
            MapEditor editor = new MapEditor();
            editor.ShowDialog();
            this.Show();

            // Mở lại nhạc intro khi quay về menu
            SoundManager.PlayMusic("intro.mp3");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnStart_Click(sender, e);
            if (e.KeyCode == Keys.Escape) Application.Exit();
        }
    }
}