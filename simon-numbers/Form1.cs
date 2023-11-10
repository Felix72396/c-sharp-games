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
using System.Threading;

namespace Simon_Numbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        soundEffects_class soundEffects = new soundEffects_class();
        logic_class logic = new logic_class();

        Dictionary<int, Button> btnDictionary = new Dictionary<int, Button>();

        int score = 0,
            repetitionsN=0,
            clickN=0;

        //to turn the form into back when losing
        bool isFormBlack = true,
            activateSound=true,
            isGameOver=false,
            canPlay=false,
            restartGame=false;

        private void Form1_Load(object sender, EventArgs e)
        {           
            btnDictionary.Add(0, btn0);
            btnDictionary.Add(1, btn1);
            btnDictionary.Add(2, btn2);
            btnDictionary.Add(3, btn3);
            btnDictionary.Add(4, btn4);
            btnDictionary.Add(5, btn5);
            btnDictionary.Add(6, btn6);
            btnDictionary.Add(7, btn7);
            btnDictionary.Add(8, btn8);
            btnDictionary.Add(9, btn9);
        }

        private void btn0_Click(object sender, EventArgs e) {
            soundEffects.playSoundEffectForButtons(btn0, activateSound);
            checkClicksWithNumbers(btn0);
            ActiveControl = null;
            //activateBtnHint();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            soundEffects.playSoundEffectForButtons(btn1, activateSound);
            checkClicksWithNumbers(btn1);
            ActiveControl = null;
            //activateBtnHint();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            soundEffects.playSoundEffectForButtons(btn2, activateSound);
            checkClicksWithNumbers(btn2);
            ActiveControl = null;
            //activateBtnHint();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            soundEffects.playSoundEffectForButtons(btn3, activateSound);
            checkClicksWithNumbers(btn3);
            ActiveControl = null;
            //activateBtnHint();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            soundEffects.playSoundEffectForButtons(btn4, activateSound);
            checkClicksWithNumbers(btn4);
            ActiveControl = null;
            //activateBtnHint();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            soundEffects.playSoundEffectForButtons(btn5, activateSound);
            checkClicksWithNumbers(btn5);
            ActiveControl = null;
            //activateBtnHint();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            soundEffects.playSoundEffectForButtons(btn6, activateSound);
            checkClicksWithNumbers(btn6);
            ActiveControl = null;
            //activateBtnHint();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            soundEffects.playSoundEffectForButtons(btn7, activateSound);
            checkClicksWithNumbers(btn7);
            ActiveControl = null;
            //activateBtnHint();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            soundEffects.playSoundEffectForButtons(btn8, activateSound);
            checkClicksWithNumbers(btn8);
            ActiveControl = null;
            //activateBtnHint();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            soundEffects.playSoundEffectForButtons(btn9, activateSound);
            checkClicksWithNumbers(btn9);
            ActiveControl = null;
            //activateBtnHint();
        }

        private void btnHint_Click(object sender, EventArgs e)
        {
            soundEffects.playSoundEffectForButtons(btnHint, activateSound);
            logic.showHintToPlay(btnDictionary);
            btnHint.Enabled = false;
            ActiveControl = null;
            score -= 10;
            txtScreen.Text = $"Score: {score}";
        }

        private void txtScreen_Enter(object sender, EventArgs e)
        {
            ActiveControl = null;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var randomNumber = new Random().Next(0, 10);

            cleanButtonColor();
            foreach (var btn in this.Controls.OfType<Button>())
            {
                if (btn.TabIndex == randomNumber)
                {
                    soundEffects.playSoundEffectForButtons(btn, activateSound);
                    btn.BackColor = Color.Red;

                    logic.saveChosenNumbers(randomNumber);
                    break;
                }
            }

            timer1.Enabled = false;
            timer3.Enabled = true;      
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //if (repetitionsN == 2) MessageBox.Show(logic.fg());
            cleanButtonColor();

            if (logic.repeatNumbers(btnDictionary, repetitionsN, activateSound))
            {
                repetitionsN++;
                btnHint.Enabled = false;
                btnHint.BackColor = Color.Olive;
                if (!isFormBlack)
                {
                    this.BackColor = Color.Black;
                    isFormBlack = true;
                }
            }
            else
            {
                timer1.Enabled = true;
                timer2.Enabled = false;
                repetitionsN = 0;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            cleanButtonColor();
            enableButtons(true);          
            timer3.Enabled = false;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            changeFormColorToBlack();
            timer4.Enabled = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            cleanButtonColor();

            if(canPlay)
            switch (e.KeyCode)
            {
                case Keys.NumPad0:
                    btn0.PerformClick();
                    btn0.BackColor = Color.Lime;
                    break;

                case Keys.NumPad1:
                    btn1.PerformClick();
                    btn1.BackColor = Color.Lime;
                    break;

                case Keys.NumPad2:
                    btn2.PerformClick();
                    btn2.BackColor = Color.Lime;
                    break;

                case Keys.NumPad3:
                    btn3.PerformClick();
                    btn3.BackColor = Color.Lime;
                    break;

                case Keys.NumPad4:
                    btn4.PerformClick();
                    btn4.BackColor = Color.Lime;
                    break;

                case Keys.NumPad5:
                    btn5.PerformClick();
                    btn5.BackColor = Color.Lime;
                    break;

                case Keys.NumPad6:
                    btn6.PerformClick();
                    btn6.BackColor = Color.Lime;
                    break;

                case Keys.NumPad7:
                    btn7.PerformClick();
                    btn7.BackColor = Color.Lime;
                    break;

                case Keys.NumPad8:
                    btn8.PerformClick();
                    btn8.BackColor = Color.Lime;
                    break;

                case Keys.NumPad9:
                    btn9.PerformClick();
                    btn9.BackColor = Color.Lime;
                    break;

                case Keys.Enter:
                    if (chkBSound.Checked) chkBSound.Checked = false;
                    else chkBSound.Checked = true;
                    break;

                case Keys.Add:
                        btnHint.PerformClick();
                    break;
            }
        }

        private void chkBSound_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBSound.Checked == true)
            {
                activateSound = true;
                chkBSound.BackColor = Color.Lime;
            }
            else
            {
                activateSound = false;
                chkBSound.BackColor = Color.Red;
            }
        }

        private void enableButtons(bool enable)
        {
            foreach (var btn in this.Controls.OfType<Button>())
            {
                if (btn.TabIndex <= 9)
                    if (enable == true)
                    {
                        btn.Enabled = true;
                        canPlay = true;
                    }
                    else 
                    { 
                        btn.Enabled = false;
                        canPlay = false;
                    }
            }
            //activateBtnHint();
        }

        private void cleanButtonColor()
        {
            //To make all the buttons the same color
            foreach (var btn in this.Controls.OfType<Button>())
            {        
                if(btn.BackColor != Color.FromArgb(0, 64, 0) && btn.Name!="btnHint")
                {
                    btn.BackColor = Color.FromArgb(0, 64, 0);
                    break;
                }
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            restartGame = true;
            resetGame();
        }

        private void checkClicksWithNumbers(Button btn)
        {
            if(restartGame==false)
                if (!logic.isClickOk(btn, clickN)) 
                {    
                    this.BackColor = Color.Red;
                    isFormBlack = false;
                    isGameOver = true;
                    soundEffects.playSoundEffect(isGameOver, activateSound);
                    resetGame(); 
                }
                else if (logic.isElementNumberReached(clickN)) 
                {
                    activateBtnHint();
                    clickN = 0;
                    score += 10;
                    txtScreen.Text = $"Score: {score}";
                    this.BackColor = Color.Lime;
                    isFormBlack = false;
                    timer4.Enabled = true;
                    isGameOver = false;
                    soundEffects.playSoundEffect(isGameOver, activateSound);
                    repeatNumbersAgain();
                    cleanButtonColor();
                    enableButtons(false);
                }
                else 
                {  
                    clickN++;
                    activateBtnHint();
                    cleanButtonColor();
                }
        }

        private void repeatNumbersAgain()
        {
            if(timer2.Interval>=600) timer2.Interval -= 100;
            timer2.Enabled = true;
            timer1.Enabled = false;
            enableButtons(false);
        }

        private void activateBtnHint()
        {
            if (clickN>0 && clickN % 3 == 0)
            {
                btnHint.Enabled = true;
                btnHint.BackColor = Color.FromArgb(192, 192, 0); 
            }
        }

        private void changeFormColorToBlack()
        {
            if(!isFormBlack) this.BackColor = Color.Black;
            isFormBlack = true;
        }

        private void resetGame()
        {           
            timer4.Enabled = true;                  
            repetitionsN = 0;
            clickN = 0;
            logic = new logic_class();
            timer1.Enabled = true;
            timer2.Enabled = false;
            timer2.Interval = 1200;
            score = 0;
            enableButtons(false);
            cleanButtonColor();
            btnHint.Enabled = false;
            txtScreen.Text = "Score: 0";
            restartGame = false;
        }
    }
}
