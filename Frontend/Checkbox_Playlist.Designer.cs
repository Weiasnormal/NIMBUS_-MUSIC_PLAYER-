namespace NIMBUS__MUSIC_PLAYER_
{
    partial class Checkbox_Playlist
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
            this.Playlistlbl = new System.Windows.Forms.Label();
            this.NoSongslbl = new System.Windows.Forms.Label();
            this.AddtoMixlbl = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Playlistlbl
            // 
            this.Playlistlbl.AutoSize = true;
            this.Playlistlbl.BackColor = System.Drawing.Color.Transparent;
            this.Playlistlbl.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Playlistlbl.ForeColor = System.Drawing.Color.Transparent;
            this.Playlistlbl.Location = new System.Drawing.Point(2, 2);
            this.Playlistlbl.Name = "Playlistlbl";
            this.Playlistlbl.Size = new System.Drawing.Size(100, 25);
            this.Playlistlbl.TabIndex = 0;
            this.Playlistlbl.Text = "Favorites";
            // 
            // NoSongslbl
            // 
            this.NoSongslbl.AutoSize = true;
            this.NoSongslbl.BackColor = System.Drawing.Color.Transparent;
            this.NoSongslbl.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoSongslbl.ForeColor = System.Drawing.Color.Silver;
            this.NoSongslbl.Location = new System.Drawing.Point(4, 30);
            this.NoSongslbl.Name = "NoSongslbl";
            this.NoSongslbl.Size = new System.Drawing.Size(69, 18);
            this.NoSongslbl.TabIndex = 1;
            this.NoSongslbl.Text = "52 songs";
            // 
            // AddtoMixlbl
            // 
            this.AddtoMixlbl.AutoSize = true;
            this.AddtoMixlbl.Location = new System.Drawing.Point(281, 20);
            this.AddtoMixlbl.Name = "AddtoMixlbl";
            this.AddtoMixlbl.Size = new System.Drawing.Size(18, 17);
            this.AddtoMixlbl.TabIndex = 2;
            this.AddtoMixlbl.UseVisualStyleBackColor = true;
            // 
            // Checkbox_Playlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.AddtoMixlbl);
            this.Controls.Add(this.NoSongslbl);
            this.Controls.Add(this.Playlistlbl);
            this.Name = "Checkbox_Playlist";
            this.Size = new System.Drawing.Size(323, 57);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Playlistlbl;
        private System.Windows.Forms.Label NoSongslbl;
        private System.Windows.Forms.CheckBox AddtoMixlbl;
    }
}
