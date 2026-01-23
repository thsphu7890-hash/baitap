using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms; // Bắt buộc để dùng Keys

namespace Battle_City.Class_game
{
    public abstract class GameObject
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Dir { get; set; } = "UP";
        protected int speed;
        public Rectangle Rect => new Rectangle(X + 2, Y + 2, 36, 36);
    }

   

    // (Giữ nguyên các class Enemy, Bullet, Wall, Explosion khác nếu đã có)
    // Nếu chưa có thì bạn phải copy đầy đủ như các bài trước mình gửi.
}