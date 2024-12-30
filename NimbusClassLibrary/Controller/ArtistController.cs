using MySql.Data.MySqlClient;
using NimbusClassLibrary.Data;
using NimbusClassLibrary.Helpers;
using NimbusClassLibrary.Interfaces;
using NimbusClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NimbusClassLibrary.Controller
{
    public class ArtistController : IController<Artist>
    {
        MySqlConnection conn;
        DbConnect db;

        public ArtistController()
        {
            db = DbConnect.Instance;
            conn = db.GetConnection();
        }

        public T GetSingle<T>(int id) where T : Artist
        {
            return (T)DBContext.artists.SingleOrDefault(a => a.Id == id);
        }

        public IEnumerable<T> GetCollection<T>() where T : Artist
        {
            return DBContext.artists as IEnumerable<T>;
        }

        public bool Create<T>(T t) where T : Artist
        {
            Artist artist = t as Artist;

            // Check if the artist already exists
            var existingArtist = DBContext.artists.FirstOrDefault(a => a.Display_Name.ToLower() == artist.Display_Name.ToLower());
            if (existingArtist != null)
            {
                // Artist already exists; no need to insert
                return true;
            }

            // Insert into database
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "INSERT INTO Artists (Display_Name, IsFollowed, IsFavorite) " +
                                  "VALUES (@DisplayName, @IsFollowed, @IsFavorite)";
            command.Parameters.Add("@DisplayName", MySqlDbType.VarChar).Value = artist.Display_Name;
            command.Parameters.Add("@IsFollowed", MySqlDbType.Bit).Value = artist.IsFollowed;
            command.Parameters.Add("@IsFavorite", MySqlDbType.Bit).Value = artist.IsFavorite;

            int res = command.ExecuteNonQuery();

            if (res > 0)
            {
                // Retrieve the auto-generated ID
                artist.Id = (int)command.LastInsertedId;

                // Add to in-memory collection
                DBContext.artists.Add(artist);
                return true;
            }

            return false;
        }

        public bool Update<T>(T t) where T : Artist
        {
            Artist artist = t as Artist;

            // Update in-memory collection
            DBContext.artists.Remove(DBContext.artists.FirstOrDefault(a => a.Id == artist.Id));
            DBContext.artists.Add(artist);

            // Update database
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "UPDATE Artists SET " +
                                  "Display_Name = @DisplayName, IsFollowed = @IsFollowed, IsFavorite = @IsFavorite " +
                                  "WHERE ID = @Id";
            command.Parameters.Add("@Id", MySqlDbType.Int32).Value = artist.Id;
            command.Parameters.Add("@DisplayName", MySqlDbType.VarChar).Value = artist.Display_Name;
            command.Parameters.Add("@IsFollowed", MySqlDbType.Bit).Value = artist.IsFollowed;
            command.Parameters.Add("@IsFavorite", MySqlDbType.Bit).Value = artist.IsFavorite;

            int res = command.ExecuteNonQuery();
            return Return.OK(res);
        }

        public bool Delete<T>(T t) where T : Artist
        {
            Artist artist = t as Artist;

            // Remove from in-memory collection
            DBContext.artists.Remove(DBContext.artists.FirstOrDefault(a => a.Id == artist.Id));

            // Delete from database
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "DELETE FROM Artists WHERE ID = @Id";
            command.Parameters.Add("@Id", MySqlDbType.Int32).Value = artist.Id;

            int res = command.ExecuteNonQuery();
            return Return.OK(res);
        }

        public int GetArtistIdByName(string artistName)
        {
            // Check if the artist exists in the database
            var artist = DBContext.artists.FirstOrDefault(a => a.Display_Name.ToLower() == artistName.ToLower());
            if (artist != null)
            {
                return artist.Id;
            }

            // If not found, return 0 or handle as needed
            return 0;
        }
    }
}
