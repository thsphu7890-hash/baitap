using System;
using System.Windows.Forms;
using WMPLib; // <--- 1. Thư viện để chạy MP3

namespace Battle_City
{
    public partial class Main : Form
    {
        // 2. Khai báo trình phát nhạc của Windows Media Player
        private WindowsMediaPlayer menuMusic;

        public Main()
        {
            InitializeComponent();

            // 3. Cài đặt nhạc
            try
            {
                menuMusic = new WindowsMediaPlayer();

                // Đường dẫn file nhạc (Nhớ copy file intro.mp3 vào thư mục bin/Debug)
                menuMusic.URL = "intro.mp3";

                // Cài đặt chế độ lặp lại (Loop)
                menuMusic.settings.setMode("loop", true);

                // Bắt đầu phát (Thường gán URL xong nó tự phát, nhưng gọi lệnh cho chắc)
                menuMusic.controls.play();
            }
            catch (Exception ex)
            {
                // Bỏ qua lỗi nếu không thấy file
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // 4. Dừng nhạc khi bấm Start
            if (menuMusic != null)
            {
                menuMusic.controls.stop();
            }

            // --- ĐOẠN NÀY GIỮ NGUYÊN ---
            Play_Level gameScreen = new Play_Level();
            this.Hide();
            gameScreen.ShowDialog();
            this.Show();
            // ---------------------------

            // 5. Phát lại nhạc khi quay về Menu
            if (menuMusic != null)
            {
                menuMusic.controls.play();
            }
        }
    }
}