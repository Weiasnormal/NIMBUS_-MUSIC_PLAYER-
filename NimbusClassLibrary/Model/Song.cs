using NimbusClassLibrary.Interfaces;
using NimbusClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimbusClassLibrary.Model
{
    public class Song : IModel
    {
        public int Id { get; set; } = 0;
        public string Title { get; set; } = string.Empty;
        public bool IsFavorite { get; set; } = false;
        public string File_Path { get; set; } = string.Empty;
        public Artist Artist { get; set; } = new Artist();
        public TimeSpan Duration { get; set; }
        public override string ToString()
        {
            return $"ID          : {Id} " +
                $"\n Title       : {Title}" +
                $"\n Is Favorite : {IsFavorite}" +
                $"\n File Path   : {File_Path}" +
                $"\n Artist Name : {Artist.Display_Name}";
        }
        /* public override bool Equals(object obj)
         {
             if (obj is Song other)
             {
                 return this.Title == other.Title; // Compare based on unique Id
             }
             return false;
         }

         public override int GetHashCode()
         {
             return Title.GetHashCode(); // Use the Id's hash code
         }
     }
     // Ensure Songs are uniquely identified by their ID*/
    }
}
