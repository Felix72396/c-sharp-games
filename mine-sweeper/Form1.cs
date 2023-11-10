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

namespace Mine_Seeker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Class
        soundEffects_class soundEffect = new soundEffects_class();
        mines_class mC = new mines_class();
        #endregion

        #region Form Movement
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        public static extern void ReleaseCapture();
        [DllImport("User32.dll", EntryPoint = "SendMessage")]

        public static extern void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int Lparam);
        //To move forms the don't have border
        public static void move_form_function(Form f)
        {
            ReleaseCapture();
            SendMessage(f.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        int sec = 0;
        int level = 1;
        private void Form1_Load(object sender, EventArgs e)
        {      
            show_mines_function(level);
            mC.check_if_all_tiles_were_clicked_method();
        }

        private void pnlTabBar_MouseDown(object sender, MouseEventArgs e)
        {
            move_form_function(this);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Enter(object sender, EventArgs e)
        {
            ActiveControl = null;
        }

        private void show_mines_function(int level)
        {          
            mC.create_tiles_method(pnlContainer, level);
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            start_game_function(level);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sec < 1000)
            {
                txtTime.Text = (sec < 10) ? $"00{sec}" : (sec < 100) ? $"0{sec}" : $"{sec}";
                sec++;
            }           
            else timer1.Enabled = false;

            if (mC.check_if_all_tiles_were_clicked_method())
            {
                timer1.Enabled = false;
                soundEffect.play_sound_effect_when_winning_or_losing_method(false);
                MessageBox.Show("You rock!", "Congratulations");
                start_game_function(level);
            }
        }

        private void pnlContainer_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void rdBBeginner_CheckedChanged(object sender, EventArgs e)
        {
            this.Size = new Size(459, 430);
            level = 1;
            start_game_function(level);
            set_btnClose_and_btnMinimize_position_function();
        }

        private void rdBIntermediate_CheckedChanged(object sender, EventArgs e)
        {
            this.Size = new Size(564, 535);
            level = 2;
            start_game_function(level);
            set_btnClose_and_btnMinimize_position_function();
        }

        private void rdBAdvance_CheckedChanged(object sender, EventArgs e)
        {
            this.Size = new Size(711, 682);
            level = 3;
            start_game_function(level);
            set_btnClose_and_btnMinimize_position_function();
        }

        private void set_btnClose_and_btnMinimize_position_function()
        {
            //int x, y;
            //x = pnlTabBar.Location.X + pnlTabBar.Width-2;
            //y = btnClose;
            btnClose.Left = ((pnlTabBar.Location.X + pnlTabBar.Width) - btnClose.Width) - 2;
            btnMinimize.Left = (btnClose.Location.X - btnClose.Width) - 2;
        }

        private void start_game_function(int level)
        {
            mC.remove_mines_method();
            mC.create_tiles_method(pnlContainer, level);
            sec = 0;
            txtTime.Text = "000";
            pnlContainer.Enabled = true;
            timer1.Enabled = false;
        }
      
    }
}
