using MySql.Data.MySqlClient;
using NimbusClassLibrary.Data;
using NimbusClassLibrary.Helpers;
using NimbusClassLibrary.Interfaces;
using NimbusClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimbusClassLibrary.Controller
{
    public class PlaylistController<t> : IController<t> where t : Playlist
    {
        MySqlConnection conn;
        DbConnect db;

        public PlaylistController()
        {
            db = DbConnect.Instance;
            conn = db.GetConnection();
        }

        public bool Create<T>(T t) where T : t
        {
            conn.Open();
            Playlist playlist = t as Playlist;
            DBContext.playlists.Add(playlist);

            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "INSERT INTO Playlists ( Name, Thumbnail ) " +
                "VALUES ( @Name, @Thumbnail )";
            command.Parameters.Add("@Name", MySqlDbType.VarChar).Value = playlist.Name;
            command.Parameters.Add("@Thumbnail", MySqlDbType.VarChar).Value = Convert.ToInt32(playlist.Thumbnail);

            int res = command.ExecuteNonQuery();
            conn.Close();
            return Return.OK(res);
        }

        public bool Delete<T>(T t) where T : t
        {
            conn.Open();
            Playlist playlist = t as Playlist;
            DBContext.playlists.Remove(DBContext.playlists.FirstOrDefault(i => i.Id == playlist.Id));

            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "DELETE FROM Playlists " +
                                  "WHERE ID = @Id";
            command.Parameters.Add("@Id", MySqlDbType.Int32).Value = playlist.Id;

            int res = command.ExecuteNonQuery();
            conn.Close ();
            return Return.OK(res);
        }

        public IEnumerable<T> GetCollection<T>() where T : t
        {
            return DBContext.playlists as IEnumerable<T>;
        }

        public T GetSingle<T>(int id) where T : t
        {
            return (T)DBContext.playlists.FirstOrDefault(s => s.Id == id);
        }

        public bool Update<T>(T t) where T : t
        {
            conn.Open ();
            Playlist playlist = t as Playlist;
            DBContext.playlists.Remove(DBContext.playlists.FirstOrDefault(i => i.Id == playlist.Id));
            DBContext.playlists.Add(playlist);

            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "UPDATE Playlists SET " +
                                  "Name = @Name, Thumbnail = @Thumbnail " +
                                  "WHERE ID = @Id";
            command.Parameters.Add("@Id", MySqlDbType.Int32).Value = playlist.Id;
            command.Parameters.Add("@Name", MySqlDbType.VarChar).Value = playlist.Name;
            command.Parameters.Add("@Thumbnail", MySqlDbType.Text).Value = playlist.Thumbnail;

            int res = command.ExecuteNonQuery();
            conn.Close ();
            return Return.OK(res);
        }
    }
}
