using NimbusClassLibrary.Interfaces;
using NimbusClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimbusClassLibrary.Model
{
    public class PlaylistSongs : IModel
    {
        public int Id { get; set; } = 0;
        public Playlist Playlist { get; set; } = new Playlist();
        public Song Song { get; set; } = new Song();
    }
}
