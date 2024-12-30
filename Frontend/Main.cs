using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;
using Guna.UI2.HtmlRenderer.Adapters.Entities;
using Guna.UI2.WinForms;
using NimbusClassLibrary;
using NimbusClassLibrary.Controller;
using NimbusClassLibrary.Model;
using TagLib;

namespace NIMBUS__MUSIC_PLAYER_
{
    public partial class Nimbus : Form
    {
        static DashboardNavigation dashboardNavigation;
        public Nimbus()
        {
            InitializeComponent();
            Initialize_Navigation_Controls();
            // test test = new test();
            // MessageBox.Show(test.test1());

        }
        private void Initialize_Navigation_Controls()
        {
            UserControl[] list =
            {
                new AllSongPanel(),
                new FavoritePanel(),
                new AlbumsPanel(),
                new ArtistsPanel(),
                new QueuePanel(),
                new PlaylistPanel()
            };

            dashboardNavigation = new DashboardNavigation(list, ViewPanel);
            dashboardNavigation.Display(0);
        }

        private void btnSidebar_Songs_Click(object sender, EventArgs e) => dashboardNavigation.Display(0);
        private void btnSidebar_Favorites_Click(object sender, EventArgs e) => dashboardNavigation.Display(1);
        private void btnSidebar_Albums_Click(object sender, EventArgs e) => dashboardNavigation.Display(2);
        private void btnSidebar_Artists_Click(object sender, EventArgs e) => dashboardNavigation.Display(3);
        private void btnSidebar_Queue_Click(object sender, EventArgs e) => dashboardNavigation.Display(4);
        private void btnSidebar_Playlist_Click(object sender, EventArgs e) => dashboardNavigation.Display(5);

        private void Theme1_Click(object sender, EventArgs e) => ApplyDarkTheme();

        //private void Theme2_Click(object sender, EventArgs e) => ApplyWhiteTheme();
        private void Theme3_Click(object sender, EventArgs e) => ApplyBlueTheme();
        private void Theme4_Click(object sender, EventArgs e) => ApplyGreenTheme();

        private void ApplyDarkTheme()
        {
            var BGColor = Color.FromArgb(18, 18, 18);
            var Color1 = Color.FromArgb(39, 39, 39);
            var NowPlayingColor = Color.FromArgb(26, 26, 26);


            this.BackColor = BGColor;
            this.ForeColor = Color.White;

            /*btnSidebar_Songs.ForeColor = Color.White;
            btnSidebar_Favorites.ForeColor = Color.White;
            btnSidebar_Albums.ForeColor = Color.White;
            btnSidebar_Artists.ForeColor = Color.White;
            btnSidebar_Queue.ForeColor = Color.White;
            btnSidebar_Playlist.ForeColor = Color.White;*/

            panel3.BackColor = NowPlayingColor;
            btnSidebar_Songs.CheckedState.FillColor = Color1;
            btnSidebar_Songs.CheckedState.FillColor2 = Color1;
            btnSidebar_Favorites.CheckedState.FillColor = Color1;
            btnSidebar_Favorites.CheckedState.FillColor2 = Color1;
            btnSidebar_Albums.CheckedState.FillColor = Color1;
            btnSidebar_Albums.CheckedState.FillColor2 = Color1;
            btnSidebar_Artists.CheckedState.FillColor = Color1;
            btnSidebar_Artists.CheckedState.FillColor2 = Color1;
            btnSidebar_Queue.CheckedState.FillColor = Color1;
            btnSidebar_Queue.CheckedState.FillColor2 = Color1;

            btnSidebar_Songs.HoverState.FillColor = Color1;
            btnSidebar_Songs.HoverState.FillColor2 = Color1;
            btnSidebar_Favorites.HoverState.FillColor = Color1;
            btnSidebar_Favorites.HoverState.FillColor2 = Color1;
            btnSidebar_Albums.HoverState.FillColor = Color1;
            btnSidebar_Albums.HoverState.FillColor2 = Color1;
            btnSidebar_Artists.HoverState.FillColor = Color1;
            btnSidebar_Artists.HoverState.FillColor2 = Color1;
            btnSidebar_Queue.HoverState.FillColor = Color1;
            btnSidebar_Queue.HoverState.FillColor2 = Color1;

            SearchBar.FillColor = Color1;

            pictureBox1.Image = Properties.Resources.Nimbus_LightLogo;
            guna2ControlBox1.IconColor = Color.White;
            guna2ControlBox1.BackColor = Color.Transparent;
            guna2ControlBox2.IconColor = Color.White;
            guna2ControlBox2.BackColor = Color.Transparent;

            

            foreach (Control control in ViewPanel.Controls)
            {
                if (control is AllSongPanel allSongControl)
                {
                    allSongControl.DetailsPanel.BackColor = Color.FromArgb(49, 49, 49);
                    allSongControl.MenuTab.BackColor = Color.FromArgb(49, 49, 49);
                    allSongControl.SongMenu.BackColor = Color.FromArgb(49, 49, 49);
                }
                if  (control is QueuePanel queuePanel)
                {
                    queuePanel.DetailsPanel.BackColor = Color.FromArgb(49, 49, 49);
                    queuePanel.MenuTab.BackColor = Color.FromArgb(49, 49, 49);
                    queuePanel.SongMenu.BackColor = Color.FromArgb(49, 49, 49);
                }
                if (control is FavoritePanel favoritePanel)
                {
                    favoritePanel.DetailsPanel.BackColor = Color.FromArgb(49, 49, 49);
                    favoritePanel.MenuTab.BackColor = Color.FromArgb(49, 49, 49);
                    favoritePanel.SongMenu.BackColor = Color.FromArgb(49, 49, 49);
                }

            }
        }

        /*private void ApplyWhiteTheme()
        {

            this.BackColor = Color.White;
            this.ForeColor = Color.Black;
            var Color1 = Color.WhiteSmoke;

            *//*btnSidebar_Songs.ForeColor = Color.Black;
            btnSidebar_Favorites.ForeColor = Color.Black;
            btnSidebar_Albums.ForeColor = Color.Black;
            btnSidebar_Artists.ForeColor = Color.Black;
            btnSidebar_Queue.ForeColor = Color.Black;
            btnSidebar_Playlist.ForeColor = Color.Black;*//*


            btnSidebar_Songs.CheckedState.FillColor = Color1;
            btnSidebar_Songs.CheckedState.FillColor2 = Color1;
            btnSidebar_Favorites.CheckedState.FillColor = Color1;
            btnSidebar_Favorites.CheckedState.FillColor2 = Color1;
            btnSidebar_Albums.CheckedState.FillColor = Color1;
            btnSidebar_Albums.CheckedState.FillColor2 = Color1;
            btnSidebar_Artists.CheckedState.FillColor = Color1;
            btnSidebar_Artists.CheckedState.FillColor2 = Color1;
            btnSidebar_Queue.CheckedState.FillColor = Color1;
            btnSidebar_Queue.CheckedState.FillColor2 = Color1;

            SearchBar.FillColor = Color.White;
            SearchBar.ForeColor = Color.Black;
            btnImportMusic.ForeColor = Color.White;
            btnImportMusic.FillColor = Color.Black;
            btnImportMusic.FillColor2 = Color.Black;

            guna2ControlBox1.IconColor = Color.Black;
            guna2ControlBox1.BackColor = Color.White;
            guna2ControlBox2.IconColor = Color.Black;
            guna2ControlBox2.BackColor = Color.White;

            btnImportMusic.Image = Properties.Resources.Iconaddbuttonwhite;
            pictureBox1.Image = Properties.Resources.Nimbus_DarkLogo;
            btnSidebar_Songs.Image = Properties.Resources.DarkSongimage;
            btnSidebar_Favorites.Image = Properties.Resources.DarkFavoritesimage;
            btnSidebar_Albums.Image = Properties.Resources.DarkAlmbumimage;
            btnSidebar_Artists.Image = Properties.Resources.DarkArtistImage;
            btnSidebar_Queue.Image = Properties.Resources.Darkqueueimage;
            btnSidebar_Playlist.Image = Properties.Resources.DarkPlaylistimage;
            btnAddaPlaylist.Image = Properties.Resources.Vector__7_;
            guna2PictureBox3.Image = Properties.Resources.DarkDrpDown___Copy1;
            guna2PictureBox2.Image = Properties.Resources.DarkDrpDown;

            panel3.BackColor = Color.WhiteSmoke;
            //guna2GradientButton2.Image = Properties.Resources.OrangePause;
            //guna2ImageButton2.Image = Properties.Resources.Dark;
            //Menubtn.Image = Properties.Resources.DarkMenu;
            //guna2GradientButton3.Image = Properties.Resources.Orange1;

            //pagka sinelect ang white theme nagiging dark icons lahat ng kasunod, need pang lagyan ng white icons yung iba para hinde masira

            *//* pictureBox7.Image = Properties.Resources.Dark1;
             pictureBox5.Image = Properties.Resources.Dark4;
             pictureBox8.Image = Properties.Resources.Dark3;
             pictureBox6.Image = Properties.Resources.Dark2;
             pictureBox9.Image = Properties.Resources.Dark5;*//*
        }*/

        private void ApplyBlueTheme()
        {
            var BGColor = Color.FromArgb(21, 28, 33);
            var Color1 = Color.FromArgb(27, 40, 50);
            var NowPlayingColor = Color.FromArgb(35, 43, 50);


            this.BackColor = BGColor;
            this.ForeColor = Color.White;

            /* btnSidebar_Songs.ForeColor = Color.White;
             btnSidebar_Favorites.ForeColor = Color.White;
             btnSidebar_Albums.ForeColor = Color.White;
             btnSidebar_Artists.ForeColor = Color.White;
             btnSidebar_Queue.ForeColor = Color.White;
             btnSidebar_Playlist.ForeColor = Color.White;*/

            

            panel3.BackColor = NowPlayingColor;
            btnSidebar_Songs.CheckedState.FillColor = Color1;
            btnSidebar_Songs.CheckedState.FillColor2 = Color1;
            btnSidebar_Favorites.CheckedState.FillColor = Color1;
            btnSidebar_Favorites.CheckedState.FillColor2 = Color1;
            btnSidebar_Albums.CheckedState.FillColor = Color1;
            btnSidebar_Albums.CheckedState.FillColor2 = Color1;
            btnSidebar_Artists.CheckedState.FillColor = Color1;
            btnSidebar_Artists.CheckedState.FillColor2 = Color1;
            btnSidebar_Queue.CheckedState.FillColor = Color1;
            btnSidebar_Queue.CheckedState.FillColor2 = Color1;

            btnSidebar_Songs.HoverState.FillColor = Color1;
            btnSidebar_Songs.HoverState.FillColor2 = Color1;
            btnSidebar_Favorites.HoverState.FillColor = Color1;
            btnSidebar_Favorites.HoverState.FillColor2 = Color1;
            btnSidebar_Albums.HoverState.FillColor = Color1;
            btnSidebar_Albums.HoverState.FillColor2 = Color1;
            btnSidebar_Artists.HoverState.FillColor = Color1;
            btnSidebar_Artists.HoverState.FillColor2 = Color1;
            btnSidebar_Queue.HoverState.FillColor = Color1;
            btnSidebar_Queue.HoverState.FillColor2 = Color1;

            SearchBar.FillColor = Color1;

            pictureBox1.Image = Properties.Resources.Nimbus_LightLogo;
            guna2ControlBox1.IconColor = Color.White;
            guna2ControlBox1.BackColor = Color.Transparent;
            guna2ControlBox2.IconColor = Color.White;
            guna2ControlBox2.BackColor = Color.Transparent;

          

            foreach (Control control in ViewPanel.Controls)
            {
                if (control is AllSongPanel allSongControl)
                {
                    allSongControl.DetailsPanel.BackColor = Color.FromArgb(35, 43, 50);
                    allSongControl.MenuTab.BackColor = Color.FromArgb(35, 43, 50);
                    allSongControl.SongMenu.BackColor = Color.FromArgb(35, 43, 50);
                }
                if (control is QueuePanel queuePanel)
                {
                    queuePanel.DetailsPanel.BackColor = Color.FromArgb(35, 43, 50);
                    queuePanel.MenuTab.BackColor = Color.FromArgb(35, 43, 50);
                    queuePanel.SongMenu.BackColor = Color.FromArgb(35, 43, 50);
                }
                if (control is FavoritePanel favoritePanel)
                {
                    favoritePanel.DetailsPanel.BackColor = Color.FromArgb(35, 43, 50);
                    favoritePanel.MenuTab.BackColor = Color.FromArgb(35, 43, 50);
                    favoritePanel.SongMenu.BackColor = Color.FromArgb(35, 43, 50);
                }
            }
        }

        private void ApplyGreenTheme()
        {
            var BGColor = Color.FromArgb(33, 40, 38);        
            var Color1 = Color.FromArgb(113, 135, 129);
            var NowPlayingColor = Color.FromArgb(75, 90, 86);


            this.BackColor = BGColor;
            this.ForeColor = Color.White;

            /* btnSidebar_Songs.ForeColor = Color.White;
             btnSidebar_Favorites.ForeColor = Color.White;
             btnSidebar_Albums.ForeColor = Color.White;
             btnSidebar_Artists.ForeColor = Color.White;
             btnSidebar_Queue.ForeColor = Color.White;
             btnSidebar_Playlist.ForeColor = Color.White;*/

            panel3.BackColor = NowPlayingColor;
            btnSidebar_Songs.CheckedState.FillColor = Color1;
            btnSidebar_Songs.CheckedState.FillColor2 = Color1;
            btnSidebar_Favorites.CheckedState.FillColor = Color1;
            btnSidebar_Favorites.CheckedState.FillColor2 = Color1;
            btnSidebar_Albums.CheckedState.FillColor = Color1;
            btnSidebar_Albums.CheckedState.FillColor2 = Color1;
            btnSidebar_Artists.CheckedState.FillColor = Color1;
            btnSidebar_Artists.CheckedState.FillColor2 = Color1;
            btnSidebar_Queue.CheckedState.FillColor = Color1;
            btnSidebar_Queue.CheckedState.FillColor2 = Color1;

            btnSidebar_Songs.HoverState.FillColor = Color1;
            btnSidebar_Songs.HoverState.FillColor2 = Color1;
            btnSidebar_Favorites.HoverState.FillColor = Color1;
            btnSidebar_Favorites.HoverState.FillColor2 = Color1;
            btnSidebar_Albums.HoverState.FillColor = Color1;
            btnSidebar_Albums.HoverState.FillColor2 = Color1;
            btnSidebar_Artists.HoverState.FillColor = Color1;
            btnSidebar_Artists.HoverState.FillColor2 = Color1;
            btnSidebar_Queue.HoverState.FillColor = Color1;
            btnSidebar_Queue.HoverState.FillColor2 = Color1;

            SearchBar.FillColor = Color1;

            pictureBox1.Image = Properties.Resources.Nimbus_LightLogo;
            guna2ControlBox1.IconColor = Color.White;
            guna2ControlBox1.BackColor = Color.Transparent;
            guna2ControlBox2.IconColor = Color.White;
            guna2ControlBox2.BackColor = Color.Transparent;

            

            foreach (Control control in ViewPanel.Controls)
            {
                if (control is AllSongPanel allSongControl)
                {
                    allSongControl.DetailsPanel.BackColor = Color.FromArgb(75, 90, 86);
                    allSongControl.MenuTab.BackColor = Color.FromArgb(75, 90, 86);
                    allSongControl.SongMenu.BackColor = Color.FromArgb(75, 90, 86);
                }
                if (control is QueuePanel queuePanel)
                {
                    queuePanel.DetailsPanel.BackColor = Color.FromArgb(75, 90, 86);
                    queuePanel.MenuTab.BackColor = Color.FromArgb(75, 90, 86);
                    queuePanel.SongMenu.BackColor = Color.FromArgb(75, 90, 86);
                }
                if (control is FavoritePanel favoritePanel)
                {
                    favoritePanel.DetailsPanel.BackColor = Color.FromArgb(75, 90, 86);
                    favoritePanel.MenuTab.BackColor = Color.FromArgb(75, 90, 86);
                    favoritePanel.SongMenu.BackColor = Color.FromArgb(75, 90, 86);
                }
            }
        }

        private void TimeSong_ValueChanged(object sender, EventArgs e)
        {

        }


        private void Nimbus_Load(object sender, EventArgs e)
        {

        }

        private void btnImportMusic_Click_1(object sender, EventArgs e)
        {
            // Open a file dialog to let the user select multiple song files
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Music Files|*.mp3;*.wav;*.flac"; // Filter for music files
                openFileDialog.Multiselect = true; // Allow multiple selections
                openFileDialog.Title = "Import Music Files";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the selected file paths
                    string[] filePaths = openFileDialog.FileNames;

                    // Initialize controllers
                    SongController<Song> songController = new SongController<Song>();
                    ArtistController artistController = new ArtistController();

                    foreach (string filePath in filePaths)
                    {
                        try
                        {
                            // Use TagLib to extract metadata
                            var tagFile = TagLib.File.Create(filePath);
                            string title = tagFile.Tag.Title ?? System.IO.Path.GetFileNameWithoutExtension(filePath);
                            string artistName = tagFile.Tag.FirstPerformer ?? "Unknown Artist";
                            TimeSpan duration = tagFile.Properties.Duration;

                            // Check if the artist exists or create a new one
                            int artistId = artistController.GetArtistIdByName(artistName);
                            if (artistId == 0)
                            {
                                Artist newArtist = new Artist { Display_Name = artistName };
                                artistController.Create(newArtist);
                                artistId = artistController.GetArtistIdByName(artistName);
                            }

                            // Create a new Song model
                            Song newSong = new Song
                            {
                                Title = title,
                                File_Path = filePath,
                                Artist = new Artist { Id = artistId, Display_Name = artistName },
                                Duration = duration
                            };

                            // Pass the song model to the SongController
                            bool isCreated = songController.Create(newSong);

                            // Provide feedback to the user
                            if (isCreated)
                            {
                                MessageBox.Show($"Song '{newSong.Title}' by '{artistName}' imported successfully!", "Import Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show($"Failed to import song '{newSong.Title}'.", "Import Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error importing file '{filePath}': {ex.Message}", "Import Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }
}
