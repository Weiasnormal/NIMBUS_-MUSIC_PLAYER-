using Guna.UI2.WinForms;
using NIMBUS__MUSIC_PLAYER_.Helper;
using NimbusClassLibrary.Controller;
using NimbusClassLibrary.Data;
using NimbusClassLibrary.Model;
using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace NIMBUS__MUSIC_PLAYER_
{
    public partial class HorizontalSongs : UserControl
    {
        
        private Control SongsMenu;
        private string title;
        private string thumbnail;
        private Artist artist;
        private TimeSpan duration;

        public event EventHandler MenuButtonClicked;

        public HorizontalSongs()
        {
            InitializeComponent();

            // Attach double-click event
            this.DoubleClick += HorizontalSongs_DoubleClick;
        }

        public HorizontalSongs(Control SongsMenu, int songnum, string title, string thumbnail, Artist artist, TimeSpan duration)
        {
            InitializeComponent();
            this.SongsMenu = SongsMenu;
            this.title = title;
            this.thumbnail = thumbnail;
            this.artist = artist;
            this.duration = duration;

            SongNumlbl.Text = songnum.ToString();
            Titlelbl.Text = title;
            Songpic.ImageLocation = thumbnail;
            Artistlbl.Text = artist.Display_Name;
            TotalTimelbl.Text = $"{duration.Minutes}:{duration.Seconds}";

        }

        public void HorizontalSongs_DoubleClick(object sender, EventArgs e)
        {
            var Highlighted = Color.FromArgb(82, 82, 82);
            var Default = Color.Transparent;

            // Ensure sender is a Control
            if (sender is Control clickedControl)
            {
                // Reset the background color of all sibling controls to default
                foreach (Control control in clickedControl.Parent.Controls)
                {
                    control.BackColor = Default;
                }

                // Highlight the double-clicked control
                clickedControl.BackColor = Highlighted;
            }

            // Force all buttons into the Play state
           //PlayerState.ForcePlayState();

            // Get the song name from the label
            string songName = Titlelbl.Text;
            
            // Stop the current song if it's playing before starting the new song
            StopAudio(); // Ensure that the current song stops immediately

            // Use the PlaySong method to play the song based on the song name
            PlaySong(songName);
        }

        public void PlaySong(string songName)
        {
            // Instantiate the SongController
            SongController<Song> songController = new SongController<Song>();

            // Query the song using the song name
            var song = DBContext.songs.FirstOrDefault(s => s.Title.Equals(songName, StringComparison.OrdinalIgnoreCase));

            if (song != null)
            {
                // Fetch the song ID from the database through the SongController
                var fetchedSong = songController.GetSingle<Song>(song.Id);

                if (fetchedSong != null)
                {
                    string filePath = fetchedSong.File_Path;

                    // Check if the new song is different from the current one
                    if (PlayerState.currentSongPath != filePath)
                    {
                        // Stop the current song before playing the new one
                        StopAudio();

                        // Update the current song path
                        PlayerState.currentSongPath = filePath;

                        // Play the new song
                        PlayAudio(filePath);
                    }
                    else
                    {
                        // If the same song is clicked again, restart it
                        PlayAudio(filePath);
                    }
                }
                else
                {
                    MessageBox.Show("Song not found in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Song name not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private async void PlayAudio(string filePath)
        {
            // Check if the file exists before attempting to play it
            if (FileExists(filePath))
            {
                // Play the audio asynchronously, ensuring it's on the UI thread
                await Task.Run(() =>
                {
                    // Use Invoke to ensure this runs on the UI thread
                    this.Invoke(new Action(() =>
                    {
                        // Set the player's URL to the new file path
                        PlayerState.player.URL = filePath;

                        // Start playback
                        PlayerState.player.controls.play();

                        // Update the playing state
                        PlayerState.IsPlaying = true;
                    }));
                });
            }
            else
            {
                MessageBox.Show("File not found: " + filePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool FileExists(string filePath)
        {
            return System.IO.File.Exists(filePath);
        }

        private void StopAudio()
{
    if (PlayerState.player.playState != WMPPlayState.wmppsStopped)
    {
        this.Invoke(new Action(() =>
        {
            PlayerState.player.controls.stop();
            PlayerState.currentSongPath = string.Empty; // Reset current song path
        }));
    }
}


        // Optional: Handle form closing and stop audio if necessary
        private void HorizontalSongs_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopAudio();
        }

        

        private void Menubtn_Click(object sender, EventArgs e)
        {
            /*foreach (Control control in this.Parent.Controls)
            {
                if (control is Guna2Panel panel && panel.Name == "SongsMenu")
                {
                    panel.Visible = false;  // Hide the SongMenu
                }
            }
            SongsMenu.Visible = !SongsMenu.Visible;
            MessageBox.Show($"Menu button clicked. SongsMenu visible: {SongsMenu.Visible}");*/

            MenuButtonClicked?.Invoke(this, EventArgs.Empty);
        }
        

    }
}
