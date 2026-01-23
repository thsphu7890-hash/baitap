namespace Battle_City.Class_game
{
    public class Explosion
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Timer { get; set; } = 10; // Thời gian tồn tại (10 khung hình)
        public bool IsFinished => Timer <= 0; // Hết giờ thì xóa

        public Explosion(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Update()
        {
            Timer--;
        }
    }
}