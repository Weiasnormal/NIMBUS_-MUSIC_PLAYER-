using Guna.UI.WinForms;
using Guna.UI2.WinForms;
using NIMBUS__MUSIC_PLAYER_.Helper;
using NimbusClassLibrary.Controller;
using NimbusClassLibrary.Model;
using Data = NimbusClassLibrary.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static NIMBUS__MUSIC_PLAYER_.HorizontalSongs;
using NIMBUS__MUSIC_PLAYER_.Interface;

namespace NIMBUS__MUSIC_PLAYER_
{
    public partial class AllSongPanel : UserControl, IRefresh
    {
        private Size originalFormSize; // Store the original size of the form
        private object selectedSong;
        SongController<Song> controller = new SongController<Song>();
        public AllSongPanel()
        {
            InitializeComponent();

            // Subscribe to state changes
            PlayerState.OnStateChanged += UpdatePlayPauseButton;

            guna2GradientButton2.Click += (sender, e) =>
            {
                // Toggle the player state
                PlayerState.IsPlaying = !PlayerState.IsPlaying;
            };

            // Capture the original size of the form
            originalFormSize = this.Size;

            // Attach the Resize event handler
            this.Resize += AllSongPanel_Resize;

            // Additional initialization for your panel and scrollbar
            AllSongsPanel.AutoScroll = true;
            AllSongsScrollbar.Scroll += (sender, e) =>
            {
                AllSongsPanel.VerticalScroll.Value = AllSongsScrollbar.Value;
            };


            int numControls = AllSongsPanel.Controls.Count;
            AllSongsPanel.SuspendLayout();
            AllSongsPanel.Controls.Clear();
            AllSongsPanel.AutoScroll = true;
            AllSongsPanel.VerticalScroll.Visible = false;

            this.Dock = DockStyle.Right;
            AllSongsScrollbar.Scroll += (sender, e) => { AllSongsPanel.VerticalScroll.Value = AllSongsScrollbar.Value; };
            AllSongsScrollbar.Height = AllSongsPanel.Height;
            AllSongsScrollbar.Visible = false;

            this.Controls.Add(AllSongsScrollbar);

            AllSongsPanel.ResumeLayout();

            // then update the form
            AllSongsPanel.PerformLayout();

            MenuTab.Visible = false;
            SongsMenu.Visible = false;

            loadSongs();

            Menu_AddPlaylist.Click += Menu_AddPlaylist_Click;

            //AllSongsPanel.Refresh();
        }
        public void RefreshPanel()
        {
            
        }

        private void UpdatePlayPauseButton(bool isPlaying)
        {
            guna2GradientButton2.Checked = isPlaying ? true : false;
            //guna2GradientButton2.Text = isPlaying ? "Pause" : "Play";
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

            foreach (Control control in AllSongsPanel.Controls)
            {
                // Skip resizing the scrollbar if not needed
                if (control == AllSongsScrollbar)
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
            AllSongsScrollbar.Height = AllSongsPanel.Height;
            AllSongsScrollbar.Maximum = AllSongsPanel.VerticalScroll.Maximum;
        }


        
        public Panel DetailsPanel
        {
            get { return DetailPanel; }
        }

        public Guna2Panel MenuTabs
        {
            get { return MenuTab; }
        }

        public Guna2Panel SongMenu
        {
            get { return SongsMenu; }
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
            get { return Menu_DeleteSong; }
        }
        public Guna2GradientButton btn2
        {
            get { return Menu_AddQueue; }
        }
        public Guna2GradientButton btn3
        {
            get { return Menu_AddPlaylist; }
        }
        public Guna2GradientButton btn4
        {
            get { return guna2GradientButton4; }
        }
        public Guna2GradientButton btn5 { get { return Menu_AddFvorites; } }
        public Guna2GradientButton btn6 { get { return guna2GradientButton1; } }
        #endregion

        private Form _addToPlaylistForm;
        public void loadSongs()
        {
            if (!AllSongsPanel.IsHandleCreated)
            {
                AllSongsPanel.HandleCreated += (s, e) => loadSongs();
                return;
            }

            AllSongsPanel.Controls.Clear();

            int songnum = 1;

            List<Song> songs = (List<Song>)controller.GetCollection<Song>();

            foreach (Song song in songs)
            {
                AllSongsPanel.Invoke(new Action(() =>
                {
                    // Create an instance of HorizontalSongs
                    var songControl = new HorizontalSongs(SongsMenu, songnum, song);

                    // Subscribe to the MenuButtonClicked event
                    songControl.MenuButtonClicked += SongControl_MenuButtonClicked;

                    // Add the song control to the AllSongsPanel
                    AllSongsPanel.Controls.Add(songControl);
                }));
                songnum++;
            }

        }

        private void DetailPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Menubtn_Click(object sender, EventArgs e)
        {
            MenuTab.Visible = !MenuTab.Visible;
        }

        private void SongControl_MenuButtonClicked(object sender, EventArgs e)
        {
            SongsMenu.Visible = !SongsMenu.Visible;
            selectedSong = sender;
        }

        private void Menu_AddPlaylist_Click(object sender, EventArgs e)
        {
            if (this.FindForm() is Nimbus mainForm)
            {
                mainForm.SwitchToPanel(5);
            }
        }

        private void Menu_AddFvorites_Click(object sender, EventArgs e)
        {
            HorizontalSongs Ssong = (HorizontalSongs)selectedSong;
            Song songTobeChanged = Ssong.Song;

            if(songTobeChanged.IsFavorite)
            {
                MessageBox.Show($"'{songTobeChanged.Title}' is already in Favorites!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Set Favorites into true
            songTobeChanged.IsFavorite = true;

            // Log the change for debugging
            //MessageBox.Show($"Updating Song ID={songTobeChanged.Id}, IsFavorite={songTobeChanged.IsFavorite}");

            // Call the update method
            bool success = controller.Update(songTobeChanged);

            if (success)
            {
                var nimbus = this.FindForm() as Nimbus;

                if (nimbus != null)
                {
                    nimbus.InitializeFavoriteButton();
                }
                Helper.Events.AddToFavorites();
                MessageBox.Show($"'{songTobeChanged.Title}' added to Favorites!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
               // IRefresh refresh = this.FindForm() as IRefresh;
            }
            else
            {
                MessageBox.Show($"Failed to add '{songTobeChanged.Title}' to Favorites.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

                SongsMenu.Visible = false;
            
        }

        private void Menu_DeleteSong_Click(object sender, EventArgs e)
        {

            Song songTobeDeleted = ((HorizontalSongs)selectedSong).Song;

            controller.Delete(((HorizontalSongs)selectedSong).Song);
            SongsMenu.Visible = false;
            MessageBox.Show($"'{songTobeDeleted.Title}' has been Deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            AllSongsPanel.Controls.Clear();
            loadSongs();
        }

        private void Menu_AddQueue_Click(object sender, EventArgs e)
        {
            HorizontalSongs Ssong = (HorizontalSongs)selectedSong;
            Song song = Ssong.Song;

            if (NimbusClassLibrary.Helpers.GlobalLibraries.Playing_Song.Contains(song))
            {
                MessageBox.Show($"'{song.Title}' is already in Queue!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            NimbusClassLibrary.Helpers.GlobalLibraries.Playing_Song.AddLast(song);
            MessageBox.Show($"'{song.Title}' is now in Queue!", "Added!", MessageBoxButtons.OK, MessageBoxIcon.Information);


            Helper.Events.AddToQueue(sender,e);
            SongsMenu.Visible = false;
        }
    }
}
