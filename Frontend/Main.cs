using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using NimbusClassLibrary;

namespace NIMBUS__MUSIC_PLAYER_
{
    public partial class Nimbus : Form
    {
        static DashboardNavigation dashboardNavigation;
        public Nimbus()
        {
            InitializeComponent();
            Initialize_Navigation_Controls();
            // test test = new test();
            // MessageBox.Show(test.test1());

        }
        private void Initialize_Navigation_Controls()
        {

            //List <UserControl> list = new List<UserControl>()
            UserControl[] list =
            { new AllSongPanel(), new FavoritePanel(), new AlbumsPanel(), new ArtistsPanel(), new QueuePanel(), new PlaylistPanel()};

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
            dashboardNavigation.Display(5);
        }

        private void SongTimePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Theme1_Click(object sender, EventArgs e)
        {
            ApplyDarkTheme();
        }

        private void Theme2_Click(object sender, EventArgs e)
        {
            ApplyWhiteTheme();//This will apply the white theme
        }

        private void Theme3_Click(object sender, EventArgs e)
        {
            ApplyBlueTheme();
        }

        private void Theme4_Click(object sender, EventArgs e)
        {
            ApplyGradientTheme();
        }
     
        private void ApplyDarkTheme()
        {
            var BGColor = Color.FromArgb(18, 18, 18);
            var Color1 = Color.FromArgb(39, 39, 39);
            var NowPlayingColor = Color.FromArgb(26, 26, 26);


            this.BackColor = BGColor;
            this.ForeColor = Color.White;
            panel3.BackColor = NowPlayingColor;
            btnSidebar_Songs.CheckedState.FillColor = Color1;
            btnSidebar_Songs.CheckedState.FillColor2 = Color1;
            btnSidebar_Favorites.CheckedState.FillColor = Color1;
            btnSidebar_Favorites.CheckedState.FillColor2 = Color1;
            btnSidebar_Albums.CheckedState.FillColor = Color1;
            btnSidebar_Albums.CheckedState.FillColor2 = Color1;
            btnSidebar_Artists.CheckedState.FillColor = Color1;
            btnSidebar_Artists.CheckedState.FillColor2 = Color1;
            btnSidebar_Queue.CheckedState.FillColor = Color1;
            btnSidebar_Queue.CheckedState.FillColor2 = Color1;

            btnSidebar_Songs.HoverState.FillColor = Color1;
            btnSidebar_Songs.HoverState.FillColor2 = Color1;
            btnSidebar_Favorites.HoverState.FillColor = Color1;
            btnSidebar_Favorites.HoverState.FillColor2 = Color1;
            btnSidebar_Albums.HoverState.FillColor = Color1;
            btnSidebar_Albums.HoverState.FillColor2 = Color1;
            btnSidebar_Artists.HoverState.FillColor = Color1;
            btnSidebar_Artists.HoverState.FillColor2 = Color1;
            btnSidebar_Queue.HoverState.FillColor = Color1;
            btnSidebar_Queue.HoverState.FillColor2 = Color1;

            SearchBar.FillColor = Color1;

        }

        private void ApplyWhiteTheme()
        {
            
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;

            
            UpdateControlWhiteTheme(this.Controls);
        }

        private void ApplyBlueTheme()
        {
            var BGColor = Color.FromArgb(21, 28, 33);
            var Color1 = Color.FromArgb(27, 40, 50);
            var NowPlayingColor = Color.FromArgb(35, 43, 50);


            this.BackColor = BGColor;
            this.ForeColor = Color.White;
            panel3.BackColor = NowPlayingColor;
            btnSidebar_Songs.CheckedState.FillColor = Color1;
            btnSidebar_Songs.CheckedState.FillColor2 = Color1;
            btnSidebar_Favorites.CheckedState.FillColor = Color1;
            btnSidebar_Favorites.CheckedState.FillColor2 = Color1;
            btnSidebar_Albums.CheckedState.FillColor = Color1;
            btnSidebar_Albums.CheckedState.FillColor2 = Color1;
            btnSidebar_Artists.CheckedState.FillColor = Color1;
            btnSidebar_Artists.CheckedState.FillColor2 = Color1;
            btnSidebar_Queue.CheckedState.FillColor = Color1;
            btnSidebar_Queue.CheckedState.FillColor2 = Color1;

            btnSidebar_Songs.HoverState.FillColor = Color1;
            btnSidebar_Songs.HoverState.FillColor2 = Color1;
            btnSidebar_Favorites.HoverState.FillColor = Color1;
            btnSidebar_Favorites.HoverState.FillColor2 = Color1;
            btnSidebar_Albums.HoverState.FillColor = Color1;
            btnSidebar_Albums.HoverState.FillColor2 = Color1;
            btnSidebar_Artists.HoverState.FillColor = Color1;
            btnSidebar_Artists.HoverState.FillColor2 = Color1;
            btnSidebar_Queue.HoverState.FillColor = Color1;
            btnSidebar_Queue.HoverState.FillColor2 = Color1;

            SearchBar.FillColor = Color1;

        }

        private void ApplyGradientTheme()
        {
            var BGColor = Color.FromArgb(21, 28, 33);
            var Color1 = Color.FromArgb(27, 40, 50);
            var Gradient1 = Color.FromArgb(69, 5, 87);
            var Gradient2 = Color.FromArgb(138, 6, 35);
            var NowPlayingColor = Color.FromArgb(35, 43, 50);


            Nimbus.ActiveForm.BackgroundImage = global::NIMBUS__MUSIC_PLAYER_.Properties.Resources.gradient_Background;
            this.ForeColor = Color.White;
            panel3.BackColor = NowPlayingColor;
            btnSidebar_Songs.CheckedState.FillColor = Color1;
            btnSidebar_Songs.CheckedState.FillColor2 = Color1;
            btnSidebar_Favorites.CheckedState.FillColor = Color1;
            btnSidebar_Favorites.CheckedState.FillColor2 = Color1;
            btnSidebar_Albums.CheckedState.FillColor = Color1;
            btnSidebar_Albums.CheckedState.FillColor2 = Color1;
            btnSidebar_Artists.CheckedState.FillColor = Color1;
            btnSidebar_Artists.CheckedState.FillColor2 = Color1;
            btnSidebar_Queue.CheckedState.FillColor = Color1;
            btnSidebar_Queue.CheckedState.FillColor2 = Color1;

            btnSidebar_Songs.HoverState.FillColor = Color1;
            btnSidebar_Songs.HoverState.FillColor2 = Color1;
            btnSidebar_Favorites.HoverState.FillColor = Color1;
            btnSidebar_Favorites.HoverState.FillColor2 = Color1;
            btnSidebar_Albums.HoverState.FillColor = Color1;
            btnSidebar_Albums.HoverState.FillColor2 = Color1;
            btnSidebar_Artists.HoverState.FillColor = Color1;
            btnSidebar_Artists.HoverState.FillColor2 = Color1;
            btnSidebar_Queue.HoverState.FillColor = Color1;
            btnSidebar_Queue.HoverState.FillColor2 = Color1;

            SearchBar.FillColor = Color1;

        }

        private void UpdateControlWhiteTheme(Control.ControlCollection controls)
        {   //This change the theme of the controls recursively
            foreach (Control control in controls)
            {
                if (control is Panel panel)
                {
                    panel.BackColor = Color.White;
                    UpdateControlWhiteTheme(panel.Controls); 
                }
                else if (control is Button button)
                {
                    button.BackColor = Color.White; 
                    button.ForeColor = Color.Black;
                    
                }
                else if (control is Label label)
                {
                    label.ForeColor = Color.Black; 
                }
                else if (control is TextBox textBox)
                {
                    textBox.BackColor = Color.White; 
                    textBox.ForeColor = Color.Black; 
                }
                else if (control is UserControl userControl)
                {
                    userControl.BackColor = Color.White; 
                    userControl.ForeColor = Color.Black; 
                }
            }
            //It will update the theme of the specific controls
            btnSidebar_Songs.ForeColor = Color.Black;
            btnSidebar_Favorites.ForeColor = Color.Black;
            btnSidebar_Albums.ForeColor = Color.Black;
            btnSidebar_Artists.ForeColor = Color.Black;
            btnSidebar_Queue.ForeColor = Color.Black;
            btnSidebar_Playlist.ForeColor = Color.Black;

            SearchBar.FillColor = Color.White;
            SearchBar.ForeColor = Color.Black;
            guna2GradientButton4.ForeColor = Color.White;
            guna2GradientButton4.FillColor = Color.Black;
            guna2GradientButton4.FillColor2 = Color.Black;
            guna2GradientButton4.Image = Properties.Resources.Iconaddbuttonwhite;
            guna2ControlBox1.IconColor = Color.Black;
            guna2ControlBox1.BackColor = Color.White;
            guna2ControlBox2.IconColor = Color.Black;
            guna2ControlBox2.BackColor = Color.White;

            pictureBox1.Image = Properties.Resources.Nimbus_DarkLogo;
            btnSidebar_Songs.Image = Properties.Resources.DarkSongimage;
            btnSidebar_Favorites.Image = Properties.Resources.DarkFavoritesimage;
            btnSidebar_Albums.Image = Properties.Resources.DarkAlmbumimage;
            btnSidebar_Artists.Image = Properties.Resources.DarkArtistImage;
            btnSidebar_Queue.Image = Properties.Resources.Darkqueueimage;
            btnSidebar_Playlist.Image = Properties.Resources.DarkPlaylistimage;
            btnAddaPlaylist.Image = Properties.Resources.Vector__7_;
            guna2PictureBox3.Image = Properties.Resources.DarkDrpDown___Copy1;
            guna2PictureBox2.Image = Properties.Resources.DarkDrpDown;

            panel3.BackColor = Color.WhiteSmoke;
        }
      
        private void btnAddaPlaylist_Click(object sender, EventArgs e)
        {

        }

    }
}
