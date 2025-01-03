using MySql.Data.MySqlClient;
using NimbusClassLibrary.Model;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimbusClassLibrary.Data
{
    public class DbConnect
    {

        static MySqlConnection conn = new MySqlConnection();
        #region Singleton Instance
        private DbConnect()
        {
            string connString =
                "Data Source = 153.92.15.21;" +
                " Initial Catalog = u936666569_Nimbus;" +
                " Persist Security Info = True;" +
                " User ID = u936666569_Nimbus;" +
                " Password = Haduken@123456;";
            try
            {
                conn.ConnectionString = connString;

                conn.Open();

                GetAllArtists();
                GetAllPlaylists();
                GetAllSongs();
                GetAllPlaylistSongs();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private static DbConnect instance = null;
        public static DbConnect Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DbConnect();
                }
                return instance;
            }
        }
        #endregion
        #region Connection Options
        public MySqlConnection GetConnection()
        {
            return conn;
        }
        public MySqlConnection RefreshConnection()
        {
            conn.Close();
            instance = new DbConnect();

            return conn;
        }
        #endregion

        #region Get all tables
        private static void GetAllSongs()
        {
            
            MySqlCommand mySqlCommand = new MySqlCommand
                (
                    "SELECT * " +
                    "FROM Songs"
                , conn);

            DbDataReader reader = mySqlCommand.ExecuteReader();

            while (reader.Read())
            {
                Song song = new Song()
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Title = reader["Title"].ToString(),
                    IsFavorite = reader["IsFavorite"].ToString() == "1",
                    File_Path = reader["File_Path"].ToString(),
                    Artist = DBContext.artists.FirstOrDefault
                    (i => i.Id == Convert.ToInt32(reader["Artist_id"]))
                };
                if (reader["Duration"] != DBNull.Value) 
                    song.Duration = TimeSpan.ParseExact(reader["Duration"].ToString(), @"hh\:mm\:ss\.fffffff", null);
                DBContext.songs.Add(song);
            }
            reader.Close();
        }
        private static void GetAllArtists()
        {

            MySqlCommand mySqlCommand = new MySqlCommand
                (
                    "SELECT * " +
                    "FROM Artists"
                , conn);

            DbDataReader reader = mySqlCommand.ExecuteReader();

            while (reader.Read())
            {
                Artist artist = new Artist()
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Display_Name = reader["Display_Name"].ToString(),
                    IsFollowed = reader["IsFollowed"].ToString() == "1",
                    IsFavorite = reader["IsFavorite"].ToString() == "1",
                    Profile_Pic = reader["Profile_Pic"].ToString()
                };

                DBContext.artists.Add(artist);
            }
            reader.Close();
        }
        
        private static void GetAllPlaylists()
        {

            MySqlCommand mySqlCommand = new MySqlCommand
                (
                    "SELECT * " +
                    "FROM Playlists"
                , conn);

            DbDataReader reader = mySqlCommand.ExecuteReader();

            while (reader.Read())
            {
                Playlist playlist = new Playlist()
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    Thumbnail = Encoding.ASCII.GetBytes(reader["Thumbnail"].ToString())
                };

                DBContext.playlists.Add(playlist);
            }
            reader.Close();
        }
        private static void GetAllPlaylistSongs()
        {

            MySqlCommand mySqlCommand = new MySqlCommand
                (
                    "SELECT * " +
                    "FROM Playlist_Songs"
                , conn);

            DbDataReader reader = mySqlCommand.ExecuteReader();

            while (reader.Read())
            {
                PlaylistSongs playlistsongs = new PlaylistSongs()
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Playlist = DBContext.playlists.FirstOrDefault(
                        i => i.Id == Convert.ToInt32(reader["Playlist_id"])),
                    Song = DBContext.songs.FirstOrDefault(
                        i => i.Id == Convert.ToInt32(reader["Song_id"]))
                };

                DBContext.playlistSongs.Add(playlistsongs);
            }
            reader.Close();
        }
        #endregion
    }
}
