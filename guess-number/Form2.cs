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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Guess_Num_DB data_obj = new Guess_Num_DB();

        int sec = 0,
            index = 0,
            completedCounter = 0,
            failureCounter = 0;

        int hour = 0, minute = 0, second = 0;
        int maxMatches = 1;

        string randomNumberString = "";

        TextBox[] arrayTxt = new TextBox[10];

        private void Form2_Load(object sender, EventArgs e)
        {
            int index = 0;
            foreach (var txt in this.Controls.OfType<TextBox>().OrderBy(x => x.TabIndex))
            {
                if (txt.Name != "txtInfo")
                {
                    arrayTxt[index++] = txt;
                }
            }
            btnReady.Focus();
            lblCompleted.Text = $"Completed: 0/{maxMatches}";
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    btnReady.PerformClick();
                    break;

                case Keys.NumPad0:
                    btn0.PerformClick();
                    break;

                case Keys.NumPad1:
                    btn1.PerformClick();
                    break;

                case Keys.NumPad2:
                    btn2.PerformClick();
                    break;

                case Keys.NumPad3:
                    btn3.PerformClick();
                    break;

                case Keys.NumPad4:
                    btn4.PerformClick();
                    break;

                case Keys.NumPad5:
                    btn5.PerformClick();
                    break;

                case Keys.NumPad6:
                    btn6.PerformClick();
                    break;

                case Keys.NumPad7:
                    btn7.PerformClick();
                    break;

                case Keys.NumPad8:
                    btn8.PerformClick();
                    break;

                case Keys.NumPad9:
                    btn9.PerformClick();
                    break;
            }
        }

        private void txtN0_Enter(object sender, EventArgs e)
        {
            ActiveControl = null;
        }

        private void txtN1_Enter(object sender, EventArgs e)
        {
            ActiveControl = null;
        }

        private void txtN2_Enter(object sender, EventArgs e)
        {
            ActiveControl = null;
        }

        private void txtN3_Enter(object sender, EventArgs e)
        {
            ActiveControl = null;
        }

        private void txtN4_Enter(object sender, EventArgs e)
        {
            ActiveControl = null;
        }

        private void txtN5_Enter(object sender, EventArgs e)
        {
            ActiveControl = null;
        }

        private void txtN6_Enter(object sender, EventArgs e)
        {
            ActiveControl = null;
        }

        private void txtN7_Enter(object sender, EventArgs e)
        {
            ActiveControl = null;
        }

        private void txtN8_Enter(object sender, EventArgs e)
        {
            ActiveControl = null;
        }

        private void txtN9_Enter(object sender, EventArgs e)
        {
            ActiveControl = null;
        }

        private void btnReady_Click(object sender, EventArgs e)
        {
            if (timer2.Enabled == false)
            {              
                timer2.Enabled = true;
            }

            txtInfo.Clear();

            btnReady.Enabled = false;
            generateNumbers();
            timer1.Start();          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmRecord2 frmR = new frmRecord2();
            frmR.ShowDialog();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            checkMatches(btn0);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            checkMatches(btn1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            checkMatches(btn2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            checkMatches(btn3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            checkMatches(btn4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            checkMatches(btn5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            checkMatches(btn6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            checkMatches(btn7);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            checkMatches(btn8);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            checkMatches(btn9);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sec++;
            if (sec == 4)
            {
                foreach (var txt in this.Controls.OfType<TextBox>().OrderBy(x => x.TabIndex))
                {
                    if (txt.Name != "txtInfo")
                    {
                        txt.Text = "X";
                    }
                }

                foreach (var btn in this.Controls.OfType<Button>().OrderBy(x => x.TabIndex))
                {
                    if (btn.TabIndex <= 9)
                    {
                        btn.Enabled = true;
                        btn.Text = btn.Tag + "";
                    }
                }

                timer1.Enabled=false;
                sec = 0;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (completedCounter >= maxMatches)
            {
                string strTime = lblTime.Text;
                strTime = strTime.Remove(0, 6);

                txtInfo.Text = $"Time: {strTime}";
                findNewRecord(strTime);
                data_obj.insertTimes2(strTime);
            }
            else showTime();
        }

        private void generateNumbers()
        {
            Dictionary<int, int> randomNumbersDictionary = new Dictionary<int, int>();
            Random randomNumberGenerator = new Random();

            int randomValueKey = 0,
                randomValue = 0;

            while (randomValueKey <= 9)
            {
                randomValue = randomNumberGenerator.Next(0, 10);
                if (!randomNumbersDictionary.ContainsValue(randomValue))
                {
                    randomNumbersDictionary.Add(randomValueKey++, randomValue);
                    randomNumberString += randomValue + "";
                }
            }

            randomValueKey = 0;
            foreach (var txt in this.Controls.OfType<TextBox>().OrderBy(x => x.TabIndex))
            {
                if (txt.Name != "txtInfo")
                {
                    txt.Text = randomNumbersDictionary[randomValueKey++] + "";
                }
            }
        }

        private void checkMatches(Button btn)
        {
            if (btn.BackColor != Color.Black)
                if (btn.Text == randomNumberString.Substring(index, 1))
                {
                    btn.BackColor = Color.Black;
                    arrayTxt[index].Text = randomNumberString.Substring(index, 1);
                    arrayTxt[index].BackColor = Color.FromArgb(4, 54, 69);
                    index++;

                    if (index > 9)
                    {
                        index = 0;
                        lblCompleted.Text = $"Completed: {++completedCounter}/{maxMatches}";
                        txtInfo.Text = "You guessed all!";
                        failureCounter = 0;
                        cleanValues();
                    }
                }
                else
                {
                    cleanValues();

                    if (completedCounter > 0) failureCounter++;
                    if (failureCounter == 3 & completedCounter > 0) lblCompleted.Text = $"Completed: {--completedCounter}/{maxMatches}";
                }
        }
      
        private void showTime()
        {
            if (second < 10 && minute < 10) lblTime.Text = $"Time: 0{hour}:0{minute}:0{second}";

            if (second < 10 && minute >= 10) lblTime.Text = $"Time: 0{hour}:{minute}:0{second}";

            if (second >= 10 && minute >= 10) lblTime.Text = $"Time: 0{hour}:{minute}:{second}";

            if (second >= 10 && minute < 10) lblTime.Text = $"Time: 0{hour}:0{minute}:{second}";

            second++;
            if (second == 60)
            {
                second = 0;
                minute++;
            }

            if (minute == 60)
            {
                minute = 0;
                hour++;
            }

            if (minute == 5) resetAllValues();
        }

        private void findNewRecord(string recordTimeString)
        {
            string bestRecordTimeString = data_obj.loadFirstRecordTime2();
            int record1 = int.Parse(Regex.Replace(bestRecordTimeString, ":", string.Empty)),
                record2 = int.Parse(Regex.Replace(recordTimeString, ":", string.Empty));
            if (record2 < record1) txtInfo.Text += " New Record";

            timer2.Enabled = false;
        }

        private void cleanValues()
        {
            randomNumberString = "";
            btnReady.Enabled = true;
            btnReady.Focus();
            index = 0;
            sec = 0;

            foreach (var btn in this.Controls.OfType<Button>().OrderBy(x => x.TabIndex))
            {
                if (btn.TabIndex <= 9)
                {
                    btn.Text = "-";
                    btn.BackColor = Color.FromArgb(4, 64, 69);
                    btn.Enabled = false;
                }
            }

            foreach (var txt in this.Controls.OfType<TextBox>().OrderBy(x => x.TabIndex))
            {
                if (txt.Name != "txtInfo")
                {
                    txt.Text = "X";
                    txt.BackColor = Color.FromArgb(4, 64, 69);
                }
            }
        }

        private void resetAllValues()
        {
            lblCompleted.Text = $"Completed: 0/{maxMatches}";
            if (completedCounter == maxMatches) completedCounter = 0;
            txtInfo.Clear();
            timer2.Enabled = false;
            lblTime.Text = "Time: 00:00:00";
            hour = 0; minute = 0; second = 0;
            cleanValues();           
        }

    }
}
