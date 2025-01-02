using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace NIMBUS__MUSIC_PLAYER_.Helper
{
    public static class PlayerState
    {
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

        #region Current Playing
        /*public static WindowsMediaPlayer player { get; private set; } = new WindowsMediaPlayer();*/
        public static WindowsMediaPlayer player = new WindowsMediaPlayer();
        public static string currentSongPath = string.Empty; // To keep track of the current song path

        #endregion

        #region Player Volume
        public static void SetVolume(int volume)
        {
            player.settings.volume = volume; // Range: 0-100
        }
        #endregion
    }
}
