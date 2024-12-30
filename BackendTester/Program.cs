using NimbusClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NimbusClassLibrary.Data;
using NimbusClassLibrary.Controller;

namespace BackendTester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SongController<Song> controller = new SongController<Song>();

            Song song = new Song()
            {
                Title = "TestInsert2",
                Artist = DBContext.artists.FirstOrDefault(i => i.Id == 0),
                IsFavorite = true,
                File_Path = "C:\\TestInsert2.mp3"
            };

            

            
            string result = controller.Create(song) ? "Updated" : "Error Inserting";
            Console.WriteLine(result);
            //foreach (Song s in controller.GetAllSongs())
            //{
            //    Console.WriteLine(s);
            //}

            Console.ReadKey();
        }
    }
}
