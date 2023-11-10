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
    public partial class Form1 : Form
    {
        public Form1(string playerSymbolParameter, Color playerColorParameter, string machineSymbolParameter, Color machineColorParameter, string levelParameter)
        {
            InitializeComponent();
            playerSymbol = playerSymbolParameter;
            playerColor = playerColorParameter;
            machineSymbol = machineSymbolParameter;
            machineColor = machineColorParameter;
            level = levelParameter;
        }

        string playerSymbol, machineSymbol, level;
        public Color playerColor, machineColor;

        level_and_symbol lvl_sym = new level_and_symbol();
        Panel[,] arrayPanel = new Panel[4, 4];
        Panel touchedPanel = new Panel();
        Label[,] lbl_arraySymbol = new Label[4, 4];

        Random numberPicker = new Random();

        bool playerWins = false, machineWins = false, playerTurn = false;

        int position1, position2, countTurns = 0;
        int row, column, positionY = 10, positionX = 10;

        private void Form1_Load(object sender, EventArgs e)
        {
            for (row = 1; row <= 3; row++)
            {
                positionX = 10;
                for (column = 1; column <= 3; column++)
                {
                    //creating panels
                    arrayPanel[row, column] = new Panel();
                    arrayPanel[row, column].BackColor = Color.Wheat;
                    arrayPanel[row, column].Size = new Size(100, 100);
                    arrayPanel[row, column].Click += new EventHandler(playerPlays_Function);
                    arrayPanel[row, column].Location = new Point(positionX, positionY);
                    panel1.Controls.Add(arrayPanel[row, column]);
                    positionX += 113;
                    //creating textboxs for panels 
                    //Felix apg                 
                }
                positionY += 113;
            }          
        }

        private void playerPlays_Function(object sender, EventArgs e)
        {
            //this is when I start my turn
            //Felix apg
            touchedPanel = (Panel)sender;
            position1 = 0;
            position2 = 0;
            for (row = 1; row <= 3; row++)
            {
                for (column = 1; column <= 3; column++)
                {
                    if (touchedPanel == arrayPanel[row, column])
                    {
                        if (arrayPanel[row, column].BackColor == Color.Wheat)
                        {
                            touchedPanel.BackColor = playerColor;
                            lbl_arraySymbol[row, column] = new Label();
                            lbl_arraySymbol[row, column].Location = new Point(0, 0);
                            lbl_arraySymbol[row, column].BackColor = arrayPanel[row, column].BackColor;
                            lbl_arraySymbol[row, column].Font = new Font(FontFamily.GenericSansSerif, 60.0F, FontStyle.Bold);
                            lbl_arraySymbol[row, column].Size = arrayPanel[row, column].Size;
                            lbl_arraySymbol[row, column].Text = playerSymbol;
                            lbl_arraySymbol[row, column].ForeColor = machineColor;
                            arrayPanel[row, column].Controls.Add(lbl_arraySymbol[row, column]);
                            countTurns++;
                            timer2.Start();
                        }
                        break;
                    }
                }
            }
            checkOut_if_PlayerWon();
        }

        private void machinePlays_Function()
        {
            playerTurn = false;

            if (countTurns != 9)
            {
                if (level == "easy")
                {
                    while (playerTurn == false)
                    {
                        position1 = numberPicker.Next(1, 4);
                        position2 = numberPicker.Next(1, 4);

                        if (arrayPanel[position1, position2].BackColor == Color.Wheat)
                        {
                            playerTurn = true;
                        }
                    }
                }
                else if (level == "intermediate")
                {
                    while (playerTurn == false)
                    {
                        //machine attacking
                        //analysing horizontally choices
                        //void in the right
                        if (arrayPanel[1, 1].BackColor == machineColor && arrayPanel[1, 2].BackColor == machineColor && arrayPanel[1, 3].BackColor == Color.Wheat)
                        {
                            position1 = 1;
                            position2 = 3;
                            playerTurn = true;
                           // MessageBox.Show(position1 + " " + position2 + " horizontal  der .....");
                        }
                        else if (arrayPanel[2, 1].BackColor == machineColor && arrayPanel[2, 2].BackColor == machineColor && arrayPanel[2, 3].BackColor == Color.Wheat)
                        {
                            position1 = 2;
                            position2 = 3;
                            playerTurn = true;
                            // MessageBox.Show(position1 + " " + position2 + " horizontal der  .....");
                        }
                        else if (arrayPanel[3, 1].BackColor == machineColor && arrayPanel[3, 2].BackColor == machineColor && arrayPanel[3, 3].BackColor == Color.Wheat)
                        {
                            position1 = 3;
                            position2 = 3;
                            playerTurn = true;
                            // MessageBox.Show(position1 + " " + position2 + " horizontal  der .....");
                        }
                        //void in the left
                        else if (arrayPanel[1, 1].BackColor == Color.Wheat && arrayPanel[1, 2].BackColor == machineColor && arrayPanel[1, 3].BackColor == machineColor)
                        {
                            position1 = 1;
                            position2 = 1;
                            playerTurn = true;
                            //MessageBox.Show(position1 + " " + position2 + "horizontal  izq  .....");
                        }
                        else if (arrayPanel[2, 1].BackColor == Color.Wheat && arrayPanel[2, 2].BackColor == machineColor && arrayPanel[2, 3].BackColor == machineColor)
                        {
                            position1 = 2;
                            position2 = 1;
                            playerTurn = true;
                            //MessageBox.Show(position1 + " " + position2 + " horizontal  izq .....");
                        }
                        else if (arrayPanel[3, 1].BackColor == Color.Wheat && arrayPanel[3, 2].BackColor == machineColor && arrayPanel[3, 3].BackColor == machineColor)
                        {
                            position1 = 3;
                            position2 = 1;
                            playerTurn = true;
                            //MessageBox.Show(position1 + " " + position2 + "horizontal izq   .....");
                        }
                        //void in the center
                        else if (arrayPanel[1, 1].BackColor == machineColor && arrayPanel[1, 2].BackColor == Color.Wheat && arrayPanel[1, 3].BackColor == machineColor)
                        {
                            position1 = 1;
                            position2 = 2;
                            playerTurn = true;
                            //MessageBox.Show(position1 + " " + position2 + " horizontal cent  .....");
                        }
                        else if (arrayPanel[2, 1].BackColor == machineColor && arrayPanel[2, 2].BackColor == Color.Wheat && arrayPanel[2, 3].BackColor == machineColor)
                        {
                            position1 = 2;
                            position2 = 2;
                            playerTurn = true;
                            //MessageBox.Show(position1 + " " + position2 + " horizontal cent  .....");
                        }
                        else if (arrayPanel[3, 1].BackColor == machineColor && arrayPanel[3, 2].BackColor == Color.Wheat && arrayPanel[3, 3].BackColor == machineColor)
                        {
                            position1 = 3;
                            position2 = 2;
                            playerTurn = true;
                            MessageBox.Show(position1 + " " + position2 + " horizontal cent  .....");
                        }
                        //analysing vertically choices
                        //void in the bottom
                        else if (arrayPanel[1, 2].BackColor == machineColor && arrayPanel[2, 2].BackColor == machineColor && arrayPanel[3, 2].BackColor == Color.Wheat)
                        {
                            position1 = 3;
                            position2 = 2;
                            playerTurn = true;
                            //MessageBox.Show(position1 + " " + position2 + "  vertical abajo  .....");
                        }
                        //void in the superior side
                        else if (arrayPanel[1, 1].BackColor == Color.Wheat && arrayPanel[2, 1].BackColor == machineColor && arrayPanel[3, 1].BackColor == machineColor)
                        {
                            position1 = 1;
                            position2 = 1;
                            playerTurn = true;
                            //MessageBox.Show(position1 + " " + position2 + " vertical arriba   .....");
                        }
                        else if (arrayPanel[1, 3].BackColor == Color.Wheat && arrayPanel[2, 3].BackColor == machineColor && arrayPanel[3, 3].BackColor == machineColor)
                        {
                            position1 = 1;
                            position2 = 3;
                            playerTurn = true;
                            //MessageBox.Show(position1 + " " + position2 + " vertical abajo   .....");
                        }
                        //void in the center
                        else if (arrayPanel[1, 2].BackColor == machineColor && arrayPanel[2, 2].BackColor == Color.Wheat && arrayPanel[3, 2].BackColor == machineColor)
                        {
                            position1 = 2;
                            position2 = 2;
                            playerTurn = true;
                            //MessageBox.Show(position1 + " " + position2 + "vertical centro    .....");
                        }
                        //analysing diagonally choices
                        //..void in the lower right
                        else if (arrayPanel[1, 1].BackColor == machineColor && arrayPanel[2, 2].BackColor == machineColor && arrayPanel[3, 3].BackColor == Color.Wheat)
                        {
                            position1 = 3;
                            position2 = 3;
                            playerTurn = true;
                        }
                        //..void in the lower left
                        else if (arrayPanel[1, 3].BackColor == machineColor && arrayPanel[2, 2].BackColor == machineColor && arrayPanel[3, 1].BackColor == Color.Wheat)
                        {
                            position1 = 3;
                            position2 = 1;
                            playerTurn = true;
                        }
                        //..void in the upper right                        
                        //..void in the center
                        else if (arrayPanel[1, 1].BackColor == machineColor && arrayPanel[2, 2].BackColor == Color.Wheat && arrayPanel[3, 3].BackColor == machineColor)
                        {
                            position1 = 2;
                            position2 = 2;
                            playerTurn = true;
                        }
                        //machine defending
                        //analysing horizontally choices
                        //void in the right
                        else if (arrayPanel[1, 1].BackColor == playerColor && arrayPanel[1, 2].BackColor == playerColor && arrayPanel[1, 3].BackColor == Color.Wheat)
                        {
                            position1 = 1;
                            position2 = 3;
                            playerTurn = true;
                        }
                        else if (arrayPanel[2, 1].BackColor == playerColor && arrayPanel[2, 2].BackColor == playerColor && arrayPanel[2, 3].BackColor == Color.Wheat)
                        {
                            position1 = 2;
                            position2 = 3;
                            playerTurn = true;
                        }
                        else if (arrayPanel[3, 1].BackColor == playerColor && arrayPanel[3, 2].BackColor == playerColor && arrayPanel[3, 3].BackColor == Color.Wheat)
                        {
                            position1 = 3;
                            position2 = 3;
                            playerTurn = true;
                        }
                        //void in the left
                        else if (arrayPanel[1, 1].BackColor == Color.Wheat && arrayPanel[1, 2].BackColor == playerColor && arrayPanel[1, 3].BackColor == playerColor)
                        {
                            position1 = 1;
                            position2 = 1;
                            playerTurn = true;
                        }
                        else if (arrayPanel[2, 1].BackColor == Color.Wheat && arrayPanel[2, 2].BackColor == playerColor && arrayPanel[2, 3].BackColor == playerColor)
                        {
                            position1 = 2;
                            position2 = 1;
                            playerTurn = true;
                        }
                        else if (arrayPanel[3, 1].BackColor == Color.Wheat && arrayPanel[3, 2].BackColor == playerColor && arrayPanel[3, 3].BackColor == playerColor)
                        {
                            position1 = 3;
                            position2 = 1;
                            playerTurn = true;
                        }
                        //void in the center
                        else if (arrayPanel[1, 1].BackColor == playerColor && arrayPanel[1, 2].BackColor == Color.Wheat && arrayPanel[1, 3].BackColor == playerColor)
                        {
                            position1 = 1;
                            position2 = 2;
                            playerTurn = true;
                        }
                        else if (arrayPanel[2, 1].BackColor == playerColor && arrayPanel[2, 2].BackColor == Color.Wheat && arrayPanel[2, 3].BackColor == playerColor)
                        {
                            position1 = 2;
                            position2 = 2;
                            playerTurn = true;
                        }
                        else if (arrayPanel[3, 1].BackColor == playerColor && arrayPanel[3, 2].BackColor == Color.Wheat && arrayPanel[3, 3].BackColor == playerColor)
                        {
                            position1 = 3;
                            position2 = 2;
                            playerTurn = true;
                        }
                        //analysing vertically choices
                        //void in the bottom
                        else if (arrayPanel[1, 1].BackColor == playerColor && arrayPanel[2, 1].BackColor == playerColor && arrayPanel[3, 1].BackColor == Color.Wheat)
                        {
                            position1 = 3;
                            position2 = 1;
                            playerTurn = true;
                        }
                        else if (arrayPanel[1, 2].BackColor == playerColor && arrayPanel[2, 2].BackColor == playerColor && arrayPanel[3, 2].BackColor == Color.Wheat)
                        {
                            position1 = 3;
                            position2 = 2;
                            playerTurn = true;
                        }
                        else if (arrayPanel[1, 3].BackColor == playerColor && arrayPanel[2, 3].BackColor == playerColor && arrayPanel[3, 3].BackColor == Color.Wheat)
                        {
                            position1 = 3;
                            position2 = 3;
                            playerTurn = true;
                        }
                        //void in the superior side
                        else if (arrayPanel[1, 1].BackColor == Color.Wheat && arrayPanel[2, 1].BackColor == playerColor && arrayPanel[3, 1].BackColor == playerColor)
                        {
                            position1 = 1;
                            position2 = 1;
                            playerTurn = true;
                        }
                        else if (arrayPanel[1, 2].BackColor == Color.Wheat && arrayPanel[2, 2].BackColor == playerColor && arrayPanel[3, 2].BackColor == playerColor)
                        {
                            position1 = 1;
                            position2 = 2;
                            playerTurn = true;
                        }
                        else if (arrayPanel[1, 3].BackColor == Color.Wheat && arrayPanel[2, 3].BackColor == playerColor && arrayPanel[3, 3].BackColor == playerColor)
                        {
                            position1 = 1;
                            position2 = 3;
                            playerTurn = true;
                        }
                        //void in the center
                        else if (arrayPanel[1, 1].BackColor == playerColor && arrayPanel[2, 1].BackColor == Color.Wheat && arrayPanel[3, 1].BackColor == playerColor)
                        {
                            position1 = 2;
                            position2 = 1;
                            playerTurn = true;
                        }
                        else if (arrayPanel[1, 2].BackColor == playerColor && arrayPanel[2, 2].BackColor == Color.Wheat && arrayPanel[3, 2].BackColor == playerColor)
                        {
                            position1 = 2;
                            position2 = 2;
                            playerTurn = true;
                        }
                        else if (arrayPanel[1, 3].BackColor == playerColor && arrayPanel[2, 3].BackColor == Color.Wheat && arrayPanel[3, 3].BackColor == playerColor)
                        {
                            position1 = 2;
                            position2 = 3;
                            playerTurn = true;
                        }
                        //analysing diagonally choices
                        //..void in the lower right
                        else if (arrayPanel[1, 1].BackColor == playerColor && arrayPanel[2, 2].BackColor == playerColor && arrayPanel[3, 3].BackColor == Color.Wheat)
                        {
                            position1 = 3;
                            position2 = 3;
                            playerTurn = true;
                        }
                        //..void in the upper left
                        else if (arrayPanel[1, 1].BackColor == Color.Wheat && arrayPanel[2, 2].BackColor == playerColor && arrayPanel[3, 3].BackColor == playerColor)
                        {
                            position1 = 1;
                            position2 = 1;
                            playerTurn = true;
                        }
                        //..void in the lower left
                        else if (arrayPanel[1, 3].BackColor == playerColor && arrayPanel[2, 2].BackColor == playerColor && arrayPanel[3, 1].BackColor == Color.Wheat)
                        {
                            position1 = 3;
                            position2 = 1;
                            playerTurn = true;
                        }
                        //..void in the upper right
                        else if (arrayPanel[1, 3].BackColor == Color.Wheat && arrayPanel[2, 2].BackColor == playerColor && arrayPanel[3, 1].BackColor == playerColor)
                        {
                            position1 = 1;
                            position2 = 3;
                            playerTurn = true;
                        }
                        //..void in the center
                        else if (arrayPanel[1, 1].BackColor == playerColor && arrayPanel[2, 2].BackColor == Color.Wheat && arrayPanel[3, 3].BackColor == playerColor)
                        {
                            position1 = 2;
                            position2 = 2;
                            playerTurn = true;
                        }
                        else if (arrayPanel[1, 3].BackColor == playerColor && arrayPanel[2, 2].BackColor == Color.Wheat && arrayPanel[3, 1].BackColor == playerColor)
                        {
                            position1 = 2;
                            position2 = 2;
                            playerTurn = true;
                        }
                        else
                        {
                            position1 = numberPicker.Next(1, 4); position2 = numberPicker.Next(1, 4);
                            if (arrayPanel[position1, position2].BackColor == Color.Wheat)
                            {
                                playerTurn = true;
                            }
                        }
                    }
                }
            }
            else
            {
                if (playerWins == false && machineWins == false)
                {
                    timer2.Stop();
                    MessageBox.Show("No Winner(Tie to Tie)");
                    restartGame_Function();
                }
            }

            checkOut_if_MachineWon();
            timer2.Stop();
            //machine playing
            arrayPanel[position1, position2].BackColor = machineColor;
            lbl_arraySymbol[position1, position2] = new Label();
            lbl_arraySymbol[position1, position2].Location = new Point(0, 0);
            lbl_arraySymbol[position1, position2].BackColor = machineColor;
            lbl_arraySymbol[position1, position2].Font = new Font(FontFamily.GenericSansSerif, 60.0F, FontStyle.Bold);
            lbl_arraySymbol[position1, position2].Size = arrayPanel[position1, position2].Size;
            lbl_arraySymbol[position1, position2].Text = machineSymbol;
            lbl_arraySymbol[position1, position2].ForeColor = playerColor;
            arrayPanel[position1, position2].Controls.Add(lbl_arraySymbol[position1, position2]);
            countTurns++;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (playerWins == false && machineWins == false)
            {
                timer1.Interval = 400;
                if (panel1.BackColor == Color.Gray)
                {
                    panel1.BackColor = Color.Brown;
                }
                else
                {
                    panel1.BackColor = Color.Gray;
                }
            }
            else if (machineWins == true)
            {
                timer1.Interval = 400;
                if (panel1.BackColor == Color.Gray)
                {
                    panel1.BackColor = machineColor;
                }
                else
                {
                    panel1.BackColor = Color.Gray;
                }
            }
            else if (playerWins == true)
            {
                timer1.Interval = 400;
                if (panel1.BackColor == Color.Gray)
                {
                    panel1.BackColor = playerColor;
                }
                else
                {
                    panel1.BackColor = Color.Gray;
                }
            }
            else
            {
                if (panel1.BackColor == Color.Gray)
                {
                    panel1.BackColor = Color.Purple;
                }
                else
                {
                    panel1.BackColor = Color.Gray;
                }
            }


        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            machinePlays_Function();
        }

        private void checkOut_if_PlayerWon()
        {
            //analysing if I won vertically
            if (arrayPanel[1, 1].BackColor == playerColor && arrayPanel[1, 2].BackColor == playerColor && arrayPanel[1, 3].BackColor == playerColor)
            {
                playerWins = true;
            }

            if (arrayPanel[2, 1].BackColor == playerColor && arrayPanel[2, 2].BackColor == playerColor && arrayPanel[2, 3].BackColor == playerColor)
            {
                playerWins = true;
            }

            if (arrayPanel[3, 1].BackColor == playerColor && arrayPanel[3, 2].BackColor == playerColor && arrayPanel[3, 3].BackColor == playerColor)
            {
                playerWins = true;
            }

            //analysing if I won horizontally
            if (arrayPanel[1, 1].BackColor == playerColor && arrayPanel[2, 1].BackColor == playerColor && arrayPanel[3, 1].BackColor == playerColor)
            {
                playerWins = true;
            }

            if (arrayPanel[1, 2].BackColor == playerColor && arrayPanel[2, 2].BackColor == playerColor && arrayPanel[3, 2].BackColor == playerColor)
            {
                playerWins = true;
            }

            if (arrayPanel[1, 3].BackColor == playerColor && arrayPanel[2, 3].BackColor == playerColor && arrayPanel[3, 3].BackColor == playerColor)
            {
                playerWins = true;
            }

            //analysing if I won diagonally
            if (arrayPanel[1, 1].BackColor == playerColor && arrayPanel[2, 2].BackColor == playerColor && arrayPanel[3, 3].BackColor == playerColor)
            {
                playerWins = true;
            }

            if (arrayPanel[1, 3].BackColor == playerColor && arrayPanel[2, 2].BackColor == playerColor && arrayPanel[3, 1].BackColor == playerColor)
            {
                playerWins = true;
            }

            if (playerWins == true)
            {
                timer2.Stop();
                MessageBox.Show("Congratulations. You beated the Machine");
                restartGame_Function();
                this.Hide();
                lvl_sym.Show();
            }
        }

        private void checkOut_if_MachineWon()
        {
            //analysing if machine won vertically
            if (arrayPanel[1, 1].BackColor == machineColor && arrayPanel[1, 2].BackColor == machineColor && arrayPanel[1, 3].BackColor == machineColor)
            {
                machineWins = true;       
            }

            if (arrayPanel[2, 1].BackColor == machineColor && arrayPanel[2, 2].BackColor == machineColor && arrayPanel[2, 3].BackColor == machineColor)
            {
                machineWins = true;
            }

            if (arrayPanel[3, 1].BackColor == machineColor && arrayPanel[3, 2].BackColor == machineColor && arrayPanel[3, 3].BackColor == machineColor)
            {
                machineWins = true;
            }

            //analysing if machine won horizontally
            if (arrayPanel[1, 1].BackColor == machineColor && arrayPanel[2, 1].BackColor == machineColor && arrayPanel[3, 1].BackColor == machineColor)
            {
                machineWins = true;
            }

            if (arrayPanel[1, 2].BackColor == machineColor && arrayPanel[2, 2].BackColor == machineColor && arrayPanel[3, 2].BackColor == machineColor)
            {
                machineWins = true;
            }

            if (arrayPanel[1, 3].BackColor == machineColor && arrayPanel[2, 3].BackColor == machineColor && arrayPanel[3, 3].BackColor == machineColor)
            {
                machineWins = true;
            }

            //analysing if machine won diagonally
            if (arrayPanel[1, 1].BackColor == machineColor && arrayPanel[2, 2].BackColor == machineColor && arrayPanel[3, 3].BackColor == machineColor)
            {
                machineWins = true;
            }

            if (arrayPanel[1, 3].BackColor == machineColor && arrayPanel[2, 2].BackColor == machineColor && arrayPanel[3, 1].BackColor == machineColor)
            {
                machineWins = true;
            }

            if (machineWins == true)
            {
                timer2.Stop();
                MessageBox.Show("Game Over");
                restartGame_Function();
            }
        }

        private void restartGame_Function()
        {
                countTurns = 0;
                this.Hide();
                lvl_sym.Show();
        }



    }//class
}//namespace
