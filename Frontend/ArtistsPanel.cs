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
        ArtistController ArtistController;
        public ArtistsPanel()
        {
            InitializeComponent();
            ArtistController = new ArtistController();
            loadSongs();
            loadArtists();

            // Additional initialization for your panel and scrollbar
            FlowlayoutPanelArtist.AutoScroll = true;
            ArtistsScrollbar.Scroll += (sender, e) =>
            {
                FlowlayoutPanelArtist.VerticalScroll.Value = ArtistsScrollbar.Value;
            };


            int numControls = FlowlayoutPanelArtist.Controls.Count;
            FlowlayoutPanelArtist.SuspendLayout();
            FlowlayoutPanelArtist.Controls.Clear();
            FlowlayoutPanelArtist.AutoScroll = true;
            FlowlayoutPanelArtist.VerticalScroll.Visible = false;

            this.Dock = DockStyle.Right;
            ArtistsScrollbar.Scroll += (sender, e) => { FlowlayoutPanelArtist.VerticalScroll.Value = ArtistsScrollbar.Value; };
            ArtistsScrollbar.Height = FlowlayoutPanelArtist.Height;
            ArtistsScrollbar.Visible = false;

            this.Controls.Add(ArtistsScrollbar);

            FlowlayoutPanelArtist   .ResumeLayout();

            // then update the form
            FlowlayoutPanelArtist.PerformLayout();
        }

        public void loadArtists()
        {
            Dropdown_Artist.Items.Clear();
            Dropdown_Artist.Items.AddRange(ArtistController.GetCollection<Artist>().ToArray());
            Dropdown_Artist.DisplayMember = "Display_Name";
        }
        public void loadSongs()
        {
            FlowlayoutPanelArtist.Controls.Clear();
            //int songnum = 1;
            //List<Song> songs;
            //SongController<Song> controller = new SongController<Song>();
            //if (artist != null)
            //{
            //    songs = (List<Song>)controller.GetSongsByArtist<Song>(artist);
            //}
            //else
            //{
            //    songs = (List<Song>)controller.GetCollection<Song>();   
            //}

            //foreach (Song song in songs)
            //{
            //    var songControl = new ArtistPlaceholder(song.Artist.Profile_Pic, song.Artist);
            //    FlowlayoutPanelArtist.Controls.Add(songControl);

            //    songnum++;
            //}


            List<Artist> artists = ArtistController.GetCollection<Artist>().ToList<Artist>();
            foreach (Artist artist in artists)
            {
                var songControl = new ArtistPlaceholder(artist);
                FlowlayoutPanelArtist.Controls.Add(songControl);
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

        private void Dropdown_Artist_SelectedIndexChanged(object sender, EventArgs e)
        {
            Artist selected = (Artist)Dropdown_Artist.SelectedItem;

            //loadSongs(selected);
        }
    }
}
