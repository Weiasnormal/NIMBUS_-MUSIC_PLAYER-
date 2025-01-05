using Guna.UI2.WinForms;
using NIMBUS__MUSIC_PLAYER_.Interface;
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
    public partial class FavoritePanel : UserControl, IRefresh
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

        private Size originalFormSize; // Store the original size of the form
        private HashSet<Song> favoriteSongs;
        private object selectedSong;
        SongController<Song> controller = new SongController<Song>();

        private Nimbus _nimbus;
        public FavoritePanel(Nimbus nimbus)
        {
            InitializeComponent();
            _nimbus = nimbus;
        }
        public FavoritePanel()
        {
            InitializeComponent();

            MenuTabs.Visible = false;

            Menu_AddPlaylist.Click += Menu_AddPlaylist_Click;
            Helper.Events.AddToFavorites += AddtoFavorite;
            Helper.Events.AddToFavorites();

            favoriteSongs = new HashSet<Song>();

            SongsMenu.Visible = false;

            // Capture the original size of the form
            originalFormSize = this.Size;

            // Attach the Resize event handler
            this.Resize += AllSongPanel_Resize;

            // Additional initialization for your panel and scrollbar
            flowFavorites.AutoScroll = true;
            FavoritesScrollbar.Scroll += (sender, e) =>
            {
                flowFavorites.VerticalScroll.Value = FavoritesScrollbar.Value;
            };


            int numControls = flowFavorites.Controls.Count;
            flowFavorites.SuspendLayout();
            flowFavorites.Controls.Clear();
            flowFavorites.AutoScroll = true;
            flowFavorites.VerticalScroll.Visible = false;

            this.Dock = DockStyle.Right;
            FavoritesScrollbar.Scroll += (sender, e) => { flowFavorites.VerticalScroll.Value = FavoritesScrollbar.Value; };
            FavoritesScrollbar.Height = flowFavorites.Height;
            FavoritesScrollbar.Visible = false;

            this.Controls.Add(FavoritesScrollbar);

            flowFavorites.ResumeLayout();

            // then update the form
            flowFavorites.PerformLayout();

            RefreshPanel();

        }

        public void RefreshPanel()
        {
            AddtoFavorite();
        }
        #region Frontend
        private void AllSongPanel_Resize(object sender, EventArgs e)
        {
            ResizeContents();
        }

        private void ResizeContents()
        {
            // Calculate scaling ratios
            float xRatio = (float)this.Width / originalFormSize.Width;
            float yRatio = (float)this.Height / originalFormSize.Height;

            foreach (Control control in flowFavorites.Controls)
            {
                // Skip resizing the scrollbar if not needed
                if (control == FavoritesScrollbar)
                    continue;

                // Calculate the new size and location for each control
                int newX = (int)(control.Location.X * xRatio);
                int newY = (int)(control.Location.Y * yRatio);
                int newWidth = (int)(control.Width * xRatio);
                int newHeight = (int)(control.Height * yRatio);

                // Apply the new size and location
                control.Location = new Point(newX, newY);
                control.Size = new Size(newWidth, newHeight);
            }

            // Update the scrollbar height and position
            FavoritesScrollbar.Height = flowFavorites.Height;
            FavoritesScrollbar.Maximum = flowFavorites.VerticalScroll.Maximum;
        }  
        #endregion

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

            // Set IsFavorite to false
            songTobeRemove.IsFavorite = false;

            // Update the database using the controller
            bool success = controller.Update(songTobeRemove);

            if (success)
            {
                var nimbus = this.FindForm() as Nimbus;

                if (nimbus != null)
                {
                    nimbus.InitializeFavoriteButton();
                }

                MessageBox.Show($"'{songTobeRemove.Title}' has been removed from Favorites!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //_nimbus.RefreshFavoriteButton();
                RefreshPanel();
                // Refresh the Favorites view
                flowFavorites.Controls.Clear();
                AddtoFavorite();
            }
            else
            {
                MessageBox.Show($"Failed to remove '{songTobeRemove.Title}' from Favorites.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            SongsMenu.Visible = false;
        }

        private void guna2GradientButton7_Click(object sender, EventArgs e)
        {
            Song songTobeDeleted = ((HorizontalSongs)selectedSong).Song;

            controller.Delete(((HorizontalSongs)selectedSong).Song);
            SongsMenu.Visible = false;
            MessageBox.Show($"'{songTobeDeleted.Title}' has been Deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            flowFavorites.Controls.Clear();
            AddtoFavorite();

            Nimbus nimbus = new Nimbus();
            nimbus.UpdateSongDetails();

        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            List<Song> songs = NimbusClassLibrary.Data.DBContext.songs.Where(s => s.IsFavorite).ToList();

            foreach(Song song in songs)
            {
                NimbusClassLibrary.Helpers.GlobalLibraries.Playing_Song.AddLast(song);
            }

            Helper.Events.AddToQueue(sender, e);
        }
    }
}
