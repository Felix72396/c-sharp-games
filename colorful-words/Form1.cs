using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;
using WMPLib;

namespace Colorful_Words
{
    public partial class Form1 : Form
    {
        public Form1(int pNBoxColor, int pNLetterColor, int second)
        {
            InitializeComponent();
            this.nBoxColor = pNBoxColor;
            this.nLetterColor = pNLetterColor;
            this.second = second;
            this.n = second;

        }

        game_settings_class gSC = new game_settings_class();
        soundEffects_class soundEffect = new soundEffects_class();

        int nBoxColor=0, 
            nLetterColor=0, 
            second=0,
            n=0;

        bool isGameOver = false;


        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gSC.startGame(pnlBoxColorContainer, pnlLetterColorContainer, pnlWordContainer);
            asignColor(pnlBoxColorContainer, pnlLetterColorContainer);
            generateWord(pnlWordContainer);
        }

        private void btnBoxColor1_Click(object sender, EventArgs e)
        {
            gSC.changeAllRadioButtonsCheckStateToFalse(btnBoxColor1, pnlLetterColorContainer);
            soundEffect.playSoundEffectForRadioButtons("boxColor");
        }     

        private void btnBoxColor2_Click(object sender, EventArgs e)
        {
            gSC.changeAllRadioButtonsCheckStateToFalse(btnBoxColor2, pnlLetterColorContainer);
            soundEffect.playSoundEffectForRadioButtons("boxColor");          
        }

        private void btnBoxColor3_Click(object sender, EventArgs e)
        {
            gSC.changeAllRadioButtonsCheckStateToFalse(btnBoxColor3, pnlLetterColorContainer);
            soundEffect.playSoundEffectForRadioButtons("boxColor");
        }

        private void btnBoxColor4_Click(object sender, EventArgs e)
        {
            gSC.changeAllRadioButtonsCheckStateToFalse(btnBoxColor4, pnlLetterColorContainer);
            soundEffect.playSoundEffectForRadioButtons("boxColor");
        }

        private void btnBoxColor5_Click(object sender, EventArgs e)
        {
            gSC.changeAllRadioButtonsCheckStateToFalse(btnBoxColor5, pnlLetterColorContainer);
            soundEffect.playSoundEffectForRadioButtons("boxColor");
        }

        private void btnLetterColor1_Click(object sender, EventArgs e)
        {
            gSC.changeAllRadioButtonsCheckStateToFalse(btnLetterColor1, pnlBoxColorContainer);
            soundEffect.playSoundEffectForRadioButtons("letterColor");
        }

        private void btnLetterColor2_Click(object sender, EventArgs e)
        {
            gSC.changeAllRadioButtonsCheckStateToFalse(btnLetterColor2, pnlBoxColorContainer);
            soundEffect.playSoundEffectForRadioButtons("letterColor");
        }

        private void btnLetterColor3_Click(object sender, EventArgs e)
        {
            gSC.changeAllRadioButtonsCheckStateToFalse(btnLetterColor3, pnlBoxColorContainer);
            soundEffect.playSoundEffectForRadioButtons("letterColor");
        }

        private void btnLetterColor4_Click(object sender, EventArgs e)
        {
            gSC.changeAllRadioButtonsCheckStateToFalse(btnLetterColor4, pnlBoxColorContainer);
            soundEffect.playSoundEffectForRadioButtons("letterColor");
        }

        private void btnLetterColor5_Click(object sender, EventArgs e)
        {
            gSC.changeAllRadioButtonsCheckStateToFalse(btnLetterColor5, pnlBoxColorContainer);
            soundEffect.playSoundEffectForRadioButtons("letterColor");
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            gSC.startGame(pnlBoxColorContainer, pnlLetterColorContainer, pnlWordContainer);
            asignColor(pnlBoxColorContainer, pnlLetterColorContainer);
            generateWord(pnlWordContainer);

            timer1.Enabled = true;
            timer2.Enabled = false;
            btnTest.Enabled = false;
            pnlBoxColorContainer.Enabled = false;
            pnlLetterColorContainer.Enabled = false;

            this.BackColor = Color.White;
            second = n;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            string stringColor = "";
            foreach (var btn in pnlWordContainer.Controls.OfType<Button>().OrderBy(x => x.TabIndex)) stringColor += btn.BackColor + " " + btn.ForeColor;

            if (compareIfStringColorsAreEqual(stringColor))
            {
                isGameOver = false;
                this.BackColor = Color.Lime;
            }
            else
            {
                isGameOver = true;
                this.BackColor = Color.Red;
            }        

            soundEffect.playSoundEffect(isGameOver);

            timer2.Enabled = true;
            btnTest.Enabled = false;
            pnlBoxColorContainer.Enabled = false;
            pnlLetterColorContainer.Enabled = false;
            second = 25;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            ActiveControl = null;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (second == 0)
            {
                foreach (var btn in pnlWordContainer.Controls.OfType<Button>())
                {
                    btn.BackColor = Color.FromArgb(64, 64, 64);
                    btn.ForeColor = Color.White;
                }

                textBox1.Text = "Guess the color of the boxes and the letters";
                timer1.Enabled = false;
                btnTest.Enabled = true;
                
                pnlBoxColorContainer.Enabled = true;
                pnlLetterColorContainer.Enabled = true;
            }
            else textBox1.Text = second <= 1 ? $"Guess the color of the boxes and the letters in {second--} second" : $"Guess the color of the boxes and the letters in {second--} seconds";
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = false;
            this.BackColor = Color.White;
            gSC.startGame(pnlBoxColorContainer, pnlLetterColorContainer, pnlWordContainer);
            asignColor(pnlBoxColorContainer, pnlLetterColorContainer);
            generateWord(pnlWordContainer);
        }

        List<Color> colorList = new List<Color>();
        int index = 0;
        string stringColor;
        private void asignColor(Panel pPnlBoxColorContainer, Panel pPnlLetterColorContainer)
        {
            colorList = gSC.generateColorList();
            index = 0;

            foreach (var btn in pPnlBoxColorContainer.Controls.OfType<Button>().OrderBy(x => x.TabIndex))
            {
                btn.BackColor = colorList[index++];
            }

            index = 0;
            foreach (var btn in pPnlLetterColorContainer.Controls.OfType<Button>().OrderBy(x => x.TabIndex))
            {
                btn.BackColor = colorList[index++];
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Main frm = new Main();
            this.Hide();
            frm.ShowDialog();
        }

        private void generateWord(Panel pnl)
        {
            second = n;
            //debo de generar
            string[] wordArray = {"APPLES", "ORANGES", "PLUMS", "BANANAS", "MANGOS", "FIGS", "GRANADES", "PRUNES", "KIWIS", "CHERRIES"};
            string word = wordArray[new Random().Next(0, wordArray.Length)];
            stringColor = "";

            Button btn;
            int x = 0,
                y = 0,
                size = 80,
                rdmIndex = 0;

            //this is to center an object or more than one
            x = ((pnl.Width / 2) - ((size * word.Length) / 2)) - 7;
            y = ((pnl.Height / 2) - (size / 2)) + 2;

            for (int i = 0; i < word.Length; i++)
            {
                
                btn = new Button();
                btn.Size = new Size(size, size);
                btn.TextAlign = ContentAlignment.MiddleCenter;
                btn.TabIndex = i;
                btn.Text = word[i].ToString();
                btn.Font = new Font("Arial", 45.0f);
                btn.Location = new Point(x, y);
                btn.Click += new EventHandler(btnClick);
                

                rdmIndex = new Random().Next(0, nBoxColor);
                btn.BackColor = colorList[rdmIndex];
                btn.ForeColor = btn.BackColor;

                while (btn.BackColor == btn.ForeColor)
                {
                    rdmIndex = new Random().Next(0, nLetterColor);
                    btn.ForeColor = colorList[rdmIndex];
                }
                
                stringColor += btn.BackColor + " " + btn.ForeColor;

                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.MouseOverBackColor = Color.Black;
                btn.FlatAppearance.BorderSize = 0;

                pnl.Controls.Add(btn);
                x += size + 2;
            }
        }


        public void btnClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (pnlBoxColorContainer.BackColor != Color.FromArgb(64, 74, 64)) btn.BackColor = pnlBoxColorContainer.BackColor;

            if (pnlLetterColorContainer.BackColor != Color.FromArgb(64, 74, 64)) btn.ForeColor = pnlLetterColorContainer.BackColor;

            soundEffect.playSoundEffectForRadioButtons("pop");

        }

        public bool compareIfStringColorsAreEqual(string pStringColor)
        {
            return (pStringColor == stringColor) ? true : false;
        }

    }
}
