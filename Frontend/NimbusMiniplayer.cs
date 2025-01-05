using NIMBUS__MUSIC_PLAYER_.Helper;
using NimbusClassLibrary.Controller;
using NimbusClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace NIMBUS__MUSIC_PLAYER_
{
    public partial class NimbusMiniplayer : Form
    {
        private System.Timers.Timer scrollTimer;
        private System.Windows.Forms.Timer timer;
        
        public NimbusMiniplayer()
        {
            InitializeComponent();
            Helper.Events.UpdateMainUI += UpdateMainUI;

            lblVolumePercent.Visible = false; // Hide the volume label by default

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 500; // Update every 500ms (half a second)
            timer.Tick += Timer_Tick; 

            // Initialize ProgressBar
            TimeSong.Minimum = 0; // Start at 0
            TimeSong.Maximum = 100; // Progress will be in percentage

            // Subscribe to the PlayerState's OnStateChanged event
            PlayerState.OnStateChanged += PlayerState_OnStateChanged;

            // Initialize button states
            Playbtn.Visible = true;
            Pausebtn.Visible = false;
            
            UpdateSongDetails();

            InitializeFavoriteButton();
        }

        

        private void CloseMiniplayer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Switchtomain_Click(object sender, EventArgs e)
        {
           /* Nimbus nimbus = new Nimbus();
            nimbus.Show();
            this.Hide();
*/
            var nimbus = Application.OpenForms.OfType<Nimbus>().FirstOrDefault();

            if (nimbus != null)
            {
                nimbus.Show(); 
                nimbus.InitializeFavoriteButton();
                this.Hide();   
            }
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
        private void Timer_Tick(object sender, EventArgs e)
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

        private void PlayerState_OnStateChanged(bool isPlaying)
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
                    
                }
                else
                {
                    // Hide both buttons if no song is playing
                    btnFavorite_Default.Visible = true;
                    btnFavorite_Pressed.Visible = false;
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
                       // Nimbus.RefreshFavoriteButton();
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
                       // Nimbus.RefreshFavoriteButton();
                    }
                    else
                    {
                        MessageBox.Show($"Failed to remove '{currentSong.Title}' from Favorites.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
