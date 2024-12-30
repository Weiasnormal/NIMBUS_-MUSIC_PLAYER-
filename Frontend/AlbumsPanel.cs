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
