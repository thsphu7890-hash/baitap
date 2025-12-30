using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using WMPLib; // <--- 1. QUAN TRỌNG: Thêm thư viện nhạc

namespace Battle_City
{
    public partial class Play_Level : Form
    {
        // ==========================================
        // 1. BIẾN TOÀN CỤC
        // ==========================================

        System.Windows.Forms.Timer gameTimer = new System.Windows.Forms.Timer();
        Random rand = new Random();

        // <--- 2. THÊM BIẾN NHẠC NỀN
        WindowsMediaPlayer bgMusic;

        // Object Người chơi
        Player player;

        // Quản lý Game
        int level = 1;
        List<Bullet> bullets = new List<Bullet>();
        List<Enemy> enemies = new List<Enemy>();
        List<Explosion> explosions = new List<Explosion>();
        List<Wall> walls = new List<Wall>();

        // Hình ảnh
        Image imgTank, imgEnemy, imgBullet, imgExplosion, imgWall;

        // ==========================================
        // 2. KHỞI TẠO
        // ==========================================
        public Play_Level()
        {
            InitializeComponent();

            // Chống nháy hình
            typeof(Panel).InvokeMember("DoubleBuffered",
                BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                null, pnlMap, new object[] { true });

            this.DoubleBuffered = true;
            this.KeyPreview = true;

            LoadImages();
            StartLevel();

            // <--- 3. CẤU HÌNH & PHÁT NHẠC NỀN (BATTLE.MP3)
            try
            {
                bgMusic = new WindowsMediaPlayer();
                bgMusic.URL = "intro.mp3"; // Nhớ copy file này vào bin/Debug
                bgMusic.settings.setMode("loop", true); // Lặp lại liên tục
                bgMusic.settings.volume = 50; // Âm lượng nhạc nền vừa phải
                bgMusic.controls.play();
            }
            catch { }

            // Cấu hình Timer
            gameTimer.Interval = 20;
            gameTimer.Tick += GameLoop;
            gameTimer.Start();

            pnlMap.Paint += PnlMap_Paint;
        }

        // <--- 4. TẮT NHẠC KHI THOÁT MÀN CHƠI
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (bgMusic != null) bgMusic.controls.stop();
            base.OnFormClosing(e);
        }

        private void LoadImages()
        {
            try { imgTank = Image.FromFile("tank.png"); } catch { }
            try { imgEnemy = Image.FromFile("enemy.png"); } catch { }
            try { imgBullet = Image.FromFile("bullet.png"); } catch { }
            try { imgExplosion = Image.FromFile("explosion.png"); } catch { }
            try { imgWall = Image.FromFile("wall.png"); } catch { }
        }

        // ==========================================
        // 3. LOGIC GAME
        // ==========================================

        private void StartLevel()
        {
            // Reset Player
            player = new Player(260, 520);

            bullets.Clear();
            enemies.Clear();
            explosions.Clear();
            walls.Clear();

            if (this.Controls.ContainsKey("lblStage"))
                this.Controls["lblStage"].Text = level.ToString();

            // Tạo Tường
            GenerateMap();

            // Tạo Địch (Spawn Safe & Xa người chơi)
            int enemyCount = 2 + level;
            int attempts = 0;

            while (enemies.Count < enemyCount && attempts < 500)
            {
                attempts++;
                int ex = rand.Next(0, pnlMap.Width - 40);
                int ey = rand.Next(0, pnlMap.Height - 40); // Sinh ngẫu nhiên toàn bản đồ

                Rectangle spawnRect = new Rectangle(ex, ey, 40, 40);

                if (!IsHitWall(spawnRect) && DistanceToPlayer(ex, ey) > 150)
                {
                    enemies.Add(new Enemy(ex, ey));
                }
            }
        }

        private double DistanceToPlayer(int x, int y)
        {
            return Math.Sqrt(Math.Pow(x - player.X, 2) + Math.Pow(y - player.Y, 2));
        }

        private void GenerateMap()
        {
            int cols = pnlMap.Width / 40;
            int rows = pnlMap.Height / 40;
            int density = 10 + (level * 5);

            for (int r = 2; r < rows - 2; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    if (rand.Next(0, 100) < density)
                    {
                        if (Math.Abs((c * 40) - 260) > 80 || Math.Abs((r * 40) - 520) > 80)
                        {
                            walls.Add(new Wall(c * 40, r * 40));
                        }
                    }
                }
            }
        }

        private void GameLoop(object sender, EventArgs e)
        {
            // --- A. ĐẠN ---
            for (int i = bullets.Count - 1; i >= 0; i--)
            {
                Bullet b = bullets[i];
                if (b.Dir == "UP") b.Y -= b.Speed;
                if (b.Dir == "DOWN") b.Y += b.Speed;
                if (b.Dir == "LEFT") b.X -= b.Speed;
                if (b.Dir == "RIGHT") b.X += b.Speed;

                if (b.X < 0 || b.X > pnlMap.Width || b.Y < 0 || b.Y > pnlMap.Height)
                    bullets.RemoveAt(i);
            }

            // --- B. ĐỊCH (Smart AI) ---
            foreach (Enemy en in enemies)
            {
                if (en.ChangeDirCooldown > 0) en.ChangeDirCooldown--;

                int nextX = en.X;
                int nextY = en.Y;

                if (en.Dir == "UP") nextY -= en.Speed;
                else if (en.Dir == "DOWN") nextY += en.Speed;
                else if (en.Dir == "LEFT") nextX -= en.Speed;
                else if (en.Dir == "RIGHT") nextX += en.Speed;

                Rectangle nextRect = new Rectangle(nextX, nextY, 40, 40);
                bool hitWall = IsHitWall(nextRect);
                bool outOfBounds = nextX < 0 || nextY < 0 || nextX > pnlMap.Width - 40 || nextY > pnlMap.Height - 40;

                if (hitWall || outOfBounds)
                {
                    string newDir = FindFreeDirection(en);
                    en.Dir = newDir;
                    en.ChangeDirCooldown = rand.Next(20, 50);
                }
                else
                {
                    if (en.ChangeDirCooldown <= 0)
                    {
                        if (rand.Next(0, 100) < 2)
                        {
                            string newDir = FindFreeDirection(en);
                            en.Dir = newDir;
                            en.ChangeDirCooldown = rand.Next(30, 80);
                        }
                    }

                    if (en.Dir == "UP") en.Y -= en.Speed;
                    else if (en.Dir == "DOWN") en.Y += en.Speed;
                    else if (en.Dir == "LEFT") en.X -= en.Speed;
                    else if (en.Dir == "RIGHT") en.X += en.Speed;
                }
            }

            // --- C. VỤ NỔ ---
            for (int i = explosions.Count - 1; i >= 0; i--)
            {
                explosions[i].LifeTime--;
                if (explosions[i].LifeTime <= 0) explosions.RemoveAt(i);
            }

            // --- D. VA CHẠM ---
            CheckCollisions();

            // --- E. QUA MÀN ---
            if (enemies.Count == 0)
            {
                gameTimer.Stop();

                // Dừng nhạc nền khi thắng
                if (bgMusic != null) bgMusic.controls.stop();

                // [SOUND] Âm thanh thắng
                SoundManager.PlayWin();

                MessageBox.Show("LEVEL " + level + " COMPLETE!", "WINNER");
                level++;
                StartLevel();

                // Phát lại nhạc nền cho màn mới
                if (bgMusic != null) bgMusic.controls.play();

                gameTimer.Start();
            }

            pnlMap.Invalidate();
        }

        private string FindFreeDirection(Enemy en)
        {
            List<string> directions = new List<string> { "UP", "DOWN", "LEFT", "RIGHT" };
            int n = directions.Count;
            while (n > 1) { n--; int k = rand.Next(n + 1); string value = directions[k]; directions[k] = directions[n]; directions[n] = value; }

            foreach (string dir in directions)
            {
                if (en.Dir == "UP" && dir == "DOWN") continue;
                if (en.Dir == "DOWN" && dir == "UP") continue;
                if (en.Dir == "LEFT" && dir == "RIGHT") continue;
                if (en.Dir == "RIGHT" && dir == "LEFT") continue;

                int tx = en.X, ty = en.Y;
                if (dir == "UP") ty -= en.Speed;
                if (dir == "DOWN") ty += en.Speed;
                if (dir == "LEFT") tx -= en.Speed;
                if (dir == "RIGHT") tx += en.Speed;

                Rectangle tr = new Rectangle(tx, ty, 40, 40);

                if (!IsHitWall(tr) && tx >= 0 && ty >= 0 && tx <= pnlMap.Width - 40 && ty <= pnlMap.Height - 40)
                    return dir;
            }

            if (en.Dir == "UP") return "DOWN";
            if (en.Dir == "DOWN") return "UP";
            if (en.Dir == "LEFT") return "RIGHT";
            return "LEFT";
        }

        private bool IsHitWall(Rectangle objRect)
        {
            foreach (Wall w in walls)
            {
                if (objRect.IntersectsWith(w.Rect)) return true;
            }
            return false;
        }

        private void CheckCollisions()
        {
            for (int i = bullets.Count - 1; i >= 0; i--)
            {
                bool bulletRemoved = false;

                // Đạn vs Địch
                for (int j = enemies.Count - 1; j >= 0; j--)
                {
                    if (bullets[i].Rect.IntersectsWith(enemies[j].Rect))
                    {
                        // [SOUND] Âm thanh nổ
                        SoundManager.PlayExplode();

                        explosions.Add(new Explosion(enemies[j].X, enemies[j].Y));
                        enemies.RemoveAt(j);
                        bullets.RemoveAt(i);
                        bulletRemoved = true;
                        break;
                    }
                }
                if (bulletRemoved) continue;

                // Đạn vs Tường
                for (int k = walls.Count - 1; k >= 0; k--)
                {
                    if (bullets[i].Rect.IntersectsWith(walls[k].Rect))
                    {
                        // [SOUND] Âm thanh nổ
                        SoundManager.PlayExplode();

                        explosions.Add(new Explosion(walls[k].X, walls[k].Y));
                        walls.RemoveAt(k);
                        bullets.RemoveAt(i);
                        bulletRemoved = true;
                        break;
                    }
                }
            }
        }

        // ==========================================
        // 4. VẼ HÌNH
        // ==========================================
        private void PnlMap_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;

            foreach (Wall w in walls)
            {
                if (imgWall != null) g.DrawImage(imgWall, w.X, w.Y, 40, 40);
                else { g.FillRectangle(Brushes.Brown, w.X, w.Y, 40, 40); g.DrawRectangle(Pens.White, w.X, w.Y, 40, 40); }
            }

            foreach (Bullet b in bullets)
            {
                if (imgBullet != null) g.DrawImage(imgBullet, b.X, b.Y, 10, 10);
                else g.FillEllipse(Brushes.White, b.X, b.Y, 8, 8);
            }

            foreach (Enemy en in enemies)
            {
                if (imgEnemy != null) DrawRotated(g, imgEnemy, en.X, en.Y, en.Dir);
                else g.FillRectangle(Brushes.Red, en.X, en.Y, 40, 40);
            }

            if (imgTank != null) DrawRotated(g, imgTank, player.X, player.Y, player.Dir);
            else { g.FillRectangle(Brushes.Yellow, player.X, player.Y, 40, 40); }

            foreach (Explosion exp in explosions)
            {
                if (imgExplosion != null) g.DrawImage(imgExplosion, exp.X, exp.Y, 40, 40);
                else g.FillEllipse(Brushes.Orange, exp.X, exp.Y, 40, 40);
            }
        }

        private void DrawRotated(Graphics g, Image img, int x, int y, string dir)
        {
            using (Bitmap bmp = new Bitmap(img))
            {
                if (dir == "DOWN") bmp.RotateFlip(RotateFlipType.Rotate180FlipNone);
                if (dir == "LEFT") bmp.RotateFlip(RotateFlipType.Rotate270FlipNone);
                if (dir == "RIGHT") bmp.RotateFlip(RotateFlipType.Rotate90FlipNone);
                g.DrawImage(bmp, x, y, 40, 40);
            }
        }

        // ==========================================
        // 5. ĐIỀU KHIỂN
        // ==========================================
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            int nextX = player.X;
            int nextY = player.Y;
            string nextDir = player.Dir;

            if (e.KeyCode == Keys.Left) { nextX -= player.Speed; nextDir = "LEFT"; }
            else if (e.KeyCode == Keys.Right) { nextX += player.Speed; nextDir = "RIGHT"; }
            else if (e.KeyCode == Keys.Up) { nextY -= player.Speed; nextDir = "UP"; }
            else if (e.KeyCode == Keys.Down) { nextY += player.Speed; nextDir = "DOWN"; }
            else if (e.KeyCode == Keys.Space) { Shoot(); return; }
            else return;

            player.Dir = nextDir;

            if (nextX < 0) nextX = 0;
            if (nextY < 0) nextY = 0;
            if (nextX > pnlMap.Width - 40) nextX = pnlMap.Width - 40;
            if (nextY > pnlMap.Height - 40) nextY = pnlMap.Height - 40;

            if (!IsHitWall(new Rectangle(nextX, nextY, 40, 40)))
            {
                player.X = nextX;
                player.Y = nextY;
            }
        }

        private void Shoot()
        {
            // [SOUND] Âm thanh bắn
            SoundManager.PlayShoot();

            int bx = player.X + 15, by = player.Y + 15;
            if (player.Dir == "UP") by -= 10;
            if (player.Dir == "DOWN") by += 40;
            if (player.Dir == "LEFT") bx -= 10;
            if (player.Dir == "RIGHT") bx += 40;

            bullets.Add(new Bullet(bx, by, player.Dir));
        }
    }
}