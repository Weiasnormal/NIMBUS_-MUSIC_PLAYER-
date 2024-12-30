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
    public partial class FavoritePanel : UserControl
    {

        public Panel DetailsPanel
        {
            get { return DetailPanel; }
        }

        public Guna2Panel MenuTab
        {
            get { return MenuTabs; }
        }

        public Guna2Panel SongMenu
        {
            get { return SongTab; }
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
            get { return guna2GradientButton7; }
        }
        public Guna2GradientButton btn2
        {
            get { return guna2GradientButton6; }
        }
        public Guna2GradientButton btn3
        {
            get { return guna2GradientButton5; }
        }
        public Guna2GradientButton btn4
        {
            get { return guna2GradientButton4; }
        }
        public Guna2GradientButton btn5
        {
            get { return guna2GradientButton3; }
        }
        public Guna2GradientButton btn6
        {
            get { return guna2GradientButton1; }
        }

        public FavoritePanel()
        {
            InitializeComponent();
        }
    }
}
