using System;
using System.Collections.Generic;
using System.Drawing;

namespace Battle_City.Class_game
{
    public class Enemy
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Dir { get; set; } = "DOWN";
        public int Speed { get; set; } = 3; // Tốc độ địch chậm hơn người chơi xíu

        private Random rand = new Random();

        public Rectangle Rect => new Rectangle(X, Y, 40, 40);

        public Enemy(int x, int y)
        {
            X = x;
            Y = y;
            Dir = "DOWN";
        }

        // AI Đơn giản: Đi thẳng, gặp tường thì quay đầu ngẫu nhiên
        public void MoveAI(int mapW, int mapH, List<Wall> walls, Player player)
        {
            int oldX = X;
            int oldY = Y;

            // Di chuyển theo hướng hiện tại
            if (Dir == "UP") Y -= Speed;
            else if (Dir == "DOWN") Y += Speed;
            else if (Dir == "LEFT") X -= Speed;
            else if (Dir == "RIGHT") X += Speed;

            // Kiểm tra va chạm biên
            bool hit = false;
            if (X < 0 || Y < 0 || X > mapW - 40 || Y > mapH - 40) hit = true;

            // Kiểm tra va chạm tường
            if (!hit)
            {
                Rectangle rect = new Rectangle(X, Y, 40, 40);
                foreach (var w in walls)
                {
                    if (rect.IntersectsWith(w.Rect))
                    {
                        hit = true;
                        break;
                    }
                }
            }

            // Kiểm tra va chạm người chơi (không được đi xuyên qua người chơi)
            if (!hit && player != null)
            {
                if (new Rectangle(X, Y, 40, 40).IntersectsWith(player.Rect)) hit = true;
            }

            // Xử lý khi va chạm: Quay lại vị trí cũ và đổi hướng ngẫu nhiên
            if (hit)
            {
                X = oldX;
                Y = oldY;
                ChangeDirection();
            }
            else
            {
                // Thỉnh thoảng tự đổi hướng dù không va chạm (cho đỡ nhàm chán)
                if (rand.Next(100) < 2) ChangeDirection();
            }
        }

        private void ChangeDirection()
        {
            string[] dirs = { "UP", "DOWN", "LEFT", "RIGHT" };
            Dir = dirs[rand.Next(4)];
        }
    }
}