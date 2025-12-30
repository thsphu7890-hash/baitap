using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Battle_City
{
    public class Enemy
    {
        public int X, Y;
        public string Dir = "DOWN";
        public int Speed = 8;

        // AI: Thời gian chờ để đổi hướng (giúp đi dứt khoát)
        public int ChangeDirCooldown = 0;

        public Enemy(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Rectangle Rect => new Rectangle(X, Y, 40, 40);
    }
}
