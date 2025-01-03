using Guna.UI2.WinForms;
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
        #region FrontEnd
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
            get { return SongsMenu; }
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
        #endregion

        private HashSet<Song> favoriteSongs;

        public FavoritePanel()
        {
            InitializeComponent();

            MenuTabs.Visible = false;

            Menu_AddPlaylist.Click += Menu_AddPlaylist_Click;
            Helper.Events.AddToFavorites += AddtoFavorite;
            Helper.Events.AddToFavorites();

            favoriteSongs = new HashSet<Song>();

            SongsMenu.Visible = false;
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

        private void AddtoFavorite()
        {

            if (!flowFavorites.IsHandleCreated)
            {
                flowFavorites.HandleCreated += (s, e) => AddtoFavorite();
                return;
            }

            flowFavorites.Controls.Clear();

            int songnum = 1;


            foreach (Song song in NimbusClassLibrary.Data.DBContext.songs.Where(s => s.IsFavorite))
            {
                flowFavorites.Invoke(new Action(() =>
                {
                    // Create an instance of HorizontalSongs
                    var songControl = new HorizontalSongs(SongsMenu, songnum, song);

                    // Subscribe to the MenuButtonClicked event
                    songControl.MenuButtonClicked += SongControl_MenuButtonClicked;

                    // Add the song control to the flowFavorites panel
                    flowFavorites.Controls.Add(songControl);
                }));
                songnum++;

            }
        }

        private void SongControl_MenuButtonClicked(object sender, EventArgs e)
        {
            SongsMenu.Visible = !SongsMenu.Visible;
        }
        /* public void AddSongToFavorites(Song song)
         {
             if (favoriteSongs.Add(song)) // Adds only if not already in favorites
             {
                 song.IsFavorite = true; // Optionally update favorite status
                 AddtoFavorite(); // Refresh the favorites display
                 MessageBox.Show($"'{song.Title}' added to Favorites!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
             else
             {
                 MessageBox.Show("This song is already in your Favorites!", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
         }

         public void RemoveSongFromFavorites(Song song)
         {
             if (favoriteSongs.Remove(song)) // Removes only if present in favorites
             {
                 song.IsFavorite = false; // Optionally update favorite status
                 AddtoFavorite(); // Refresh the favorites display
                 MessageBox.Show($"'{song.Title}' removed from Favorites!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
         }*/
    }
}
