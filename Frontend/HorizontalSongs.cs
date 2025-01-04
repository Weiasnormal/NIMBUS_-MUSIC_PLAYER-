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
        private Song _song;

        public Song Song
        {
            get { return _song; }
        }

        public event EventHandler MenuButtonClicked;

        private Nimbus _nimbus;

        public HorizontalSongs(Nimbus nimbus)
        {
            InitializeComponent();
            _nimbus = nimbus;  
        }

        public HorizontalSongs()
        {
            InitializeComponent();

            // Attach double-click event
            this.DoubleClick += HorizontalSongs_DoubleClick;
        }

        public HorizontalSongs(Control SongsMenu, int songnum, Song song)
        {
            InitializeComponent();
            this.SongsMenu = SongsMenu;
            _song = song;

            
            SongNumlbl.Text = songnum.ToString();
            Titlelbl.Text = _song.Title;
            Songpic.ImageLocation = _song.Artist.Profile_Pic;
            Artistlbl.Text = _song.Artist.Display_Name;
            TotalTimelbl.Text = $"{song.Duration.Minutes:D2}:{song.Duration.Seconds:D2}";
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

            // Get the song name from the label
            string songName = Titlelbl.Text;

            // Verify if there is a song to play
            if (!string.IsNullOrEmpty(songName))
            {
                // Stop the current song if it's playing before starting the new song
                PlayerState.StopSong(); // Ensure that the current song stops immediately

                // Update the WMPLib player's URL synchronously
                PlayerState.player.URL = _song.File_Path;

                // Trigger the UI update
                var nimbus = this.FindForm() as Nimbus;

                if (nimbus != null)
                {
                    nimbus.InitializeFavoriteButton();
                    nimbus.UpdateSongDetails();
                }

                // Play the song asynchronously
                PlayerState.BackgroundWorker.CancelAsync();
                Task.Run(() => PlayerState.PlaySong(_song));
            }
            else
            {
                // Handle the case where no song name is found
            }
        }


        // Optional: Handle form closing and stop audio if necessary
        private void HorizontalSongs_FormClosing(object sender, FormClosingEventArgs e)
        {
            PlayerState.StopSong();
        }

        

        private void Menubtn_Click(object sender, EventArgs e)
        {
            MenuButtonClicked?.Invoke(this, EventArgs.Empty);
        }
       

    }
}
