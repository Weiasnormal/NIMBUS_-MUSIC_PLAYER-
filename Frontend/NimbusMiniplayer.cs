using NIMBUS__MUSIC_PLAYER_.Helper;
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

            lblVolumePercent.Visible = false; // Hide the volume label by default

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 500; // Update every 500ms (half a second)
            timer.Tick += timer1_Tick;

            // Initialize ProgressBar
            TimeSong.Minimum = 0; // Start at 0
            TimeSong.Maximum = 100; // Progress will be in percentage

            // Subscribe to the PlayerState's OnStateChanged event
            PlayerState.OnStateChanged += PlayerState_OnStateChanged; 

            // Initialize button states
            Playbtn.Visible = true;
            Pausebtn.Visible = false;
        }

       

        private void CloseMiniplayer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Switchtomain_Click(object sender, EventArgs e)
        {
            
            Nimbus nimbus = new Nimbus();
            nimbus.Show();
            this.Hide();

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
       

        private void UpdateSongDetails()
        {
            try
            {
                var currentSong = PlayerState.CurrentSong?.Value;

                if (currentSong != null)
                {
                    TitleSonglbl.Text = currentSong.Title; // Update the song title
                    Artistlbl.Text = currentSong.Artist.Display_Name; // Update the artist name
                }
                else
                {
                    TitleSonglbl.Text = "-";
                    Artistlbl.Text = "-";
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Error updating song details: {ex.Message}");
            }
        }
    }
}
