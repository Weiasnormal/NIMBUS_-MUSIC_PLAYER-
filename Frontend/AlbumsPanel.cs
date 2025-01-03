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

namespace NIMBUS__MUSIC_PLAYER_
{
    public partial class AlbumsPanel : UserControl
    {
        public AlbumsPanel()
        {
            InitializeComponent();

            // Additional initialization for your panel and scrollbar
            FlowLayoutPanelAlbum.AutoScroll = true;
            AlbumsScrollbar.Scroll += (sender, e) =>
            {
                FlowLayoutPanelAlbum.VerticalScroll.Value = AlbumsScrollbar.Value;
            };


            int numControls = FlowLayoutPanelAlbum.Controls.Count;
            FlowLayoutPanelAlbum.SuspendLayout();
            FlowLayoutPanelAlbum.Controls.Clear();
            FlowLayoutPanelAlbum.AutoScroll = true;
            FlowLayoutPanelAlbum.VerticalScroll.Visible = false;

            this.Dock = DockStyle.Right;
            AlbumsScrollbar.Scroll += (sender, e) => { FlowLayoutPanelAlbum.VerticalScroll.Value = AlbumsScrollbar.Value; };
            AlbumsScrollbar.Height = FlowLayoutPanelAlbum.Height;
            AlbumsScrollbar.Visible = false;

            this.Controls.Add(AlbumsScrollbar);

            FlowLayoutPanelAlbum.ResumeLayout();

            // then update the form
            FlowLayoutPanelAlbum.PerformLayout();
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
    }
}
