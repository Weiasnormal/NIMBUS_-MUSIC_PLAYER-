using Guna.UI2.WinForms;
using NimbusClassLibrary.Controller;
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
    public partial class ArtistsPanel : UserControl
    {
        public ArtistsPanel()
        {
            InitializeComponent();
            loadSongs();
        }

        public void loadSongs()
        {
            int songnum = 1;

            SongController<Song> controller = new SongController<Song>();
            List<Song> songs = (List<Song>)controller.GetCollection<Song>();
            foreach (Song song in songs)
            {
                var songControl = new ArtistPlaceholder(song.Artist.Profile_Pic, song.Artist);
                FlowlayoutPanelArtist.Controls.Add(songControl);

                songnum++;
            }

        }




        public Guna2TextBox SearchBars
        {
            get { return SearchBar; }
        }
        public Guna2ComboBox Dropdown_Artists
        {
            get { return Dropdown_Artist; }
        }
        public Guna2ComboBox Dropdown_Albums
        {
            get { return Dropdown_Album; }
        }
        public Guna2ComboBox Dropdown_Sorts
        {
            get { return Dropdown_Sort; }
        }
    }
}
