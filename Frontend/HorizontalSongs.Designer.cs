namespace NIMBUS__MUSIC_PLAYER_
{
    partial class HorizontalSongs
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
            this.SongNum = new System.Windows.Forms.Label();
            this.Titlelbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SongArtistlbl = new System.Windows.Forms.Label();
            this.SongTitlelbl = new System.Windows.Forms.Label();
            this.TotalTime = new System.Windows.Forms.Label();
            this.Background = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Songpic = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Songpic)).BeginInit();
            this.SuspendLayout();
            // 
            // SongNum
            // 
            this.SongNum.AutoSize = true;
            this.SongNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SongNum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SongNum.Location = new System.Drawing.Point(13, 10);
            this.SongNum.Name = "SongNum";
            this.SongNum.Size = new System.Drawing.Size(24, 25);
            this.SongNum.TabIndex = 0;
            this.SongNum.Text = "1";
            // 
            // Titlelbl
            // 
            this.Titlelbl.AutoSize = true;
            this.Titlelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlelbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Titlelbl.Location = new System.Drawing.Point(89, 14);
            this.Titlelbl.Name = "Titlelbl";
            this.Titlelbl.Size = new System.Drawing.Size(78, 22);
            this.Titlelbl.TabIndex = 1;
            this.Titlelbl.Text = "Havana";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Songpic);
            this.panel1.Controls.Add(this.Titlelbl);
            this.panel1.Location = new System.Drawing.Point(77, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 50);
            this.panel1.TabIndex = 2;
            // 
            // SongArtistlbl
            // 
            this.SongArtistlbl.AutoSize = true;
            this.SongArtistlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SongArtistlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SongArtistlbl.Location = new System.Drawing.Point(519, 14);
            this.SongArtistlbl.Name = "SongArtistlbl";
            this.SongArtistlbl.Size = new System.Drawing.Size(145, 22);
            this.SongArtistlbl.TabIndex = 3;
            this.SongArtistlbl.Text = "Camila Cabello";
            // 
            // SongTitlelbl
            // 
            this.SongTitlelbl.AutoSize = true;
            this.SongTitlelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SongTitlelbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SongTitlelbl.Location = new System.Drawing.Point(919, 13);
            this.SongTitlelbl.Name = "SongTitlelbl";
            this.SongTitlelbl.Size = new System.Drawing.Size(78, 22);
            this.SongTitlelbl.TabIndex = 4;
            this.SongTitlelbl.Text = "Havana";
            // 
            // TotalTime
            // 
            this.TotalTime.AutoSize = true;
            this.TotalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TotalTime.Location = new System.Drawing.Point(1312, 14);
            this.TotalTime.Name = "TotalTime";
            this.TotalTime.Size = new System.Drawing.Size(49, 22);
            this.TotalTime.TabIndex = 5;
            this.TotalTime.Text = "3:30";
            // 
            // Background
            // 
            this.Background.CheckedState.Parent = this.Background;
            this.Background.HoverState.Image = global::NIMBUS__MUSIC_PLAYER_.Properties.Resources.Rectangle_169;
            this.Background.HoverState.ImageSize = new System.Drawing.Size(1494, 54);
            this.Background.HoverState.Parent = this.Background;
            this.Background.Location = new System.Drawing.Point(-1, -1);
            this.Background.Name = "Background";
            this.Background.PressedState.Parent = this.Background;
            this.Background.Size = new System.Drawing.Size(1495, 51);
            this.Background.TabIndex = 6;
            // 
            // Songpic
            // 
            this.Songpic.Image = global::NIMBUS__MUSIC_PLAYER_.Properties.Resources.image_171;
            this.Songpic.Location = new System.Drawing.Point(17, 4);
            this.Songpic.Name = "Songpic";
            this.Songpic.Size = new System.Drawing.Size(42, 42);
            this.Songpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Songpic.TabIndex = 2;
            this.Songpic.TabStop = false;
            // 
            // HorizontalSongs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.TotalTime);
            this.Controls.Add(this.SongTitlelbl);
            this.Controls.Add(this.SongArtistlbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SongNum);
            this.Controls.Add(this.Background);
            this.Name = "HorizontalSongs";
            this.Size = new System.Drawing.Size(1493, 49);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Songpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SongNum;
        private System.Windows.Forms.Label Titlelbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Songpic;
        private System.Windows.Forms.Label SongArtistlbl;
        private System.Windows.Forms.Label SongTitlelbl;
        private System.Windows.Forms.Label TotalTime;
        private Guna.UI2.WinForms.Guna2ImageButton Background;
    }
}
