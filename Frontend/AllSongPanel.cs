using NimbusClassLibrary.Controller;
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
    public partial class AllSongPanel : UserControl
    {
        public AllSongPanel()
        {
            InitializeComponent();
            

            int numControls = AllSongsPanel.Controls.Count;
            AllSongsPanel.SuspendLayout();
            AllSongsPanel.Controls.Clear();
            AllSongsPanel.AutoScroll = true;
            AllSongsPanel.VerticalScroll.Visible = false;

            loadSongs();

            this.Dock = DockStyle.Right;
            AllSongsScrollbar.Scroll += (sender, e) => { AllSongsPanel.VerticalScroll.Value = AllSongsScrollbar.Value; };
            AllSongsScrollbar.Height = AllSongsPanel.Height;
            AllSongsScrollbar.Visible = false;
            
            this.Controls.Add(AllSongsScrollbar);

            AllSongsPanel.ResumeLayout();

            // then update the form
            AllSongsPanel.PerformLayout();
        }

        public Panel DetailsPanel
        {
            get { return DetailPanel; }
        }

        public Panel MenuTab
        {
            get { return guna2Panel1; }
        }

        public Panel SongMenu
        {
            get { return SongsMenu; }
        }

       


        public void loadSongs()
        {
            int songnum = 1;

            SongController<Song> controller = new SongController<Song>();
            List<Song> songs = (List<Song>)controller.GetCollection<Song>();
            foreach(Song song in songs) 
            {
                AllSongsPanel.Controls.Add(new HorizontalSongs(songnum, song.Title, song.Artist.Profile_Pic, song.Artist, song.Duration));
                songnum++;
            }
        }

        private void DetailPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
