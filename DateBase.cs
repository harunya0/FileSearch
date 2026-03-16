using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace SmartNote
{
    public class DateBase
    {
        static string db = "Data Source=notes.db";
        public static void Init()
        {
            using var con = new SQLiteConnection(db);
            con.Open();

            string sql =
                @"CREATE TABLE IF NOT EXISTS notes(
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                title TEXT,
                content TEXT,
                created TEXT,
                updated TEXT);";

            var cmd = new SQLiteCommand(sql, con);
            cmd.ExecuteNonQuery();
        }

        public static void Add(string title, string content)
        {
            using var con = new SQLiteConnection(db);
            con.Open();

            string sql = "INSERT INTO notes(title,content,created,updated) VALUES(@t,@c,@d,@d)";
            var cmd = new SQLiteCommand(sql, con);
            cmd.Parameters.AddWithValue("@t", title);
            cmd.Parameters.AddWithValue("@c", content);
            cmd.Parameters.AddWithValue("@d", DateTime.Now);

            cmd.ExecuteNonQuery();
        }

        public static List<Note> GetAll()
        {
            var list = new List<Note>();
            using var con = new SQLiteConnection(db);
            con.Open();

            string sql = "SELECT * FROM notes";
            var cmd = new SQLiteCommand(sql, con);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new Note
                {
                    Id = reader.GetInt32(0),
                    Title = reader.GetString(1),
                    Content = reader.GetString(2),
                    Created = Convert.ToDateTime(reader["created"]),
                    Updated = Convert.ToDateTime(reader["updated"])
                });
            }
            return list;
        }

        public static void Delete (int id)
        {
            using var con = new SQLiteConnection(db);
            con.Open();

            string sql = "DELETE FROM notes WHERE id=@id";

            var cmd = new SQLiteCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();
        }

        public static void Update(int id, string title, string content)
        {
            using var con = new SQLiteConnection(db);
            con.Open();

            string sql = "UPDATE notes SET title=@t, content=@c, updated=@d WHERE id=@id";

            var cmd = new SQLiteCommand(sql, con);

            cmd.Parameters.AddWithValue("@t", title);
            cmd.Parameters.AddWithValue("@c", content);
            cmd.Parameters.AddWithValue("@d", DateTime.Now);
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();
        }

        public static List<Note> Search(string word)
        {
            var list = new List<Note>();

            using var con = new SQLiteConnection(db);
            con.Open();

            string sql = "SELECT * FROM notes WHERE title LIKE @w OR content LIKE @w";

            var cmd = new SQLiteCommand(sql, con);
            cmd.Parameters.AddWithValue("@w", "%" + word + "%");

            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new Note
                {
                    Id = reader.GetInt32(0),
                    Title = reader.GetString(1),
                    Content = reader.GetString(2),
                    Created = Convert.ToDateTime(reader["created"]),
                    Updated = Convert.ToDateTime(reader["updated"])
                });
            }

            return list;
        }

        public static Note GetByTitle(string title)
        {
            using var con = new SQLiteConnection(db);
            con.Open();

            string sql = "SELECT * FROM notes WHERE title=@t";

            var cmd = new SQLiteCommand(sql, con);
            cmd.Parameters.AddWithValue("@t", title);

            var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                return new Note
                {
                    Id = reader.GetInt32(0),
                    Title = reader.GetString(1),
                    Content = reader.GetString(2),
                    Created = Convert.ToDateTime(reader["created"]),
                    Updated = Convert.ToDateTime(reader["updated"])
                };
            }
            return null;
        }
    }
}
