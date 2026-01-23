using System;
using System.IO;
using WMPLib; // Đảm bảo đã Add Reference WMPLib

namespace Battle_City.Class_game
{
    public static class SoundManager
    {
        // Player cho nhạc nền
        private static WindowsMediaPlayer playerBGM = new WindowsMediaPlayer();

        // --- 1. PHÁT NHẠC NỀN (Intro, Win) ---
        public static void PlayMusic(string filename)
        {
            try
            {
                if (File.Exists(filename))
                {
                    playerBGM.URL = Path.GetFullPath(filename); // Lấy đường dẫn đầy đủ
                    playerBGM.settings.setMode("loop", true);
                    playerBGM.settings.volume = 50;
                    playerBGM.controls.play();
                }
                else
                {
                    // Dòng này giúp bạn biết file nhạc có bị thiếu không
                    // System.Windows.Forms.MessageBox.Show("Không tìm thấy file: " + filename);
                }
            }
            catch { }
        }

        public static void StopMusic()
        {
            try { playerBGM.controls.stop(); } catch { }
        }

        // --- 2. PHÁT HIỆU ỨNG (Bắn, Nổ) - ĐÃ SỬA ĐỂ CHẠY ĐƯỢC MP3 ---
        public static void PlaySound(string filename)
        {
            try
            {
                if (File.Exists(filename))
                {
                    // Tạo một player mới mỗi lần bắn để không bị ngắt quãng
                    WindowsMediaPlayer sfx = new WindowsMediaPlayer();
                    sfx.URL = Path.GetFullPath(filename);
                    sfx.settings.volume = 100;
                    sfx.controls.play();
                }
            }
            catch { }
        }
    }
}