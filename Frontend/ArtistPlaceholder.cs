using NIMBUS__MUSIC_PLAYER_.Helper;
using NimbusClassLibrary.Controller;
using NimbusClassLibrary.Data;
using NimbusClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;

namespace NIMBUS__MUSIC_PLAYER_
{
    public partial class ArtistPlaceholder : UserControl
    {
        private Artist artist;

        public ArtistPlaceholder()
        {
            InitializeComponent();
        }

        public ArtistPlaceholder(Artist artist)
        {
            InitializeComponent();
            this.artist = artist;

            ArtistPhoto.ImageLocation = artist.Profile_Pic;
            TitleSonglbl.Text = artist.Display_Name;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            SongController<Song> songController = new SongController<Song>();

            foreach (Song s in songController.GetSongsByArtist<Song>(artist))
            {
                if (!NimbusClassLibrary.Helpers.GlobalLibraries.Playing_Song.Contains(s))
                {
                    NimbusClassLibrary.Helpers.GlobalLibraries.Playing_Song.AddLast(s);
                }

            }

            //
            Helper.Events.AddToQueue(sender, e);

            if(!PlayerState.IsPlaying) PlayerState.ForcePlayState();
        }
    }
}
