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
    public partial class QueuePanel : UserControl
    {
        private Panel _menuTab;

        public Panel DetailsPanel
        {
            get { return DetailPanel; }
        }

        public Panel MenuTab
        {
            get { return MenuTabs; }
            set { _menuTab = value; }
        }

        public Panel SongMenu
        {
            get { return SongTab; }
        }
        public QueuePanel()
        {
            InitializeComponent();
        }
    }
}
