using NimbusClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using data = NimbusClassLibrary;

namespace BackendTester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            data.Controller.SongController controller = new data.Controller.SongController();

            foreach (Song s in controller.GetAllSongs())
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();
        }
    }
}
