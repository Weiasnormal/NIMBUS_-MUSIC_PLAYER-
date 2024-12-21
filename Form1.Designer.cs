namespace NIMBUS__MUSIC_PLAYER_
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.Sidebar = new Guna.UI2.WinForms.Guna2Panel();
            this.Panel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.QueueButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.PlaylistButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ArtistButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.AlbumButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.FavoritesButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SongsButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.NImbusLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.NowPlaying = new Guna.UI2.WinForms.Guna2Panel();
            this.Sidebar.SuspendLayout();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NImbusLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.Location = new System.Drawing.Point(351, 1);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1553, 135);
            this.guna2Panel1.TabIndex = 0;
            // 
            // Sidebar
            // 
            this.Sidebar.BackgroundImage = global::NIMBUS__MUSIC_PLAYER_.Properties.Resources.Rectangle_167__1_;
            this.Sidebar.Controls.Add(this.Panel);
            this.Sidebar.Controls.Add(this.NImbusLogo);
            this.Sidebar.Location = new System.Drawing.Point(2, 1);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.ShadowDecoration.Parent = this.Sidebar;
            this.Sidebar.Size = new System.Drawing.Size(347, 1080);
            this.Sidebar.TabIndex = 2;
            this.Sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel3_Paint);
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.Transparent;
            this.Panel.Controls.Add(this.QueueButton);
            this.Panel.Controls.Add(this.PlaylistButton);
            this.Panel.Controls.Add(this.ArtistButton);
            this.Panel.Controls.Add(this.AlbumButton);
            this.Panel.Controls.Add(this.FavoritesButton);
            this.Panel.Controls.Add(this.SongsButton);
            this.Panel.Location = new System.Drawing.Point(17, 100);
            this.Panel.Name = "Panel";
            this.Panel.ShadowDecoration.Parent = this.Panel;
            this.Panel.Size = new System.Drawing.Size(313, 440);
            this.Panel.TabIndex = 3;
            // 
            // QueueButton
            // 
            this.QueueButton.CheckedState.Parent = this.QueueButton;
            this.QueueButton.CustomImages.Parent = this.QueueButton;
            this.QueueButton.FillColor = System.Drawing.Color.Transparent;
            this.QueueButton.FillColor2 = System.Drawing.Color.Transparent;
            this.QueueButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.QueueButton.ForeColor = System.Drawing.Color.White;
            this.QueueButton.HoverState.Parent = this.QueueButton;
            this.QueueButton.Image = global::NIMBUS__MUSIC_PLAYER_.Properties.Resources.Sidebar_Placeholder__6_;
            this.QueueButton.ImageSize = new System.Drawing.Size(313, 65);
            this.QueueButton.Location = new System.Drawing.Point(0, 359);
            this.QueueButton.Name = "QueueButton";
            this.QueueButton.ShadowDecoration.Parent = this.QueueButton;
            this.QueueButton.Size = new System.Drawing.Size(330, 65);
            this.QueueButton.TabIndex = 8;
            // 
            // PlaylistButton
            // 
            this.PlaylistButton.CheckedState.Parent = this.PlaylistButton;
            this.PlaylistButton.CustomImages.Parent = this.PlaylistButton;
            this.PlaylistButton.FillColor = System.Drawing.Color.Transparent;
            this.PlaylistButton.FillColor2 = System.Drawing.Color.Transparent;
            this.PlaylistButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PlaylistButton.ForeColor = System.Drawing.Color.White;
            this.PlaylistButton.HoverState.Parent = this.PlaylistButton;
            this.PlaylistButton.Image = global::NIMBUS__MUSIC_PLAYER_.Properties.Resources.Playlist_Dropdown;
            this.PlaylistButton.ImageSize = new System.Drawing.Size(313, 65);
            this.PlaylistButton.Location = new System.Drawing.Point(0, 288);
            this.PlaylistButton.Name = "PlaylistButton";
            this.PlaylistButton.ShadowDecoration.Parent = this.PlaylistButton;
            this.PlaylistButton.Size = new System.Drawing.Size(313, 65);
            this.PlaylistButton.TabIndex = 7;
            // 
            // ArtistButton
            // 
            this.ArtistButton.CheckedState.Parent = this.ArtistButton;
            this.ArtistButton.CustomImages.Parent = this.ArtistButton;
            this.ArtistButton.FillColor = System.Drawing.Color.Transparent;
            this.ArtistButton.FillColor2 = System.Drawing.Color.Transparent;
            this.ArtistButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ArtistButton.ForeColor = System.Drawing.Color.White;
            this.ArtistButton.HoverState.Parent = this.ArtistButton;
            this.ArtistButton.Image = global::NIMBUS__MUSIC_PLAYER_.Properties.Resources.Sidebar_Placeholder__5_;
            this.ArtistButton.ImageSize = new System.Drawing.Size(313, 65);
            this.ArtistButton.Location = new System.Drawing.Point(0, 213);
            this.ArtistButton.Name = "ArtistButton";
            this.ArtistButton.ShadowDecoration.Parent = this.ArtistButton;
            this.ArtistButton.Size = new System.Drawing.Size(313, 65);
            this.ArtistButton.TabIndex = 6;
            // 
            // AlbumButton
            // 
            this.AlbumButton.CheckedState.Parent = this.AlbumButton;
            this.AlbumButton.CustomImages.Parent = this.AlbumButton;
            this.AlbumButton.FillColor = System.Drawing.Color.Transparent;
            this.AlbumButton.FillColor2 = System.Drawing.Color.Transparent;
            this.AlbumButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AlbumButton.ForeColor = System.Drawing.Color.White;
            this.AlbumButton.HoverState.Parent = this.AlbumButton;
            this.AlbumButton.Image = global::NIMBUS__MUSIC_PLAYER_.Properties.Resources.Sidebar_Placeholder__3_;
            this.AlbumButton.ImageSize = new System.Drawing.Size(313, 65);
            this.AlbumButton.Location = new System.Drawing.Point(0, 142);
            this.AlbumButton.Name = "AlbumButton";
            this.AlbumButton.ShadowDecoration.Parent = this.AlbumButton;
            this.AlbumButton.Size = new System.Drawing.Size(313, 65);
            this.AlbumButton.TabIndex = 5;
            // 
            // FavoritesButton
            // 
            this.FavoritesButton.CheckedState.Parent = this.FavoritesButton;
            this.FavoritesButton.CustomImages.Parent = this.FavoritesButton;
            this.FavoritesButton.FillColor = System.Drawing.Color.Transparent;
            this.FavoritesButton.FillColor2 = System.Drawing.Color.Transparent;
            this.FavoritesButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FavoritesButton.ForeColor = System.Drawing.Color.White;
            this.FavoritesButton.HoverState.Parent = this.FavoritesButton;
            this.FavoritesButton.Image = global::NIMBUS__MUSIC_PLAYER_.Properties.Resources.Sidebar_Placeholder__2_;
            this.FavoritesButton.ImageSize = new System.Drawing.Size(313, 65);
            this.FavoritesButton.Location = new System.Drawing.Point(0, 71);
            this.FavoritesButton.Name = "FavoritesButton";
            this.FavoritesButton.ShadowDecoration.Parent = this.FavoritesButton;
            this.FavoritesButton.Size = new System.Drawing.Size(313, 65);
            this.FavoritesButton.TabIndex = 4;
            // 
            // SongsButton
            // 
            this.SongsButton.CheckedState.Parent = this.SongsButton;
            this.SongsButton.CustomImages.Parent = this.SongsButton;
            this.SongsButton.FillColor = System.Drawing.Color.Transparent;
            this.SongsButton.FillColor2 = System.Drawing.Color.Transparent;
            this.SongsButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SongsButton.ForeColor = System.Drawing.Color.White;
            this.SongsButton.HoverState.Parent = this.SongsButton;
            this.SongsButton.Image = global::NIMBUS__MUSIC_PLAYER_.Properties.Resources.Sidebar_Placeholder;
            this.SongsButton.ImageSize = new System.Drawing.Size(313, 65);
            this.SongsButton.Location = new System.Drawing.Point(0, 2);
            this.SongsButton.Name = "SongsButton";
            this.SongsButton.ShadowDecoration.Parent = this.SongsButton;
            this.SongsButton.Size = new System.Drawing.Size(313, 65);
            this.SongsButton.TabIndex = 3;
            // 
            // NImbusLogo
            // 
            this.NImbusLogo.BackColor = System.Drawing.Color.Transparent;
            this.NImbusLogo.Image = global::NIMBUS__MUSIC_PLAYER_.Properties.Resources.Nimbus_Horizontal_Logo_2;
            this.NImbusLogo.Location = new System.Drawing.Point(24, 18);
            this.NImbusLogo.Name = "NImbusLogo";
            this.NImbusLogo.ShadowDecoration.Parent = this.NImbusLogo;
            this.NImbusLogo.Size = new System.Drawing.Size(214, 38);
            this.NImbusLogo.TabIndex = 0;
            this.NImbusLogo.TabStop = false;
            // 
            // NowPlaying
            // 
            this.NowPlaying.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.NowPlaying.BackColor = System.Drawing.Color.Transparent;
            this.NowPlaying.BackgroundImage = global::NIMBUS__MUSIC_PLAYER_.Properties.Resources.Rectangle_167__2_;
            this.NowPlaying.Location = new System.Drawing.Point(2, 902);
            this.NowPlaying.Name = "NowPlaying";
            this.NowPlaying.ShadowDecoration.Parent = this.NowPlaying;
            this.NowPlaying.Size = new System.Drawing.Size(1905, 135);
            this.NowPlaying.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1906, 1037);
            this.Controls.Add(this.NowPlaying);
            this.Controls.Add(this.Sidebar);
            this.Controls.Add(this.guna2Panel1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Main";
            this.Sidebar.ResumeLayout(false);
            this.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NImbusLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel Sidebar;
        private Guna.UI2.WinForms.Guna2PictureBox NImbusLogo;
        private Guna.UI2.WinForms.Guna2GradientPanel Panel;
        private Guna.UI2.WinForms.Guna2GradientButton SongsButton;
        private Guna.UI2.WinForms.Guna2GradientButton FavoritesButton;
        private Guna.UI2.WinForms.Guna2GradientButton AlbumButton;
        private Guna.UI2.WinForms.Guna2GradientButton PlaylistButton;
        private Guna.UI2.WinForms.Guna2GradientButton ArtistButton;
        private Guna.UI2.WinForms.Guna2GradientButton QueueButton;
        private Guna.UI2.WinForms.Guna2Panel NowPlaying;
    }
}

