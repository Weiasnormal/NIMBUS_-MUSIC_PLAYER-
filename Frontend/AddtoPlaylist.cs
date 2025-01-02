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
    public partial class AddtoPlaylist : UserControl
    {
        public AddtoPlaylist()
        {
            InitializeComponent();
        }

        private void Close_AddtoPlaylist_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void NewPlaylist_Click(object sender, EventArgs e)
        {
            CreatePlaylist createPlaylist = new CreatePlaylist();
            Panel ShowAddPlaylist = (Panel)this.Parent;
            ShowAddPlaylist.Controls.Clear();
            ShowAddPlaylist.Location = new Point(439, 154);
            ShowAddPlaylist.Size = createPlaylist.Size;
            ShowAddPlaylist.Controls.Add(new CreatePlaylist());
            ShowAddPlaylist.Visible = true;
            this.Parent.Controls.Remove(this);

        }
    }
}
