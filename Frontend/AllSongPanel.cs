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
        public Panel detailPanel { get; set; }
        public AllSongPanel()
        {
            InitializeComponent();
            detailPanel = this.DetailPanel;
        }

        public void BlueTheme(Color color)
        {
            
            DetailPanel.BackColor = color;
            guna2Panel1.FillColor = color;
        }      
    }
}
