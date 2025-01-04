namespace NIMBUS__MUSIC_PLAYER_
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
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.guna2GradientButton3 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Switchtomain = new System.Windows.Forms.PictureBox();
            this.lblVolumePercent = new System.Windows.Forms.Label();
            this.Playbtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Pausebtn = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.CloseMiniplayer)).BeginInit();
            this.SongTimePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SoundIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Switchtomain)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseMiniplayer
            // 
            this.CloseMiniplayer.BackColor = System.Drawing.Color.Transparent;
            this.CloseMiniplayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseMiniplayer.Image = global::NIMBUS__MUSIC_PLAYER_.Properties.Resources.Group__4_;
            this.CloseMiniplayer.Location = new System.Drawing.Point(300, 12);
            this.CloseMiniplayer.Name = "CloseMiniplayer";
            this.CloseMiniplayer.Size = new System.Drawing.Size(34, 26);
            this.CloseMiniplayer.TabIndex = 41;
            this.CloseMiniplayer.TabStop = false;
            this.CloseMiniplayer.Click += new System.EventHandler(this.CloseMiniplayer_Click);
            // 
            // Artistlbl
            // 
            this.Artistlbl.AutoSize = true;
            this.Artistlbl.BackColor = System.Drawing.Color.Transparent;
            this.Artistlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Artistlbl.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Artistlbl.Location = new System.Drawing.Point(111, 59);
            this.Artistlbl.Name = "Artistlbl";
            this.Artistlbl.Size = new System.Drawing.Size(111, 18);
            this.Artistlbl.TabIndex = 40;
            this.Artistlbl.Text = "Camilla Cabello";
            this.Artistlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TitleSonglbl
            // 
            this.TitleSonglbl.AutoSize = true;
            this.TitleSonglbl.BackColor = System.Drawing.Color.Transparent;
            this.TitleSonglbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleSonglbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TitleSonglbl.Location = new System.Drawing.Point(109, 30);
            this.TitleSonglbl.Name = "TitleSonglbl";
            this.TitleSonglbl.Size = new System.Drawing.Size(114, 29);
            this.TitleSonglbl.TabIndex = 39;
            this.TitleSonglbl.Text = "HAVANA";
            this.TitleSonglbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SongTimePanel
            // 
            this.SongTimePanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SongTimePanel.BackColor = System.Drawing.Color.Transparent;
            this.SongTimePanel.Controls.Add(this.EndTime);
            this.SongTimePanel.Controls.Add(this.TimePlayed);
            this.SongTimePanel.Controls.Add(this.TimeSong);
            this.SongTimePanel.Location = new System.Drawing.Point(29, 112);
            this.SongTimePanel.Name = "SongTimePanel";
            this.SongTimePanel.Size = new System.Drawing.Size(288, 44);
            this.SongTimePanel.TabIndex = 38;
            // 
            // EndTime
            // 
            this.EndTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EndTime.AutoSize = true;
            this.EndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EndTime.Location = new System.Drawing.Point(241, 23);
            this.EndTime.Name = "EndTime";
            this.EndTime.Size = new System.Drawing.Size(31, 16);
            this.EndTime.TabIndex = 9;
            this.EndTime.Text = "3:39";
            // 
            // TimePlayed
            // 
            this.TimePlayed.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TimePlayed.AutoSize = true;
            this.TimePlayed.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimePlayed.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TimePlayed.Location = new System.Drawing.Point(15, 23);
            this.TimePlayed.Name = "TimePlayed";
            this.TimePlayed.Size = new System.Drawing.Size(31, 16);
            this.TimePlayed.TabIndex = 8;
            this.TimePlayed.Text = "0:00";
            // 
            // TimeSong
            // 
            this.TimeSong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TimeSong.BackColor = System.Drawing.Color.DimGray;
            this.TimeSong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TimeSong.FillColor = System.Drawing.Color.White;
            this.TimeSong.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.TimeSong.Location = new System.Drawing.Point(18, 8);
            this.TimeSong.Name = "TimeSong";
            this.TimeSong.ProgressColor = System.Drawing.Color.White;
            this.TimeSong.ShadowDecoration.Parent = this.TimeSong;
            this.TimeSong.Size = new System.Drawing.Size(254, 3);
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
            this.SoundIcon.Location = new System.Drawing.Point(30, 253);
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
            this.pictureBox8.Location = new System.Drawing.Point(229, 191);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(20, 20);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox8.TabIndex = 34;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = global::NIMBUS__MUSIC_PLAYER_.Properties.Resources.Vector__5_;
            this.pictureBox6.Location = new System.Drawing.Point(295, 191);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(20, 20);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 35;
            this.pictureBox6.TabStop = false;
            // 
            // guna2GradientButton3
            // 
            this.guna2GradientButton3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.guna2GradientButton3.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton3.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.guna2GradientButton3.CheckedState.Parent = this.guna2GradientButton3;
            this.guna2GradientButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2GradientButton3.CustomImages.CheckedImage = global::NIMBUS__MUSIC_PLAYER_.Properties.Resources.Favorite;
            this.guna2GradientButton3.CustomImages.Image = global::NIMBUS__MUSIC_PLAYER_.Properties.Resources.Icon_Favorites;
            this.guna2GradientButton3.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2GradientButton3.CustomImages.Parent = this.guna2GradientButton3;
            this.guna2GradientButton3.FillColor = System.Drawing.Color.Empty;
            this.guna2GradientButton3.FillColor2 = System.Drawing.Color.Empty;
            this.guna2GradientButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(50)))), ((int)(((byte)(53)))));
            this.guna2GradientButton3.HoverState.Parent = this.guna2GradientButton3;
            this.guna2GradientButton3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton3.Location = new System.Drawing.Point(289, 249);
            this.guna2GradientButton3.Name = "guna2GradientButton3";
            this.guna2GradientButton3.PressedColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton3.ShadowDecoration.Parent = this.guna2GradientButton3;
            this.guna2GradientButton3.Size = new System.Drawing.Size(33, 32);
            this.guna2GradientButton3.TabIndex = 33;
            this.guna2GradientButton3.TextOffset = new System.Drawing.Point(15, 0);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::NIMBUS__MUSIC_PLAYER_.Properties.Resources.Vector__4_;
            this.pictureBox5.Location = new System.Drawing.Point(90, 191);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(20, 20);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 30;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox7.Image = global::NIMBUS__MUSIC_PLAYER_.Properties.Resources.Group__2_;
            this.pictureBox7.Location = new System.Drawing.Point(27, 187);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(28, 28);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox7.TabIndex = 31;
            this.pictureBox7.TabStop = false;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // Switchtomain
            // 
            this.Switchtomain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Switchtomain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Switchtomain.Image = global::NIMBUS__MUSIC_PLAYER_.Properties.Resources.Icon_Resize;
            this.Switchtomain.Location = new System.Drawing.Point(274, 14);
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
            this.lblVolumePercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolumePercent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblVolumePercent.Location = new System.Drawing.Point(30, 234);
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
            this.Playbtn.Location = new System.Drawing.Point(138, 173);
            this.Playbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Playbtn.Name = "Playbtn";
            this.Playbtn.PressedColor = System.Drawing.Color.Transparent;
            this.Playbtn.ShadowDecoration.Parent = this.Playbtn;
            this.Playbtn.Size = new System.Drawing.Size(65, 62);
            this.Playbtn.TabIndex = 44;
            this.Playbtn.TextOffset = new System.Drawing.Point(15, 0);
            this.Playbtn.UseTransparentBackground = true;
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
            this.Pausebtn.Location = new System.Drawing.Point(138, 173);
            this.Pausebtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pausebtn.Name = "Pausebtn";
            this.Pausebtn.PressedColor = System.Drawing.Color.Transparent;
            this.Pausebtn.ShadowDecoration.Parent = this.Pausebtn;
            this.Pausebtn.Size = new System.Drawing.Size(65, 62);
            this.Pausebtn.TabIndex = 45;
            this.Pausebtn.TextOffset = new System.Drawing.Point(15, 0);
            this.Pausebtn.UseTransparentBackground = true;
            // 
            // NimbusMiniplayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::NIMBUS__MUSIC_PLAYER_.Properties.Resources.MIni_Player_BlackBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(346, 308);
            this.Controls.Add(this.Pausebtn);
            this.Controls.Add(this.Playbtn);
            this.Controls.Add(this.lblVolumePercent);
            this.Controls.Add(this.Switchtomain);
            this.Controls.Add(this.CloseMiniplayer);
            this.Controls.Add(this.Artistlbl);
            this.Controls.Add(this.TitleSonglbl);
            this.Controls.Add(this.SongTimePanel);
            this.Controls.Add(this.VolumeBar);
            this.Controls.Add(this.SoundIcon);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.guna2GradientButton3);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox7);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NimbusMiniplayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NimbusMiniplayer";
            ((System.ComponentModel.ISupportInitialize)(this.CloseMiniplayer)).EndInit();
            this.SongTimePanel.ResumeLayout(false);
            this.SongTimePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SoundIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Switchtomain)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox6;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox7;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.PictureBox Switchtomain;
        private System.Windows.Forms.Label lblVolumePercent;
        private Guna.UI2.WinForms.Guna2GradientButton Playbtn;
        private Guna.UI2.WinForms.Guna2GradientButton Pausebtn;
    }
}