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


namespace Colorful_Words
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

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

        private void Main_Load(object sender, EventArgs e)
        {

        }

        int nBoxColor = 0,
            nLetterColor = 0,
            second = 0;

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            nBoxColor = 2;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            nBoxColor = 3;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            nBoxColor = 4;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            nBoxColor = 5;
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            nLetterColor = 2;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            nLetterColor = 3;
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            nLetterColor = 4;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            nLetterColor = 5;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            second = 10;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            second = 15;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            second = 25;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            moveForm(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(nBoxColor>0 & nLetterColor>0 & second > 0)
            {
                this.Hide();
                Form1 frm = new Form1(nBoxColor, nLetterColor, second);
                frm.ShowDialog();
                Application.Exit();
            }
            else { MessageBox.Show("There are options that haven't been picked yet!"); }

        }
    }
}
