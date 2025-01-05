using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using AxWMPLib;
using Guna.UI.WinForms;
using Guna.UI2.HtmlRenderer.Adapters.Entities;
using Guna.UI2.WinForms;
using NIMBUS__MUSIC_PLAYER_.Helper;
using NIMBUS__MUSIC_PLAYER_.Interface;
using NIMBUS__MUSIC_PLAYER_.Properties;
using NimbusClassLibrary;
using NimbusClassLibrary.Controller;
using NimbusClassLibrary.Data;
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
        private System.Timers.Timer scrollTimer;
        private System.Windows.Forms.Timer timer;

        public Nimbus()
        {
            InitializeComponent();
            Initialize_Navigation_Controls();
            InitializeFavoriteButton();

            var horizontalSongs = new HorizontalSongs(this);
            this.Controls.Add(horizontalSongs);

            //var favoritePanel = new FavoritePanel(this);
            //this.Controls.Add(favoritePanel);
            PlayerState.player.DurationUnitChange += Player_DurationUnitChange;
            Helper.Events.UpdateMainUI += UpdateMainUI;
            ShowAddPlaylist.Visible = false;
            PlaylistList.Visible = false;
            btnSound_Open.Visible = false;
            VolumeBar.Visible = false;
            lblVolumePercent.Visible = false;
            btnFavorite_Pressed.Visible = false;
            
            Pausebtn.Visible = false;

            PlayerState.OnStateChanged += UpdatePlayPauseButton;

            Pausebtn.Click += (sender, e) =>
            {
                // Toggle the player state
                PlayerState.IsPlaying = !PlayerState.IsPlaying;
            };


            #region Song Timer / Duration
            
            double sample = PlayerState.player.controls.currentPosition;
            // Initialize ProgressBar
            TimeSong.Minimum = 0; // Start at 0
            TimeSong.Maximum = (int)Helper.PlayerState.CurrentSong.Value.Duration.TotalSeconds; // Progress will be in percentage
            #endregion

            #region Change Play/Pause Button
            // Subscribe to the PlayerState's OnStateChanged event
            PlayerState.OnStateChanged += PlayerState_OnStateChanged;

            // Initialize button states
            Playbtn.Visible = true;
            Pausebtn.Visible = false;
            #endregion

            #region Change .text/value of Artist and Song Title
            // Subscribe to PlayerState's OnStateChanged event
            PlayerState.OnStateChanged += PlayerState_OnStateChanged1;

            TitleSonglbl.Text = "-";
            Artistlbl.Text = "-";

            // Initialize UI elements
            UpdateSongDetails();
            #endregion

            
        }

        private void Player_DurationUnitChange(int NewDurationUnit)
        {
            TimeSong.Value = NewDurationUnit;
        }

        #region Change to pause icon when a song card is clicked
        private void PlayerState_OnStateChanged(bool isPlaying)
        {
            // Update the visibility of the buttons based on the playing state
            if (InvokeRequired)
            {
                // Ensure the UI update happens on the main thread
                Invoke(new Action(() => UpdateButtonVisibility(isPlaying)));
            }
            else
            {
                UpdateButtonVisibility(isPlaying);
            }
        }

        private void UpdateButtonVisibility(bool isPlaying)
        {
            Playbtn.Visible = !isPlaying; // Play button is visible when not playing
            Pausebtn.Visible = isPlaying; // Pause button is visible when playing
        }
        #endregion

        #region Change.text/value of Artist and Song Title
        private void PlayerState_OnStateChanged1(bool isPlaying)
        {
            // Ensure updates happen on the UI thread
            if (InvokeRequired)
            {
                Invoke(new Action(UpdateSongDetails));
            }
            else
            {
                UpdateSongDetails();
            }
        }

        public void UpdateSongDetails()
        {
            try
            {
                // Get the current song's file path from the WMPLib player
                string playingSongPath = PlayerState.player?.URL;

                if (!string.IsNullOrEmpty(playingSongPath))
                {
                    // Use SongController to fetch the song details based on the file path
                    var songController = new SongController<Song>();
                    var currentSong = songController.GetCollection<Song>()
                                         .FirstOrDefault(s => s.File_Path == playingSongPath);

                    if (currentSong != null)
                    {
                        // Truncate title if it's longer than 12 characters
                        TitleSonglbl.Text = TruncateText(currentSong.Title, 12);

                        // Update the artist name
                        Artistlbl.Text = currentSong.Artist?.Display_Name ?? "-";
                    }
                    else
                    {
                        TitleSonglbl.Text = "-";
                        Artistlbl.Text = "-";
                    }
                }
                else
                {
                    TitleSonglbl.Text = "-";
                    Artistlbl.Text = "-";
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions gracefully (e.g., logging)
                Console.WriteLine($"Error updating song details: {ex.Message}");
            }
        }

        private string TruncateText(string text, int maxLength)
        {
            if (string.IsNullOrEmpty(text)) return "-";
            return text.Length > maxLength ? text.Substring(0, maxLength) + "..." : text;
        }
        

        private void UpdateMainUI()
        {
            Song CurrentSong = PlayerState.CurrentSong.Value;

            TitleSonglbl.Text = CurrentSong.Title;
            Artistlbl.Text = CurrentSong.Artist.Display_Name;
            
        }
        #endregion

        #region RefreshPanelImplementation
        public class DashboardNavigation
        {
            private IRefresh[] refreshablePanels;
            private Control viewPanel;
            private UserControl[] panels;
            public int CurrentPanelIndex { get; private set; }

            public DashboardNavigation(UserControl[] panels, Control viewPanel)
            {
                this.panels = panels;
                this.viewPanel = viewPanel;
                this.refreshablePanels = panels.OfType<IRefresh>().ToArray();
            }

            public void Display(int panelIndex)
            {
                if (panelIndex < 0 || panelIndex >= panels.Length)
                    return;

                CurrentPanelIndex = panelIndex;
                viewPanel.Controls.Clear();
                viewPanel.Controls.Add(panels[panelIndex]);
            }

            public void RefreshPanel(int panelIndex)
            {
                if (panelIndex >= 0 && panelIndex < refreshablePanels.Length)
                {
                    refreshablePanels[panelIndex].RefreshPanel();
                }
            }
            /*public void AllRefresh()
            {
                foreach (var panel in dashboardNavigation.refreshablePanels)
                {
                    panel.RefreshPanel();
                }
            }*/
        }
       
        public void RefreshCurrentPanel()
        {
            int activePanelIndex = dashboardNavigation.CurrentPanelIndex;
            dashboardNavigation.RefreshPanel(activePanelIndex);
        }
        #endregion

        #region SidebarNavigation
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

        private void btnSidebar_Songs_Click(object sender, EventArgs e)
        {
            dashboardNavigation.Display(0);
        }

        private void btnSidebar_Favorites_Click(object sender, EventArgs e)
        {
            dashboardNavigation.Display(1);
        }

        private void btnSidebar_Albums_Click(object sender, EventArgs e)
        {
            dashboardNavigation.Display(2);
        }

        private void btnSidebar_Artists_Click(object sender, EventArgs e)
        {
            dashboardNavigation.Display(3);
        }

        private void btnSidebar_Queue_Click(object sender, EventArgs e)
        {
            dashboardNavigation.Display(4);
        }

        private void btnSidebar_Playlist_Click(object sender, EventArgs e)
        {
            PlaylistList.Visible = !PlaylistList.Visible;
            if (PlaylistList.Visible)
                dashboardNavigation.Display(5);
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

        #endregion


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
            TimeSong.ProgressColor = Color.FromArgb(255, 128, 0);
            TimeSong.ProgressColor2 = Color.FromArgb(255, 128, 0);
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
            TimeSong.ProgressColor = Color.FromArgb(172, 40, 79);
            TimeSong.ProgressColor2 = Color.FromArgb(172, 40, 79);
            ShufflebtnHighlight.CustomImages.Image = Resources.Icon_ShuffleBlue;
            LoopbtnHighlight.CustomImages.Image = Resources.Icon_LoopBlue;
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
            TimeSong.ProgressColor = Color.FromArgb(170, 136, 0);
            TimeSong.ProgressColor2 = Color.FromArgb(170, 136, 0);
            ShufflebtnHighlight.CustomImages.Image = Resources.Icon_ShuffleGreen;
            LoopbtnHighlight.CustomImages.Image = Resources.Icon_LoopGreen;
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

   
        #region ImportMusicButtonClick
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

                    // Load all existing songs into a HashSet for quick lookup
                    var existingSongs = new HashSet<(string Title, string FilePath)>(
                        DBContext.songs.Select(s => (s.Title, s.File_Path))
                    );

                    foreach (string filePath in filePaths)
                    {
                        try
                        {
                            // Use TagLib to extract metadata
                            var tagFile = TagLib.File.Create(filePath);
                            string title = tagFile.Tag.Title ?? System.IO.Path.GetFileNameWithoutExtension(filePath);
                            string artistName = tagFile.Tag.FirstPerformer ?? "Unknown Artist";
                            TimeSpan duration = tagFile.Properties.Duration;

                            // Check if the song already exists in the HashSet
                            if (existingSongs.Contains((title, filePath)))
                            {
                                MessageBox.Show($"The song '{title}' already exists in the library.", "Duplicate Song", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                continue;
                            }

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
                                // Add the new song to the HashSet after successful insertion
                                existingSongs.Add((newSong.Title, newSong.File_Path));
                                MessageBox.Show($"Song '{newSong.Title}' by '{artistName}' imported successfully!", "Import Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Initialize_Navigation_Controls();
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
        #endregion

        #region NowPlayingPanel

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
            PlayerState.player.controls.play();
        }

        private void Pausebtn_Click(object sender, EventArgs e)
        {
            Playbtn.Visible = true;
            Pausebtn.Visible = false;
            PlayerState.player.controls.pause();
            
        }

        private void VolumeBar_Scroll(object sender, ScrollEventArgs e)
        {
            PlayerState.SetVolume(VolumeBar.Value);
            lblVolumePercent.Text = VolumeBar.Value.ToString() + " %";
            lblVolumePercent.Visible = true; // Show the label while scrolling

            // Reset and start the timer
            if (scrollTimer != null)
            {
                scrollTimer.Stop();
                scrollTimer.Dispose();
            }

            scrollTimer = new System.Timers.Timer(100);
            scrollTimer.Elapsed += HideVolumeLabel;
            scrollTimer.AutoReset = false; // Ensure the timer only runs once
            scrollTimer.Start();
        }

        private void HideVolumeLabel(object sender, ElapsedEventArgs e)
        {
            if (lblVolumePercent.InvokeRequired)
            {
                lblVolumePercent.Invoke(new Action(() => lblVolumePercent.Visible = false));
            }
            else
            {
                lblVolumePercent.Visible = false;
            }
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
            
            NimbusMiniplayer miniplayer = new NimbusMiniplayer();
            miniplayer.Show();
            this.Hide();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            PlayerState.SetNextSong();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            PlayerState.SetPreviousSong();
        }

        private void btnSound_Close_Click(object sender, EventArgs e)
        {
            btnSound_Close.Visible = false;
            btnSound_Open.Visible = true;
            VolumeBar.Visible = true;
        }

        private void btnSound_Open_Click(object sender, EventArgs e)
        {
            btnSound_Close.Visible = true;
            btnSound_Open.Visible = false;
            VolumeBar.Visible = false;
        }

        #endregion

        #region FavoriteButtonFunction
        public void InitializeFavoriteButton()
        {
            try
            {
                // Get the currently playing song's file path from PlayerState
                string playingSongPath = PlayerState.player.URL;

                if (!string.IsNullOrEmpty(playingSongPath))
                {
                    // Use SongController to fetch the song by file path
                    var songController = new SongController<Song>();
                    Song currentSong = songController.GetCollection<Song>()
                                          .FirstOrDefault(s => s.File_Path == playingSongPath);

                    if (currentSong != null)
                    {
                        // Update button visibility based on the song's IsFavorite status
                        btnFavorite_Default.Visible = !currentSong.IsFavorite;
                        btnFavorite_Pressed.Visible = currentSong.IsFavorite;
                        //MessageBox.Show($"{currentSong.IsFavorite} {currentSong.IsFavorite}");
                    }
                    else
                    {
                        // Hide both buttons if no song is playing
                        btnFavorite_Default.Visible = true;
                        btnFavorite_Pressed.Visible = false;
                    }

                }
                
            }
            catch (Exception ex)
            {
                // Log or handle the exception as needed
                Console.WriteLine(ex.Message);
            }
        }


        private void btnFavorite_Default_Click(object sender, EventArgs e)
        {
            //InitializeFavoriteButton();
            // Get the currently playing song's file path
            string playingSongPath = PlayerState.player.URL;

            if (!string.IsNullOrEmpty(playingSongPath))
            {
                var songController = new SongController<Song>();
                Song currentSong = songController.GetCollection<Song>()
                                      .FirstOrDefault(s => s.File_Path == playingSongPath);

                if (currentSong != null)
                {
                    currentSong.IsFavorite = true;

                    // Update the song in the database
                    if (songController.Update(currentSong))
                    {
                        btnFavorite_Default.Visible = false;
                        btnFavorite_Pressed.Visible = true;
                        MessageBox.Show($"'{currentSong.Title}' added to Favorites!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //RefreshFavoriteButton();
                        RefreshCurrentPanel();

                    }
                    else
                    {
                        MessageBox.Show($"Failed to add '{currentSong.Title}' to Favorites.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void btnFavorite_Pressed_Click(object sender, EventArgs e)
        {
            //InitializeFavoriteButton();
            // Get the currently playing song's file path
            string playingSongPath = PlayerState.player.URL;

            if (!string.IsNullOrEmpty(playingSongPath))
            {
                var songController = new SongController<Song>();
                Song currentSong = songController.GetCollection<Song>()
                                      .FirstOrDefault(s => s.File_Path == playingSongPath);

                if (currentSong != null)
                {
                    currentSong.IsFavorite = false;

                    // Update the song in the database
                    if (songController.Update(currentSong))
                    {
                        btnFavorite_Default.Visible = true;
                        btnFavorite_Pressed.Visible = false;
                        MessageBox.Show($"'{currentSong.Title}' removed from Favorites!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //RefreshFavoriteButton();
                        RefreshCurrentPanel();
                    }
                    else
                    {
                        MessageBox.Show($"Failed to remove '{currentSong.Title}' from Favorites.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        #endregion
    }
}
