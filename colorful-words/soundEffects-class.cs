using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Media;
using WMPLib;


namespace Colorful_Words
{
    class soundEffects_class
    {
        private string getSoundEffectLocation(string effectName)
        {
            int locationLength = Directory.GetCurrentDirectory().Length - 9;
            string fileLocation = Directory.GetCurrentDirectory().Substring(0, locationLength);
            return fileLocation += $@"Resources\{effectName}-sound-effect.mp3";
        }

        public void playSoundEffectForRadioButtons(string rdB)
        {
                WindowsMediaPlayer player = new WindowsMediaPlayer();
                player.URL = getSoundEffectLocation(rdB);
                player.controls.play();
        }

        public void playSoundEffect(bool isGameOver)
        {
                WindowsMediaPlayer player = new WindowsMediaPlayer();
                if (isGameOver) player.URL = getSoundEffectLocation("wrong");
                else player.URL = getSoundEffectLocation("right");
                player.controls.play();
        }
    }
}
