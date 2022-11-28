using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public static class AudioHandler
    {
        static Dictionary<string, SoundPlayer> Audio = new Dictionary<string, SoundPlayer>()
        {
            { "card", new SoundPlayer("Audio/Card.wav") }
        };

        public static void PlayAudio(string key)
        {
            return;
            Audio[key].Play();
        }
    }
}
