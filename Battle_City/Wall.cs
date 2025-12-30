using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_City
{
    public class Wall
    {
        public int X, Y;

        public Wall(int x, int y)
        {
            X = x;
            Y = y;
        }

        // Tường 40x40
        public Rectangle Rect => new Rectangle(X, Y, 40, 40);
    }
}
