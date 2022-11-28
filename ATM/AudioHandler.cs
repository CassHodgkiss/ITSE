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
            { "insert_pin",       new SoundPlayer("Audio/audio_2.wav")  },
            { "pin_incorrect",    new SoundPlayer("Audio/audio_3.wav")  },
            { "pin_failed",       new SoundPlayer("Audio/audio_4.wav")  },
            { "main_options",     new SoundPlayer("Audio/audio_5.wav")  },
            { "account",          new SoundPlayer("Audio/audio_6.wav")  },
            { "statement",        new SoundPlayer("Audio/audio_7.wav")  },
            { "withdraw",         new SoundPlayer("Audio/audio_8.wav")  },
            { "withdraw_success", new SoundPlayer("Audio/audio_9.wav")  },
            { "withdraw_failed",  new SoundPlayer("Audio/audio_10.wav") },
            { "withdraw_amount",  new SoundPlayer("Audio/audio_11.wav") },
            { "withdraw_0",       new SoundPlayer("Audio/audio_12.wav") },
            { "deposit",          new SoundPlayer("Audio/audio_13.wav") },
            { "deposit_success",  new SoundPlayer("Audio/audio_14.wav") },
            { "transfer_id",      new SoundPlayer("Audio/audio_15.wav") },
            { "transfer_amount",  new SoundPlayer("Audio/audio_16.wav") },
            { "transfer_same",    new SoundPlayer("Audio/audio_17.wav") },
            { "transfer_0",       new SoundPlayer("Audio/audio_18.wav") },
            { "transfer_success", new SoundPlayer("Audio/audio_19.wav") },
            { "transfer_failed",  new SoundPlayer("Audio/audio_20.wav") },
            { "ejecting_card",    new SoundPlayer("Audio/audio_21.wav") }
        };

        public static void PlayAudio(string key)
        {
            Audio[key].Play();
        }
    }
}
