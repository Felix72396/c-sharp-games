using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tic_tac_toe_game
{
    class styles
    {
        public string playerSelectedSymbol;
        Random numberPicker = new Random();
        public Color select_MachineColor(Color playerColor)
        {
            
            Color machineColor=playerColor;
            Random numberPicker = new Random();
            while (machineColor == playerColor)
            {
                switch (numberPicker.Next(1, 6))
                {
                    case 1:
                        machineColor = Color.White;
                        break;
                    case 2:
                        machineColor = Color.Yellow;
                        break;
                    case 3:
                        machineColor = Color.Green;
                        break;
                    case 4:
                        machineColor = Color.Red;
                        break;
                    case 5:
                        machineColor = Color.Black;
                        break;
                }
             
            }
            return machineColor;
        }
        public Tuple<string,string> selectSymbol_method(int playerPick)
        {
            int number;
            string machineSymbol = "";
            bool numberRepeated = true;

            if (playerPick == 1)
            {
                playerSelectedSymbol = "*";
            }
            else if (playerPick == 2)
            {
                playerSelectedSymbol = "X";
            }
            else if (playerPick == 3)
            {
                playerSelectedSymbol = "O";
            }
            else if(playerPick == 4)
            {
                playerSelectedSymbol = "F";
            }
            else
            {
                playerSelectedSymbol = "@";
            }

            while (numberRepeated == true)
            {
                number = numberPicker.Next(1, 6);
                if (number == playerPick)
                {         
                    numberRepeated = true;
                }
                else
                {
                    numberRepeated = false;
                    switch (number)
                    {
                        case 1:
                            machineSymbol = "*";
                            break;

                        case 2:
                            machineSymbol = "X";
                            break;

                        case 3:
                            machineSymbol = "0";
                            break;

                        case 4:
                            machineSymbol = "F";
                            break;

                        case 5:
                            machineSymbol = "@";
                            break;
                    }
                }
            }
            return Tuple.Create(playerSelectedSymbol, machineSymbol); 
        }

    }//Class
}//nameSpace
