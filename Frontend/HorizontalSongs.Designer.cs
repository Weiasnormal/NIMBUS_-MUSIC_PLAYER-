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
            this.SongNumlbl = new System.Windows.Forms.Label();
            this.Titlelbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Songpic = new System.Windows.Forms.PictureBox();
            this.Artistlbl = new System.Windows.Forms.Label();
            this.Albumlbl = new System.Windows.Forms.Label();
            this.TotalTimelbl = new System.Windows.Forms.Label();
            this.Menubtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Songpic)).BeginInit();
            this.SuspendLayout();
            // 
            // SongNumlbl
            // 
            this.SongNumlbl.AutoSize = true;
            this.SongNumlbl.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SongNumlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SongNumlbl.Location = new System.Drawing.Point(17, 17);
            this.SongNumlbl.Name = "SongNumlbl";
            this.SongNumlbl.Size = new System.Drawing.Size(19, 25);
            this.SongNumlbl.TabIndex = 0;
            this.SongNumlbl.Text = "1";
            // 
            // Titlelbl
            // 
            this.Titlelbl.AutoSize = true;
            this.Titlelbl.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlelbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Titlelbl.Location = new System.Drawing.Point(89, 14);
            this.Titlelbl.Name = "Titlelbl";
            this.Titlelbl.Size = new System.Drawing.Size(68, 21);
            this.Titlelbl.TabIndex = 1;
            this.Titlelbl.Text = "Havana";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Songpic);
            this.panel1.Controls.Add(this.Titlelbl);
            this.panel1.Location = new System.Drawing.Point(76, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 50);
            this.panel1.TabIndex = 2;
            // 
            // Songpic
            // 
            this.Songpic.Image = global::NIMBUS__MUSIC_PLAYER_.Properties.Resources.Default_Album;
            this.Songpic.Location = new System.Drawing.Point(3, 3);
            this.Songpic.Name = "Songpic";
            this.Songpic.Size = new System.Drawing.Size(42, 42);
            this.Songpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Songpic.TabIndex = 2;
            this.Songpic.TabStop = false;
            // 
            // Artistlbl
            // 
            this.Artistlbl.AutoSize = true;
            this.Artistlbl.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Artistlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Artistlbl.Location = new System.Drawing.Point(347, 17);
            this.Artistlbl.Name = "Artistlbl";
            this.Artistlbl.Size = new System.Drawing.Size(128, 21);
            this.Artistlbl.TabIndex = 3;
            this.Artistlbl.Text = "Camila Cabello";
            // 
            // Albumlbl
            // 
            this.Albumlbl.AutoSize = true;
            this.Albumlbl.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Albumlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Albumlbl.Location = new System.Drawing.Point(661, 17);
            this.Albumlbl.Name = "Albumlbl";
            this.Albumlbl.Size = new System.Drawing.Size(71, 21);
            this.Albumlbl.TabIndex = 4;
            this.Albumlbl.Text = "No Title";
            // 
            // TotalTimelbl
            // 
            this.TotalTimelbl.AutoSize = true;
            this.TotalTimelbl.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTimelbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TotalTimelbl.Location = new System.Drawing.Point(984, 17);
            this.TotalTimelbl.Name = "TotalTimelbl";
            this.TotalTimelbl.Size = new System.Drawing.Size(42, 21);
            this.TotalTimelbl.TabIndex = 5;
            this.TotalTimelbl.Text = "3:30";
            // 
            // Menubtn
            // 
            this.Menubtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Menubtn.CheckedState.Parent = this.Menubtn;
            this.Menubtn.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.Menubtn.HoverState.Parent = this.Menubtn;
            this.Menubtn.Image = global::NIMBUS__MUSIC_PLAYER_.Properties.Resources.Menu;
            this.Menubtn.ImageSize = new System.Drawing.Size(25, 25);
            this.Menubtn.Location = new System.Drawing.Point(1091, 14);
            this.Menubtn.Name = "Menubtn";
            this.Menubtn.PressedState.Parent = this.Menubtn;
            this.Menubtn.Size = new System.Drawing.Size(51, 33);
            this.Menubtn.TabIndex = 30;
            // 
            // HorizontalSongs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Menubtn);
            this.Controls.Add(this.TotalTimelbl);
            this.Controls.Add(this.Albumlbl);
            this.Controls.Add(this.Artistlbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SongNumlbl);
            this.Name = "HorizontalSongs";
            this.Size = new System.Drawing.Size(1162, 59);
            this.DoubleClick += new System.EventHandler(this.HorizontalSongs_DoubleClick);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Songpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SongNumlbl;
        private System.Windows.Forms.Label Titlelbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Songpic;
        private System.Windows.Forms.Label Artistlbl;
        private System.Windows.Forms.Label Albumlbl;
        private System.Windows.Forms.Label TotalTimelbl;
        private Guna.UI2.WinForms.Guna2ImageButton Menubtn;
    }
}
