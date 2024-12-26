using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NimbusClassLibrary.Models
{
    public class Artist
    {
        public int Id { get; set; }
        public string Display_Name { get; set; }
        public bool IsFollowed { get; set; }
        public bool IsFavorite { get; set; }
        public byte[] Profile_Pic { get; set; }

        public override string ToString()
        {
            return $"ID          : {Id} " +
                $"\n Display name: {Display_Name}" +
                $"\n Is Followed : {IsFollowed}" +
                $"\n Is Favorite : {IsFavorite}" +
                $"\n Profile Pic : {Profile_Pic}";
        }
    }
}
