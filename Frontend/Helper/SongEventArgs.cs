using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIMBUS__MUSIC_PLAYER_.Helper
{
    public class SongEventArgs : EventArgs
    {
        public string SongName { get; }
        public string ArtistName { get; }

        public SongEventArgs(string songName, string artistName)
        {
            SongName = songName;
            ArtistName = artistName;
        }
    }
}
