﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLocatorPattern.AudioPlayerFactory
{
    public class LibVlcPlaybackService : IPlaybackService
    {
        public void PlayFile(string filePath)
        {
            Console.WriteLine("LibVlc is being used to play {0}", filePath);
        }
    }
}
