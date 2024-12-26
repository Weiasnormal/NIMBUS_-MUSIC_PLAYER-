using NimbusClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimbusClassLibrary.Model
{
    public class Playlist
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = string.Empty;
        public byte[] Thumbnail { get; set; } = new byte[0];

        public override string ToString()
        {
            return $"ID         : {Id} " +
                $"\n Name       : {Name}" +
                $"\n Thumbnail  : {Thumbnail}";
        }
    }
}
