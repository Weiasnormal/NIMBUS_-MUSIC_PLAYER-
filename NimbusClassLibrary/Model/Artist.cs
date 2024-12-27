using NimbusClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NimbusClassLibrary.Model
{
    public class Artist : IModel
    {
        public int Id { get; set; } = 0;
        public string Display_Name { get; set; } = string.Empty;
        public bool IsFollowed { get; set; } = false;
        public bool IsFavorite { get; set; } = false;
        public byte[] Profile_Pic { get; set; } = new byte[0];

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
