namespace NIMBUS__MUSIC_PLAYER_
{
    partial class PlaylistPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Dropdown_Sort = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Dropdown_Album = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Dropdown_Artist = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2ImageButton4 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Menubtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Playlistlbl = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblArtist = new System.Windows.Forms.Label();
            this.lblAlbum = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDuration = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Playlistlbl)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dropdown_Sort
            // 
            this.Dropdown_Sort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Dropdown_Sort.Animated = true;
            this.Dropdown_Sort.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Dropdown_Sort.BackColor = System.Drawing.Color.Transparent;
            this.Dropdown_Sort.BorderColor = System.Drawing.Color.Black;
            this.Dropdown_Sort.BorderRadius = 10;
            this.Dropdown_Sort.BorderThickness = 0;
            this.Dropdown_Sort.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Dropdown_Sort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Dropdown_Sort.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.Dropdown_Sort.FocusedColor = System.Drawing.Color.Empty;
            this.Dropdown_Sort.FocusedState.Parent = this.Dropdown_Sort;
            this.Dropdown_Sort.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dropdown_Sort.ForeColor = System.Drawing.Color.White;
            this.Dropdown_Sort.FormattingEnabled = true;
            this.Dropdown_Sort.HoverState.Parent = this.Dropdown_Sort;
            this.Dropdown_Sort.ItemHeight = 30;
            this.Dropdown_Sort.Items.AddRange(new object[] {
            "Sort:",
            "Recently Added",
            "Title (A-Z)",
            "Title (Z-A)",
            "Artist (A-Z)",
            "Artist (Z-A)",
            "Album (A-Z)",
            "Album (Z-A)"});
            this.Dropdown_Sort.ItemsAppearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.Dropdown_Sort.ItemsAppearance.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dropdown_Sort.ItemsAppearance.ForeColor = System.Drawing.Color.White;
            this.Dropdown_Sort.ItemsAppearance.Parent = this.Dropdown_Sort;
            this.Dropdown_Sort.ItemsAppearance.SelectedBackColor = System.Drawing.Color.DimGray;
            this.Dropdown_Sort.ItemsAppearance.SelectedFont = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dropdown_Sort.ItemsAppearance.SelectedForeColor = System.Drawing.Color.White;
            this.Dropdown_Sort.Location = new System.Drawing.Point(1336, 102);
            this.Dropdown_Sort.Name = "Dropdown_Sort";
            this.Dropdown_Sort.ShadowDecoration.Parent = this.Dropdown_Sort;
            this.Dropdown_Sort.Size = new System.Drawing.Size(200, 36);
            this.Dropdown_Sort.StartIndex = 0;
            this.Dropdown_Sort.TabIndex = 20;
            // 
            // Dropdown_Album
            // 
            this.Dropdown_Album.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Dropdown_Album.Animated = true;
            this.Dropdown_Album.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Dropdown_Album.BackColor = System.Drawing.Color.Transparent;
            this.Dropdown_Album.BorderColor = System.Drawing.Color.Black;
            this.Dropdown_Album.BorderRadius = 10;
            this.Dropdown_Album.BorderThickness = 0;
            this.Dropdown_Album.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Dropdown_Album.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Dropdown_Album.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.Dropdown_Album.FocusedColor = System.Drawing.Color.Empty;
            this.Dropdown_Album.FocusedState.Parent = this.Dropdown_Album;
            this.Dropdown_Album.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dropdown_Album.ForeColor = System.Drawing.Color.White;
            this.Dropdown_Album.FormattingEnabled = true;
            this.Dropdown_Album.HoverState.Parent = this.Dropdown_Album;
            this.Dropdown_Album.ItemHeight = 30;
            this.Dropdown_Album.Items.AddRange(new object[] {
            "Albums:",
            "Yanni",
            "Mhartin"});
            this.Dropdown_Album.ItemsAppearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.Dropdown_Album.ItemsAppearance.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dropdown_Album.ItemsAppearance.ForeColor = System.Drawing.Color.White;
            this.Dropdown_Album.ItemsAppearance.Parent = this.Dropdown_Album;
            this.Dropdown_Album.ItemsAppearance.SelectedBackColor = System.Drawing.Color.DimGray;
            this.Dropdown_Album.ItemsAppearance.SelectedFont = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dropdown_Album.ItemsAppearance.SelectedForeColor = System.Drawing.Color.White;
            this.Dropdown_Album.Location = new System.Drawing.Point(1128, 102);
            this.Dropdown_Album.Name = "Dropdown_Album";
            this.Dropdown_Album.ShadowDecoration.Parent = this.Dropdown_Album;
            this.Dropdown_Album.Size = new System.Drawing.Size(200, 36);
            this.Dropdown_Album.StartIndex = 0;
            this.Dropdown_Album.TabIndex = 19;
            // 
            // Dropdown_Artist
            // 
            this.Dropdown_Artist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Dropdown_Artist.Animated = true;
            this.Dropdown_Artist.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Dropdown_Artist.BackColor = System.Drawing.Color.Transparent;
            this.Dropdown_Artist.BorderColor = System.Drawing.Color.Black;
            this.Dropdown_Artist.BorderRadius = 10;
            this.Dropdown_Artist.BorderThickness = 0;
            this.Dropdown_Artist.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Dropdown_Artist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Dropdown_Artist.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.Dropdown_Artist.FocusedColor = System.Drawing.Color.Empty;
            this.Dropdown_Artist.FocusedState.Parent = this.Dropdown_Artist;
            this.Dropdown_Artist.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dropdown_Artist.ForeColor = System.Drawing.Color.White;
            this.Dropdown_Artist.FormattingEnabled = true;
            this.Dropdown_Artist.HoverState.Parent = this.Dropdown_Artist;
            this.Dropdown_Artist.ItemHeight = 30;
            this.Dropdown_Artist.Items.AddRange(new object[] {
            "Artist:",
            "Yanni",
            "Mhartin"});
            this.Dropdown_Artist.ItemsAppearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.Dropdown_Artist.ItemsAppearance.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dropdown_Artist.ItemsAppearance.ForeColor = System.Drawing.Color.White;
            this.Dropdown_Artist.ItemsAppearance.Parent = this.Dropdown_Artist;
            this.Dropdown_Artist.ItemsAppearance.SelectedBackColor = System.Drawing.Color.DimGray;
            this.Dropdown_Artist.ItemsAppearance.SelectedFont = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dropdown_Artist.ItemsAppearance.SelectedForeColor = System.Drawing.Color.White;
            this.Dropdown_Artist.Location = new System.Drawing.Point(920, 102);
            this.Dropdown_Artist.Name = "Dropdown_Artist";
            this.Dropdown_Artist.ShadowDecoration.Parent = this.Dropdown_Artist;
            this.Dropdown_Artist.Size = new System.Drawing.Size(200, 36);
            this.Dropdown_Artist.StartIndex = 0;
            this.Dropdown_Artist.TabIndex = 18;
            // 
            // guna2ImageButton4
            // 
            this.guna2ImageButton4.CheckedState.Image = global::NIMBUS__MUSIC_PLAYER_.Properties.Resources.Icon_Pause;
            this.guna2ImageButton4.CheckedState.Parent = this.guna2ImageButton4;
            this.guna2ImageButton4.HoverState.Parent = this.guna2ImageButton4;
            this.guna2ImageButton4.Image = global::NIMBUS__MUSIC_PLAYER_.Properties.Resources.Icon_Play;
            this.guna2ImageButton4.ImageSize = new System.Drawing.Size(48, 48);
            this.guna2ImageButton4.Location = new System.Drawing.Point(41, 88);
            this.guna2ImageButton4.Name = "guna2ImageButton4";
            this.guna2ImageButton4.PressedState.Parent = this.guna2ImageButton4;
            this.guna2ImageButton4.Size = new System.Drawing.Size(58, 58);
            this.guna2ImageButton4.TabIndex = 15;
            // 
            // Menubtn
            // 
            this.Menubtn.CheckedState.Parent = this.Menubtn;
            this.Menubtn.HoverState.Parent = this.Menubtn;
            this.Menubtn.Image = global::NIMBUS__MUSIC_PLAYER_.Properties.Resources.Menu;
            this.Menubtn.ImageSize = new System.Drawing.Size(32, 32);
            this.Menubtn.Location = new System.Drawing.Point(163, 102);
            this.Menubtn.Name = "Menubtn";
            this.Menubtn.PressedState.Parent = this.Menubtn;
            this.Menubtn.Size = new System.Drawing.Size(51, 33);
            this.Menubtn.TabIndex = 6;
            // 
            // guna2ImageButton2
            // 
            this.guna2ImageButton2.CheckedState.Parent = this.guna2ImageButton2;
            this.guna2ImageButton2.HoverState.Parent = this.guna2ImageButton2;
            this.guna2ImageButton2.Image = global::NIMBUS__MUSIC_PLAYER_.Properties.Resources.Group__3_;
            this.guna2ImageButton2.ImageSize = new System.Drawing.Size(32, 32);
            this.guna2ImageButton2.Location = new System.Drawing.Point(106, 102);
            this.guna2ImageButton2.Name = "guna2ImageButton2";
            this.guna2ImageButton2.PressedState.Parent = this.guna2ImageButton2;
            this.guna2ImageButton2.Size = new System.Drawing.Size(51, 33);
            this.guna2ImageButton2.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(40, 201);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1495, 727);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // Playlistlbl
            // 
            this.Playlistlbl.Image = global::NIMBUS__MUSIC_PLAYER_.Properties.Resources.Midnight_Session;
            this.Playlistlbl.Location = new System.Drawing.Point(40, 18);
            this.Playlistlbl.Name = "Playlistlbl";
            this.Playlistlbl.Size = new System.Drawing.Size(545, 65);
            this.Playlistlbl.TabIndex = 9;
            this.Playlistlbl.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::NIMBUS__MUSIC_PLAYER_.Properties.Resources.Song_Table;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.Location = new System.Drawing.Point(40, 220);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1479, 51);
            this.panel3.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(71, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(52, 25);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Title";
            // 
            // lblArtist
            // 
            this.lblArtist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblArtist.AutoSize = true;
            this.lblArtist.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtist.ForeColor = System.Drawing.Color.White;
            this.lblArtist.Location = new System.Drawing.Point(446, 14);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(65, 25);
            this.lblArtist.TabIndex = 3;
            this.lblArtist.Text = "Artist";
            // 
            // lblAlbum
            // 
            this.lblAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAlbum.AutoSize = true;
            this.lblAlbum.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlbum.ForeColor = System.Drawing.Color.White;
            this.lblAlbum.Location = new System.Drawing.Point(845, 14);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(74, 25);
            this.lblAlbum.TabIndex = 1;
            this.lblAlbum.Text = "Album";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.ForeColor = System.Drawing.Color.White;
            this.lblNumber.Location = new System.Drawing.Point(17, 14);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(25, 25);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "#";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Controls.Add(this.lblDuration);
            this.panel2.Controls.Add(this.lblNumber);
            this.panel2.Controls.Add(this.lblArtist);
            this.panel2.Controls.Add(this.lblAlbum);
            this.panel2.Location = new System.Drawing.Point(40, 144);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1495, 51);
            this.panel2.TabIndex = 2;
            // 
            // lblDuration
            // 
            this.lblDuration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.ForeColor = System.Drawing.Color.White;
            this.lblDuration.Location = new System.Drawing.Point(1260, 14);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(94, 25);
            this.lblDuration.TabIndex = 2;
            this.lblDuration.Text = "Duration";
            // 
            // PlaylistPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.Dropdown_Sort);
            this.Controls.Add(this.Dropdown_Album);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Dropdown_Artist);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.guna2ImageButton4);
            this.Controls.Add(this.Menubtn);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.guna2ImageButton2);
            this.Controls.Add(this.Playlistlbl);
            this.Name = "PlaylistPanel";
            this.Size = new System.Drawing.Size(1572, 863);
            ((System.ComponentModel.ISupportInitialize)(this.Playlistlbl)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox Playlistlbl;
        private Guna.UI2.WinForms.Guna2ImageButton Menubtn;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton4;
        private Guna.UI2.WinForms.Guna2ComboBox Dropdown_Sort;
        private Guna.UI2.WinForms.Guna2ComboBox Dropdown_Album;
        private Guna.UI2.WinForms.Guna2ComboBox Dropdown_Artist;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.Label lblAlbum;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDuration;
    }
}
