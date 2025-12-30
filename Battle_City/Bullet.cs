    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Drawing; // Cần thư viện này để dùng Rectangle

namespace Battle_City
{
    public class Bullet
    {
        public int X, Y;
        public string Dir;
        public int Speed = 15;

        public Bullet(int x, int y, string dir)
        {
            X = x;
            Y = y;
            Dir = dir;
        }

        // Tạo khung va chạm 8x8
        public Rectangle Rect => new Rectangle(X, Y, 8, 8);
    }
}