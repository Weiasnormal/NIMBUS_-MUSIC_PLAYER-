﻿namespace NIMBUS__MUSIC_PLAYER_
{
    partial class ArtistPlaceholder
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
            this.TitleSonglbl = new System.Windows.Forms.Label();
            this.ArtistPhoto = new System.Windows.Forms.PictureBox();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.ArtistPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleSonglbl
            // 
            this.TitleSonglbl.AutoSize = true;
            this.TitleSonglbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleSonglbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TitleSonglbl.Location = new System.Drawing.Point(-5, 225);
            this.TitleSonglbl.Name = "TitleSonglbl";
            this.TitleSonglbl.Size = new System.Drawing.Size(173, 26);
            this.TitleSonglbl.TabIndex = 14;
            this.TitleSonglbl.Text = "Unknown Artist";
            this.TitleSonglbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ArtistPhoto
            // 
            this.ArtistPhoto.Image = global::NIMBUS__MUSIC_PLAYER_.Properties.Resources.Default_Album;
            this.ArtistPhoto.Location = new System.Drawing.Point(0, 0);
            this.ArtistPhoto.Name = "ArtistPhoto";
            this.ArtistPhoto.Size = new System.Drawing.Size(220, 220);
            this.ArtistPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ArtistPhoto.TabIndex = 19;
            this.ArtistPhoto.TabStop = false;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 55);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(220, 165);
            this.guna2GradientPanel1.TabIndex = 20;
            this.guna2GradientPanel1.UseTransparentBackground = true;
            // 
            // guna2GradientButton2
            // 
            this.guna2GradientButton2.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton2.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.guna2GradientButton2.CheckedState.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.CustomImages.CheckedImage = global::NIMBUS__MUSIC_PLAYER_.Properties.Resources.Icon_Pause;
            this.guna2GradientButton2.CustomImages.Image = global::NIMBUS__MUSIC_PLAYER_.Properties.Resources.Icon_Play;
            this.guna2GradientButton2.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2GradientButton2.CustomImages.ImageOffset = new System.Drawing.Point(0, -5);
            this.guna2GradientButton2.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2GradientButton2.CustomImages.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.FillColor = System.Drawing.Color.Empty;
            this.guna2GradientButton2.FillColor2 = System.Drawing.Color.Empty;
            this.guna2GradientButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(50)))), ((int)(((byte)(53)))));
            this.guna2GradientButton2.HoverState.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton2.Location = new System.Drawing.Point(150, 161);
            this.guna2GradientButton2.Name = "guna2GradientButton2";
            this.guna2GradientButton2.PressedColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton2.ShadowDecoration.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.Size = new System.Drawing.Size(67, 57);
            this.guna2GradientButton2.TabIndex = 25;
            this.guna2GradientButton2.TextOffset = new System.Drawing.Point(15, 0);
            this.guna2GradientButton2.UseTransparentBackground = true;
            this.guna2GradientButton2.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // ArtistPlaceholder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2GradientButton2);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.ArtistPhoto);
            this.Controls.Add(this.TitleSonglbl);
            this.Name = "ArtistPlaceholder";
            this.Size = new System.Drawing.Size(221, 285);
            ((System.ComponentModel.ISupportInitialize)(this.ArtistPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TitleSonglbl;
        private System.Windows.Forms.PictureBox ArtistPhoto;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
    }
}
