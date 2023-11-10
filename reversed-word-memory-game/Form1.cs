using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reverse_Word
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string [] arrayWord = {
                               "avocado", 
                               "powerful", 
                               "crazy", 
                               "coding", 
                               "effort", 
                               "equal", 
                               "untouched", 
                               "timeless", 
                               "everything", 
                               "hesitate", 
                               "happen", 
                               "eagle", 
                               "cricket",
                               "lovely",
                               "spot",
                               "place",
                               "altogether",
                               "property",
                               "deserve",
                               "sincere",
                               "backward",
                               "lifeless",
                               "broken",
                               "breath"
                              };
        string word = "";
        int countDown = 0;
        private void txtLetter_Enter(object sender, EventArgs e)
        {
            ActiveControl = null;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            timer1.Enabled = true;
            word = arrayWord[new Random().Next(0,arrayWord.Length)];
            string letter = word.Substring(new Random().Next(0, word.Length), 1);
            word = word.Replace(letter, letter.ToUpper());
            //this.Text = word;
            countDown = word.Length;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {

            if (txtWord.Text == word)
            {
                btnTest.Enabled = false;
                MessageBox.Show("You won!");
                txtLetter.Text = "";
                txtWord.Text = "";
            }
            else
            {
                MessageBox.Show("Incorrect!");
            }

            resetAllValues();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtLetter.Text = word.Substring(--countDown, 1);
            if (countDown == 0)
            {
                txtWord.ReadOnly = false;
                timer1.Stop();
                btnTest.Enabled = true;
            }

        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            resetAllValues();
        }

        private void resetAllValues()
        {
            btnStart.Enabled = true;
            btnTest.Enabled = false;
            txtLetter.Text = "";
            txtWord.Text = "";
            timer1.Enabled = false;
            txtWord.ReadOnly = true;
        }


    }
}
