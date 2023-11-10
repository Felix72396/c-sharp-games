using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Media;
using WMPLib;


namespace Mine_Seeker
{
    class soundEffects_class
    {
        private string get_sound_effect_location_function(string soundName)
        {
            int locationLength = Directory.GetCurrentDirectory().Length - 9;
            string fileLocation = Directory.GetCurrentDirectory().Substring(0, locationLength);
            return fileLocation += $@"Resources\{soundName}-sound-effect.mp3";
        }

        public void play_sound_effect_method(string sound_file_name)
        {
                WindowsMediaPlayer player = new WindowsMediaPlayer();
                player.URL = get_sound_effect_location_function(sound_file_name);
                player.controls.play();
        }

        public void play_sound_effect_when_winning_or_losing_method(bool isGameOver)
        {
                WindowsMediaPlayer player = new WindowsMediaPlayer();
                player.URL =(isGameOver==true)? get_sound_effect_location_function("wrong"): get_sound_effect_location_function("claps");

                player.controls.play();
        }
    }
}
