using NimbusClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimbusClassLibrary.Data
{
    public class DBContext
    {
        public static ICollection<Song> songs = new List<Song>();
        public static ICollection<Artist> artists = new List<Artist>();
        public static ICollection<Playlist> playlists = new List<Playlist>();
        public static ICollection<PlaylistSongs> playlistSongs = new List<PlaylistSongs>();
    }
}
