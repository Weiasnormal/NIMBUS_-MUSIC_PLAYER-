using NimbusClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimbusClassLibrary.Helpers
{
    public static class GlobalLibraries
    {
        // Current queue of songs to be played (LinkedList)
        public static LinkedList<Song> Playing_Song = new LinkedList<Song>();

        // Stack to keep track of previously played songs
        public static Stack<Song> Previous_Songs = new Stack<Song>();

    }
}
