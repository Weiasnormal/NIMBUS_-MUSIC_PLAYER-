using MySql.Data.MySqlClient;
using NimbusClassLibrary.Data;
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
        
        public SongController()
        {
            DbConnect db = DbConnect.Instance;
            conn = db.GetConnection();
        }
        public IEnumerable<Song> GetAllSongs()
        {
            return DBContext.songs.ToList();
        }
    }
}
