using NimbusClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimbusClassLibrary.Models
{
    public class Playlist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] Thumbnail { get; set; }
    }
}
