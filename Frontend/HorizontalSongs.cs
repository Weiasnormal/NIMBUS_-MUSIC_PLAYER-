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
        private WindowsMediaPlayer player;
        private string currentSongPath; // To keep track of the current song path

        //private Form _addToPlaylistForm;
        private Guna2Panel SongsMenu;
        private string title;
        private string thumbnail;
        private Artist artist;
        private TimeSpan duration;

        public event EventHandler MenuButtonClicked;

        public HorizontalSongs()
        {
            InitializeComponent();
            player = new WindowsMediaPlayer();
            currentSongPath = string.Empty;

            // Attach double-click event
            this.DoubleClick += HorizontalSongs_DoubleClick;
        }

        public HorizontalSongs( Guna2Panel SongsMenu, int songnum, string title, string thumbnail, Artist artist, TimeSpan duration)
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
            player = new WindowsMediaPlayer();
            currentSongPath = string.Empty;

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
            PlayerState.ForcePlayState();

            // Get the song name from the label
            string songName = Artistlbl.Text;
            
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
            var song = DBContext.songs.FirstOrDefault(s => s.Artist.Display_Name == songName);

            if (song != null)
            {
                // Fetch the song ID from the database through the SongController
                var fetchedSong = songController.GetSingle<Song>(song.Id);

                if (fetchedSong != null)
                {
                    string filePath = fetchedSong.File_Path;

                    // Only stop the current song if the new song is different
                    if (filePath != currentSongPath)
                    {
                        // Stop the current song if another one is selected
                        StopAudio();

                        // Play the new song
                        PlayAudio(filePath);
                        currentSongPath = filePath; // Update the current song path
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
                        // Stop any currently playing song before starting the new one
                        player.URL = filePath;
                        player.controls.play();
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
            // Check if a song is currently playing
            if (player.playState != WMPPlayState.wmppsStopped)
            {
                // Stop the audio
                this.Invoke(new Action(() =>
                {
                    player.controls.stop();
                    currentSongPath = string.Empty; // Reset the current song path after stopping
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
            /* foreach (Control control in this.Parent.Controls)
             {
                 if (control is Guna2Panel panel && panel.Name == "SongsMenu")
                 {
                     panel.Visible = false;  // Hide the SongMenu
                 }
             }*/
            //SongsMenu.Visible = !SongsMenu.Visible;
            //MessageBox.Show($"Menu button clicked. SongsMenu visible: {SongsMenu.Visible}");

            MenuButtonClicked?.Invoke(this, EventArgs.Empty);
        }
        

    }
}
