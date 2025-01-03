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
    public partial class FavoritePanel : UserControl
    {
        
        private static FavoritePanel _instance;
        private List<Song> favoriteSongs;
        public FlowLayoutPanel FavSongList { get; private set; }
        public static FavoritePanel Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FavoritePanel();
                }
                return _instance;
            }
        }
        public Panel DetailsPanel
        {
            get { return DetailPanel; }
        }

        public Guna2Panel MenuTab
        {
            get { return MenuTabs; }
        }

        public Guna2Panel SongMenu
        {
            get { return SongTab; }
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

        public Guna2GradientButton btn1
        {
            get { return guna2GradientButton7; }
        }
        public Guna2GradientButton btn2
        {
            get { return guna2GradientButton6; }
        }
        public Guna2GradientButton btn3
        {
            get { return Menu_AddPlaylist; }
        }
        public Guna2GradientButton btn4
        {
            get { return guna2GradientButton4; }
        }
        public Guna2GradientButton btn5
        {
            get { return guna2GradientButton3; }
        }
        public Guna2GradientButton btn6
        {
            get { return guna2GradientButton1; }
        }

        public FavoritePanel()
        {
            InitializeComponent();


            MenuTabs.Visible = false;

            Menu_AddPlaylist.Click += Menu_AddPlaylist_Click;
            favoriteSongs = new List<Song>();

            FavSongsPanel = new FlowLayoutPanel();
            FavSongsPanel.Dock = DockStyle.Fill;
            this.Controls.Add(FavSongsPanel);
        }

        private void Menubtn_Click(object sender, EventArgs e)
        {
            MenuTabs.Visible = !MenuTabs.Visible;
        }

        private void Menu_AddPlaylist_Click(object sender, EventArgs e)
        {
            if (this.FindForm() is Nimbus mainForm)
            {
                mainForm.SwitchToPanel(5);
            }
        }
        /* public void AddSongToFavorites(Song song)
         {
             if (!favoriteSongs.Any(s => s.Id == song.Id)) // Avoid duplicates
             {
                 favoriteSongs.Add(song);
                 // Add the song to the UI
                 var songControl = new HorizontalSongs(null, favoriteSongs.Count, song.Title, song.File_Path, song.Artist, song.Duration);
                 {
                     Dock = DockStyle.Top;// Align songs neatly in the panel
                 };      
                 this.Controls.Add(songControl);

                 MessageBox.Show($"'{song.Title}' added to Favorites!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
             else
             {
                 MessageBox.Show("Song is already in favorites.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
         }*/
        //private Control SongsMenu;
        public void AddSongToFavorites(Song song)
        {
            // Check if the song is already in favorites
            if (favoriteSongs.Any(s => s.Title == song.Title))
            {
                MessageBox.Show("This song is already in your favorites!", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Add the song to the favoriteSongs list
            favoriteSongs.Add(song);

            // Create a new HorizontalSongs control for the song
            var favoriteSongControl = new HorizontalSongs(FavSongsPanel, favoriteSongs.Count, song.Title, song.File_Path, song.Artist, song.Duration)
            { 
            Dock = DockStyle.Top// Align the song control neatly in the panel
            };

            // Add the song control to the panel (make sure it's added to the correct panel)
            FavSongsPanel.Controls.Add(favoriteSongControl);

            // Refresh the UI to show the new song
            FavoritePanel.Instance.FavSongsPanel.Invalidate(); // This can be used to refresh the panel

            // Display a success message
            MessageBox.Show($"'{song.Title}' has been added to your Favorites!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

}

