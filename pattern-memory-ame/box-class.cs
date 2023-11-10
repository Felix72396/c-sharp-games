using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Patterns_Game
{
    class box_class
    {
       
        List<int> boxPatternTabIndexList = new List<int>();
        public void createBoxPattern(int nRows, int nColumns, int nBoxPattern, Button[,] btnBox)
        {
            int randomNRow,
                randomNColumn;

            boxPatternTabIndexList.Clear();
            for (int i = 0; i < nBoxPattern; i++)
            {
                randomNRow = new Random().Next(0, nRows);
                randomNColumn = new Random().Next(0, nColumns);
                if(btnBox[randomNRow, randomNColumn].BackColor==Color.FromArgb(122, 255, 255))
                {
                    btnBox[randomNRow, randomNColumn].BackColor = Color.FromArgb(128, 128, 255);
                    boxPatternTabIndexList.Add(btnBox[randomNRow, randomNColumn].TabIndex);
                }
                else { i--; }
            }
        }

        public bool checkIfPickIsOk(int pTabIndex)
        {
            bool isOk = false;

            //MessageBox.Show(boxPatternTabIndexList.Count + " list   tab:"+pTabIndex);
            foreach (var tabIndex in boxPatternTabIndexList)
            {
                if (tabIndex == pTabIndex)
                {
                    isOk = true;
                    break;
                }
            }

            return isOk;
        }

        public void showPattern(Panel container)
        {
            foreach (var box in container.Controls.OfType<Button>().Where(x=>x.Name!="btnStart"))
            {
                foreach (var tabIndex in boxPatternTabIndexList)
                {
                    if (tabIndex == box.TabIndex)
                        if (box.BackColor == Color.FromArgb(122, 255, 255)) box.BackColor = Color.FromArgb(128, 128, 255);
                }                
            }
        }

        public void startLevel(Panel container, int level, Form frm)
        {
            frm.BackColor = Color.FromArgb(128, 128, 255);
            deleteBox(container, level);
        }

        private void deleteBox(Panel container, int level)
        {
            foreach (var box in container.Controls.OfType<Button>().Where(x=>x.Name!="btnStart").OrderBy(x=>x.TabIndex))
            {
                container.Controls.Remove(box);
            }          
        }

    }
}
