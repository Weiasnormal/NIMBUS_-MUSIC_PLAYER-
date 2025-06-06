﻿namespace NIMBUS__MUSIC_PLAYER_
{
    partial class NimbusMiniplayer
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
            this.components = new System.ComponentModel.Container();
            this.CloseMiniplayer = new System.Windows.Forms.PictureBox();
            this.Artistlbl = new System.Windows.Forms.Label();
            this.TitleSonglbl = new System.Windows.Forms.Label();
            this.SongTimePanel = new System.Windows.Forms.Panel();
            this.EndTime = new System.Windows.Forms.Label();
            this.TimePlayed = new System.Windows.Forms.Label();
            this.TimeSong = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.VolumeBar = new Guna.UI2.WinForms.Guna2TrackBar();
            this.SoundIcon = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Switchtomain = new System.Windows.Forms.PictureBox();
            this.lblVolumePercent = new System.Windows.Forms.Label();
            this.Playbtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Pausebtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnFavorite_Pressed = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnFavorite_Default = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.CloseMiniplayer)).BeginInit();
            this.SongTimePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SoundIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Switchtomain)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseMiniplayer
            // 
            this.CloseMiniplayer.BackColor = System.Drawing.Color.Transparent;
            this.CloseMiniplayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseMiniplayer.Image = global::NIMBUS__MUSIC_PLAYER_.Properties.Resources.Group__4_;
            this.CloseMiniplayer.Location = new System.Drawing.Point(300, 12);
            this.CloseMiniplayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CloseMiniplayer.Name = "CloseMiniplayer";
            this.CloseMiniplayer.Size = new System.Drawing.Size(35, 26);
            this.CloseMiniplayer.TabIndex = 41;
            this.CloseMiniplayer.TabStop = false;
            this.CloseMiniplayer.Click += new System.EventHandler(this.CloseMiniplayer_Click);
            // 
            // Artistlbl
            // 
            this.Artistlbl.AutoSize = true;
            this.Artistlbl.BackColor = System.Drawing.Color.Transparent;
            this.Artistlbl.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Artistlbl.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Artistlbl.Location = new System.Drawing.Point(34, 42);
            this.Artistlbl.Name = "Artistlbl";
            this.Artistlbl.Size = new System.Drawing.Size(127, 21);
            this.Artistlbl.TabIndex = 40;
            this.Artistlbl.Text = "Camilla Cabello";
            this.Artistlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TitleSonglbl
            // 
            this.TitleSonglbl.AutoSize = true;
            this.TitleSonglbl.BackColor = System.Drawing.Color.Transparent;
            this.TitleSonglbl.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleSonglbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TitleSonglbl.Location = new System.Drawing.Point(5, 13);
            this.TitleSonglbl.Name = "TitleSonglbl";
            this.TitleSonglbl.Size = new System.Drawing.Size(121, 32);
            this.TitleSonglbl.TabIndex = 39;
            this.TitleSonglbl.Text = "HAVANA";
            this.TitleSonglbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SongTimePanel
            // 
            this.SongTimePanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SongTimePanel.BackColor = System.Drawing.Color.Transparent;
            this.SongTimePanel.Controls.Add(this.EndTime);
            this.SongTimePanel.Controls.Add(this.TimePlayed);
            this.SongTimePanel.Controls.Add(this.TimeSong);
            this.SongTimePanel.Location = new System.Drawing.Point(29, 112);
            this.SongTimePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SongTimePanel.Name = "SongTimePanel";
            this.SongTimePanel.Size = new System.Drawing.Size(288, 44);
            this.SongTimePanel.TabIndex = 38;
            // 
            // EndTime
            // 
            this.EndTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EndTime.AutoSize = true;
            this.EndTime.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EndTime.Location = new System.Drawing.Point(237, 23);
            this.EndTime.Name = "EndTime";
            this.EndTime.Size = new System.Drawing.Size(47, 18);
            this.EndTime.TabIndex = 9;
            this.EndTime.Text = "00:00";
            // 
            // TimePlayed
            // 
            this.TimePlayed.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TimePlayed.AutoSize = true;
            this.TimePlayed.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimePlayed.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TimePlayed.Location = new System.Drawing.Point(11, 23);
            this.TimePlayed.Name = "TimePlayed";
            this.TimePlayed.Size = new System.Drawing.Size(47, 18);
            this.TimePlayed.TabIndex = 8;
            this.TimePlayed.Text = "00:00";
            // 
            // TimeSong
            // 
            this.TimeSong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TimeSong.BackColor = System.Drawing.Color.DimGray;
            this.TimeSong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TimeSong.FillColor = System.Drawing.Color.White;
            this.TimeSong.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.TimeSong.Location = new System.Drawing.Point(19, 7);
            this.TimeSong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TimeSong.Name = "TimeSong";
            this.TimeSong.ProgressColor = System.Drawing.Color.White;
            this.TimeSong.ShadowDecoration.Parent = this.TimeSong;
            this.TimeSong.Size = new System.Drawing.Size(253, 2);
            this.TimeSong.TabIndex = 0;
            this.TimeSong.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // VolumeBar
            // 
            this.VolumeBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.VolumeBar.BackColor = System.Drawing.Color.Transparent;
            this.VolumeBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VolumeBar.FillColor = System.Drawing.Color.DarkGray;
            this.VolumeBar.HoverState.Parent = this.VolumeBar;
            this.VolumeBar.Location = new System.Drawing.Point(64, 252);
            this.VolumeBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VolumeBar.Name = "VolumeBar";
            this.VolumeBar.Size = new System.Drawing.Size(101, 27);
            this.VolumeBar.TabIndex = 37;
            this.VolumeBar.ThumbColor = System.Drawing.Color.White;
            this.VolumeBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.VolumeBar_Scroll);
            // 
            // SoundIcon
            // 
            this.SoundIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SoundIcon.BackColor = System.Drawing.Color.Transparent;
            this.SoundIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SoundIcon.Image = global::NIMBUS__MUSIC_PLAYER_.Properties.Resources.Group;
            this.SoundIcon.Location = new System.Drawing.Point(29, 254);
            this.SoundIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SoundIcon.Name = "SoundIcon";
            this.SoundIcon.Size = new System.Drawing.Size(20, 20);
            this.SoundIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.SoundIcon.TabIndex = 36;
            this.SoundIcon.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox8.Image = global::NIMBUS__MUSIC_PLAYER_.Properties.Resources.Vector__3_;
            this.pictureBox8.Location = new System.Drawing.Point(256, 191);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(20, 20);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox8.TabIndex = 34;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::NIMBUS__MUSIC_PLAYER_.Properties.Resources.Vector__4_;
            this.pictureBox5.Location = new System.Drawing.Point(64, 191);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(20, 20);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 30;
            this.pictureBox5.TabStop = false;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // Switchtomain
            // 
            this.Switchtomain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Switchtomain.BackColor = System.Drawing.Color.Transparent;
            this.Switchtomain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Switchtomain.Image = global::NIMBUS__MUSIC_PLAYER_.Properties.Resources.Icon_Resize;
            this.Switchtomain.Location = new System.Drawing.Point(14, 20);
            this.Switchtomain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Switchtomain.Name = "Switchtomain";
            this.Switchtomain.Size = new System.Drawing.Size(20, 20);
            this.Switchtomain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Switchtomain.TabIndex = 42;
            this.Switchtomain.TabStop = false;
            this.Switchtomain.Click += new System.EventHandler(this.Switchtomain_Click);
            // 
            // lblVolumePercent
            // 
            this.lblVolumePercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVolumePercent.AutoSize = true;
            this.lblVolumePercent.BackColor = System.Drawing.Color.Transparent;
            this.lblVolumePercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolumePercent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblVolumePercent.Location = new System.Drawing.Point(29, 234);
            this.lblVolumePercent.Name = "lblVolumePercent";
            this.lblVolumePercent.Size = new System.Drawing.Size(23, 16);
            this.lblVolumePercent.TabIndex = 43;
            this.lblVolumePercent.Text = "    ";
            // 
            // Playbtn
            // 
            this.Playbtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Playbtn.BackColor = System.Drawing.Color.Transparent;
            this.Playbtn.CheckedState.Parent = this.Playbtn;
            this.Playbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Playbtn.CustomImages.Image = global::NIMBUS__MUSIC_PLAYER_.Properties.Resources.Icon_Play;
            this.Playbtn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Playbtn.CustomImages.ImageOffset = new System.Drawing.Point(0, -15);
            this.Playbtn.CustomImages.ImageSize = new System.Drawing.Size(45, 45);
            this.Playbtn.CustomImages.Parent = this.Playbtn;
            this.Playbtn.FillColor = System.Drawing.Color.Empty;
            this.Playbtn.FillColor2 = System.Drawing.Color.Empty;
            this.Playbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Playbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(50)))), ((int)(((byte)(53)))));
            this.Playbtn.HoverState.Parent = this.Playbtn;
            this.Playbtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Playbtn.Location = new System.Drawing.Point(139, 174);
            this.Playbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Playbtn.Name = "Playbtn";
            this.Playbtn.PressedColor = System.Drawing.Color.Transparent;
            this.Playbtn.ShadowDecoration.Parent = this.Playbtn;
            this.Playbtn.Size = new System.Drawing.Size(65, 62);
            this.Playbtn.TabIndex = 44;
            this.Playbtn.TextOffset = new System.Drawing.Point(15, 0);
            this.Playbtn.UseTransparentBackground = true;
            this.Playbtn.Visible = false;
            this.Playbtn.Click += new System.EventHandler(this.Playbtn_Click);
            // 
            // Pausebtn
            // 
            this.Pausebtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Pausebtn.BackColor = System.Drawing.Color.Transparent;
            this.Pausebtn.CheckedState.Parent = this.Pausebtn;
            this.Pausebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pausebtn.CustomImages.Image = global::NIMBUS__MUSIC_PLAYER_.Properties.Resources.Icon_Pause;
            this.Pausebtn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Pausebtn.CustomImages.ImageOffset = new System.Drawing.Point(0, -15);
            this.Pausebtn.CustomImages.ImageSize = new System.Drawing.Size(45, 45);
            this.Pausebtn.CustomImages.Parent = this.Pausebtn;
            this.Pausebtn.FillColor = System.Drawing.Color.Empty;
            this.Pausebtn.FillColor2 = System.Drawing.Color.Empty;
            this.Pausebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pausebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(50)))), ((int)(((byte)(53)))));
            this.Pausebtn.HoverState.Parent = this.Pausebtn;
            this.Pausebtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Pausebtn.Location = new System.Drawing.Point(139, 174);
            this.Pausebtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pausebtn.Name = "Pausebtn";
            this.Pausebtn.PressedColor = System.Drawing.Color.Transparent;
            this.Pausebtn.ShadowDecoration.Parent = this.Pausebtn;
            this.Pausebtn.Size = new System.Drawing.Size(65, 62);
            this.Pausebtn.TabIndex = 45;
            this.Pausebtn.TextOffset = new System.Drawing.Point(15, 0);
            this.Pausebtn.UseTransparentBackground = true;
            this.Pausebtn.Visible = false;
            this.Pausebtn.Click += new System.EventHandler(this.Pausebtn_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.TargetControl = null;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            // 
            // btnFavorite_Pressed
            // 
            this.btnFavorite_Pressed.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnFavorite_Pressed.BackColor = System.Drawing.Color.Transparent;
            this.btnFavorite_Pressed.CheckedState.Parent = this.btnFavorite_Pressed;
            this.btnFavorite_Pressed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFavorite_Pressed.CustomImages.Image = global::NIMBUS__MUSIC_PLAYER_.Properties.Resources.Favorite;
            this.btnFavorite_Pressed.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFavorite_Pressed.CustomImages.Parent = this.btnFavorite_Pressed;
            this.btnFavorite_Pressed.FillColor = System.Drawing.Color.Empty;
            this.btnFavorite_Pressed.FillColor2 = System.Drawing.Color.Empty;
            this.btnFavorite_Pressed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFavorite_Pressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(50)))), ((int)(((byte)(53)))));
            this.btnFavorite_Pressed.HoverState.Parent = this.btnFavorite_Pressed;
            this.btnFavorite_Pressed.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnFavorite_Pressed.Location = new System.Drawing.Point(283, 254);
            this.btnFavorite_Pressed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFavorite_Pressed.Name = "btnFavorite_Pressed";
            this.btnFavorite_Pressed.PressedColor = System.Drawing.Color.Transparent;
            this.btnFavorite_Pressed.ShadowDecoration.Parent = this.btnFavorite_Pressed;
            this.btnFavorite_Pressed.Size = new System.Drawing.Size(33, 32);
            this.btnFavorite_Pressed.TabIndex = 47;
            this.btnFavorite_Pressed.TextOffset = new System.Drawing.Point(15, 0);
            this.btnFavorite_Pressed.Click += new System.EventHandler(this.btnFavorite_Pressed_Click);
            // 
            // btnFavorite_Default
            // 
            this.btnFavorite_Default.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnFavorite_Default.BackColor = System.Drawing.Color.Transparent;
            this.btnFavorite_Default.CheckedState.Parent = this.btnFavorite_Default;
            this.btnFavorite_Default.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFavorite_Default.CustomImages.Image = global::NIMBUS__MUSIC_PLAYER_.Properties.Resources.Icon_Favorites;
            this.btnFavorite_Default.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFavorite_Default.CustomImages.Parent = this.btnFavorite_Default;
            this.btnFavorite_Default.FillColor = System.Drawing.Color.Empty;
            this.btnFavorite_Default.FillColor2 = System.Drawing.Color.Empty;
            this.btnFavorite_Default.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFavorite_Default.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(50)))), ((int)(((byte)(53)))));
            this.btnFavorite_Default.HoverState.Parent = this.btnFavorite_Default;
            this.btnFavorite_Default.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnFavorite_Default.Location = new System.Drawing.Point(284, 254);
            this.btnFavorite_Default.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFavorite_Default.Name = "btnFavorite_Default";
            this.btnFavorite_Default.PressedColor = System.Drawing.Color.Transparent;
            this.btnFavorite_Default.ShadowDecoration.Parent = this.btnFavorite_Default;
            this.btnFavorite_Default.Size = new System.Drawing.Size(33, 32);
            this.btnFavorite_Default.TabIndex = 46;
            this.btnFavorite_Default.TextOffset = new System.Drawing.Point(15, 0);
            this.btnFavorite_Default.Click += new System.EventHandler(this.btnFavorite_Default_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.TitleSonglbl);
            this.panel2.Controls.Add(this.Artistlbl);
            this.panel2.Location = new System.Drawing.Point(80, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 76);
            this.panel2.TabIndex = 48;
            // 
            // NimbusMiniplayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::NIMBUS__MUSIC_PLAYER_.Properties.Resources.MIni_Player_BlackBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(347, 308);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnFavorite_Pressed);
            this.Controls.Add(this.btnFavorite_Default);
            this.Controls.Add(this.Pausebtn);
            this.Controls.Add(this.Playbtn);
            this.Controls.Add(this.lblVolumePercent);
            this.Controls.Add(this.Switchtomain);
            this.Controls.Add(this.CloseMiniplayer);
            this.Controls.Add(this.SongTimePanel);
            this.Controls.Add(this.VolumeBar);
            this.Controls.Add(this.SoundIcon);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox5);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NimbusMiniplayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NimbusMiniplayer";
            ((System.ComponentModel.ISupportInitialize)(this.CloseMiniplayer)).EndInit();
            this.SongTimePanel.ResumeLayout(false);
            this.SongTimePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SoundIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Switchtomain)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CloseMiniplayer;
        private System.Windows.Forms.Label Artistlbl;
        private System.Windows.Forms.Label TitleSonglbl;
        private System.Windows.Forms.Panel SongTimePanel;
        private System.Windows.Forms.Label EndTime;
        private System.Windows.Forms.Label TimePlayed;
        private Guna.UI2.WinForms.Guna2ProgressBar TimeSong;
        private Guna.UI2.WinForms.Guna2TrackBar VolumeBar;
        private System.Windows.Forms.PictureBox SoundIcon;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox5;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.PictureBox Switchtomain;
        private System.Windows.Forms.Label lblVolumePercent;
        private Guna.UI2.WinForms.Guna2GradientButton Playbtn;
        private Guna.UI2.WinForms.Guna2GradientButton Pausebtn;
        public System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        public System.Windows.Forms.Timer timer2;
        private Guna.UI2.WinForms.Guna2GradientButton btnFavorite_Pressed;
        private Guna.UI2.WinForms.Guna2GradientButton btnFavorite_Default;
        private System.Windows.Forms.Panel panel2;
    }
}