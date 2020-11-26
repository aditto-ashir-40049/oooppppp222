using System;
using System.Collections.Generic;
using System.Text;

namespace lab_7_interface_3
{
    interface MusicPlayerInterface
    {
        void Switch(bool on);
        void play(bool on);
        void setVolume(int loudness);
        void playNext();
        void playPrevious();
    }
}
