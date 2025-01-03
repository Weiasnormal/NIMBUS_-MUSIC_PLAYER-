using NimbusClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace NIMBUS__MUSIC_PLAYER_.Helper
{
    public static class PlayerState
    {
        public static LinkedListNode<Song> CurrentSong
        {
            get 
            {
                return NimbusClassLibrary.Helpers.GlobalLibraries.Playing_Song.First;
            }
        }

        private static BackgroundWorker _backgroundWorker;

        public static BackgroundWorker BackgroundWorker
        {
            get 
            {
                if (_backgroundWorker == null)
                {
                    _backgroundWorker = new BackgroundWorker();

                    _backgroundWorker.DoWork += _backgroundWorker_DoWork;
                    _backgroundWorker.RunWorkerCompleted += _backgroundWorker_RunWorkerCompleted;
                    _backgroundWorker.WorkerSupportsCancellation = true;
                }
                    
                return _backgroundWorker;
            }
            set { _backgroundWorker = value; }
        }

        private static void _backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            SetNextSong();

            _backgroundWorker.RunWorkerAsync();
        }

        private static void _backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            if(NimbusClassLibrary.Helpers.GlobalLibraries.Playing_Song.Count > 1) 
                Task.Run(()=>PlaySong(CurrentSong.Value));

            while (player.playState != WMPPlayState.wmppsStopped &&
                       player.playState != WMPPlayState.wmppsReady)
            {
                Thread.Sleep(100);
            }
        }

        private static bool _isPlaying;

        public static bool IsPlaying
        {
            get => _isPlaying;
            set
            {
                if (_isPlaying != value)
                {
                    _isPlaying = value;
                    OnStateChanged?.Invoke(_isPlaying);
                }
            }
        }

        public static event Action<bool> OnStateChanged;

        // Method to force the Play state
        public static void ForcePlayState()
        {
            IsPlaying = false; // Set to false, then set to true to ensure proper notification
            IsPlaying = true;
        }

        #region Player
        /*public static WindowsMediaPlayer player { get; private set; } = new WindowsMediaPlayer();*/
        private static WindowsMediaPlayer _player;

        public static WindowsMediaPlayer player
        {
            get 
            {
                if (_player == null)
                    _player = new WindowsMediaPlayer();
                return _player;
            }
            private set { _player = value; }
        }

        public static void SetNextSong()
        { 
            NimbusClassLibrary.Helpers.GlobalLibraries.Previous_Songs.Push(CurrentSong.Value);
            NimbusClassLibrary.Helpers.GlobalLibraries.Playing_Song.RemoveFirst();
        }

        public static void StopSong()
        {
            if (player.playState != WMPPlayState.wmppsStopped)
            {
                player.controls.stop();
            }
            BackgroundWorker.CancelAsync();
        }

        public static async Task PlaySong(Song playsong)
        {

            if (FileExists(playsong.File_Path))
            {
                // Play the audio asynchronously, ensuring it's on the UI thread
                await Task.Run(() =>
                {
                    // Set the player's URL to the new file path
                    player.URL = playsong.File_Path;

                    // Start playback
                    player.controls.play();

                    // Update the playing state
                    IsPlaying = true;
                });
            }
            else
            {
                MessageBox.Show("File not found: " + playsong.File_Path, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Player Volume
        public static void SetVolume(int volume)
        {
            _player.settings.volume = volume; // Range: 0-100
        }
        #endregion

        private static bool FileExists(string filePath)
        {
            return System.IO.File.Exists(filePath);
        }
    }
}
