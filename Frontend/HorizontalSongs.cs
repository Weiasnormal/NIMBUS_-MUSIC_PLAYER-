using NimbusClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NIMBUS__MUSIC_PLAYER_
{
    public partial class HorizontalSongs : UserControl
    {
        public HorizontalSongs()
        {

        }
        public HorizontalSongs(int songnum, string title, string thumbnail, Artist artist, TimeSpan duration)
        {
            InitializeComponent();
            SongNumlbl.Text = songnum.ToString();
            Titlelbl.Text = title;
            Songpic.ImageLocation = thumbnail;
            Artistlbl.Text = artist.Display_Name;
            TotalTimelbl.Text = $"{duration.Minutes}:{duration.Seconds}";

        }

    }
}
