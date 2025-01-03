using Guna.UI.WinForms;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using NimbusClassLibrary;
using NimbusClassLibrary.Model;
using System.Threading;

namespace NIMBUS__MUSIC_PLAYER_
{
    public partial class QueuePanel : UserControl
    {
     

        #region Theme Change
        public Panel DetailsPanel { get { return DetailPanel; } }
        public Guna2Panel MenuTab
        {
            get { return MenuTabs; }            
        }
        public Guna2Panel SongMenu
        {
            get { return SongsMenu; }
        }
        public Guna2TextBox SearchBars
        {
            get { return SearchBar; }
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
            get { return guna2GradientButton1; }
        }
        public Guna2GradientButton btn2
        {
            get { return guna2GradientButton3; }
        }
        public Guna2GradientButton btn3
        {
            get { return Menu_AddPlaylist; }
        }
        public Guna2GradientButton btn4
        {
            get { return guna2GradientButton4; }
        }
        #endregion
        public QueuePanel()
        {
            InitializeComponent();

            MenuTabs.Visible = false;   
            SongsMenu.Visible = false;

            Helper.Events.AddToQueue += QueuePanel_AddtoQueue;
            

            Menu_AddPlaylist.Click += Menu_AddPlaylist_Click;

            // Additional initialization for your panel and scrollbar
            flowpanelQueue.AutoScroll = true;
            QueueScrollbar.Scroll += (sender, e) =>
            {
                flowpanelQueue.VerticalScroll.Value = QueueScrollbar.Value;
            };


            int numControls = flowpanelQueue.Controls.Count;
            flowpanelQueue.SuspendLayout();
            flowpanelQueue.Controls.Clear();
            flowpanelQueue  .AutoScroll = true;
            flowpanelQueue  .VerticalScroll.Visible = false;

            this.Dock = DockStyle.Right;
            QueueScrollbar.Scroll += (sender, e) => { flowpanelQueue.VerticalScroll.Value = QueueScrollbar.Value; };
            QueueScrollbar.Height =     flowpanelQueue.Height;
            QueueScrollbar.Visible = false;

            this.Controls.Add(QueueScrollbar);

            flowpanelQueue.ResumeLayout();

            // then update the form
            flowpanelQueue.PerformLayout();
        }

       /* private void QueuePanel_AddtoQueue(object sender, EventArgs e)
        {
            int songnum = 1;
            foreach (Song song in NimbusClassLibrary.Helpers.GlobalLibraries.Playing_Song)
            {
                flowpanelQueue.Invoke(new Action(() => {
                    flowpanelQueue.Controls.Add(new HorizontalSongs(SongsMenu, songnum, song.Title, song.Artist.Profile_Pic, song.Artist, song.Duration));
                }));
                songnum++;
            }
        
        }
*/
        private void QueuePanel_AddtoQueue(object sender, EventArgs e)
        {
            int songnum = 1;

            foreach (Song song in NimbusClassLibrary.Helpers.GlobalLibraries.Playing_Song)
            {
                flowpanelQueue.Invoke(new Action(() =>
                {   // created for the horizontal song control
                    var songControl = new HorizontalSongs(SongsMenu, songnum, song);
                    songControl.MenuButtonClicked += SongControl_MenuButtonClicked;
                    flowpanelQueue.Controls.Add(songControl);
                }));
                songnum++;
            }
        }

        private void Menubtn_Click(object sender, EventArgs e)
        {
            MenuTabs.Visible = !MenuTabs.Visible;
        }
        private void SongControl_MenuButtonClicked(object sender, EventArgs e)
        {
            SongsMenu.Visible = !SongsMenu.Visible;

        }

        private void Menu_AddPlaylist_Click(object sender, EventArgs e)
        {
            if (this.FindForm() is Nimbus mainForm)
            {
                mainForm.SwitchToPanel(5);
            }
        }
    }
}
