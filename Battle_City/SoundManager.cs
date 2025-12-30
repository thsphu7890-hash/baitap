using System;
using System.IO;
using WMPLib; // Cần Add Reference: Windows Media Player

namespace Battle_City
{
    public static class SoundManager
    {
        // Định nghĩa tên file
        private static string shootFile = "shoot.mp3";
        private static string explodeFile = "explosion.mp3";
        private static string winFile = "win.mp3";

        private static void PlaySound(string fileName)
        {
            if (File.Exists(fileName))
            {
                WindowsMediaPlayer player = new WindowsMediaPlayer();
                player.URL = fileName;
                player.settings.autoStart = false;
                player.settings.volume = 100;
                player.controls.play();
            }
        }

        public static void PlayShoot() => PlaySound(shootFile);
        public static void PlayExplode() => PlaySound(explodeFile);
        public static void PlayWin() => PlaySound(winFile);
    }
}