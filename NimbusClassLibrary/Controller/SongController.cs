using MySql.Data.MySqlClient;
using NimbusClassLibrary.Data;
using NimbusClassLibrary.Helpers;
using NimbusClassLibrary.Interfaces;
using NimbusClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimbusClassLibrary.Controller
{
    public class SongController<t> : IController<t> where t : Song
    {
        MySqlConnection conn;
        DbConnect db;

        public SongController()
        {
            db = DbConnect.Instance;
            conn = db.GetConnection();
        }
        public T GetSingle<T>(int id) where T : t
        {
            return (T)DBContext.songs.FirstOrDefault(s => s.Id == id) ;
        }
        public IEnumerable<T> GetCollection<T>() where T : t
        {
            return DBContext.songs as IEnumerable<T>;
        }
        public IEnumerable<Song> GetSongsByArtist<T>(Artist artist)
        {
            return DBContext.songs.Where(s => s.Artist == artist).ToList<Song>();
        }
        public bool Create<T>(T t) where T : t
        {
            Song song = t as Song;
            DBContext.songs.Add(song);

            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "INSERT INTO Songs ( Title, IsFavorite, Artist_id, File_Path, Duration ) " +
                "VALUES ( @Title, @IsFavorite, @Artist_id, @File_Path, @Duration )";
            command.Parameters.Add("@Title", MySqlDbType.VarChar).Value = song.Title;
            command.Parameters.Add("@IsFavorite", MySqlDbType.Int16).Value = Convert.ToInt32(song.IsFavorite);
            command.Parameters.Add("@Artist_id", MySqlDbType.Int32).Value = song.Artist.Id;
            command.Parameters.Add("@File_Path", MySqlDbType.Text).Value = song.File_Path;
            command.Parameters.Add("@Duration", MySqlDbType.VarChar).Value = song.Duration;

            int res = command.ExecuteNonQuery();
            return Return.OK(res);
        }
        public bool Update<T>(T t) where T : t
        {
            Song song = t as Song;
            DBContext.songs.Remove(DBContext.songs.FirstOrDefault(i => i.Id == song.Id));
            DBContext.songs.Add(song);

            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "UPDATE Songs SET " +
                                  "Title = @Title, IsFavorite = @IsFavorite, Artist_id = @Artist_id, " +
                                  "File_Path = @File_Path, Duration = @Duration" +
                                  "WHERE ID = @Id";
            command.Parameters.Add("@Id", MySqlDbType.Int32).Value = song.Id;
            command.Parameters.Add("@Title", MySqlDbType.VarChar).Value = song.Title;
            command.Parameters.Add("@IsFavorite", MySqlDbType.Int16).Value = Convert.ToInt32(song.IsFavorite);
            command.Parameters.Add("@Artist_id", MySqlDbType.Int32).Value = song.Artist.Id;
            command.Parameters.Add("@File_Path", MySqlDbType.Text).Value = song.File_Path;
            command.Parameters.Add("@Duration", MySqlDbType.VarChar).Value = song.Duration;

            int res = command.ExecuteNonQuery();
            return Return.OK(res);
        }
        public bool Delete<T>(T t) where T : t
        {
            Song song = t as Song;
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
