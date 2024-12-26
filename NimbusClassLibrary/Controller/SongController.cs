using MySql.Data.MySqlClient;
using NimbusClassLibrary.Data;
using NimbusClassLibrary.Helpers;
using NimbusClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimbusClassLibrary.Controller
{
    public class SongController
    {
        MySqlConnection conn;
        DbConnect db;

        public SongController()
        {
            db = DbConnect.Instance;
            conn = db.GetConnection();
        }
        public IEnumerable<Song> GetAllSongs()
        {
            return DBContext.songs.ToList();
        }
        public Song GetSong(int id)
        {
            return DBContext.songs.SingleOrDefault(s => s.Id == id);
        }
        public bool CreateSong(Song song)
        {
            DBContext.songs.Add(song);

            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "INSERT INTO Songs ( Title, IsFavorite, Artist_id, File_Path ) " +
                "VALUES ( @Title, @IsFavorite, @Artist_id, @File_Path )";
            command.Parameters.Add("@Title", MySqlDbType.VarChar).Value = song.Title;
            command.Parameters.Add("@IsFavorite", MySqlDbType.Int16).Value = Convert.ToInt32(song.IsFavorite);
            command.Parameters.Add("@Artist_id", MySqlDbType.Int32).Value = song.Artist.Id;
            command.Parameters.Add("@File_Path", MySqlDbType.Text).Value = song.File_Path;

            int res = command.ExecuteNonQuery();
            return Return.OK(res);
        }
        public bool UpdateSong(Song song)
        {
            DBContext.songs.Remove(DBContext.songs.FirstOrDefault(i => i.Id == song.Id));
            DBContext.songs.Add(song);

            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "UPDATE Songs SET " +
                                  "Title = @Title, IsFavorite = @IsFavorite, Artist_id = @Artist_id, " +
                                  "File_Path = @File_Path " +
                                  "WHERE ID = @Id";
            command.Parameters.Add("@Id", MySqlDbType.Int32).Value = song.Id;
            command.Parameters.Add("@Title", MySqlDbType.VarChar).Value = song.Title;
            command.Parameters.Add("@IsFavorite", MySqlDbType.Int16).Value = Convert.ToInt32(song.IsFavorite);
            command.Parameters.Add("@Artist_id", MySqlDbType.Int32).Value = song.Artist.Id;
            command.Parameters.Add("@File_Path", MySqlDbType.Text).Value = song.File_Path;

            int res = command.ExecuteNonQuery();
            return Return.OK(res);
        }
        public bool DeleteSong(Song song)
        {
            DBContext.songs.Remove(DBContext.songs.FirstOrDefault(i => i.Id == song.Id));

            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "DELETE FROM Songs " +
                                  "WHERE ID = @Id";
            command.Parameters.Add("@Id", MySqlDbType.Int32).Value = song.Id;

            int res = command.ExecuteNonQuery();
            return Return.OK(res);
        }
    }
}
