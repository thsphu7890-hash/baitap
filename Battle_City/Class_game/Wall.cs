using System.Drawing;

namespace Battle_City.Class_game
{
    public class Wall
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Type { get; set; } // 0: Gạch, 1: Sắt, 2: Nước

        public Rectangle Rect => new Rectangle(X, Y, 40, 40);

        public Wall(int x, int y, int type)
        {
            X = x;
            Y = y;
            Type = type;
        }
    }
}