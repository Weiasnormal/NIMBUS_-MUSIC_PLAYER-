﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIMBUS__MUSIC_PLAYER_.Helper
{
    public class Events
    {
        public static Action<object,EventArgs> AddToQueue;
        public static Action AddToFavorites;
        public static Action UpdateMainUI;
        public static Action LoadSongs;
    }
}
