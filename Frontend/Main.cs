using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxWMPLib;
using Guna.UI.WinForms;
using Guna.UI2.HtmlRenderer.Adapters.Entities;
using Guna.UI2.WinForms;
using NIMBUS__MUSIC_PLAYER_.Helper;
using NimbusClassLibrary;
using NimbusClassLibrary.Controller;
using NimbusClassLibrary.Model;
using TagLib;
using WMPLib;

namespace NIMBUS__MUSIC_PLAYER_
{
    public partial class Nimbus : Form
    {
        static DashboardNavigation dashboardNavigation;

        private WindowsMediaPlayer player;
        private HorizontalSongs currentSongControl;

        public IEnumerable<object> Buttons { get; private set; }

        private Timer timer;

        public Nimbus()
        {
            InitializeComponent();
            Initialize_Navigation_Controls();
            
            ShowAddPlaylist.Visible = false;
            MiniplayerPanel.Visible = false;
            PlaylistList.Visible = false;
            // test test = new test();
            // MessageBox.Show(test.test1());
            Pausebtn.Visible = false;

            PlayerState.OnStateChanged += UpdatePlayPauseButton;

            Pausebtn.Click += (sender, e) =>
            {
                // Toggle the player state
                PlayerState.IsPlaying = !PlayerState.IsPlaying;
            };

            // Initialize Timer
            timer = new Timer();
            timer.Interval = 500; // Update every 500ms (half a second)
            timer.Tick += timer1_Tick;

            // Initialize ProgressBar
            TimeSong.Minimum = 0; // Start at 0
            TimeSong.Maximum = 100; // Progress will be in percentage
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
        private void btnSidebar_Playlist_Click(object sender, EventArgs e)
        {
            PlaylistList.Visible = !PlaylistList.Visible;
        }

        private void PlaylistList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PlaylistList.SelectedItem != null)
            {
                dashboardNavigation.Display(5);
            }
        }

        public void SwitchToPanel(int panelIndex)
        {
            dashboardNavigation.Display(panelIndex);
        }

        private void Theme1_Click(object sender, EventArgs e) => ApplyDarkTheme();
        private void Theme3_Click(object sender, EventArgs e) => ApplyBlueTheme();
        private void Theme4_Click(object sender, EventArgs e) => ApplyGreenTheme();



        private void btnAddaPlaylist_Click(object sender, EventArgs e)
        {            
            CreatePlaylist createPlaylist = new CreatePlaylist();
            ShowAddPlaylist.Controls.Clear();
            ShowAddPlaylist.Location = new Point(439, 154);
            ShowAddPlaylist.Size = createPlaylist.Size;
            ShowAddPlaylist.Controls.Add(new CreatePlaylist());
            ShowAddPlaylist.Visible = true;
        }

        private void ShowAddPlaylist_ControlRemoved(object sender, ControlEventArgs e)
        {
            ShowAddPlaylist.Visible = false;
        }
        #region Apply Dark Theme
        private void ApplyDarkTheme()
        {
            var BGColor = Color.FromArgb(18, 18, 18);
            var Color1 = Color.FromArgb(39, 39, 39);
            var NowPlayingColor = Color.FromArgb(26, 26, 26);
            var Hover = Color.FromArgb(49, 49, 49);

            this.BackColor = BGColor;
            this.ForeColor = Color.White;

            PlaylistList.BackColor = BGColor;
            PlaylistList.SelectedItem = Hover;
            panel3.BackColor = NowPlayingColor;
            btnSidebar_Songs.CheckedState.FillColor = Hover;
            btnSidebar_Songs.CheckedState.FillColor2 = Hover;
            btnSidebar_Favorites.CheckedState.FillColor = Hover;
            btnSidebar_Favorites.CheckedState.FillColor2 = Hover;
            btnSidebar_Albums.CheckedState.FillColor = Hover;
            btnSidebar_Albums.CheckedState.FillColor2 = Hover;
            btnSidebar_Artists.CheckedState.FillColor = Hover;
            btnSidebar_Artists.CheckedState.FillColor2 = Hover;
            btnSidebar_Queue.CheckedState.FillColor = Hover;
            btnSidebar_Queue.CheckedState.FillColor2 = Hover;

            btnSidebar_Songs.HoverState.FillColor = Hover;
            btnSidebar_Songs.HoverState.FillColor2 = Hover;
            btnSidebar_Favorites.HoverState.FillColor = Hover;
            btnSidebar_Favorites.HoverState.FillColor2 = Hover;
            btnSidebar_Albums.HoverState.FillColor = Hover;
            btnSidebar_Albums.HoverState.FillColor2 = Hover;
            btnSidebar_Artists.HoverState.FillColor = Hover;
            btnSidebar_Artists.HoverState.FillColor2 = Hover;
            btnSidebar_Queue.HoverState.FillColor = Hover;
            btnSidebar_Queue.HoverState.FillColor2 = Hover;

            SearchBar.FillColor = Hover;

            pictureBox1.Image = Properties.Resources.Nimbus_LightLogo;
            guna2ControlBox1.IconColor = Color.White;
            guna2ControlBox1.BackColor = Color.Transparent;
            guna2ControlBox2.IconColor = Color.White;
            guna2ControlBox2.BackColor = Color.Transparent;



            foreach (Control control in ViewPanel.Controls)
            {
                if (control is AllSongPanel allSongControl)
                {
                    allSongControl.DetailsPanel.BackColor = Color1;
                    allSongControl.MenuTabs.FillColor = Color1;
                    allSongControl.SongMenu.FillColor = Color1;
                    allSongControl.Dropdown_Artists.FillColor = Color1;
                    allSongControl.Dropdown_Artists.ItemsAppearance.BackColor = Color1;
                    allSongControl.Dropdown_Artists.ItemsAppearance.SelectedBackColor = Hover;
                    allSongControl.Dropdown_Albums.FillColor = Color1;
                    allSongControl.Dropdown_Albums.ItemsAppearance.BackColor = Color1;
                    allSongControl.Dropdown_Albums.ItemsAppearance.SelectedBackColor = Hover;
                    allSongControl.Dropdown_Sorts.FillColor = Color1;
                    allSongControl.Dropdown_Sorts.ItemsAppearance.BackColor = Color1;
                    allSongControl.Dropdown_Sorts.ItemsAppearance.SelectedBackColor = Hover;

                    allSongControl.btn1.HoverState.FillColor = Hover;
                    allSongControl.btn1.HoverState.FillColor2 = Hover;
                    allSongControl.btn2.HoverState.FillColor = Hover;
                    allSongControl.btn2.HoverState.FillColor2 = Hover;
                    allSongControl.btn3.HoverState.FillColor = Hover;
                    allSongControl.btn3.HoverState.FillColor2 = Hover;
                    allSongControl.btn4.HoverState.FillColor = Hover;
                    allSongControl.btn4.HoverState.FillColor2 = Hover;
                    allSongControl.btn5.HoverState.FillColor = Hover;
                    allSongControl.btn5.HoverState.FillColor2 = Hover;
                    allSongControl.btn6.HoverState.FillColor = Hover;
                    allSongControl.btn6.HoverState.FillColor2 = Hover;
                }
                if (control is QueuePanel queuePanel)
                {
                    queuePanel.DetailsPanel.BackColor = Color1;
                    queuePanel.MenuTab.FillColor = Color1;
                    queuePanel.SongMenu.FillColor = Color1;
                    queuePanel.Dropdown_Artists.FillColor = Color1;
                    queuePanel.Dropdown_Artists.ItemsAppearance.BackColor = Color1;
                    queuePanel.Dropdown_Artists.ItemsAppearance.SelectedBackColor = Hover;
                    queuePanel.Dropdown_Albums.FillColor = Color1;
                    queuePanel.Dropdown_Albums.ItemsAppearance.BackColor = Color1;
                    queuePanel.Dropdown_Albums.ItemsAppearance.SelectedBackColor = Hover;
                    queuePanel.Dropdown_Sorts.FillColor = Color1;
                    queuePanel.Dropdown_Sorts.ItemsAppearance.BackColor = Color1;
                    queuePanel.Dropdown_Sorts.ItemsAppearance.SelectedBackColor = Hover;
                    queuePanel.SearchBars.FillColor = Hover;

                    queuePanel.btn1.HoverState.FillColor = Hover;
                    queuePanel.btn1.HoverState.FillColor2 = Hover;
                    queuePanel.btn2.HoverState.FillColor = Hover;
                    queuePanel.btn2.HoverState.FillColor2 = Hover;
                    queuePanel.btn3.HoverState.FillColor = Hover;
                    queuePanel.btn3.HoverState.FillColor2 = Hover;
                    queuePanel.btn4.HoverState.FillColor = Hover;
                    queuePanel.btn4.HoverState.FillColor2 = Hover;
                }
                if (control is FavoritePanel favoritePanel)
                {
                    favoritePanel.DetailsPanel.BackColor = Color1;
                    favoritePanel.MenuTab.FillColor = Color1;
                    favoritePanel.SongMenu.FillColor = Color1;
                    favoritePanel.Dropdown_Artists.FillColor = Color1;
                    favoritePanel.Dropdown_Artists.ItemsAppearance.BackColor = Color1;
                    favoritePanel.Dropdown_Artists.ItemsAppearance.SelectedBackColor = Hover;
                    favoritePanel.Dropdown_Albums.FillColor = Color1;
                    favoritePanel.Dropdown_Albums.ItemsAppearance.BackColor = Color1;
                    favoritePanel.Dropdown_Albums.ItemsAppearance.SelectedBackColor = Hover;
                    favoritePanel.Dropdown_Sorts.FillColor = Color1;
                    favoritePanel.Dropdown_Sorts.ItemsAppearance.BackColor = Color1;
                    favoritePanel.Dropdown_Sorts.ItemsAppearance.SelectedBackColor = Hover;
                    favoritePanel.SearchBars.FillColor = Hover;

                    favoritePanel.btn1.HoverState.FillColor = Hover;
                    favoritePanel.btn1.HoverState.FillColor2 = Hover;
                    favoritePanel.btn2.HoverState.FillColor = Hover;
                    favoritePanel.btn2.HoverState.FillColor2 = Hover;
                    favoritePanel.btn3.HoverState.FillColor = Hover;
                    favoritePanel.btn3.HoverState.FillColor2 = Hover;
                    favoritePanel.btn4.HoverState.FillColor = Hover;
                    favoritePanel.btn4.HoverState.FillColor2 = Hover;
                    favoritePanel.btn5.HoverState.FillColor = Hover;
                    favoritePanel.btn5.HoverState.FillColor2 = Hover;
                    favoritePanel.btn6.HoverState.FillColor = Hover;
                    favoritePanel.btn6.HoverState.FillColor2 = Hover;
                }
                if (control is AlbumsPanel albumsPanel)
                {
                    albumsPanel.Dropdown_Artists.FillColor = Color1;
                    albumsPanel.Dropdown_Artists.ItemsAppearance.BackColor = Color1;
                    albumsPanel.Dropdown_Artists.ItemsAppearance.SelectedBackColor = Hover;
                    albumsPanel.Dropdown_Albums.FillColor = Color1;
                    albumsPanel.Dropdown_Albums.ItemsAppearance.BackColor = Color1;
                    albumsPanel.Dropdown_Albums.ItemsAppearance.SelectedBackColor = Hover;
                    albumsPanel.Dropdown_Sorts.FillColor = Color1;
                    albumsPanel.Dropdown_Sorts.ItemsAppearance.BackColor = Color1;
                    albumsPanel.Dropdown_Sorts.ItemsAppearance.SelectedBackColor = Hover;
                    albumsPanel.SearchBars.FillColor = Hover;
                }
                if (control is ArtistsPanel artisitsPanel)
                {
                    artisitsPanel.Dropdown_Artists.FillColor = Color1;
                    artisitsPanel.Dropdown_Artists.ItemsAppearance.BackColor = Color1;
                    artisitsPanel.Dropdown_Artists.ItemsAppearance.SelectedBackColor = Hover;
                    artisitsPanel.Dropdown_Albums.FillColor = Color1;
                    artisitsPanel.Dropdown_Albums.ItemsAppearance.BackColor = Color1;
                    artisitsPanel.Dropdown_Albums.ItemsAppearance.SelectedBackColor = Hover;
                    artisitsPanel.Dropdown_Sorts.FillColor = Color1;
                    artisitsPanel.Dropdown_Sorts.ItemsAppearance.BackColor = Color1;
                    artisitsPanel.Dropdown_Sorts.ItemsAppearance.SelectedBackColor = Hover;
                    artisitsPanel.SearchBars.FillColor = Hover;
                }
                if (control is PlaylistPanel playlistPanel)
                {
                    playlistPanel.DetailsPanel.BackColor = Color1;
                    playlistPanel.MenuTabs.FillColor = Color1;
                    playlistPanel.SongMenu.FillColor = Color1;
                    playlistPanel.Dropdown_Artists.FillColor = Color1;
                    playlistPanel.Dropdown_Artists.ItemsAppearance.BackColor = Color1;
                    playlistPanel.Dropdown_Artists.ItemsAppearance.SelectedBackColor = Hover;
                    playlistPanel.Dropdown_Albums.FillColor = Color1;
                    playlistPanel.Dropdown_Albums.ItemsAppearance.BackColor = Color1;
                    playlistPanel.Dropdown_Albums.ItemsAppearance.SelectedBackColor = Hover;
                    playlistPanel.Dropdown_Sorts.FillColor = Color1;
                    playlistPanel.Dropdown_Sorts.ItemsAppearance.BackColor = Color1;
                    playlistPanel.Dropdown_Sorts.ItemsAppearance.SelectedBackColor = Hover;

                    playlistPanel.btn1.HoverState.FillColor = Hover;
                    playlistPanel.btn1.HoverState.FillColor2 = Hover;
                    playlistPanel.btn2.HoverState.FillColor = Hover;
                    playlistPanel.btn2.HoverState.FillColor2 = Hover;
                    playlistPanel.btn3.HoverState.FillColor = Hover;
                    playlistPanel.btn3.HoverState.FillColor2 = Hover;
                    playlistPanel.btn4.HoverState.FillColor = Hover;
                    playlistPanel.btn4.HoverState.FillColor2 = Hover;
                    playlistPanel.btn5.HoverState.FillColor = Hover;
                    playlistPanel.btn5.HoverState.FillColor2 = Hover;
                    playlistPanel.btn6.HoverState.FillColor = Hover;
                    playlistPanel.btn6.HoverState.FillColor2 = Hover;
                }
            }
        }
#endregion
        #region Apply Blue Theme
        private void ApplyBlueTheme()
        {
            var BGColor = Color.FromArgb(21, 28, 33);
            var Color1 = Color.FromArgb(27, 40, 50);
            var NowPlayingColor = Color.FromArgb(35, 43, 50);
            var Hover = Color.FromArgb(38, 55, 69);

            this.BackColor = BGColor;
            this.ForeColor = Color.White;

            PlaylistList.BackColor = BGColor;
            panel3.BackColor = NowPlayingColor;
            btnSidebar_Songs.CheckedState.FillColor = Hover;
            btnSidebar_Songs.CheckedState.FillColor2 = Hover;
            btnSidebar_Favorites.CheckedState.FillColor = Hover;
            btnSidebar_Favorites.CheckedState.FillColor2 = Hover;
            btnSidebar_Albums.CheckedState.FillColor = Hover;
            btnSidebar_Albums.CheckedState.FillColor2 = Hover;
            btnSidebar_Artists.CheckedState.FillColor = Hover;
            btnSidebar_Artists.CheckedState.FillColor2 = Hover;
            btnSidebar_Queue.CheckedState.FillColor = Hover;
            btnSidebar_Queue.CheckedState.FillColor2 = Hover;

            btnSidebar_Songs.HoverState.FillColor = Hover;
            btnSidebar_Songs.HoverState.FillColor2 = Hover;
            btnSidebar_Favorites.HoverState.FillColor = Hover;
            btnSidebar_Favorites.HoverState.FillColor2 = Hover;
            btnSidebar_Albums.HoverState.FillColor = Hover;
            btnSidebar_Albums.HoverState.FillColor2 = Hover;
            btnSidebar_Artists.HoverState.FillColor = Hover;
            btnSidebar_Artists.HoverState.FillColor2 = Hover;
            btnSidebar_Queue.HoverState.FillColor = Hover;
            btnSidebar_Queue.HoverState.FillColor2 = Hover;

            SearchBar.FillColor = Hover;

            pictureBox1.Image = Properties.Resources.Nimbus_LightLogo;
            guna2ControlBox1.IconColor = Color.White;
            guna2ControlBox1.BackColor = Color.Transparent;
            guna2ControlBox2.IconColor = Color.White;
            guna2ControlBox2.BackColor = Color.Transparent;

          

            foreach (Control control in ViewPanel.Controls)
            {
                if (control is AllSongPanel allSongControl)
                {
                    allSongControl.DetailsPanel.BackColor = Color1;
                    allSongControl.MenuTabs.FillColor = Color1;
                    allSongControl.SongMenu.FillColor = Color1;
                    allSongControl.Dropdown_Artists.FillColor = Color1;
                    allSongControl.Dropdown_Artists.ItemsAppearance.BackColor = Color1;
                    allSongControl.Dropdown_Artists.ItemsAppearance.SelectedBackColor = Hover;
                    allSongControl.Dropdown_Albums.FillColor = Color1;
                    allSongControl.Dropdown_Albums.ItemsAppearance.BackColor = Color1;
                    allSongControl.Dropdown_Albums.ItemsAppearance.SelectedBackColor = Hover;
                    allSongControl.Dropdown_Sorts.FillColor = Color1;
                    allSongControl.Dropdown_Sorts.ItemsAppearance.BackColor = Color1;
                    allSongControl.Dropdown_Sorts.ItemsAppearance.SelectedBackColor = Hover;

                    allSongControl.btn1.HoverState.FillColor = Hover;
                    allSongControl.btn1.HoverState.FillColor2 = Hover;
                    allSongControl.btn2.HoverState.FillColor = Hover;
                    allSongControl.btn2.HoverState.FillColor2 = Hover;
                    allSongControl.btn3.HoverState.FillColor = Hover;
                    allSongControl.btn3.HoverState.FillColor2 = Hover;
                    allSongControl.btn4.HoverState.FillColor = Hover;
                    allSongControl.btn4.HoverState.FillColor2 = Hover;
                    allSongControl.btn5.HoverState.FillColor = Hover;
                    allSongControl.btn5.HoverState.FillColor2 = Hover;
                    allSongControl.btn6.HoverState.FillColor = Hover;
                    allSongControl.btn6.HoverState.FillColor2 = Hover;
                }
                if (control is QueuePanel queuePanel)
                {
                    queuePanel.DetailsPanel.BackColor = Color1;
                    queuePanel.MenuTab.FillColor = Color1;
                    queuePanel.SongMenu.FillColor = Color1;
                    queuePanel.Dropdown_Artists.FillColor = Color1;
                    queuePanel.Dropdown_Artists.ItemsAppearance.BackColor = Color1;
                    queuePanel.Dropdown_Artists.ItemsAppearance.SelectedBackColor = Hover;
                    queuePanel.Dropdown_Albums.FillColor = Color1;
                    queuePanel.Dropdown_Albums.ItemsAppearance.BackColor = Color1;
                    queuePanel.Dropdown_Albums.ItemsAppearance.SelectedBackColor = Hover;
                    queuePanel.Dropdown_Sorts.FillColor = Color1;
                    queuePanel.Dropdown_Sorts.ItemsAppearance.BackColor = Color1;
                    queuePanel.Dropdown_Sorts.ItemsAppearance.SelectedBackColor = Hover;
                    queuePanel.SearchBars.FillColor = Hover;

                    queuePanel.btn1.HoverState.FillColor = Hover;
                    queuePanel.btn1.HoverState.FillColor2 = Hover;
                    queuePanel.btn2.HoverState.FillColor = Hover;
                    queuePanel.btn2.HoverState.FillColor2 = Hover;
                    queuePanel.btn3.HoverState.FillColor = Hover;
                    queuePanel.btn3.HoverState.FillColor2 = Hover;
                    queuePanel.btn4.HoverState.FillColor = Hover;
                    queuePanel.btn4.HoverState.FillColor2 = Hover;
                }
                if (control is FavoritePanel favoritePanel)
                {
                    favoritePanel.DetailsPanel.BackColor = Color1;
                    favoritePanel.MenuTab.FillColor = Color1;
                    favoritePanel.SongMenu.FillColor = Color1;
                    favoritePanel.Dropdown_Artists.FillColor = Color1;
                    favoritePanel.Dropdown_Artists.ItemsAppearance.BackColor = Color1;
                    favoritePanel.Dropdown_Artists.ItemsAppearance.SelectedBackColor = Hover;
                    favoritePanel.Dropdown_Albums.FillColor = Color1;
                    favoritePanel.Dropdown_Albums.ItemsAppearance.BackColor = Color1;
                    favoritePanel.Dropdown_Albums.ItemsAppearance.SelectedBackColor = Hover;
                    favoritePanel.Dropdown_Sorts.FillColor = Color1;
                    favoritePanel.Dropdown_Sorts.ItemsAppearance.BackColor = Color1;
                    favoritePanel.Dropdown_Sorts.ItemsAppearance.SelectedBackColor = Hover;
                    favoritePanel.SearchBars.FillColor = Hover;

                    favoritePanel.btn1.HoverState.FillColor = Hover;
                    favoritePanel.btn1.HoverState.FillColor2 = Hover;
                    favoritePanel.btn2.HoverState.FillColor = Hover;
                    favoritePanel.btn2.HoverState.FillColor2 = Hover;
                    favoritePanel.btn3.HoverState.FillColor = Hover;
                    favoritePanel.btn3.HoverState.FillColor2 = Hover;
                    favoritePanel.btn4.HoverState.FillColor = Hover;
                    favoritePanel.btn4.HoverState.FillColor2 = Hover;
                    favoritePanel.btn5.HoverState.FillColor = Hover;
                    favoritePanel.btn5.HoverState.FillColor2 = Hover;
                    favoritePanel.btn6.HoverState.FillColor = Hover;
                    favoritePanel.btn6.HoverState.FillColor2 = Hover;
                }
                if (control is AlbumsPanel albumsPanel)
                {
                    albumsPanel.Dropdown_Artists.FillColor = Color1;
                    albumsPanel.Dropdown_Artists.ItemsAppearance.BackColor = Color1;
                    albumsPanel.Dropdown_Artists.ItemsAppearance.SelectedBackColor = Hover;
                    albumsPanel.Dropdown_Albums.FillColor = Color1;
                    albumsPanel.Dropdown_Albums.ItemsAppearance.BackColor = Color1;
                    albumsPanel.Dropdown_Albums.ItemsAppearance.SelectedBackColor = Hover;
                    albumsPanel.Dropdown_Sorts.FillColor = Color1;
                    albumsPanel.Dropdown_Sorts.ItemsAppearance.BackColor = Color1;
                    albumsPanel.Dropdown_Sorts.ItemsAppearance.SelectedBackColor = Hover;
                    albumsPanel.SearchBars.FillColor = Hover;
                }
                if (control is ArtistsPanel artisitsPanel)
                {
                    artisitsPanel.Dropdown_Artists.FillColor = Color1;
                    artisitsPanel.Dropdown_Artists.ItemsAppearance.BackColor = Color1;
                    artisitsPanel.Dropdown_Artists.ItemsAppearance.SelectedBackColor = Hover;
                    artisitsPanel.Dropdown_Albums.FillColor = Color1;
                    artisitsPanel.Dropdown_Albums.ItemsAppearance.BackColor = Color1;
                    artisitsPanel.Dropdown_Albums.ItemsAppearance.SelectedBackColor = Hover;
                    artisitsPanel.Dropdown_Sorts.FillColor = Color1;
                    artisitsPanel.Dropdown_Sorts.ItemsAppearance.BackColor = Color1;
                    artisitsPanel.Dropdown_Sorts.ItemsAppearance.SelectedBackColor = Hover;
                    artisitsPanel.SearchBars.FillColor = Hover;
                }
                if (control is PlaylistPanel playlistPanel)
                {
                    playlistPanel.DetailsPanel.BackColor = Color1;
                    playlistPanel.MenuTabs.FillColor = Color1;
                    playlistPanel.SongMenu.FillColor = Color1;
                    playlistPanel.Dropdown_Artists.FillColor = Color1;
                    playlistPanel.Dropdown_Artists.ItemsAppearance.BackColor = Color1;
                    playlistPanel.Dropdown_Artists.ItemsAppearance.SelectedBackColor = Hover;
                    playlistPanel.Dropdown_Albums.FillColor = Color1;
                    playlistPanel.Dropdown_Albums.ItemsAppearance.BackColor = Color1;
                    playlistPanel.Dropdown_Albums.ItemsAppearance.SelectedBackColor = Hover;
                    playlistPanel.Dropdown_Sorts.FillColor = Color1;
                    playlistPanel.Dropdown_Sorts.ItemsAppearance.BackColor = Color1;
                    playlistPanel.Dropdown_Sorts.ItemsAppearance.SelectedBackColor = Hover;

                    playlistPanel.btn1.HoverState.FillColor = Hover;
                    playlistPanel.btn1.HoverState.FillColor2 = Hover;
                    playlistPanel.btn2.HoverState.FillColor = Hover;
                    playlistPanel.btn2.HoverState.FillColor2 = Hover;
                    playlistPanel.btn3.HoverState.FillColor = Hover;
                    playlistPanel.btn3.HoverState.FillColor2 = Hover;
                    playlistPanel.btn4.HoverState.FillColor = Hover;
                    playlistPanel.btn4.HoverState.FillColor2 = Hover;
                    playlistPanel.btn5.HoverState.FillColor = Hover;
                    playlistPanel.btn5.HoverState.FillColor2 = Hover;
                    playlistPanel.btn6.HoverState.FillColor = Hover;
                    playlistPanel.btn6.HoverState.FillColor2 = Hover;
                }
            }
        }
        #endregion
        #region Apply Green Theme
        private void ApplyGreenTheme()
        {
            var BGColor = Color.FromArgb(33, 40, 38);        
            var Color1 = Color.FromArgb(75, 90, 86);
            var NowPlayingColor = Color.FromArgb(50, 60, 57);
            var Hover = Color.FromArgb(67, 78, 75);

            this.BackColor = BGColor;
            this.ForeColor = Color.White;

            PlaylistList.BackColor = BGColor;
            panel3.BackColor = NowPlayingColor;
            btnSidebar_Songs.CheckedState.FillColor = Hover;
            btnSidebar_Songs.CheckedState.FillColor2 = Hover;
            btnSidebar_Favorites.CheckedState.FillColor = Hover;
            btnSidebar_Favorites.CheckedState.FillColor2 = Hover;
            btnSidebar_Albums.CheckedState.FillColor = Hover;
            btnSidebar_Albums.CheckedState.FillColor2 = Hover;
            btnSidebar_Artists.CheckedState.FillColor = Hover;
            btnSidebar_Artists.CheckedState.FillColor2 = Hover;
            btnSidebar_Queue.CheckedState.FillColor = Hover;
            btnSidebar_Queue.CheckedState.FillColor2 = Hover;

            btnSidebar_Songs.HoverState.FillColor = Hover;
            btnSidebar_Songs.HoverState.FillColor2 = Hover;
            btnSidebar_Favorites.HoverState.FillColor = Hover;
            btnSidebar_Favorites.HoverState.FillColor2 = Hover;
            btnSidebar_Albums.HoverState.FillColor = Hover;
            btnSidebar_Albums.HoverState.FillColor2 = Hover;
            btnSidebar_Artists.HoverState.FillColor = Hover;
            btnSidebar_Artists.HoverState.FillColor2 = Hover;
            btnSidebar_Queue.HoverState.FillColor = Hover;
            btnSidebar_Queue.HoverState.FillColor2 = Hover;

            SearchBar.FillColor = Hover;

            pictureBox1.Image = Properties.Resources.Nimbus_LightLogo;
            guna2ControlBox1.IconColor = Color.White;
            guna2ControlBox1.BackColor = Color.Transparent;
            guna2ControlBox2.IconColor = Color.White;
            guna2ControlBox2.BackColor = Color.Transparent;


            
            foreach (Control control in ViewPanel.Controls)
            {
                if (control is AllSongPanel allSongControl)
                {
                    allSongControl.DetailsPanel.BackColor = Color1;
                    allSongControl.MenuTabs.FillColor = Color1;
                    allSongControl.SongMenu.FillColor = Color1;
                    allSongControl.Dropdown_Artists.FillColor = Color1;
                    allSongControl.Dropdown_Artists.ItemsAppearance.BackColor = Color1;
                    allSongControl.Dropdown_Artists.ItemsAppearance.SelectedBackColor = Hover;
                    allSongControl.Dropdown_Albums.FillColor = Color1;                
                    allSongControl.Dropdown_Albums.ItemsAppearance.BackColor = Color1;
                    allSongControl.Dropdown_Albums.ItemsAppearance.SelectedBackColor = Hover;
                    allSongControl.Dropdown_Sorts.FillColor = Color1;
                    allSongControl.Dropdown_Sorts.ItemsAppearance.BackColor = Color1;
                    allSongControl.Dropdown_Sorts.ItemsAppearance.SelectedBackColor = Hover;

                    allSongControl.btn1.HoverState.FillColor = Hover;
                    allSongControl.btn1.HoverState.FillColor2 = Hover;
                    allSongControl.btn2.HoverState.FillColor = Hover;
                    allSongControl.btn2.HoverState.FillColor2 = Hover;
                    allSongControl.btn3.HoverState.FillColor = Hover;
                    allSongControl.btn3.HoverState.FillColor2 = Hover;
                    allSongControl.btn4.HoverState.FillColor = Hover;
                    allSongControl.btn4.HoverState.FillColor2 = Hover;
                    allSongControl.btn5.HoverState.FillColor = Hover;
                    allSongControl.btn5.HoverState.FillColor2 = Hover;
                    allSongControl.btn6.HoverState.FillColor = Hover;
                    allSongControl.btn6.HoverState.FillColor2 = Hover;
                }                       
                if (control is QueuePanel queuePanel)
                {
                    queuePanel.DetailsPanel.BackColor = Color1;
                    queuePanel.MenuTab.FillColor = Color1;
                    queuePanel.SongMenu.FillColor = Color1;
                    queuePanel.Dropdown_Artists.FillColor = Color1;
                    queuePanel.Dropdown_Artists.ItemsAppearance.BackColor = Color1;
                    queuePanel.Dropdown_Artists.ItemsAppearance.SelectedBackColor = Hover;
                    queuePanel.Dropdown_Albums.FillColor = Color1;
                    queuePanel.Dropdown_Albums.ItemsAppearance.BackColor = Color1;
                    queuePanel.Dropdown_Albums.ItemsAppearance.SelectedBackColor = Hover;
                    queuePanel.Dropdown_Sorts.FillColor = Color1;
                    queuePanel.Dropdown_Sorts.ItemsAppearance.BackColor = Color1;
                    queuePanel.Dropdown_Sorts.ItemsAppearance.SelectedBackColor = Hover;
                    queuePanel.SearchBars.FillColor = Hover;

                    queuePanel.btn1.HoverState.FillColor = Hover;
                    queuePanel.btn1.HoverState.FillColor2 = Hover;
                    queuePanel.btn2.HoverState.FillColor = Hover;
                    queuePanel.btn2.HoverState.FillColor2 = Hover;
                    queuePanel.btn3.HoverState.FillColor = Hover;
                    queuePanel.btn3.HoverState.FillColor2 = Hover;
                    queuePanel.btn4.HoverState.FillColor = Hover;
                    queuePanel.btn4.HoverState.FillColor2 = Hover;                 
                }
                if (control is FavoritePanel favoritePanel)
                {
                    favoritePanel.DetailsPanel.BackColor = Color1;
                    favoritePanel.MenuTab.FillColor = Color1;
                    favoritePanel.SongMenu.FillColor = Color1;
                    favoritePanel.Dropdown_Artists.FillColor = Color1;
                    favoritePanel.Dropdown_Artists.ItemsAppearance.BackColor = Color1;
                    favoritePanel.Dropdown_Artists.ItemsAppearance.SelectedBackColor = Hover;
                    favoritePanel.Dropdown_Albums.FillColor = Color1;
                    favoritePanel.Dropdown_Albums.ItemsAppearance.BackColor = Color1;
                    favoritePanel.Dropdown_Albums.ItemsAppearance.SelectedBackColor = Hover;
                    favoritePanel.Dropdown_Sorts.FillColor = Color1;
                    favoritePanel.Dropdown_Sorts.ItemsAppearance.BackColor = Color1;
                    favoritePanel.Dropdown_Sorts.ItemsAppearance.SelectedBackColor = Hover;
                    favoritePanel.SearchBars.FillColor = Hover;

                    favoritePanel.btn1.HoverState.FillColor = Hover;
                    favoritePanel.btn1.HoverState.FillColor2 = Hover;
                    favoritePanel.btn2.HoverState.FillColor = Hover;
                    favoritePanel.btn2.HoverState.FillColor2 = Hover;
                    favoritePanel.btn3.HoverState.FillColor = Hover;
                    favoritePanel.btn3.HoverState.FillColor2 = Hover;
                    favoritePanel.btn4.HoverState.FillColor = Hover;
                    favoritePanel.btn4.HoverState.FillColor2 = Hover;
                    favoritePanel.btn5.HoverState.FillColor = Hover;
                    favoritePanel.btn5.HoverState.FillColor2 = Hover;
                    favoritePanel.btn6.HoverState.FillColor = Hover;
                    favoritePanel.btn6.HoverState.FillColor2 = Hover;
                }
                if (control is AlbumsPanel albumsPanel)
                {
                    albumsPanel.Dropdown_Artists.FillColor = Color1;
                    albumsPanel.Dropdown_Artists.ItemsAppearance.BackColor = Color1;
                    albumsPanel.Dropdown_Artists.ItemsAppearance.SelectedBackColor = Hover;
                    albumsPanel.Dropdown_Albums.FillColor = Color1;
                    albumsPanel.Dropdown_Albums.ItemsAppearance.BackColor = Color1;
                    albumsPanel.Dropdown_Albums.ItemsAppearance.SelectedBackColor = Hover;
                    albumsPanel.Dropdown_Sorts.FillColor = Color1;
                    albumsPanel.Dropdown_Sorts.ItemsAppearance.BackColor = Color1;
                    albumsPanel.Dropdown_Sorts.ItemsAppearance.SelectedBackColor = Hover;
                    albumsPanel.SearchBars.FillColor = Hover;
                }
                if (control is ArtistsPanel artisitsPanel)
                {
                    artisitsPanel.Dropdown_Artists.FillColor = Color1;
                    artisitsPanel.Dropdown_Artists.ItemsAppearance.BackColor = Color1;
                    artisitsPanel.Dropdown_Artists.ItemsAppearance.SelectedBackColor = Hover;
                    artisitsPanel.Dropdown_Albums.FillColor = Color1;
                    artisitsPanel.Dropdown_Albums.ItemsAppearance.BackColor = Color1;
                    artisitsPanel.Dropdown_Albums.ItemsAppearance.SelectedBackColor = Hover;
                    artisitsPanel.Dropdown_Sorts.FillColor = Color1;
                    artisitsPanel.Dropdown_Sorts.ItemsAppearance.BackColor = Color1;
                    artisitsPanel.Dropdown_Sorts.ItemsAppearance.SelectedBackColor = Hover;
                    artisitsPanel.SearchBars.FillColor = Hover;
                }
                if (control is PlaylistPanel playlistPanel)
                {
                    playlistPanel.DetailsPanel.BackColor = Color1;
                    playlistPanel.MenuTabs.FillColor = Color1;
                    playlistPanel.SongMenu.FillColor = Color1;
                    playlistPanel.Dropdown_Artists.FillColor = Color1;
                    playlistPanel.Dropdown_Artists.ItemsAppearance.BackColor = Color1;
                    playlistPanel.Dropdown_Artists.ItemsAppearance.SelectedBackColor = Hover;
                    playlistPanel.Dropdown_Albums.FillColor = Color1;
                    playlistPanel.Dropdown_Albums.ItemsAppearance.BackColor = Color1;
                    playlistPanel.Dropdown_Albums.ItemsAppearance.SelectedBackColor = Hover;
                    playlistPanel.Dropdown_Sorts.FillColor = Color1;
                    playlistPanel.Dropdown_Sorts.ItemsAppearance.BackColor = Color1;
                    playlistPanel.Dropdown_Sorts.ItemsAppearance.SelectedBackColor = Hover;

                    playlistPanel.btn1.HoverState.FillColor = Hover;
                    playlistPanel.btn1.HoverState.FillColor2 = Hover;
                    playlistPanel.btn2.HoverState.FillColor = Hover;
                    playlistPanel.btn2.HoverState.FillColor2 = Hover;
                    playlistPanel.btn3.HoverState.FillColor = Hover;
                    playlistPanel.btn3.HoverState.FillColor2 = Hover;
                    playlistPanel.btn4.HoverState.FillColor = Hover;
                    playlistPanel.btn4.HoverState.FillColor2 = Hover;
                    playlistPanel.btn5.HoverState.FillColor = Hover;
                    playlistPanel.btn5.HoverState.FillColor2 = Hover;
                    playlistPanel.btn6.HoverState.FillColor = Hover;
                    playlistPanel.btn6.HoverState.FillColor2 = Hover;
                }
            }
        }
        #endregion

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

        private void UpdatePlayPauseButton(bool isPlaying)
        {
            Pausebtn.Checked = isPlaying ? true : false;
            //guna2GradientButton2.Text = isPlaying ? "Pause" : "Play";
        }

        private void Queuebtn_Click(object sender, EventArgs e)
        {
            btnSidebar_Queue_Click(sender, e);
            btnSidebar_Queue.Checked = true;
        }

        private void Playbtn_Click(object sender, EventArgs e)
        {
            Playbtn.Visible = false;
            Pausebtn.Visible = true;
            
        }

        private void Pausebtn_Click(object sender, EventArgs e)
        {
            Playbtn.Visible = true;
            Pausebtn.Visible = false;
            
        }

        private void VolumeBar_Scroll(object sender, ScrollEventArgs e)
        {
            PlayerState.SetVolume(VolumeBar.Value);
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Automatically update TimePlayed label
            if (PlayerState.player.currentMedia != null)
            {
                double currentPosition = PlayerState.player.controls.currentPosition; // Current playback position
                double duration = PlayerState.player.currentMedia.duration;          // Total duration
                UpdateTimePlayed(currentPosition, duration);
                UpdateProgressBar(currentPosition, duration);
            }
        }

        private void UpdateTimePlayed(double current, double total)
        {
            // Format the current time and total duration
            string currentTime = TimeSpan.FromSeconds(current).ToString(@"mm\:ss");
            string totalTime = TimeSpan.FromSeconds(total).ToString(@"mm\:ss");

            // Set the TimePlayed label text
            TimePlayed.Text = $"{currentTime}";
            EndTime.Text = $"{totalTime}";
        }

        private void UpdateProgressBar(double current, double total)
        {
            if (total > 0) // Avoid division by zero
            {
                // Calculate progress as a percentage
                int progress = (int)((current / total) * 100);
                TimeSong.Value = progress;
            }
        }

        private void Shufflebtn_Click(object sender, EventArgs e)
        {
            Shufflebtn.Visible = false;
            ShufflebtnHighlight.Visible = true;
        }

        private void ShufflebtnHighlight_Click(object sender, EventArgs e)
        {
            Shufflebtn.Visible = true;
            ShufflebtnHighlight.Visible = false;
        }

        private void Loopbtn_Click(object sender, EventArgs e)
        {
            Loopbtn.Visible = false;
            LoopbtnHighlight.Visible = true;
        }

        private void LoopbtnHighlight_Click(object sender, EventArgs e)
        {
            Loopbtn.Visible = true;
            LoopbtnHighlight.Visible = false;
        }

        private void Miniplayerbtn_Click(object sender, EventArgs e)
        {  
            Miniplayer miniplayer = new Miniplayer();
            MiniplayerPanel.Controls.Clear();
            MiniplayerPanel.Location = new Point(1277, 7);
            MiniplayerPanel.Size = miniplayer.Size;
            MiniplayerPanel.Controls.Add(new Miniplayer());
            MiniplayerPanel.Visible = true;
        }

        private void MiniplayerPanel_ControlRemoved(object sender, ControlEventArgs e)
        {
            MiniplayerPanel.Visible = false;
        }
    }
}
