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
    public partial class ArtistPlaceholder : UserControl
    {
        private string thumbnail;
        private Artist artist;

        public ArtistPlaceholder()
        {
            InitializeComponent();
        }

            public ArtistPlaceholder(string thumbnail, Artist artist)
        {
            InitializeComponent();
            this.thumbnail = thumbnail;
            this.artist = artist;

            ArtistPhoto.ImageLocation = thumbnail;
            TitleSonglbl.Text = artist.Display_Name;
        }


    }
}
