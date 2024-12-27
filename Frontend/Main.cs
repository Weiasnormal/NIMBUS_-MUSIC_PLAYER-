using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NimbusClassLibrary;

namespace NIMBUS__MUSIC_PLAYER_
{
    public partial class Main : Form
    {
        static DashboardNavigation dashboardNavigation;
        public Main()
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
    }
}
