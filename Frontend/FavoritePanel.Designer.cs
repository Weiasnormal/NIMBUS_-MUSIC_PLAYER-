﻿namespace NIMBUS__MUSIC_PLAYER_
{
    partial class FavoritePanel
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
            this.guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblFavoritesPanel = new System.Windows.Forms.Label();
            this.Dropdown_Sort = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Dropdown_Album = new Guna.UI2.WinForms.Guna2ComboBox();
            this.DetailPanel = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblArtist = new System.Windows.Forms.Label();
            this.lblAlbum = new System.Windows.Forms.Label();
            this.Dropdown_Artist = new Guna.UI2.WinForms.Guna2ComboBox();
            this.flowFavorites = new System.Windows.Forms.FlowLayoutPanel();
            this.SongsMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2GradientButton7 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.RemovefromFavorites = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton3 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Menu_AddPlaylist = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SearchBar = new Guna.UI2.WinForms.Guna2TextBox();
            this.Menubtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.MenuTabs = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton4 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.FavoritesScrollbar = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.DetailPanel.SuspendLayout();
            this.SongsMenu.SuspendLayout();
            this.MenuTabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GradientButton2
            // 
            this.guna2GradientButton2.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton2.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.guna2GradientButton2.CheckedState.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.CustomImages.CheckedImage = global::NIMBUS__MUSIC_PLAYER_.Properties.Resources.Icon_Pause;
            this.guna2GradientButton2.CustomImages.Image = global::NIMBUS__MUSIC_PLAYER_.Properties.Resources.Icon_Play;
            this.guna2GradientButton2.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2GradientButton2.CustomImages.ImageOffset = new System.Drawing.Point(0, -10);
            this.guna2GradientButton2.CustomImages.ImageSize = new System.Drawing.Size(38, 38);
            this.guna2GradientButton2.CustomImages.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.FillColor = System.Drawing.Color.Empty;
            this.guna2GradientButton2.FillColor2 = System.Drawing.Color.Empty;
            this.guna2GradientButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(50)))), ((int)(((byte)(53)))));
            this.guna2GradientButton2.HoverState.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton2.Location = new System.Drawing.Point(45, 73);
            this.guna2GradientButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2GradientButton2.Name = "guna2GradientButton2";
            this.guna2GradientButton2.PressedColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton2.ShadowDecoration.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.Size = new System.Drawing.Size(51, 50);
            this.guna2GradientButton2.TabIndex = 35;
            this.guna2GradientButton2.TextOffset = new System.Drawing.Point(15, 0);
            this.guna2GradientButton2.Click += new System.EventHandler(this.guna2GradientButton2_Click);
            // 
            // lblFavoritesPanel
            // 
            this.lblFavoritesPanel.AutoSize = true;
            this.lblFavoritesPanel.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFavoritesPanel.ForeColor = System.Drawing.Color.White;
            this.lblFavoritesPanel.Location = new System.Drawing.Point(33, 6);
            this.lblFavoritesPanel.Name = "lblFavoritesPanel";
            this.lblFavoritesPanel.Size = new System.Drawing.Size(214, 55);
            this.lblFavoritesPanel.TabIndex = 28;
            this.lblFavoritesPanel.Text = "Favorites";
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
            this.Dropdown_Sort.FocusedColor = System.Drawing.Color.Black;
            this.Dropdown_Sort.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.Dropdown_Sort.FocusedState.Parent = this.Dropdown_Sort;
            this.Dropdown_Sort.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dropdown_Sort.ForeColor = System.Drawing.Color.White;
            this.Dropdown_Sort.FormattingEnabled = true;
            this.Dropdown_Sort.HoverState.BorderColor = System.Drawing.Color.Black;
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
            this.Dropdown_Sort.ItemsAppearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dropdown_Sort.ItemsAppearance.ForeColor = System.Drawing.Color.White;
            this.Dropdown_Sort.ItemsAppearance.Parent = this.Dropdown_Sort;
            this.Dropdown_Sort.ItemsAppearance.SelectedBackColor = System.Drawing.Color.DimGray;
            this.Dropdown_Sort.ItemsAppearance.SelectedFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dropdown_Sort.ItemsAppearance.SelectedForeColor = System.Drawing.Color.White;
            this.Dropdown_Sort.Location = new System.Drawing.Point(1041, 81);
            this.Dropdown_Sort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dropdown_Sort.Name = "Dropdown_Sort";
            this.Dropdown_Sort.ShadowDecoration.Parent = this.Dropdown_Sort;
            this.Dropdown_Sort.Size = new System.Drawing.Size(200, 36);
            this.Dropdown_Sort.StartIndex = 0;
            this.Dropdown_Sort.TabIndex = 33;
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
            this.Dropdown_Album.ItemsAppearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dropdown_Album.ItemsAppearance.ForeColor = System.Drawing.Color.White;
            this.Dropdown_Album.ItemsAppearance.Parent = this.Dropdown_Album;
            this.Dropdown_Album.ItemsAppearance.SelectedBackColor = System.Drawing.Color.DimGray;
            this.Dropdown_Album.ItemsAppearance.SelectedFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dropdown_Album.ItemsAppearance.SelectedForeColor = System.Drawing.Color.White;
            this.Dropdown_Album.Location = new System.Drawing.Point(829, 81);
            this.Dropdown_Album.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dropdown_Album.Name = "Dropdown_Album";
            this.Dropdown_Album.ShadowDecoration.Parent = this.Dropdown_Album;
            this.Dropdown_Album.Size = new System.Drawing.Size(200, 36);
            this.Dropdown_Album.StartIndex = 0;
            this.Dropdown_Album.TabIndex = 32;
            // 
            // DetailPanel
            // 
            this.DetailPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DetailPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.DetailPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DetailPanel.Controls.Add(this.lblTitle);
            this.DetailPanel.Controls.Add(this.lblDuration);
            this.DetailPanel.Controls.Add(this.lblNumber);
            this.DetailPanel.Controls.Add(this.lblArtist);
            this.DetailPanel.Controls.Add(this.lblAlbum);
            this.DetailPanel.Location = new System.Drawing.Point(43, 135);
            this.DetailPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DetailPanel.Name = "DetailPanel";
            this.DetailPanel.Size = new System.Drawing.Size(1197, 50);
            this.DetailPanel.TabIndex = 27;
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
            // lblDuration
            // 
            this.lblDuration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.ForeColor = System.Drawing.Color.White;
            this.lblDuration.Location = new System.Drawing.Point(984, 14);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(94, 25);
            this.lblDuration.TabIndex = 2;
            this.lblDuration.Text = "Duration";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.ForeColor = System.Drawing.Color.White;
            this.lblNumber.Location = new System.Drawing.Point(17, 14);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(21, 22);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "#";
            // 
            // lblArtist
            // 
            this.lblArtist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblArtist.AutoSize = true;
            this.lblArtist.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtist.ForeColor = System.Drawing.Color.White;
            this.lblArtist.Location = new System.Drawing.Point(355, 14);
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
            this.lblAlbum.Location = new System.Drawing.Point(676, 14);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(74, 25);
            this.lblAlbum.TabIndex = 1;
            this.lblAlbum.Text = "Album";
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
            this.Dropdown_Artist.ItemsAppearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dropdown_Artist.ItemsAppearance.ForeColor = System.Drawing.Color.White;
            this.Dropdown_Artist.ItemsAppearance.Parent = this.Dropdown_Artist;
            this.Dropdown_Artist.ItemsAppearance.SelectedBackColor = System.Drawing.Color.DimGray;
            this.Dropdown_Artist.ItemsAppearance.SelectedFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dropdown_Artist.ItemsAppearance.SelectedForeColor = System.Drawing.Color.White;
            this.Dropdown_Artist.Location = new System.Drawing.Point(617, 81);
            this.Dropdown_Artist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dropdown_Artist.Name = "Dropdown_Artist";
            this.Dropdown_Artist.ShadowDecoration.Parent = this.Dropdown_Artist;
            this.Dropdown_Artist.Size = new System.Drawing.Size(200, 36);
            this.Dropdown_Artist.StartIndex = 0;
            this.Dropdown_Artist.TabIndex = 31;
            // 
            // flowFavorites
            // 
            this.flowFavorites.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowFavorites.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowFavorites.Location = new System.Drawing.Point(43, 191);
            this.flowFavorites.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowFavorites.Name = "flowFavorites";
            this.flowFavorites.Size = new System.Drawing.Size(1196, 496);
            this.flowFavorites.TabIndex = 30;
            this.flowFavorites.WrapContents = false;
            // 
            // SongsMenu
            // 
            this.SongsMenu.BorderRadius = 10;
            this.SongsMenu.Controls.Add(this.guna2GradientButton7);
            this.SongsMenu.Controls.Add(this.RemovefromFavorites);
            this.SongsMenu.Controls.Add(this.guna2GradientButton3);
            this.SongsMenu.Controls.Add(this.Menu_AddPlaylist);
            this.SongsMenu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.SongsMenu.Location = new System.Drawing.Point(776, 183);
            this.SongsMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SongsMenu.Name = "SongsMenu";
            this.SongsMenu.ShadowDecoration.Parent = this.SongsMenu;
            this.SongsMenu.Size = new System.Drawing.Size(309, 215);
            this.SongsMenu.TabIndex = 38;
            this.SongsMenu.UseTransparentBackground = true;
            // 
            // guna2GradientButton7
            // 
            this.guna2GradientButton7.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton7.BorderRadius = 10;
            this.guna2GradientButton7.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.guna2GradientButton7.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.guna2GradientButton7.CheckedState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton7.CheckedState.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton7.CheckedState.Parent = this.guna2GradientButton7;
            this.guna2GradientButton7.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton7.CustomImages.Parent = this.guna2GradientButton7;
            this.guna2GradientButton7.FillColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton7.FillColor2 = System.Drawing.Color.Transparent;
            this.guna2GradientButton7.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton7.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton7.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.guna2GradientButton7.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.guna2GradientButton7.HoverState.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton7.HoverState.Parent = this.guna2GradientButton7;
            this.guna2GradientButton7.Image = global::NIMBUS__MUSIC_PLAYER_.Properties.Resources.Icon_Menu_Delete;
            this.guna2GradientButton7.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton7.ImageOffset = new System.Drawing.Point(11, 0);
            this.guna2GradientButton7.ImageSize = new System.Drawing.Size(18, 20);
            this.guna2GradientButton7.Location = new System.Drawing.Point(7, 160);
            this.guna2GradientButton7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2GradientButton7.Name = "guna2GradientButton7";
            this.guna2GradientButton7.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.guna2GradientButton7.ShadowDecoration.Parent = this.guna2GradientButton7;
            this.guna2GradientButton7.Size = new System.Drawing.Size(299, 46);
            this.guna2GradientButton7.TabIndex = 25;
            this.guna2GradientButton7.Text = "Delete Song";
            this.guna2GradientButton7.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton7.TextOffset = new System.Drawing.Point(22, 0);
            this.guna2GradientButton7.Click += new System.EventHandler(this.guna2GradientButton7_Click);
            // 
            // RemovefromFavorites
            // 
            this.RemovefromFavorites.BackColor = System.Drawing.Color.Transparent;
            this.RemovefromFavorites.BorderRadius = 10;
            this.RemovefromFavorites.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.RemovefromFavorites.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.RemovefromFavorites.CheckedState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemovefromFavorites.CheckedState.ForeColor = System.Drawing.Color.White;
            this.RemovefromFavorites.CheckedState.Parent = this.RemovefromFavorites;
            this.RemovefromFavorites.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.RemovefromFavorites.CustomImages.Parent = this.RemovefromFavorites;
            this.RemovefromFavorites.FillColor = System.Drawing.Color.Transparent;
            this.RemovefromFavorites.FillColor2 = System.Drawing.Color.Transparent;
            this.RemovefromFavorites.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemovefromFavorites.ForeColor = System.Drawing.Color.White;
            this.RemovefromFavorites.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.RemovefromFavorites.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.RemovefromFavorites.HoverState.ForeColor = System.Drawing.Color.White;
            this.RemovefromFavorites.HoverState.Parent = this.RemovefromFavorites;
            this.RemovefromFavorites.Image = global::NIMBUS__MUSIC_PLAYER_.Properties.Resources.Icon_Menu_Remove;
            this.RemovefromFavorites.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.RemovefromFavorites.ImageOffset = new System.Drawing.Point(10, 0);
            this.RemovefromFavorites.Location = new System.Drawing.Point(7, 110);
            this.RemovefromFavorites.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RemovefromFavorites.Name = "RemovefromFavorites";
            this.RemovefromFavorites.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.RemovefromFavorites.ShadowDecoration.Parent = this.RemovefromFavorites;
            this.RemovefromFavorites.Size = new System.Drawing.Size(299, 46);
            this.RemovefromFavorites.TabIndex = 24;
            this.RemovefromFavorites.Text = "Remove from this Playlist";
            this.RemovefromFavorites.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.RemovefromFavorites.TextOffset = new System.Drawing.Point(20, 0);
            this.RemovefromFavorites.Click += new System.EventHandler(this.RemovefromFavorites_Click);
            // 
            // guna2GradientButton3
            // 
            this.guna2GradientButton3.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton3.BorderRadius = 10;
            this.guna2GradientButton3.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.guna2GradientButton3.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.guna2GradientButton3.CheckedState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton3.CheckedState.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton3.CheckedState.Parent = this.guna2GradientButton3;
            this.guna2GradientButton3.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton3.CustomImages.Parent = this.guna2GradientButton3;
            this.guna2GradientButton3.FillColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton3.FillColor2 = System.Drawing.Color.Transparent;
            this.guna2GradientButton3.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton3.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton3.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.guna2GradientButton3.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.guna2GradientButton3.HoverState.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton3.HoverState.Parent = this.guna2GradientButton3;
            this.guna2GradientButton3.Image = global::NIMBUS__MUSIC_PLAYER_.Properties.Resources.Icon_Menu_AddtoQueue;
            this.guna2GradientButton3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton3.ImageOffset = new System.Drawing.Point(10, 0);
            this.guna2GradientButton3.Location = new System.Drawing.Point(7, 62);
            this.guna2GradientButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2GradientButton3.Name = "guna2GradientButton3";
            this.guna2GradientButton3.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.guna2GradientButton3.ShadowDecoration.Parent = this.guna2GradientButton3;
            this.guna2GradientButton3.Size = new System.Drawing.Size(299, 46);
            this.guna2GradientButton3.TabIndex = 23;
            this.guna2GradientButton3.Text = "Add to Queue";
            this.guna2GradientButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton3.TextOffset = new System.Drawing.Point(20, 0);
            // 
            // Menu_AddPlaylist
            // 
            this.Menu_AddPlaylist.BackColor = System.Drawing.Color.Transparent;
            this.Menu_AddPlaylist.BorderRadius = 10;
            this.Menu_AddPlaylist.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.Menu_AddPlaylist.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.Menu_AddPlaylist.CheckedState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_AddPlaylist.CheckedState.ForeColor = System.Drawing.Color.White;
            this.Menu_AddPlaylist.CheckedState.Parent = this.Menu_AddPlaylist;
            this.Menu_AddPlaylist.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Menu_AddPlaylist.CustomImages.Parent = this.Menu_AddPlaylist;
            this.Menu_AddPlaylist.FillColor = System.Drawing.Color.Transparent;
            this.Menu_AddPlaylist.FillColor2 = System.Drawing.Color.Transparent;
            this.Menu_AddPlaylist.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_AddPlaylist.ForeColor = System.Drawing.Color.White;
            this.Menu_AddPlaylist.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.Menu_AddPlaylist.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.Menu_AddPlaylist.HoverState.ForeColor = System.Drawing.Color.White;
            this.Menu_AddPlaylist.HoverState.Parent = this.Menu_AddPlaylist;
            this.Menu_AddPlaylist.Image = global::NIMBUS__MUSIC_PLAYER_.Properties.Resources.Icon_Menu_AddtoPlaylist;
            this.Menu_AddPlaylist.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Menu_AddPlaylist.ImageOffset = new System.Drawing.Point(10, 0);
            this.Menu_AddPlaylist.Location = new System.Drawing.Point(7, 10);
            this.Menu_AddPlaylist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Menu_AddPlaylist.Name = "Menu_AddPlaylist";
            this.Menu_AddPlaylist.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.Menu_AddPlaylist.ShadowDecoration.Parent = this.Menu_AddPlaylist;
            this.Menu_AddPlaylist.Size = new System.Drawing.Size(299, 46);
            this.Menu_AddPlaylist.TabIndex = 22;
            this.Menu_AddPlaylist.Text = "Add to other playlist";
            this.Menu_AddPlaylist.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Menu_AddPlaylist.TextOffset = new System.Drawing.Point(20, 0);
            this.Menu_AddPlaylist.Click += new System.EventHandler(this.Menu_AddPlaylist_Click);
            // 
            // SearchBar
            // 
            this.SearchBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBar.AutoRoundedCorners = true;
            this.SearchBar.BackColor = System.Drawing.Color.Transparent;
            this.SearchBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SearchBar.BorderColor = System.Drawing.Color.White;
            this.SearchBar.BorderRadius = 18;
            this.SearchBar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchBar.DefaultText = "";
            this.SearchBar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SearchBar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SearchBar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchBar.DisabledState.Parent = this.SearchBar;
            this.SearchBar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchBar.FillColor = System.Drawing.Color.Transparent;
            this.SearchBar.FocusedState.BorderColor = System.Drawing.Color.White;
            this.SearchBar.FocusedState.Parent = this.SearchBar;
            this.SearchBar.ForeColor = System.Drawing.Color.Silver;
            this.SearchBar.HoverState.BorderColor = System.Drawing.Color.White;
            this.SearchBar.HoverState.Parent = this.SearchBar;
            this.SearchBar.IconLeft = global::NIMBUS__MUSIC_PLAYER_.Properties.Resources.SVG;
            this.SearchBar.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.SearchBar.IconLeftSize = new System.Drawing.Size(15, 15);
            this.SearchBar.Location = new System.Drawing.Point(935, 21);
            this.SearchBar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.PasswordChar = '\0';
            this.SearchBar.PlaceholderForeColor = System.Drawing.Color.White;
            this.SearchBar.PlaceholderText = "Search";
            this.SearchBar.SelectedText = "";
            this.SearchBar.ShadowDecoration.Parent = this.SearchBar;
            this.SearchBar.Size = new System.Drawing.Size(304, 39);
            this.SearchBar.TabIndex = 36;
            this.SearchBar.TextOffset = new System.Drawing.Point(20, 0);
            // 
            // Menubtn
            // 
            this.Menubtn.CheckedState.Parent = this.Menubtn;
            this.Menubtn.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.Menubtn.HoverState.Parent = this.Menubtn;
            this.Menubtn.Image = global::NIMBUS__MUSIC_PLAYER_.Properties.Resources.Menu;
            this.Menubtn.ImageSize = new System.Drawing.Size(25, 25);
            this.Menubtn.Location = new System.Drawing.Point(165, 81);
            this.Menubtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Menubtn.Name = "Menubtn";
            this.Menubtn.PressedState.Parent = this.Menubtn;
            this.Menubtn.Size = new System.Drawing.Size(51, 33);
            this.Menubtn.TabIndex = 29;
            this.Menubtn.Visible = false;
            this.Menubtn.Click += new System.EventHandler(this.Menubtn_Click);
            // 
            // guna2ImageButton2
            // 
            this.guna2ImageButton2.CheckedState.Parent = this.guna2ImageButton2;
            this.guna2ImageButton2.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton2.HoverState.Parent = this.guna2ImageButton2;
            this.guna2ImageButton2.Image = global::NIMBUS__MUSIC_PLAYER_.Properties.Resources.Group__3_;
            this.guna2ImageButton2.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton2.Location = new System.Drawing.Point(107, 82);
            this.guna2ImageButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2ImageButton2.Name = "guna2ImageButton2";
            this.guna2ImageButton2.PressedState.Parent = this.guna2ImageButton2;
            this.guna2ImageButton2.Size = new System.Drawing.Size(51, 33);
            this.guna2ImageButton2.TabIndex = 26;
            // 
            // MenuTabs
            // 
            this.MenuTabs.BorderRadius = 10;
            this.MenuTabs.Controls.Add(this.guna2GradientButton1);
            this.MenuTabs.Controls.Add(this.guna2GradientButton4);
            this.MenuTabs.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.MenuTabs.Location = new System.Drawing.Point(165, 121);
            this.MenuTabs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MenuTabs.Name = "MenuTabs";
            this.MenuTabs.ShadowDecoration.Parent = this.MenuTabs;
            this.MenuTabs.Size = new System.Drawing.Size(239, 114);
            this.MenuTabs.TabIndex = 39;
            this.MenuTabs.UseTransparentBackground = true;
            this.MenuTabs.Visible = false;
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.BorderRadius = 10;
            this.guna2GradientButton1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.guna2GradientButton1.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.guna2GradientButton1.CheckedState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton1.CheckedState.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.CheckedState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton1.CustomImages.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.FillColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.guna2GradientButton1.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.guna2GradientButton1.HoverState.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.HoverState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Image = global::NIMBUS__MUSIC_PLAYER_.Properties.Resources.Icon_Menu_RemovePlaylist;
            this.guna2GradientButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton1.ImageOffset = new System.Drawing.Point(10, 0);
            this.guna2GradientButton1.Location = new System.Drawing.Point(9, 62);
            this.guna2GradientButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.guna2GradientButton1.ShadowDecoration.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Size = new System.Drawing.Size(220, 46);
            this.guna2GradientButton1.TabIndex = 23;
            this.guna2GradientButton1.Text = "Delete playlist";
            this.guna2GradientButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton1.TextOffset = new System.Drawing.Point(20, 0);
            // 
            // guna2GradientButton4
            // 
            this.guna2GradientButton4.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton4.BorderRadius = 10;
            this.guna2GradientButton4.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.guna2GradientButton4.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.guna2GradientButton4.CheckedState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton4.CheckedState.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton4.CheckedState.Parent = this.guna2GradientButton4;
            this.guna2GradientButton4.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton4.CustomImages.Parent = this.guna2GradientButton4;
            this.guna2GradientButton4.FillColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton4.FillColor2 = System.Drawing.Color.Transparent;
            this.guna2GradientButton4.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton4.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton4.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.guna2GradientButton4.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.guna2GradientButton4.HoverState.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton4.HoverState.Parent = this.guna2GradientButton4;
            this.guna2GradientButton4.Image = global::NIMBUS__MUSIC_PLAYER_.Properties.Resources.Icon_Menu_AddtoQueue;
            this.guna2GradientButton4.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton4.ImageOffset = new System.Drawing.Point(10, 0);
            this.guna2GradientButton4.Location = new System.Drawing.Point(9, 10);
            this.guna2GradientButton4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2GradientButton4.Name = "guna2GradientButton4";
            this.guna2GradientButton4.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.guna2GradientButton4.ShadowDecoration.Parent = this.guna2GradientButton4;
            this.guna2GradientButton4.Size = new System.Drawing.Size(220, 46);
            this.guna2GradientButton4.TabIndex = 22;
            this.guna2GradientButton4.Text = "Add to Queue";
            this.guna2GradientButton4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton4.TextOffset = new System.Drawing.Point(20, 0);
            // 
            // FavoritesScrollbar
            // 
            this.FavoritesScrollbar.AutoRoundedCorners = true;
            this.FavoritesScrollbar.BorderRadius = 4;
            this.FavoritesScrollbar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.FavoritesScrollbar.HoverState.Parent = null;
            this.FavoritesScrollbar.LargeChange = 10;
            this.FavoritesScrollbar.Location = new System.Drawing.Point(1260, 135);
            this.FavoritesScrollbar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.FavoritesScrollbar.MouseWheelBarPartitions = 10;
            this.FavoritesScrollbar.Name = "FavoritesScrollbar";
            this.FavoritesScrollbar.PressedState.Parent = this.FavoritesScrollbar;
            this.FavoritesScrollbar.ScrollbarSize = 11;
            this.FavoritesScrollbar.Size = new System.Drawing.Size(11, 542);
            this.FavoritesScrollbar.TabIndex = 40;
            this.FavoritesScrollbar.ThumbColor = System.Drawing.Color.White;
            // 
            // FavoritePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.FavoritesScrollbar);
            this.Controls.Add(this.MenuTabs);
            this.Controls.Add(this.SongsMenu);
            this.Controls.Add(this.SearchBar);
            this.Controls.Add(this.guna2GradientButton2);
            this.Controls.Add(this.lblFavoritesPanel);
            this.Controls.Add(this.Dropdown_Sort);
            this.Controls.Add(this.Dropdown_Album);
            this.Controls.Add(this.DetailPanel);
            this.Controls.Add(this.Dropdown_Artist);
            this.Controls.Add(this.Menubtn);
            this.Controls.Add(this.flowFavorites);
            this.Controls.Add(this.guna2ImageButton2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FavoritePanel";
            this.Size = new System.Drawing.Size(1275, 687);
            this.DetailPanel.ResumeLayout(false);
            this.DetailPanel.PerformLayout();
            this.SongsMenu.ResumeLayout(false);
            this.MenuTabs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox SearchBar;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
        private System.Windows.Forms.Label lblFavoritesPanel;
        private Guna.UI2.WinForms.Guna2ComboBox Dropdown_Sort;
        private Guna.UI2.WinForms.Guna2ComboBox Dropdown_Album;
        private System.Windows.Forms.Panel DetailPanel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.Label lblAlbum;
        private Guna.UI2.WinForms.Guna2ComboBox Dropdown_Artist;
        private Guna.UI2.WinForms.Guna2ImageButton Menubtn;
        private System.Windows.Forms.FlowLayoutPanel flowFavorites;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
        private Guna.UI2.WinForms.Guna2Panel SongsMenu;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton7;
        private Guna.UI2.WinForms.Guna2GradientButton RemovefromFavorites;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton3;
        private Guna.UI2.WinForms.Guna2GradientButton Menu_AddPlaylist;
        private Guna.UI2.WinForms.Guna2Panel MenuTabs;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton4;
        private Guna.UI2.WinForms.Guna2VScrollBar FavoritesScrollbar;
    }
}
