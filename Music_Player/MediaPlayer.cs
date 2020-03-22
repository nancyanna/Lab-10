using System;
using System.Collections.Generic;
using System.Text;

namespace Music_Player
{
    class MediaPlayer
    {
        public void PlayMedia(IAudioPlayer media)
        {
            media.Play();

        }

    }
}
