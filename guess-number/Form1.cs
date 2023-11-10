using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace GuessNum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Guess_Num_DB cn = new Guess_Num_DB();

        int[] numbers = new int[20];
        int maxDigit = 10;
        int sec = 0;
        int completedCounter = 0,
            failureCounter=0;
        int minute = 0, second = 0;
        int maxMatches = 10;

        private void Form1_Load(object sender, EventArgs e)
        {
            txtRandomN.MaxLength = maxDigit;
            txtAnswer.MaxLength = maxDigit;
            cn.countRecordTimesLessThan7mins();
            //btnReady.Focus();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (btnReady.Focused) btnReady.PerformClick();
                if (btnTest.Focused) btnTest.PerformClick();
            }
                
            if (e.KeyCode == Keys.R) btnCallFrmRecord.PerformClick();
        }

        private void btnCallFrmRecord_Click(object sender, EventArgs e)
        {
            frmRecord frmR = new frmRecord();
            frmR.ShowDialog();
        }

        private void btnCallFrmRecord_Enter(object sender, EventArgs e)
        {
            ActiveControl = null;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            btnReady.Enabled = false;

            foreach(var txt in this.Controls.OfType<TextBox>())
            {
                txt.Clear();
            }
            Random randomN = new Random();
        
            for (int i = 0; i < maxDigit; i++)
            {        
                numbers[i] = randomN.Next(0, 10);
                txtRandomN.Text += numbers[i] + " ";
            }

            btnTest.Enabled = false;
            timer1.Start();
            sec = 0;

            if (timer2.Enabled == false)
            {
                lblPerfect.Text = "Completed: 0/10";
                lblPerfect.ForeColor = Color.White;
                timer2.Enabled = true;

                if(completedCounter == maxMatches)
                    resetAllValues();
            }           
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            //int auxLimit = 0;

            //auxLimit = limit - (limit - txtAnswer.TextLength);
            //auxLimit = txtAnswer.TextLength;

            if (txtAnswer.TextLength > 0)
            {              
                int matchCounter = 0;
                for (int i = 0; i < txtAnswer.TextLength; i++)
                {
                    if (int.Parse(txtAnswer.Text.Substring(i, 1)) == numbers[i]) matchCounter++;
                }

                for (int i = 0; i < maxDigit; i++)
                {
                    txtRandomN.Text += numbers[i] + "";
                }

                checkMatches(matchCounter);

                btnTest.Enabled = false;
                btnReady.Enabled = true;
                btnReady.Focus();
            }
            else
            {
                txtInfo.Text = "You need to fill the blank with numbers before testing.";
                txtAnswer.Focus();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetAllValues();
        }

        private void txtInfo_Enter(object sender, EventArgs e)
        {
            ActiveControl = null;
        }

        private void txtRandomN_Enter(object sender, EventArgs e)
        {
            ActiveControl = null;
        }
      
        private void txtAnswer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (++sec == 5)
            {
                timer1.Stop();
                txtRandomN.Clear();
                btnTest.Enabled = true;
                txtAnswer.Enabled = true;
                txtAnswer.Focus();                  
            }              
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (completedCounter >= maxMatches)
            {              
                string strTime = lblTime.Text;
                txtInfo.Text = strTime;

                strTime = strTime.Replace("Time: ", "");
                cn.insertTimes(strTime);               
                findNewRecord(strTime);
                
            }
            else showTime();
        }

        private void txtAnswer_TextChanged(object sender, EventArgs e)
        {
            if(txtAnswer.TextLength==txtAnswer.MaxLength) btnTest.Focus();
        }

        private void showTime()
        {
            if (second < 10 && minute < 10) lblTime.Text = $"Time: 0{minute}:0{second}";

            if (second < 10 && minute >= 10) lblTime.Text = $"Time: {minute}:0{second}";

            if (second >= 10 && minute >= 10) lblTime.Text = $"Time: {minute}:{second}";

            if (second >= 10 && minute < 10) lblTime.Text = $"Time: 0{minute}:{second}";

            second++;
            if (second == 60)
            {
                second = 0;
                minute++;
            }

            if (minute == 60)
            {
                minute = 0;
            }

            if (minute == 10) resetAllValues();
        }

        private void checkMatches(int matchCounter)
        {
            if (matchCounter == maxDigit)
            {
                txtInfo.Text = "You guessed all!";
                lblPerfect.Text = $"Completed: {++completedCounter}/{maxDigit}";
                if (completedCounter == maxMatches)
                {
                    lblPerfect.ForeColor = Color.Teal;
                }

                failureCounter = 0;
            }
            else
            {
                if (matchCounter > 1) txtInfo.Text = $"You got {matchCounter} matches";
                else if (matchCounter == 1) txtInfo.Text = $"You got {matchCounter} match";
                else txtInfo.Text = $"You got no matches";

                if (completedCounter > 0 && ++failureCounter == 5)
                {
                    failureCounter = 0;
                    completedCounter--;
                    lblPerfect.Text = $"Completed: {completedCounter}/{maxDigit}";
                }
            }
        }

        private void findNewRecord(string recordTimeString)
        {
            string bestRecordTimeString = cn.loadFirstRecordTime();
            int record1 = int.Parse(Regex.Replace(bestRecordTimeString, ":", string.Empty)),
                record2 = int.Parse(Regex.Replace(recordTimeString, ":", string.Empty));
            if (record2 < record1) txtInfo.Text += " New Record";

            timer2.Enabled = false;
        }

        private void resetAllValues()
        {
            lblPerfect.Text = "Completed: 0/10";
            lblTime.Text = "Time: 00:00";
            txtInfo.Clear();
            txtRandomN.Clear();
            txtAnswer.Clear();
            txtAnswer.Enabled = false;         
            btnReady.Enabled = true;
            btnReady.Focus();
            btnTest.Enabled = false;
            timer1.Enabled = false;
            timer2.Enabled = false;                    
            completedCounter = 0;
            minute = 0; 
            second = 0;           
        }
    }
}
