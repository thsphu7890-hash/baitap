using System;
using System.Data;
using System.Data.SqlClient; // Thư viện kết nối SQL
using System.Windows.Forms;

namespace Battle_City.Class_game
{
    public static class HighScoreManager
    {
        // --- QUAN TRỌNG: SỬA TÊN SERVER CHO ĐÚNG MÁY BẠN ---
        // Cách xem tên Server: Mở SQL Server, dòng 'Server name' lúc đăng nhập
        // Ví dụ: "Server=DESKTOP-ABC\\SQLEXPRESS;..." hoặc "Server=.;..."
        private static string connectionString = @"Server=.\SQLEXPRESS;Database=BattleCityDB;Trusted_Connection=True;";

        // 1. Lưu điểm mới
        public static void SaveScore(string playerName, int score)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO HighScores (PlayerName, Score) VALUES (@name, @score)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", playerName);
                        cmd.Parameters.AddWithValue("@score", score);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu điểm: " + ex.Message);
            }
        }

        // 2. Lấy Top 10 điểm cao nhất
        public static DataTable GetTopScores()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    // Lấy top 10, sắp xếp điểm từ cao xuống thấp
                    string query = "SELECT TOP 10 PlayerName, Score, DatePlayed FROM HighScores ORDER BY Score DESC";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lấy điểm: " + ex.Message);
            }
            return dt;
        }
    }
}