using System;
using System.Collections.Generic;
using System.Text;

namespace lab_7_interface_3
{
    interface RadioPlayerInterface
    {
        void Switch(bool on);
        void retune(double frequency);
        void setVolume(int loudness);
        void changeChannel();
    }
}
