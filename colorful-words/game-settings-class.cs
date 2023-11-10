using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;

namespace Colorful_Words
{
    class game_settings_class
    {
        List<Color> colorList;
        int index = 0;
        string stringColor = "";

        public List<Color> generateColorList()
        {
            Color[] colorArray = {Color.Red, Color.Yellow, Color.Green, Color.Blue, Color.Purple, Color.Orange, Color.DarkRed, Color.Coral, Color.Aqua};
            colorList = new List<Color>();
            bool isColorRepeated = false;

            while (colorList.Count!=5)
            {
                index = new Random().Next(0, colorArray.Length);
                isColorRepeated = false;

                if (colorList.Count == 0) colorList.Add(colorArray[index]);
                else
                {
                    foreach (var clr in colorList)
                    {
                        if (clr == colorArray[index])
                        {
                            isColorRepeated = true;
                            break;
                        }
                    }

                    if (isColorRepeated == false) colorList.Add(colorArray[index]);
                }
                //MessageBox.Show(colorList[colorList.Count - 1] + "");
            }

            return colorList;
        }//method

        //private void asignColor(Panel pPnlBoxColorContainer, Panel pPnlLetterColorContainer)
        //{
        //    colorList = generateColorList();
        //    index = 0;

        //    foreach (var btn in pPnlBoxColorContainer.Controls.OfType<Button>().OrderBy(x => x.TabIndex))
        //    {
        //        btn.BackColor = colorList[index++];
        //    }

        //    index = 0;
        //    foreach (var btn in pPnlLetterColorContainer.Controls.OfType<Button>().OrderBy(x => x.TabIndex))
        //    {
        //        btn.BackColor = colorList[index++];
        //    }
        //}

        //private void generateWord(Panel pnl)
        //{
        //    //debo de generar
        //    string word = "MANZANAS";
        //    stringColor = "";

        //    Form1 frm = new Form1();

        //    Button btn;
        //    int x = 0,
        //        y = 0,
        //        size = 80,
        //        rdmIndex = 0;

        //    //this is to center an object or more than one
        //    x = ((pnl.Width / 2) - ((size * word.Length) / 2)) - 7;
        //    y = ((pnl.Height / 2) - (size / 2)) + 2;

        //    for (int i = 0; i < word.Length; i++)
        //    {
        //        btn = new Button();
        //        btn.Size = new Size(size, size);
        //        btn.TextAlign = ContentAlignment.MiddleCenter;
        //        btn.TabIndex = i;
        //        btn.Text = word[i].ToString();
        //        btn.Font = new Font("Arial", 45.0f);
        //        btn.Location = new Point(x, y);
        //        btn.Click += new EventHandler(frm.btnClick);

        //        rdmIndex = new Random().Next(0, 3);
        //        btn.BackColor = colorList[rdmIndex];
        //        btn.ForeColor = btn.BackColor;

        //        while (btn.BackColor == btn.ForeColor)
        //        {
        //            rdmIndex = new Random().Next(0, 3);
        //            btn.ForeColor = colorList[rdmIndex];
        //        }

        //        stringColor += btn.BackColor + " " + btn.ForeColor;

        //        btn.FlatStyle = FlatStyle.Flat;
        //        btn.FlatAppearance.MouseOverBackColor = Color.Black;
        //        btn.FlatAppearance.BorderSize = 0;

        //        pnl.Controls.Add(btn);
        //        x += size + 2;
        //    }
        //}



       

        public void changeAllRadioButtonsCheckStateToFalse(Button pBtn, Panel pPnlContainer)
        {
            pBtn.Parent.BackColor = pBtn.BackColor;        
            pPnlContainer.BackColor = Color.FromArgb(64, 74, 64);
            pBtn.FlatAppearance.BorderSize = 1;
            
            foreach (var btn in pPnlContainer.Controls.OfType<Button>().OrderBy(x=>x.TabIndex))
            {
                btn.FlatAppearance.BorderSize = 0;
                if (btn.FlatAppearance.BorderSize > 0)
                {
                    btn.FlatAppearance.BorderSize = 0;
                    break;
                }
            }

            foreach (var btn in pBtn.Parent.Controls.OfType<Button>())
            {
                if (btn != pBtn) btn.FlatAppearance.BorderSize = 0;
            }
        }

        public void startGame(Panel pPnlBoxColorContainer, Panel pPnlLetterColorContainer, Panel pPnlWordContainer)
        {
            resetControls(pPnlBoxColorContainer, pPnlLetterColorContainer, pPnlWordContainer);
            //asignColor(pPnlBoxColorContainer, pPnlLetterColorContainer);
            //generateWord(pPnlWordContainer);
        }

        private void resetControls(Panel pPnlBoxColorContainer, Panel pPnlLetterColorContainer, Panel pPnlWordContainer)
        {
            pPnlBoxColorContainer.BackColor=Color.FromArgb(64, 74, 64);
            pPnlLetterColorContainer.BackColor = pPnlBoxColorContainer.BackColor;

            foreach (var btn in pPnlBoxColorContainer.Controls.OfType<Button>())
            {              
                    btn.FlatAppearance.BorderSize = 0;
            }

            foreach (var btn in pPnlLetterColorContainer.Controls.OfType<Button>())
            {
                    btn.FlatAppearance.BorderSize = 0;
            }

            foreach (var btn in pPnlWordContainer.Controls.OfType<Button>().OrderBy(x=>x.TabIndex))
            {
                pPnlWordContainer.Controls.Remove(btn);
            }
        }

    }//class
}//namespace
