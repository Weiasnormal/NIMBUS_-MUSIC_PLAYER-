using NimbusClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimbusClassLibrary.Model
{
    public class PlaylistSongs
    {
        public int Id { get; set; }
        public Playlist Playlist { get; set; }
        public Song Song { get; set; }
    }
}
