using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Media;
using WMPLib;


namespace Patterns_Game
{
    class soundEffects_class
    {
        private string getSoundEffectLocation(string soundName)
        {
            int locationLength = Directory.GetCurrentDirectory().Length - 9;
            string fileLocation = Directory.GetCurrentDirectory().Substring(0, locationLength);
            return fileLocation += $@"Resources\{soundName}-sound-effect.mp3";
        }

        public void playSoundEffect(string soundName)
        {
                WindowsMediaPlayer player = new WindowsMediaPlayer();
                player.URL = getSoundEffectLocation(soundName);
                player.controls.play();
        }

        public void playSoundEffectWhenWinningOrLosing(bool isGameOver)
        {
                WindowsMediaPlayer player = new WindowsMediaPlayer();
                if (isGameOver) player.URL = getSoundEffectLocation("wrong");
                else player.URL = getSoundEffectLocation("right");
                player.controls.play();
        }
    }
}
