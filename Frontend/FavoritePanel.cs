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
            get { return RemovefromFavorites; }
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
        private object selectedSong;
        SongController<Song> controller = new SongController<Song>();
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
            selectedSong = sender;
        }

        private void RemovefromFavorites_Click(object sender, EventArgs e)
        {
            Song songTobeRemove = ((HorizontalSongs)selectedSong).Song;
            // Set Favorites into true
            songTobeRemove.IsFavorite = false;
            SongsMenu.Visible = false;
            MessageBox.Show($"'{songTobeRemove.Title}' has been Removed from the Favorites!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            flowFavorites.Controls.Clear();
            AddtoFavorite();
        }

        private void guna2GradientButton7_Click(object sender, EventArgs e)
        {
            Song songTobeDeleted = ((HorizontalSongs)selectedSong).Song;

            controller.Delete(((HorizontalSongs)selectedSong).Song);
            SongsMenu.Visible = false;
            MessageBox.Show($"'{songTobeDeleted.Title}' has been Deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            flowFavorites.Controls.Clear();
            AddtoFavorite(); 
        }
    }
}
