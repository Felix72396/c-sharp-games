using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessNum
{
    public partial class menuFrm : Form
    {
        public menuFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.ShowDialog();
            Application.Exit();
                                 
        }

        private void button1_Enter(object sender, EventArgs e)
        {
            ActiveControl = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            this.Hide();
            frm.ShowDialog();
            Application.Exit();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            this.Hide();
            frm.ShowDialog();
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.ShowDialog();
            Application.Exit();
        }

        private void menuFrm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                
                case Keys.NumPad1:
                    button1.PerformClick();
                    MessageBox.Show("klk");
                    break;

                case Keys.NumPad2:
                    button2.PerformClick();
                    break;               
            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.ShowDialog();
            Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            this.Hide();
            frm.ShowDialog();
            Application.Exit();
        }

        private void btnClose_Enter(object sender, EventArgs e)
        {
            ActiveControl = null;
        }
    }
}
