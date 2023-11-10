using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Patterns_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        box_class bC = new box_class();
        soundEffects_class soundEffect = new soundEffects_class();
       
        int level = 1,
            clicks=0, 
            nSecInfoTime=0,
            secondInfoTime=0,
            nSecPlayTime=0,
            secondPlayTime=0,
            score=0;
        bool isGameOver = false;

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        public static extern void ReleaseCapture();
        [DllImport("User32.dll", EntryPoint = "SendMessage")]

        public static extern void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int Lparam);
        //para mover a los formularios que no tienen bordes
        public static void moveForm(Form f)
        {
            ReleaseCapture();
            SendMessage(f.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            centerControls();
        }


        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            moveForm(this);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            clicks = 0;
            setInitialValues(pnlBoxContainer);
            btnStart.Visible = false;
            btnRestartLevel.Enabled = true;
            pnlBoxContainer.Enabled = false;

            secondInfoTime = nSecInfoTime;
            timer2.Enabled = true;
        }

        private void btnRestartLevel_Click(object sender, EventArgs e)
        {
            clicks = 0;

            score -= 100;
            lblPoints.Text = score + "";

            lblSecondPlayTime.Text = "-";
            centerControls();

            bC.startLevel(pnlBoxContainer, level, this);
            setInitialValues(pnlBoxContainer);
            
            secondInfoTime = nSecInfoTime;
            btnHint.Visible = false;
            pnlBoxContainer.Enabled = false;
            timer2.Enabled = true;
            timer3.Enabled = false;
        }

        private void btnRestartGame_Click(object sender, EventArgs e)
        {
            level = 1;
            score = 0;
            lblPoints.Text = score + "";
            resetTimers();
            btnStart.Visible = true;
            centerControls();
            bC.startLevel(pnlBoxContainer, level, this);
        }

        public void btnBoxClick(object sender, EventArgs e)
        {
            Button btnBox = (Button)sender;
            
            if (bC.checkIfPickIsOk(btnBox.TabIndex))
            {
                if (btnBox.BackColor != Color.Lime)
                {
                    clicks++;
                    btnBox.BackColor = Color.Lime;
                    soundEffect.playSoundEffect("box");
                }
                
                if (nBoxPattern == clicks)
                {
                    resetTimers();
                    disableBoxesWhenWinningOrLosing();
                    AddScore();
                  
                    this.BackColor = Color.Lime;
                    
                    isGameOver = false;
                    soundEffect.playSoundEffectWhenWinningOrLosing(isGameOver);
                    //level++;
                    ++level;           
                    timer1.Enabled = true;
                }
            }
            else
            {
                resetTimers();
                disableBoxesWhenWinningOrLosing();
                score = 0;
                lblPoints.Text = score + "";
                this.BackColor = Color.Red;
                btnBox.BackColor = Color.Red;
                isGameOver = true;
                soundEffect.playSoundEffectWhenWinningOrLosing(isGameOver);
                level = 1;
                timer1.Enabled = true;
            }           
        }

        private void AddScore()
        {
            if (secondPlayTime > 0 & secondPlayTime <= 2)
            {
                score += (1000 * secondPlayTime);
            }
            else if (secondPlayTime >= 3) score += (1000 * 3);
            else score += 500;

            lblPoints.Text = score + "";
        }

        private void resetTimers()
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            //btnStart.Visible = true;
            pnlBoxContainer.Enabled = true;
            pnlInfoTime.Visible = false;
            btnRestartLevel.Enabled = false;
            btnHint.Visible = false;

            lblLevelCount.Text = level + "";
            lblSecondPlayTime.Text = "-";
            centerControls();
        }

        private void hidePattern()
        {
            foreach (var box in pnlBoxContainer.Controls.OfType<Button>().Where(x => x.Name != "btnStart"))
            {
                if (box.BackColor == Color.FromArgb(128, 128, 255)) box.BackColor = Color.FromArgb(122, 255, 255);
            }

            if (level > 10)
            {
                btnHint.Visible = true;
            }
        }

        private void disableBoxesWhenWinningOrLosing()
        {
            foreach (var box in pnlBoxContainer.Controls.OfType<Button>().Where(x=>x.Name!="btnStart"))
            {
                box.Enabled = false;
            }
        }

        private void btnHint_Click(object sender, EventArgs e)
        {
            score -= 500;
            lblPoints.Text = score + "";
            bC.showPattern(pnlBoxContainer);

            centerControls();

            timer4.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (level > 20)
            {
                level = 1;
                soundEffect.playSoundEffect("claps");
                MessageBox.Show("Congratulations! You've passed all levels");
            }

            clicks = 0;
            bC.startLevel(pnlBoxContainer, level, this);
            btnStart.Visible = true;
            btnRestartLevel.Enabled = false;
            pnlBoxContainer.Enabled = true;
            timer1.Enabled = false;
            this.BackColor = Color.FromArgb(128, 128, 255);
           
            lblLevelCount.Text = level + "";
            centerControls();
        }
     
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (pnlInfoTime.Visible == false) pnlInfoTime.Visible = true;
            
            if (secondInfoTime == -1)
            {
                secondPlayTime = nSecPlayTime;
                hidePattern();
                pnlInfoTime.Visible = false;
                
                pnlBoxContainer.Enabled = true;
                timer2.Enabled = false;
                timer3.Enabled = true;                
            }
            else
            {
                lblInfoTime.Text = $"Memorize the pattern in {secondInfoTime} {((secondInfoTime--)>1?"seconds":"second")}";
                centerControls();
                soundEffect.playSoundEffect("tick");
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            lblSecondPlayTime.Text = $"{secondPlayTime} {(secondPlayTime > 1 ? "secs" : "sec")}";

            if (secondPlayTime == -1)
            {
                timer3.Enabled = false;
                lblSecondPlayTime.Text = "-";
            }

            centerControls();
            secondPlayTime--;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            hidePattern();
            timer4.Enabled = false;
        }


        int size = 0,
            nRows = 0,
            nColumns = 0,
            nBoxPattern = 0;

        public void setInitialValues(Panel container)
        {
            if (level < 9)
            {
                size = 100;
                nRows = 3;
                nSecInfoTime = 2;
            }
            else
            {
                size = 80;
                nRows = 4;
                nSecInfoTime = 4;
            }

            switch (level)
            {
                case 1:
                    nColumns = 3;
                    nBoxPattern = 3;
                    break;

                case 2:
                    nColumns = 3;
                    nBoxPattern = 4;
                    break;

                case 3:
                    nColumns = 4;
                    nBoxPattern = 4;
                    break;

                case 4:
                    nColumns = 4;
                    nBoxPattern = 5;
                    break;

                case 5:
                    nColumns = 4;
                    nBoxPattern = 6;
                    break;

                case 6:
                    nColumns = 5;
                    nBoxPattern = 6;
                    break;

                case 7:
                    nColumns = 5;
                    nBoxPattern = 7;
                    break;

                case 8:
                    nColumns = 5;
                    nBoxPattern = 8;
                    break;

                case 9:
                    nColumns = 5;
                    nBoxPattern = 8;
                    break;

                case 10:
                    nColumns = 5;
                    nBoxPattern = 9;
                    break;

                case 11:
                    nColumns = 5;
                    nBoxPattern = 10;
                    break;

                case 12:
                    nColumns = 6;
                    nBoxPattern = 10;
                    break;

                case 13:
                    nColumns = 6;
                    nBoxPattern = 11;
                    break;

                case 14:
                    nColumns = 6;
                    nBoxPattern = 12;
                    break;

                case 15:
                    nColumns = 6;
                    nBoxPattern = 13;
                    break;

                case 16:
                    nColumns = 7;
                    nBoxPattern = 10;
                    break;

                case 17:
                    nColumns = 7;
                    nBoxPattern = 11;
                    break;

                case 18:
                    nColumns = 7;
                    nBoxPattern = 12;
                    break;

                case 19:
                    nColumns = 7;
                    nBoxPattern = 13;
                    break;

                case 20:
                    nColumns = 7;
                    nBoxPattern = 14;
                    break;
            }

            //nSec += nBoxPattern; this is used to calculate the amount of secs we have to memorize a pattern. The harder the pattern the longer the time to memorize it
            //nSecInfoTime += nBoxPattern;

            //nSecPlayTime = nBoxPattern; this time will start when the user clicks the boxes and if it's done quickly you can get higher scores
            nSecPlayTime = nBoxPattern;
         
            createBox(nRows, nColumns, size, nBoxPattern, container);
        }

        public void createBox(int nRows, int nColumns, int size, int nBoxPattern, Panel container)
        {
            Button[,] btnBox = new Button[nRows, nColumns];

            int x = 0,
                y = 0,
                tabIndex = 0;

            y = (container.Height / 2) - ((size / 2) * nRows);

            for (int r = 0; r < nRows; r++)
            {
                x = (container.Width / 2) - ((size / 2) * nColumns)-2;
                for (int c = 0; c < nColumns; c++)
                {
                    btnBox[r, c] = new Button();
                    btnBox[r, c].Size = new Size(size, size);
                    btnBox[r, c].Location = new Point(x, y);
                    x += size + 1;
                    btnBox[r, c].BackColor = Color.FromArgb(122, 255, 255);
                    btnBox[r, c].FlatStyle = FlatStyle.Flat;
                    btnBox[r, c].FlatAppearance.BorderSize = 1;
                    btnBox[r, c].FlatAppearance.BorderColor = Color.FromArgb(128, 128, 255);
                    btnBox[r, c].FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 228, 255);
                    btnBox[r, c].FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 205);
                    btnBox[r, c].TabIndex = tabIndex++;

                    btnBox[r, c].Click += new EventHandler(btnBoxClick);
                    container.Controls.Add(btnBox[r, c]);
                }

                y += size + 1;
            }

            bC.createBoxPattern(nRows, nColumns, nBoxPattern, btnBox);
        }

        private void centerControls()
        {
            int x = 0, y = 0;

            x = (pnlInfoTime.Width / 2) - (lblInfoTime.Width / 2);
            y = (pnlInfoTime.Height / 2) - (lblInfoTime.Height / 2) - 2;
            lblInfoTime.Location = new Point(x, y);

            x = (pnlBoxContainer.Width / 2) - (btnStart.Width / 2);
            y = (pnlBoxContainer.Height / 2) - (btnStart.Height / 2);
            btnStart.Location = new Point(x, y);

            x = (pnlTime.Width / 2) - (lblPlayTime.Width / 2);
            y = (pnlTime.Height / 2) - (lblPlayTime.Height / 2);
            lblPlayTime.Location = new Point(x, y);

            x = (pnlSecond.Width / 2) - (lblSecondPlayTime.Width / 2);
            y = (pnlSecond.Height / 2) - (lblSecondPlayTime.Height / 2);
            lblSecondPlayTime.Location = new Point(x, y);

            x = (pnlScore.Width / 2) - (lblScore.Width / 2);
            y = (pnlScore.Height / 2) - (lblScore.Height / 2);
            lblScore.Location = new Point(x, y);

            x = (pnlPoint.Width / 2) - (lblPoints.Width / 2);
            y = (pnlPoint.Height / 2) - (lblPoints.Height / 2);
            lblPoints.Location = new Point(x, y);

            x = (pnlLevel.Width / 2) - (lblLevel.Width / 2);
            y = (pnlLevel.Height / 2) - (lblLevel.Height / 2);
            lblLevel.Location = new Point(x, y);

            x = (pnlLevelCount.Width / 2) - (lblLevelCount.Width / 2) + 1;
            y = (pnlLevelCount.Height / 2) - (lblLevelCount.Height / 2);
            lblLevelCount.Location = new Point(x, y);

            x = (pnlLevelLimit.Width / 2) - (lblLevelLimit.Width / 2) + 1;
            y = (pnlLevelLimit.Height / 2) - (lblLevelLimit.Height / 2);
            lblLevelLimit.Location = new Point(x, y);

            x = (pnlRestartLvl.Width / 2) - (btnRestartLevel.Width / 2);
            y = (pnlRestartLvl.Height / 2) - (btnRestartLevel.Height / 2); ;
            btnRestartLevel.Location = new Point(x, y);

            x = (pnlRestartGame.Width / 2) - (btnRestartGame.Width / 2);
            y = (pnlRestartGame.Height / 2) - (btnRestartGame.Height / 2);
            btnRestartGame.Location = new Point(x, y);
        }

       
    }
}
