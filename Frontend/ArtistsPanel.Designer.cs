namespace NIMBUS__MUSIC_PLAYER_
{
    partial class ArtistsPanel
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
            this.lblArtistPanel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SearchBar = new Guna.UI2.WinForms.Guna2TextBox();
            this.Dropdown_Sort = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Dropdown_Album = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Dropdown_Artist = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SuspendLayout();
            // 
            // lblArtistPanel
            // 
            this.lblArtistPanel.AutoSize = true;
            this.lblArtistPanel.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtistPanel.ForeColor = System.Drawing.Color.White;
            this.lblArtistPanel.Location = new System.Drawing.Point(33, 6);
            this.lblArtistPanel.Name = "lblArtistPanel";
            this.lblArtistPanel.Size = new System.Drawing.Size(161, 55);
            this.lblArtistPanel.TabIndex = 28;
            this.lblArtistPanel.Text = "Artists";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(43, 147);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1196, 538);
            this.flowLayoutPanel1.TabIndex = 42;
            // 
            // SearchBar
            // 
            this.SearchBar.AutoRoundedCorners = true;
            this.SearchBar.BackColor = System.Drawing.Color.Transparent;
            this.SearchBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SearchBar.BorderColor = System.Drawing.Color.White;
            this.SearchBar.BorderRadius = 19;
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
            this.SearchBar.Location = new System.Drawing.Point(43, 81);
            this.SearchBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.PasswordChar = '\0';
            this.SearchBar.PlaceholderForeColor = System.Drawing.Color.White;
            this.SearchBar.PlaceholderText = "Search";
            this.SearchBar.SelectedText = "";
            this.SearchBar.ShadowDecoration.Parent = this.SearchBar;
            this.SearchBar.Size = new System.Drawing.Size(304, 40);
            this.SearchBar.TabIndex = 41;
            this.SearchBar.TextOffset = new System.Drawing.Point(20, 0);
            // 
            // Dropdown_Sort
            // 
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
            this.Dropdown_Sort.Location = new System.Drawing.Point(784, 83);
            this.Dropdown_Sort.Name = "Dropdown_Sort";
            this.Dropdown_Sort.ShadowDecoration.Parent = this.Dropdown_Sort;
            this.Dropdown_Sort.Size = new System.Drawing.Size(200, 36);
            this.Dropdown_Sort.StartIndex = 0;
            this.Dropdown_Sort.TabIndex = 40;
            // 
            // Dropdown_Album
            // 
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
            this.Dropdown_Album.Location = new System.Drawing.Point(573, 83);
            this.Dropdown_Album.Name = "Dropdown_Album";
            this.Dropdown_Album.ShadowDecoration.Parent = this.Dropdown_Album;
            this.Dropdown_Album.Size = new System.Drawing.Size(200, 36);
            this.Dropdown_Album.StartIndex = 0;
            this.Dropdown_Album.TabIndex = 39;
            // 
            // Dropdown_Artist
            // 
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
            this.Dropdown_Artist.Location = new System.Drawing.Point(360, 83);
            this.Dropdown_Artist.Name = "Dropdown_Artist";
            this.Dropdown_Artist.ShadowDecoration.Parent = this.Dropdown_Artist;
            this.Dropdown_Artist.Size = new System.Drawing.Size(200, 36);
            this.Dropdown_Artist.StartIndex = 0;
            this.Dropdown_Artist.TabIndex = 38;
            // 
            // ArtistsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.SearchBar);
            this.Controls.Add(this.Dropdown_Sort);
            this.Controls.Add(this.Dropdown_Album);
            this.Controls.Add(this.Dropdown_Artist);
            this.Controls.Add(this.lblArtistPanel);
            this.Name = "ArtistsPanel";
            this.Size = new System.Drawing.Size(1272, 685);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblArtistPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2TextBox SearchBar;
        private Guna.UI2.WinForms.Guna2ComboBox Dropdown_Sort;
        private Guna.UI2.WinForms.Guna2ComboBox Dropdown_Album;
        private Guna.UI2.WinForms.Guna2ComboBox Dropdown_Artist;
    }
}
