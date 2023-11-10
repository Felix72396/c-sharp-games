using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Simon_Numbers
{
    class logic_class
    {
        Dictionary <int, int> numberListDictionary;
        public logic_class(){
            numberListDictionary = new Dictionary<int, int>();
            key = 0;
        }

        int key = 0;

        soundEffects_class soundEffects = new soundEffects_class();

        public void saveChosenNumbers(int pValue)
        {
            numberListDictionary.Add(key++, pValue);

        }

        public bool repeatNumbers(Dictionary<int, Button> btnDictionary, int pKey, bool activateSound)
        {
            //MessageBox.Show(numberList.Count + "  " + pIndex);
            try
            {
                if (pKey <= numberListDictionary.Count && btnDictionary[numberListDictionary[pKey]].TabIndex == numberListDictionary[pKey])
                {
                    soundEffects.playSoundEffectForButtons(btnDictionary[numberListDictionary[pKey]], activateSound);
                    btnDictionary[numberListDictionary[pKey]].BackColor = Color.Lime;                       
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            if (pKey != numberListDictionary.Count-1) return true;
            else return false;
        }

        public bool isClickOk(Button btn, int pKey)
        {
            //MessageBox.Show(numberListDictionary[0]+" " + pKey + " " + numberListDictionary.Count);
            if (numberListDictionary[pKey] == btn.TabIndex) return true;
            else return false;
        }

        public bool isElementNumberReached(int clicksN)
        {
            //MessageBox.Show(clicksN + "  " + (numberList.Count - 1));
            if (clicksN == numberListDictionary.Count - 1) return true;
            else return false;
        }

        public void showHintToPlay(Dictionary<int, Button> btnDictionary)
        {
            int lastIndex = numberListDictionary.Count() - 1;
            int index = numberListDictionary[lastIndex];
            btnDictionary[index].BackColor = Color.Yellow;           
        }
    }
}
