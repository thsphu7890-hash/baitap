using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Battle_City.Class_game
{
    public class Player
    {
        // Các thuộc tính cơ bản
        public int X { get; set; }
        public int Y { get; set; }
        public int Speed { get; set; } = 4; // Tốc độ di chuyển
        public string Dir { get; set; } = "UP"; // Hướng mặc định

        // Thuộc tính Rect dùng để xử lý va chạm (Hitbox)
        public Rectangle Rect
        {
            get { return new Rectangle(X, Y, 40, 40); }
        }

        // Hàm khởi tạo
        public Player(int x, int y)
        {
            this.X = x;
            this.Y = y;
            this.Dir = "UP";
        }

        // --- HÀM 1: RESET VỊ TRÍ (Sửa lỗi "Does not contain definition") ---
        public void ResetPosition(int newX, int newY)
        {
            this.X = newX;
            this.Y = newY;
            this.Dir = "UP"; // Khi hồi sinh thì quay đầu lên trên
        }

        // --- HÀM 2: ĐIỀU KHIỂN (Logic di chuyển) ---
        public void Control(Keys key, int mapWidth, int mapHeight, List<Wall> walls)
        {
            int oldX = X;
            int oldY = Y;

            // 1. Xác định hướng và di chuyển
            if (key == Keys.Left)
            {
                X -= Speed;
                Dir = "LEFT";
            }
            else if (key == Keys.Right)
            {
                X += Speed;
                Dir = "RIGHT";
            }
            else if (key == Keys.Up)
            {
                Y -= Speed;
                Dir = "UP";
            }
            else if (key == Keys.Down)
            {
                Y += Speed;
                Dir = "DOWN";
            }

            // 2. Giới hạn biên map (Không cho chạy ra ngoài màn hình)
            if (X < 0) X = 0;
            if (Y < 0) Y = 0;
            if (X > mapWidth - 40) X = mapWidth - 40;
            if (Y > mapHeight - 40) Y = mapHeight - 40;

            // 3. Xử lý va chạm tường (Nếu đâm tường thì lùi lại vị trí cũ)
            Rectangle newRect = new Rectangle(X, Y, 40, 40);
            foreach (var wall in walls)
            {
                if (newRect.IntersectsWith(wall.Rect))
                {
                    X = oldX;
                    Y = oldY;
                    break;
                }
            }
        }
    }
}