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
    public partial class HorizontalSongs : UserControl
    {
        public HorizontalSongs()
        {

        }
        public HorizontalSongs(int songnum, string title, string thumbnail, Artist artist, TimeSpan duration)
        {
            InitializeComponent();
            SongNumlbl.Text = songnum.ToString();
            Titlelbl.Text = title;
            Songpic.ImageLocation = thumbnail;
            Artistlbl.Text = artist.Display_Name;
            TotalTimelbl.Text = $"{duration.Minutes}:{duration.Seconds}";
        }

        private void HorizontalSongs_DoubleClick(object sender, EventArgs e)
        {
            // how to get songId of the card??? hahaha
            PlaySong(1);
        }

        public void PlaySong(int songId)
        {
            try
            {
                // Use the SongController to fetch the song based on songId
                var songController = new NimbusClassLibrary.Controller.SongController<Song>();
                var song = songController.GetSingle<Song>(songId); // Get the song using its ID

                if (song != null && !string.IsNullOrEmpty(song.File_Path))
                {
                    // Play the song using the file path
                    WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
                    player.URL = song.File_Path; // Set the MP3 file path
                    player.controls.play(); // Start playing
                }
                else
                {
                    MessageBox.Show("Unable to find the song or the file path is invalid.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while playing the song: {ex.Message}");
            }
        }
    }
}
