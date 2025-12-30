using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_City
{
    public class Explosion
    {
        public int X, Y;
        public int LifeTime = 10; // Thời gian tồn tại

        public Explosion(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}