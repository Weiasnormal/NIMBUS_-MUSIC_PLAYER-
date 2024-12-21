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
            data.Data.DbConnect dbConnect = new data.Data.DbConnect();
            Console.WriteLine("Connected");

            Console.ReadLine(); 
        }
    }
}
