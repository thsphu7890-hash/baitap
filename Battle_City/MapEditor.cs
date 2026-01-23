using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Reflection;

namespace Battle_City
{
    public partial class MapEditor : Form
    {
        private const int ROWS = 13;
        private const int COLS = 13;
        private const int CELL_SIZE = 40;
        private int[,] mapData = new int[ROWS, COLS];
        private int currentTool = 1;

        private Image imgBrick, imgSteel, imgWater;

        public MapEditor()
        {
            InitializeComponent();
            LoadResources();
            BindEvents();
        }

        private void LoadResources()
        {
            try
            {
                // Kiểm tra và load đúng tên file .png từ thư mục của bạn
                if (File.Exists("wall.png")) imgBrick = Image.FromFile("wall.png");
                if (File.Exists("steel.png")) imgSteel = Image.FromFile("steel.png");
                if (File.Exists("water.png")) imgWater = Image.FromFile("water.png");
            }
            catch (Exception ex) { MessageBox.Show("Lỗi tải ảnh: " + ex.Message); }
        }

        private void BindEvents()
        {
            pnlGrid.Paint += PnlGrid_Paint;
            pnlGrid.MouseDown += PnlGrid_MouseDown;
            pnlGrid.MouseMove += PnlGrid_MouseMove;

            // Chống nháy hình khi vẽ
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                null, pnlGrid, new object[] { true });

            if (rbBrick != null) rbBrick.CheckedChanged += Tool_Changed;
            if (rbSteel != null) rbSteel.CheckedChanged += Tool_Changed;
            if (rbWater != null) rbWater.CheckedChanged += Tool_Changed;
            if (rbEraser != null) rbEraser.CheckedChanged += Tool_Changed;

            if (btnSave != null) btnSave.Click += BtnSave_Click;
            if (btnPlay != null) btnPlay.Click += BtnPlay_Click;
            if (btnBack != null) btnBack.Click += (s, e) => this.Close();
        }

        private void Tool_Changed(object sender, EventArgs e)
        {
            if (rbBrick.Checked) currentTool = 1;
            else if (rbSteel.Checked) currentTool = 2;
            else if (rbWater.Checked) currentTool = 3;
            else if (rbEraser.Checked) currentTool = 0;
        }

        private void DrawTile(MouseEventArgs e)
        {
            int c = e.X / CELL_SIZE;
            int r = e.Y / CELL_SIZE;

            if (c >= 0 && c < COLS && r >= 0 && r < ROWS)
            {
                if (e.Button == MouseButtons.Right) mapData[r, c] = 0;
                else if (e.Button == MouseButtons.Left) mapData[r, c] = currentTool;
                pnlGrid.Invalidate();
            }
        }

        private void PnlGrid_MouseDown(object sender, MouseEventArgs e) => DrawTile(e);
        private void PnlGrid_MouseMove(object sender, MouseEventArgs e) { if (e.Button != MouseButtons.None) DrawTile(e); }

        private void PnlGrid_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            for (int r = 0; r < ROWS; r++)
            {
                for (int c = 0; c < COLS; c++)
                {
                    Rectangle rect = new Rectangle(c * CELL_SIZE, r * CELL_SIZE, CELL_SIZE, CELL_SIZE);
                    int type = mapData[r, c];

                    if (type == 1) g.DrawImage(imgBrick ?? CreateBmp(Color.Brown), rect);
                    else if (type == 2) g.DrawImage(imgSteel ?? CreateBmp(Color.Gray), rect);
                    else if (type == 3) g.DrawImage(imgWater ?? CreateBmp(Color.Blue), rect);
                }
            }
            // Vẽ lưới mờ
            Pen p = new Pen(Color.FromArgb(40, Color.White));
            for (int i = 0; i <= ROWS; i++) g.DrawLine(p, 0, i * CELL_SIZE, COLS * CELL_SIZE, i * CELL_SIZE);
            for (int i = 0; i <= COLS; i++) g.DrawLine(p, i * CELL_SIZE, 0, i * CELL_SIZE, ROWS * CELL_SIZE);
        }

        private Bitmap CreateBmp(Color c)
        {
            Bitmap b = new Bitmap(CELL_SIZE, CELL_SIZE);
            using (Graphics g = Graphics.FromImage(b)) g.Clear(c);
            return b;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("custom_map.txt"))
                {
                    for (int r = 0; r < ROWS; r++)
                    {
                        string line = "";
                        for (int c = 0; c < COLS; c++) line += mapData[r, c] + " ";
                        sw.WriteLine(line.Trim());
                    }
                }
                MessageBox.Show("Đã lưu map thành công!");
            }
            catch (Exception ex) { MessageBox.Show("Lỗi lưu file: " + ex.Message); }
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            BtnSave_Click(null, null);
            this.Hide();
            Play_Level game = new Play_Level("custom_map.txt");
            game.ShowDialog();
            this.Show();
        }
    }
}