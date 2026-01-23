using Battle_City.Class_game;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Battle_City
{
    public partial class Play_Level : Form
    {
        Random rand = new Random();
        Player player;
        List<Bullet> bullets = new List<Bullet>();
        List<Enemy> enemies = new List<Enemy>();
        List<Explosion> explosions = new List<Explosion>();
        List<Wall> walls = new List<Wall>();

        int playerLives = 3;
        string customMapPath = "";

        // Khai báo biến ảnh
        Image imgTank, imgEnemy, imgBullet, imgExplosion, imgWall, imgSteel, imgWater;

        public Play_Level(string filePath)
        {
            InitializeComponent();
            this.customMapPath = filePath;
            LoadAssets();
            SetupGame();
            StartLevel();
        }

        public Play_Level()
        {
            InitializeComponent();
            LoadAssets();
            SetupGame();
            StartLevel();
        }

        private void LoadAssets()
        {
            try
            {
                if (File.Exists("tank.png")) imgTank = Image.FromFile("tank.png");
                if (File.Exists("enemy.png")) imgEnemy = Image.FromFile("enemy.png");
                if (File.Exists("bullet.png")) imgBullet = Image.FromFile("bullet.png");
                if (File.Exists("explosion.png")) imgExplosion = Image.FromFile("explosion.png");
                if (File.Exists("wall.png")) imgWall = Image.FromFile("wall.png");
                if (File.Exists("steel.png")) imgSteel = Image.FromFile("steel.png");
                if (File.Exists("water.png")) imgWater = Image.FromFile("water.png");
            }
            catch { }
        }

        private void SetupGame()
        {
            if (pnlMap != null)
            {
                typeof(Panel).InvokeMember("DoubleBuffered",
                    BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                    null, pnlMap, new object[] { true });

                pnlMap.Paint += pnlMap_Paint;
            }

            timer1.Interval = 20;
            timer1.Tick += GameLoop;
            timer1.Start();
        }

        private void StartLevel()
        {
            player = new Player(240, 520);
            bullets.Clear();
            enemies.Clear();
            walls.Clear();
            explosions.Clear();

            GenerateMap();

            int enemyCount = 3;
            if (customMapPath == "Level2") enemyCount = 4;
            if (customMapPath == "Level3") enemyCount = 5;

            for (int i = 0; i < enemyCount; i++)
                enemies.Add(new Enemy(i * 150 + 50, 20));
        }

        private void GenerateMap()
        {
            if (!string.IsNullOrEmpty(customMapPath) && File.Exists(customMapPath))
            {
                string[] lines = File.ReadAllLines(customMapPath);
                for (int r = 0; r < lines.Length; r++)
                {
                    string[] cols = lines[r].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    for (int c = 0; c < cols.Length; c++)
                    {
                        if (int.TryParse(cols[c], out int val))
                        {
                            int x = c * 40; int y = r * 40;
                            if (val == 1) walls.Add(new Wall(x, y, 0));
                            if (val == 2) walls.Add(new Wall(x, y, 1));
                            if (val == 3) walls.Add(new Wall(x, y, 2));
                        }
                    }
                }
            }
            else
            {
                if (customMapPath == "Level1") CreateMapLevel1();
                else if (customMapPath == "Level2") CreateMapLevel2();
                else if (customMapPath == "Level3") CreateMapLevel3();
                else CreateMapLevel1();
            }
        }

        private void CreateMapLevel1()
        {
            walls.Add(new Wall(200, 520, 0));
            walls.Add(new Wall(200, 480, 0));
            walls.Add(new Wall(240, 480, 0));
            walls.Add(new Wall(280, 480, 0));
            walls.Add(new Wall(280, 520, 0));
            for (int i = 0; i < 5; i++)
            {
                walls.Add(new Wall(100 + i * 40, 200, 0));
                walls.Add(new Wall(300 + i * 40, 300, 0));
            }
            walls.Add(new Wall(100, 100, 1));
            walls.Add(new Wall(400, 100, 1));
        }

        private void CreateMapLevel2()
        {
            walls.Add(new Wall(200, 520, 1));
            walls.Add(new Wall(200, 480, 1));
            walls.Add(new Wall(240, 480, 1));
            walls.Add(new Wall(280, 480, 1));
            walls.Add(new Wall(280, 520, 1));
            walls.Add(new Wall(220, 240, 2));
            walls.Add(new Wall(260, 240, 2));
            walls.Add(new Wall(300, 240, 2));
            for (int y = 0; y < 400; y += 80)
            {
                walls.Add(new Wall(150, y, 1));
                walls.Add(new Wall(350, y, 1));
            }
        }

        private void CreateMapLevel3()
        {
            for (int x = 40; x < 500; x += 80)
            {
                for (int y = 40; y < 400; y += 80)
                {
                    walls.Add(new Wall(x, y, 0));
                }
            }
            walls.Add(new Wall(200, 520, 0));
            walls.Add(new Wall(200, 480, 0));
            walls.Add(new Wall(240, 480, 0));
            walls.Add(new Wall(280, 480, 0));
            walls.Add(new Wall(280, 520, 0));
        }

        private void GameLoop(object sender, EventArgs e)
        {
            UpdateLogic();
            if (pnlMap != null) pnlMap.Invalidate();
        }

        private void UpdateLogic()
        {
            // 1. Đạn
            for (int i = bullets.Count - 1; i >= 0; i--)
            {
                bullets[i].Move();
                if (bullets[i].X < 0 || bullets[i].X > pnlMap.Width ||
                    bullets[i].Y < 0 || bullets[i].Y > pnlMap.Height)
                {
                    bullets.RemoveAt(i);
                }
            }

            // 2. Kẻ địch
            foreach (var en in enemies)
            {
                en.MoveAI(pnlMap.Width, pnlMap.Height, walls, player);
                if (rand.Next(100) < 2)
                {
                    bullets.Add(new Bullet(en.X + 15, en.Y + 15, en.Dir, true));
                    // SoundManager.PlaySound("shoot.wav"); // Bật nếu muốn nghe tiếng địch bắn
                }
            }

            // 3. Va chạm
            CheckCollisions();

            // 4. Nổ
            for (int i = explosions.Count - 1; i >= 0; i--)
            {
                explosions[i].Update();
                if (explosions[i].IsFinished) explosions.RemoveAt(i);
            }

            // Kiểm tra thắng
            if (enemies.Count == 0)
            {
                GameWin();
            }
        }

        private void CheckCollisions()
        {
            for (int i = bullets.Count - 1; i >= 0; i--)
            {
                Rectangle bRect = new Rectangle(bullets[i].X, bullets[i].Y, 10, 10);

                // Va chạm tường
                for (int j = walls.Count - 1; j >= 0; j--)
                {
                    if (bRect.IntersectsWith(walls[j].Rect))
                    {
                        if (walls[j].Type == 0)
                        {
                            walls.RemoveAt(j);
                            // SoundManager.PlaySound("explosion.wav"); // Có thể thêm tiếng vỡ gạch
                        }
                        if (walls[j].Type != 2)
                        {
                            bullets.RemoveAt(i);
                            goto NextBullet;
                        }
                    }
                }

                // Đạn trúng địch
                if (!bullets[i].IsEnemyBullet)
                {
                    for (int j = enemies.Count - 1; j >= 0; j--)
                    {
                        if (bRect.IntersectsWith(enemies[j].Rect))
                        {
                            // --- ÂM THANH NỔ ---
                            SoundManager.PlaySound("explosion.mp3");

                            explosions.Add(new Explosion(enemies[j].X, enemies[j].Y));
                            enemies.RemoveAt(j);
                            bullets.RemoveAt(i);
                            goto NextBullet;
                        }
                    }
                }
                // Đạn trúng người chơi
                else if (player != null)
                {
                    if (bRect.IntersectsWith(player.Rect))
                    {
                        // --- ÂM THANH NỔ ---
                        SoundManager.PlaySound("explosion.mp3");

                        explosions.Add(new Explosion(player.X, player.Y));
                        playerLives--;
                        player.ResetPosition(240, 520);
                        bullets.RemoveAt(i);

                        if (playerLives <= 0) GameOver();
                        goto NextBullet;
                    }
                }
            NextBullet:;
            }
        }

        private void GameOver()
        {
            timer1.Stop();
            MessageBox.Show("GAME OVER! BẠN ĐÃ THUA.");
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void GameWin()
        {
            timer1.Stop();

            // --- ÂM THANH CHIẾN THẮNG ---
            SoundManager.PlayMusic("win.mp3");

            MessageBox.Show("CHÚC MỪNG! BẠN ĐÃ CHIẾN THẮNG MÀN " + customMapPath);

            SoundManager.StopMusic(); // Dừng nhạc thắng để qua màn sau

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void pnlMap_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            foreach (var w in walls)
            {
                if (w.Type == 0)
                {
                    if (imgWall != null) g.DrawImage(imgWall, w.Rect);
                    else g.FillRectangle(Brushes.Brown, w.Rect);
                }
                else if (w.Type == 1)
                {
                    if (imgSteel != null) g.DrawImage(imgSteel, w.Rect);
                    else g.FillRectangle(Brushes.Gray, w.Rect);
                }
                else
                {
                    if (imgWater != null) g.DrawImage(imgWater, w.Rect);
                    else g.FillRectangle(Brushes.Blue, w.Rect);
                }
            }

            if (player != null)
                DrawRotated(g, imgTank, player.X, player.Y, player.Dir, Color.Yellow);

            foreach (var en in enemies)
                DrawRotated(g, imgEnemy, en.X, en.Y, en.Dir, Color.Red);

            foreach (var b in bullets)
            {
                if (imgBullet != null) g.DrawImage(imgBullet, b.X, b.Y, 10, 10);
                else g.FillEllipse(b.IsEnemyBullet ? Brushes.Red : Brushes.White, b.X, b.Y, 10, 10);
            }

            foreach (var ex in explosions)      
            {
                if (imgExplosion != null) g.DrawImage(imgExplosion, ex.X, ex.Y, 40, 40);
                else g.FillEllipse(Brushes.Orange, ex.X, ex.Y, 40, 40);
            }
        }

        private void DrawRotated(Graphics g, Image img, int x, int y, string dir, Color backupColor)
        {
            var state = g.Save();
            g.TranslateTransform(x + 20, y + 20);

            float angle = 0;
            if (dir == "RIGHT") angle = 90;
            else if (dir == "DOWN") angle = 180;
            else if (dir == "LEFT") angle = 270;
            g.RotateTransform(angle);

            if (img != null)
            {
                g.DrawImage(img, -20, -20, 40, 40);
            }
            else
            {
                using (Brush b = new SolidBrush(backupColor))
                    g.FillRectangle(b, -20, -20, 40, 40);
                using (Pen p = new Pen(Color.Black, 3))
                    g.DrawLine(p, 0, -5, 0, -25);
            }
            g.Restore(state);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (player == null) return;

            if (e.KeyCode == Keys.Space)
            {
                bullets.Add(new Bullet(player.X + 15, player.Y + 15, player.Dir, false));

                // --- ÂM THANH BẮN ---
                SoundManager.PlaySound("shoot.mp3");
            }
            else
                player.Control(e.KeyCode, pnlMap.Width, pnlMap.Height, walls);
        }
    }
}