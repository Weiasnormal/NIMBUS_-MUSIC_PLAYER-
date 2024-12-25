using NimbusClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimbusClassLibrary.Model
{
    public class Song
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsFavorite { get; set; }
        public string File_Path { get; set; }
        public Artist Artist { get; set; }

        public override string ToString()
        {
            return $"ID          : {Id} " +
                $"\n Title       : {Title}" +
                $"\n Is Favorite : {IsFavorite}" +
                $"\n File Path   : {File_Path}" +
                $"\n Artist Name : {Artist.Display_Name}";
        }
    }
}
