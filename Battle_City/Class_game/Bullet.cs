namespace Battle_City.Class_game
{
    public class Bullet
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Dir { get; set; }
        public int Speed { get; set; } = 8;
        public bool IsEnemyBullet { get; set; } // True = Đạn địch, False = Đạn mình

        public Bullet(int x, int y, string dir, bool isEnemy)
        {
            X = x;
            Y = y;
            Dir = dir;
            IsEnemyBullet = isEnemy;
        }

        public void Move()
        {
            if (Dir == "UP") Y -= Speed;
            else if (Dir == "DOWN") Y += Speed;
            else if (Dir == "LEFT") X -= Speed;
            else if (Dir == "RIGHT") X += Speed;
        }
    }
}