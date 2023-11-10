using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_tac_toe_game
{

    public partial class level_and_symbol : Form 
    {
        public level_and_symbol()
        {
            InitializeComponent();
        }
       

        bool levelSelected = false, symbolSelected = false, colorSelected=false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (var lvl in groupBox1.Controls.OfType<RadioButton>())
            {
                if (lvl.Checked == true)
                {
                    levelSelected = true;
                    break;
                }
            }


            foreach (var symbl in groupBox2.Controls.OfType<RadioButton>())
            {
                if (symbl.Checked == true)
                {
                    symbolSelected = true;
                    break;
                }
            }

            foreach (var clr in groupBox3.Controls.OfType<RadioButton>())
            {
                if (clr.Checked == true)
                {
                    colorSelected= true;
                    break;
                }
            }

            if (levelSelected == true && symbolSelected == true && colorSelected==true)
            {
                button1.Enabled = true;
                button1.ForeColor = Color.DarkOrange;
                button1.BackColor = Color.LightGreen;
                timer1.Stop();         
            }
        }

        private void level_and_symbol_Load(object sender, EventArgs e)
        {
          
        }
       
         
        private void button1_Click(object sender, EventArgs e)
        {
            ///In this part I'm coding the level that my game will have
            ///felix apg
            ///       
            string level=string.Empty;
            int playerPick = 0;
            string playerSymbol;
            Color playerColor = Color.Empty;
            Color machineColor = Color.Empty;
            string machineSymbol;
            styles gameStyle = new styles();


            if (radioButton1.Checked == true)
            {
                level = "easy";
            }

            if (radioButton2.Checked == true)
            {
                level = "intermediate";
            }

            if (radioButton3.Checked == true)
            {
                level = "hard";
            }

            //Choosing my Symbol
            if (radioButton4.Checked == true)
            {
                playerPick = 1;
            }

            if (radioButton5.Checked == true)
            {
                playerPick = 2;
            }

            if (radioButton6.Checked == true)
            {
                playerPick = 3;
            }

            if (radioButton7.Checked == true)
            {
                playerPick = 4;
            }

            if (radioButton8.Checked == true)
            {
                playerPick = 5;
            }
     
            //In this part I am assigning the color I am goint to use.
            if (radioButton9.Checked == true)
            {
                playerColor = Color.White;              
            }

            if (radioButton10.Checked == true)
            {
                playerColor = Color.Yellow;          
            }

            if (radioButton11.Checked == true)
            {
                 playerColor  = Color.Green;            
            }

            if (radioButton12.Checked == true)
            {
                playerColor = Color.Red;             
            }

            if (radioButton13.Checked == true)
            {
                playerColor = Color.Black;            
            }

            playerSymbol = gameStyle.selectSymbol_method(playerPick).Item1;
            machineColor = gameStyle.select_MachineColor(playerColor);
            machineSymbol = gameStyle.selectSymbol_method(playerPick).Item2;           
            Form1 frm1 = new Form1(playerSymbol, playerColor, machineSymbol, machineColor, level);
         
            this.Hide();
            frm1.Show();

        }
    }
}
