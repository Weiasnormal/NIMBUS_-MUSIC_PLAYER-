using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimbusClassLibrary.Models
{
    public class Artist
    {
        public int Id { get; set; }
        public string Display_Name { get; set; }
        public bool IsFollowed { get; set; }
        public bool IsFavorite { get; set; }
        public byte[] Profile_Pic { get; set; }
    }
}
