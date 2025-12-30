using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Battle_City
{
    public class Player
    {
        public int X, Y;
        public string Dir = "UP";
        public int Speed = 8;

        public Player(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Rectangle Rect => new Rectangle(X, Y, 40, 40);
    }
}