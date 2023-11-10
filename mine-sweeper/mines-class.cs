using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace Mine_Seeker
{
    class mines_class
    {
        soundEffects_class soundEffect = new soundEffects_class();
        Button[,] tileArray;

        int rowLimit, columnLimit, nMine;

        private void mine_click_event(object sender, EventArgs e)
        {
            Button mineButton = (Button)sender;

            if (mineButton.Tag == "mine")
            {
                mineButton.Parent.Enabled = false;
                show_mines_function();
            }
            else if (mineButton.Tag != "")
            {
                mineButton.Text = mineButton.Tag + "";
                mineButton.Enabled = false;
            }
            else
            {               
                expand_space_when_clicking_function(mineButton.TabIndex);
            }

            foreach(var mineBtn in tileArray)
            {
                if (mineBtn.BackColor == Color.FromArgb(140, 162, 255)) mineBtn.Enabled = false;
            }

            mineButton.BackColor = Color.FromArgb(140, 162, 255);
            soundEffect.play_sound_effect_method("box");
        }

        
        public void create_tiles_method(Panel container, int level)
        {

            int size = 20,
                x = 2,
                y = 2,
                tabIndexCounter=0;

            if (level == 1)
            {
                rowLimit = 16;
                columnLimit = 16;
            }         
            else if(level == 2)
            {
                rowLimit = 21;
                columnLimit = 21;
            }
            else
            {
                rowLimit = 28;
                columnLimit = 28;
            }
               

            //y = (pnlContainer.Height / 2) - ((size / 2) * (row));
            tileArray = new Button[rowLimit, columnLimit];

            for (int row = 0; row < this.rowLimit; row++)
            {
                //x = (pnlContainer.Width / 2) - ((size / 2) * (column));
                x = 2;
                for (int column = 0; column < this.columnLimit; column++)
                {
                    tileArray[row, column] = new Button();
                    tileArray[row, column].BackColor = Color.FromArgb(82, 120, 220);
                    tileArray[row, column].FlatStyle = FlatStyle.Flat;
                    tileArray[row, column].FlatAppearance.BorderSize = 0;
                    tileArray[row, column].Click += new EventHandler(mine_click_event);
                    tileArray[row, column].Size = new Size(size, size);
                    tileArray[row, column].Location = new Point(x, y);
                    x += size + 1;

                    tileArray[row, column].TabIndex = tabIndexCounter++;
                    container.Controls.Add(tileArray[row, column]);
                }

                y += size + 1;
            }

            add_random_mine_function(tileArray, rowLimit, columnLimit, level);
            add_mine_counter_function(tileArray, rowLimit, columnLimit);
        }

        private void add_random_mine_function(Button [,] mineArray, int pRowLimit, int pColumnLimit, int level)
        {
            int rowIndex = 0,
               columnIndex = 0;

            if (level == 1) nMine = 30;
            else if (level == 2) nMine = 45;
            else nMine = 60;

            Random randomIndex = new Random();

            for (int mineCounter = 0; mineCounter < nMine; mineCounter++)
            {
                rowIndex = randomIndex.Next(0, pRowLimit);
                columnIndex = randomIndex.Next(0, pColumnLimit);

                if (mineArray[rowIndex, columnIndex].Tag != "mine") mineArray[rowIndex, columnIndex].Tag = "mine";
                else mineCounter--;
            }            
        }

        private void add_mine_counter_function(Button[,] tileArray, int pRowLimit, int pColumnLimit)
        {
            int mineCounter = 0;
            for (int row = 0; row < pRowLimit; row++)
            {                
                for (int column = 0; column < pColumnLimit; column++)
                {
                    //corners
                    if (tileArray[row, column].Tag != "mine")
                    {
                        if (row == 0 && column == 0)
                        {
                            mineCounter = 0;
                            if (tileArray[row, column + 1].Tag == "mine") mineCounter++;
                            if (tileArray[row + 1, column].Tag == "mine") mineCounter++;
                            if (tileArray[row + 1, column + 1].Tag == "mine") mineCounter++;
                            tileArray[row, column].Tag = ((mineCounter > 0) ? mineCounter + "" : "");
                        }
                       
                        if (row == 0 && column == pColumnLimit-1)
                        {
                            mineCounter = 0;
                            if (tileArray[row, column - 1].Tag == "mine") mineCounter++;
                            if (tileArray[row + 1, column - 1].Tag == "mine") mineCounter++;
                            if (tileArray[row + 1, column].Tag == "mine") mineCounter++;
                            tileArray[row, column].Tag = ((mineCounter > 0) ? mineCounter + "" : "");
                        }

                        if (row == pRowLimit-1 && column == 0)
                        {
                            mineCounter = 0;
                            if (tileArray[row, column + 1].Tag == "mine") mineCounter++;
                            if (tileArray[row - 1, column + 1].Tag == "mine") mineCounter++;
                            if (tileArray[row - 1, column].Tag == "mine") mineCounter++;
                            tileArray[row, column].Tag = ((mineCounter > 0) ? mineCounter + "" : "");
                        }

                        if (row == pRowLimit - 1 && column == pColumnLimit - 1)
                        {
                            mineCounter = 0;
                            if (tileArray[row, column - 1].Tag == "mine") mineCounter++;
                            if (tileArray[row - 1, column - 1].Tag == "mine") mineCounter++;
                            if (tileArray[row - 1, column].Tag == "mine") mineCounter++;
                            tileArray[row, column].Tag = ((mineCounter > 0) ? mineCounter + "": "");
                        }

                        //top
                        if (row == 0 && column > 0 && column < pColumnLimit - 1)
                        {
                            mineCounter = 0;
                            if (tileArray[row, column - 1].Tag == "mine") mineCounter++;
                            if (tileArray[row, column + 1].Tag == "mine") mineCounter++;
                            if (tileArray[row + 1, column].Tag == "mine") mineCounter++;
                            if (tileArray[row + 1, column - 1].Tag == "mine") mineCounter++;
                            if (tileArray[row + 1, column + 1].Tag == "mine") mineCounter++;
                            tileArray[row, column].Tag = ((mineCounter > 0) ? mineCounter + "" : "");
                        }

                        //bottom
                        if (row == pRowLimit - 1 && column > 0 && column < pColumnLimit - 1)
                        {
                            mineCounter = 0;
                            if (tileArray[row, column - 1].Tag == "mine") mineCounter++;
                            if (tileArray[row, column + 1].Tag == "mine") mineCounter++;
                            if (tileArray[row - 1, column].Tag == "mine") mineCounter++;
                            if (tileArray[row - 1, column - 1].Tag == "mine") mineCounter++;
                            if (tileArray[row - 1, column + 1].Tag == "mine") mineCounter++;
                            tileArray[row, column].Tag = ((mineCounter > 0) ? mineCounter + "" : "");
                        }

                        //right
                        if (column == pColumnLimit - 1 && row > 0 && row < pRowLimit - 1)
                        {
                            mineCounter = 0;
                            if (tileArray[row - 1, column].Tag == "mine") mineCounter++;
                            if (tileArray[row + 1, column].Tag == "mine") mineCounter++;
                            if (tileArray[row, column - 1].Tag == "mine") mineCounter++;
                            if (tileArray[row - 1, column - 1].Tag == "mine") mineCounter++;
                            if (tileArray[row + 1, column - 1].Tag == "mine") mineCounter++;
                            tileArray[row, column].Tag = ((mineCounter > 0) ? mineCounter + "" : "");
                        }

                        //left
                        if (column == 0 && row > 0 && row < pRowLimit - 1)
                        {
                            mineCounter = 0;
                            if (tileArray[row - 1, column].Tag == "mine") mineCounter++;
                            if (tileArray[row + 1, column].Tag == "mine") mineCounter++;
                            if (tileArray[row, column + 1].Tag == "mine") mineCounter++;
                            if (tileArray[row - 1, column + 1].Tag == "mine") mineCounter++;
                            if (tileArray[row + 1, column + 1].Tag == "mine") mineCounter++;
                            tileArray[row, column].Tag = ((mineCounter > 0) ? mineCounter + "" : "");
                        }

                        //center
                        if (row > 0 && row < pRowLimit - 1 && column > 0 && column < pColumnLimit - 1)
                        {
                            mineCounter = 0;
                            if (tileArray[row - 1, column - 1].Tag == "mine") mineCounter++;
                            if (tileArray[row - 1, column].Tag == "mine") mineCounter++;
                            if (tileArray[row - 1, column + 1].Tag == "mine") mineCounter++;
                            if (tileArray[row, column + 1].Tag == "mine") mineCounter++;
                            if (tileArray[row + 1, column + 1].Tag == "mine") mineCounter++;
                            if (tileArray[row + 1, column].Tag == "mine") mineCounter++;
                            if (tileArray[row + 1, column - 1].Tag == "mine") mineCounter++;
                            if (tileArray[row, column - 1].Tag == "mine") mineCounter++;
                            tileArray[row, column].Tag = ((mineCounter > 0) ? mineCounter + "" : "");
                        }
                    }                     
                }
            }
        }

        //int space_counter = 0;
        private void expand_space_when_clicking_function(int tileBtn_tabIndex)
        {
            bool isTileEmpty = true;
            int rowPosition = 0, columnPosition = 0;

            //looking for positions
            for (int row = 0; row < rowLimit; row++)
            {
                for (int column = 0; column < columnLimit; column++)
                {
                    if (tileArray[row, column].Tag == "" && tileArray[row, column].TabIndex == tileBtn_tabIndex)
                    {
                        rowPosition = row;
                        columnPosition = column;
                    }
                }
            }

            //top spaces
            for (int row = rowPosition; row >= 0; row--)
            {
                if (tileArray[row, columnPosition].Tag == "")
                {
                    tileArray[row, columnPosition].BackColor = Color.FromArgb(140, 162, 255);
                }
                else if (tileArray[row, columnPosition].Tag != "mine")
                {
                    tileArray[row, columnPosition].BackColor = Color.FromArgb(140, 162, 255);
                    tileArray[row, columnPosition].Text = tileArray[row, columnPosition].Tag + "";
                    isTileEmpty = false;
                    break;
                }

                if (isTileEmpty == false) break;
            }

            //bottom spaces
            isTileEmpty = true;

            for (int row = rowPosition; row < rowLimit; row++)
            {
                if (tileArray[row, columnPosition].Tag == "")
                {
                    tileArray[row, columnPosition].BackColor = Color.FromArgb(140, 162, 255);
                }
                else if (tileArray[row, columnPosition].Tag != "mine")
                {
                    tileArray[row, columnPosition].BackColor = Color.FromArgb(140, 162, 255);
                    tileArray[row, columnPosition].Text = tileArray[row, columnPosition].Tag + "";
                    isTileEmpty = false;
                    break;
                }

                if (isTileEmpty == false) break;
            }

            //right spaces
            isTileEmpty = true;

            for (int column = columnPosition; column < columnLimit; column++)
            {
                if (tileArray[rowPosition, column].Tag == "")
                {
                    tileArray[rowPosition, column].BackColor = Color.FromArgb(140, 162, 255);
                }
                else if (tileArray[rowPosition, column].Tag != "mine")
                {
                    tileArray[rowPosition, column].BackColor = Color.FromArgb(140, 162, 255);
                    tileArray[rowPosition, column].Text = tileArray[rowPosition, column].Tag + "";
                    isTileEmpty = false;
                    break;
                }

                if (isTileEmpty == false) break;
            }

            //left spaces
            isTileEmpty = true;

            for (int column = columnPosition; column >= 0; column--)
            {
                if (tileArray[rowPosition, column].Tag == "")
                {
                    tileArray[rowPosition, column].BackColor = Color.FromArgb(140, 162, 255);
                }
                else if (tileArray[rowPosition, column].Tag != "mine")
                {
                    tileArray[rowPosition, column].BackColor = Color.FromArgb(140, 162, 255);
                    tileArray[rowPosition, column].Text = tileArray[rowPosition, column].Tag + "";
                    isTileEmpty = false;
                    break;
                }

                if (isTileEmpty == false) break;
            }


            for (int row = 0; row < rowLimit; row++)
            {
                for (int column = 0; column < columnLimit; column++)
                {
                    //corners
                    if (tileArray[row, column].Tag == "" && tileArray[row, column].BackColor == Color.FromArgb(140, 162, 255))
                    {
                        if (row == 0 && column == 0)
                        {
                            if (tileArray[row, column + 1].Tag != "mine")
                            {
                                tileArray[row, column + 1].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row, column + 1].Text = tileArray[row, column + 1].Tag + "";
                            }

                            if (tileArray[row + 1, column].Tag != "mine")
                            {
                                tileArray[row + 1, column].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row + 1, column].Text = tileArray[row + 1, column].Tag + "";
                            }

                            if (tileArray[row + 1, column + 1].Tag != "mine")
                            {
                                tileArray[row + 1, column + 1].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row + 1, column + 1].Text = tileArray[row + 1, column + 1].Tag + "";                               
                            }
                        }

                        if (row == 0 && column == columnLimit - 1)
                        {
                            if (tileArray[row, column - 1].Tag != "mine")
                            {
                                tileArray[row, column - 1].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row, column - 1].Text = tileArray[row, column - 1].Tag + "";
                            }

                            if (tileArray[row + 1, column - 1].Tag != "mine")
                            {
                                tileArray[row + 1, column - 1].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row + 1, column - 1].Text = tileArray[row + 1, column - 1].Tag + "";
                            }

                            if (tileArray[row + 1, column].Tag != "mine")
                            {
                                tileArray[row + 1, column].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row + 1, column].Text = tileArray[row + 1, column].Tag +"";
                            }
                        }

                        if (row == rowLimit - 1 && column == 0)
                        {
                            if (tileArray[row, column + 1].Tag != "mine")
                            {
                                tileArray[row, column + 1].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row, column + 1].Text = tileArray[row, column + 1].Tag + "";
                            }

                            if (tileArray[row - 1, column + 1].Tag != "mine")
                            {
                                tileArray[row - 1, column + 1].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row - 1, column + 1].Text = tileArray[row - 1, column + 1].Tag + "";
                            }

                            if (tileArray[row - 1, column].Tag != "mine")
                            {
                                tileArray[row - 1, column].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row - 1, column].Text = tileArray[row - 1, column].Tag + "";
                            }
                        }

                        if (row == rowLimit - 1 && column == columnLimit - 1)
                        {
                            if (tileArray[row, column - 1].Tag != "mine")
                            {
                                tileArray[row, column - 1].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row, column - 1].Text = tileArray[row, column - 1].Tag + "";
                            }

                            if (tileArray[row - 1, column - 1].Tag != "mine")
                            {
                                tileArray[row - 1, column - 1].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row - 1, column - 1].Text = tileArray[row - 1, column - 1].Tag + "";
                            }

                            if (tileArray[row - 1, column].Tag != "mine")
                            {
                                tileArray[row - 1, column].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row - 1, column].Text = tileArray[row - 1, column].Tag + "";
                            }
                        }

                        //top
                        if (row == 0 && column > 0 && column < columnLimit - 1)
                        {
                            if (tileArray[row, column - 1].Tag != "mine")
                            {
                                tileArray[row, column - 1].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row, column - 1].Text = tileArray[row, column - 1].Tag + "";
                            }

                            if (tileArray[row, column + 1].Tag != "mine")
                            {
                                tileArray[row, column + 1].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row, column + 1].Text = tileArray[row, column + 1].Tag + "";
                            }

                            if (tileArray[row + 1, column].Tag != "mine")
                            {
                                tileArray[row + 1, column].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row + 1, column].Text = tileArray[row + 1, column].Tag + "";
                            }

                            if (tileArray[row + 1, column - 1].Tag != "mine")
                            {
                                tileArray[row + 1, column - 1].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row + 1, column - 1].Text = tileArray[row + 1, column - 1].Tag + "";
                            }

                            if (tileArray[row + 1, column + 1].Tag != "mine")
                            {
                                tileArray[row + 1, column + 1].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row + 1, column + 1].Text = tileArray[row + 1, column + 1].Tag + "";
                            }
                        }

                        //bottom
                        if (row == rowLimit - 1 && column > 0 && column < columnLimit - 1)
                        {
                            if (tileArray[row, column - 1].Tag != "mine")
                            {
                                tileArray[row, column - 1].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row, column - 1].Text = tileArray[row, column - 1].Tag + "";
                            }

                            if (tileArray[row, column + 1].Tag != "mine")
                            {
                                tileArray[row, column + 1].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row, column + 1].Text = tileArray[row, column + 1].Tag + "";
                            }

                            if (tileArray[row - 1, column].Tag != "mine")
                            {
                                tileArray[row - 1, column].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row - 1, column].Text = tileArray[row - 1, column].Tag + "";
                            }

                            if (tileArray[row - 1, column - 1].Tag != "mine")
                            {
                                tileArray[row - 1, column - 1].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row - 1, column - 1].Text = tileArray[row - 1, column - 1].Tag + "";
                            }

                            if (tileArray[row - 1, column + 1].Tag != "mine")
                            {
                                tileArray[row - 1, column + 1].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row - 1, column + 1].Text = tileArray[row - 1, column + 1].Tag + "";
                            }
                        }

                        //right
                        if (column == columnLimit - 1 && row > 0 && row < rowLimit- 1)
                        {
                            if (tileArray[row - 1, column].Tag != "mine")
                            {
                                tileArray[row - 1, column].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row - 1, column].Text = tileArray[row - 1, column].Tag + "";
                            }

                            if (tileArray[row + 1, column].Tag != "mine")
                            {
                                tileArray[row + 1, column].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row + 1, column].Text = tileArray[row + 1, column].Tag + "";
                            }

                            if (tileArray[row, column - 1].Tag != "mine")
                            {
                                tileArray[row, column - 1].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row, column - 1].Text = tileArray[row, column - 1].Tag + "";
                            }

                            if (tileArray[row - 1, column - 1].Tag != "mine")
                            {
                                tileArray[row - 1, column - 1].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row - 1, column - 1].Text = tileArray[row - 1, column - 1].Tag + "";
                            }

                            if (tileArray[row + 1, column - 1].Tag != "mine")
                            {
                                tileArray[row + 1, column - 1].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row + 1, column - 1].Text = tileArray[row + 1, column - 1].Tag + "";
                            }
                        }

                        //left
                        if (column == 0 && row > 0 && row < rowLimit - 1)
                        {
                            if (tileArray[row - 1, column].Tag != "mine")
                            {
                                tileArray[row - 1, column].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row - 1, column].Text = tileArray[row - 1, column].Tag + "";
                            }

                            if (tileArray[row + 1, column].Tag != "mine")
                            {
                                tileArray[row + 1, column].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row + 1, column].Text = tileArray[row + 1, column].Tag + "";
                            }

                            if (tileArray[row, column + 1].Tag != "mine")
                            {
                                tileArray[row, column + 1].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row, column + 1].Text = tileArray[row, column + 1].Tag + "";
                            }

                            if (tileArray[row - 1, column + 1].Tag != "mine")
                            {
                                tileArray[row - 1, column + 1].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row - 1, column + 1].Text = tileArray[row - 1, column + 1].Tag + "";
                            }
                            if (tileArray[row + 1, column + 1].Tag != "mine")
                            {
                                tileArray[row + 1, column + 1].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row + 1, column + 1].Text = tileArray[row + 1, column + 1].Tag + "";
                            }
                        }

                        //center
                        if (row > 0 && row < rowLimit - 1 && column > 0 && column < columnLimit - 1)
                        {
                            if (tileArray[row - 1, column - 1].Tag != "mine")
                            {
                                tileArray[row - 1, column - 1].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row - 1, column - 1].Text = tileArray[row - 1, column - 1].Tag + "";
                            }

                            if (tileArray[row - 1, column].Tag != "mine")
                            {
                                tileArray[row - 1, column].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row - 1, column].Text = tileArray[row - 1, column].Tag + "";
                            }

                            if (tileArray[row - 1, column + 1].Tag != "mine")
                            {
                                tileArray[row - 1, column + 1].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row - 1, column + 1].Text = tileArray[row - 1, column + 1].Tag + "";
                            }

                            if (tileArray[row, column + 1].Tag != "mine")
                            {
                                tileArray[row, column + 1].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row, column + 1].Text = tileArray[row, column + 1].Tag + "";
                            }

                            if (tileArray[row + 1, column + 1].Tag != "mine")
                            {
                                tileArray[row + 1, column + 1].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row + 1, column + 1].Text = tileArray[row + 1, column + 1].Tag + "";
                            }

                            if (tileArray[row + 1, column].Tag != "mine")
                            {
                                tileArray[row + 1, column].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row + 1, column].Text = tileArray[row + 1, column].Tag + "";
                            }

                            if (tileArray[row + 1, column - 1].Tag != "mine")
                            {
                                tileArray[row + 1, column - 1].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row + 1, column].Text = tileArray[row + 1, column].Tag + "";
                            }

                            if (tileArray[row, column - 1].Tag != "mine")
                            {
                                tileArray[row, column - 1].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row + 1, column].Text = tileArray[row + 1, column].Tag + "";
                            }
                        }
                    }
                }
            }


            for (int row = rowLimit-1; row >= 0; row--)
            {
                for (int column = columnLimit-1; column >=0; column--)
                {
                    //corners
                    if (tileArray[row, column].Tag == "" && tileArray[row, column].BackColor == Color.FromArgb(140, 162, 255))
                    {
                        if (row == 0 && column == 0)
                        {
                            if (tileArray[row, column + 1].Tag != "mine")
                            {
                                tileArray[row, column + 1].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row, column + 1].Text = tileArray[row, column + 1].Tag + "";
                            }

                            if (tileArray[row + 1, column].Tag != "mine")
                            {
                                tileArray[row + 1, column].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row + 1, column].Text = tileArray[row + 1, column].Tag + "";
                            }

                            if (tileArray[row + 1, column + 1].Tag != "mine")
                            {
                                tileArray[row + 1, column + 1].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row + 1, column + 1].Text = tileArray[row + 1, column + 1].Tag + "";
                            }
                        }

                        if (row == 0 && column == columnLimit - 1)
                        {
                            if (tileArray[row, column - 1].Tag != "mine")
                            {
                                tileArray[row, column - 1].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row, column - 1].Text = tileArray[row, column - 1].Tag + "";
                            }

                            if (tileArray[row + 1, column - 1].Tag != "mine")
                            {
                                tileArray[row + 1, column - 1].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row + 1, column - 1].Text = tileArray[row + 1, column - 1].Tag + "";
                            }

                            if (tileArray[row + 1, column].Tag != "mine")
                            {
                                tileArray[row + 1, column].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row + 1, column].Text = tileArray[row + 1, column].Tag + "";
                            }
                        }

                        if (row == rowLimit - 1 && column == 0)
                        {
                            if (tileArray[row, column + 1].Tag != "mine")
                            {
                                tileArray[row, column + 1].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row, column + 1].Text = tileArray[row, column + 1].Tag + "";
                            }

                            if (tileArray[row - 1, column + 1].Tag != "mine")
                            {
                                tileArray[row - 1, column + 1].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row - 1, column + 1].Text = tileArray[row - 1, column + 1].Tag + "";
                            }

                            if (tileArray[row - 1, column].Tag != "mine")
                            {
                                tileArray[row - 1, column].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row - 1, column].Text = tileArray[row - 1, column].Tag + "";
                            }
                        }

                        if (row == rowLimit - 1 && column == columnLimit - 1)
                        {
                            if (tileArray[row, column - 1].Tag != "mine")
                            {
                                tileArray[row, column - 1].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row, column - 1].Text = tileArray[row, column - 1].Tag + "";
                            }

                            if (tileArray[row - 1, column - 1].Tag != "mine")
                            {
                                tileArray[row - 1, column - 1].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row - 1, column - 1].Text = tileArray[row - 1, column - 1].Tag + "";
                            }

                            if (tileArray[row - 1, column].Tag != "mine")
                            {
                                tileArray[row - 1, column].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row - 1, column].Text = tileArray[row - 1, column].Tag + "";
                            }
                        }

                        //top
                        if (row == 0 && column > 0 && column < columnLimit - 1)
                        {
                            if (tileArray[row, column - 1].Tag != "mine")
                            {
                                tileArray[row, column - 1].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row, column - 1].Text = tileArray[row, column - 1].Tag + "";
                            }

                            if (tileArray[row, column + 1].Tag != "mine")
                            {
                                tileArray[row, column + 1].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row, column + 1].Text = tileArray[row, column + 1].Tag + "";
                            }

                            if (tileArray[row + 1, column].Tag != "mine")
                            {
                                tileArray[row + 1, column].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row + 1, column].Text = tileArray[row + 1, column].Tag + "";
                            }

                            if (tileArray[row + 1, column - 1].Tag != "mine")
                            {
                                tileArray[row + 1, column - 1].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row + 1, column - 1].Text = tileArray[row + 1, column - 1].Tag + "";
                            }

                            if (tileArray[row + 1, column + 1].Tag != "mine")
                            {
                                tileArray[row + 1, column + 1].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row + 1, column + 1].Text = tileArray[row + 1, column + 1].Tag + "";
                            }
                        }

                        //bottom
                        if (row == rowLimit - 1 && column > 0 && column < columnLimit - 1)
                        {
                            if (tileArray[row, column - 1].Tag != "mine")
                            {
                                tileArray[row, column - 1].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row, column - 1].Text = tileArray[row, column - 1].Tag + "";
                            }

                            if (tileArray[row, column + 1].Tag != "mine")
                            {
                                tileArray[row, column + 1].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row, column + 1].Text = tileArray[row, column + 1].Tag + "";
                            }

                            if (tileArray[row - 1, column].Tag != "mine")
                            {
                                tileArray[row - 1, column].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row - 1, column].Text = tileArray[row - 1, column].Tag + "";
                            }

                            if (tileArray[row - 1, column - 1].Tag != "mine")
                            {
                                tileArray[row - 1, column - 1].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row - 1, column - 1].Text = tileArray[row - 1, column - 1].Tag + "";
                            }

                            if (tileArray[row - 1, column + 1].Tag != "mine")
                            {
                                tileArray[row - 1, column + 1].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row - 1, column + 1].Text = tileArray[row - 1, column + 1].Tag + "";
                            }
                        }

                        //right
                        if (column == columnLimit - 1 && row > 0 && row < rowLimit - 1)
                        {
                            if (tileArray[row - 1, column].Tag != "mine")
                            {
                                tileArray[row - 1, column].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row - 1, column].Text = tileArray[row - 1, column].Tag + "";
                            }

                            if (tileArray[row + 1, column].Tag != "mine")
                            {
                                tileArray[row + 1, column].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row + 1, column].Text = tileArray[row + 1, column].Tag + "";
                            }

                            if (tileArray[row, column - 1].Tag != "mine")
                            {
                                tileArray[row, column - 1].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row, column - 1].Text = tileArray[row, column - 1].Tag + "";
                            }

                            if (tileArray[row - 1, column - 1].Tag != "mine")
                            {
                                tileArray[row - 1, column - 1].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row - 1, column - 1].Text = tileArray[row - 1, column - 1].Tag + "";
                            }

                            if (tileArray[row + 1, column - 1].Tag != "mine")
                            {
                                tileArray[row + 1, column - 1].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row + 1, column - 1].Text = tileArray[row + 1, column - 1].Tag + "";
                            }
                        }

                        //left
                        if (column == 0 && row > 0 && row < rowLimit - 1)
                        {
                            if (tileArray[row - 1, column].Tag != "mine")
                            {
                                tileArray[row - 1, column].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row - 1, column].Text = tileArray[row - 1, column].Tag + "";
                            }

                            if (tileArray[row + 1, column].Tag != "mine")
                            {
                                tileArray[row + 1, column].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row + 1, column].Text = tileArray[row + 1, column].Tag + "";
                            }

                            if (tileArray[row, column + 1].Tag != "mine")
                            {
                                tileArray[row, column + 1].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row, column + 1].Text = tileArray[row, column + 1].Tag + "";
                            }

                            if (tileArray[row - 1, column + 1].Tag != "mine")
                            {
                                tileArray[row - 1, column + 1].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row - 1, column + 1].Text = tileArray[row - 1, column + 1].Tag + "";
                            }

                            if (tileArray[row + 1, column + 1].Tag != "mine")
                            {
                                tileArray[row + 1, column + 1].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row + 1, column + 1].Text = tileArray[row + 1, column + 1].Tag + "";
                            }
                        }

                        //center
                        if (row > 0 && row < rowLimit - 1 && column > 0 && column < columnLimit - 1)
                        {
                            if (tileArray[row - 1, column - 1].Tag != "mine")
                            {
                                tileArray[row - 1, column - 1].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row - 1, column - 1].Text = tileArray[row - 1, column - 1].Tag + "";
                            }

                            if (tileArray[row - 1, column].Tag != "mine")
                            {
                                tileArray[row - 1, column].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row - 1, column].Text = tileArray[row - 1, column].Tag + "";
                            }

                            if (tileArray[row - 1, column + 1].Tag != "mine")
                            {
                                tileArray[row - 1, column + 1].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row - 1, column + 1].Text = tileArray[row - 1, column + 1].Tag + "";
                            }

                            if (tileArray[row, column + 1].Tag != "mine")
                            {
                                tileArray[row, column + 1].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row, column + 1].Text = tileArray[row, column + 1].Tag + "";
                            }

                            if (tileArray[row + 1, column + 1].Tag != "mine")
                            {
                                tileArray[row + 1, column + 1].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row + 1, column + 1].Text = tileArray[row + 1, column + 1].Tag + "";
                            }

                            if (tileArray[row + 1, column].Tag != "mine")
                            {
                                tileArray[row + 1, column].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row + 1, column].Text = tileArray[row + 1, column].Tag + "";
                            }

                            if (tileArray[row + 1, column - 1].Tag != "mine")
                            {
                                tileArray[row + 1, column - 1].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row + 1, column].Text = tileArray[row + 1, column].Tag + "";
                            }

                            if (tileArray[row, column - 1].Tag != "mine")
                            {
                                tileArray[row, column - 1].BackColor = Color.FromArgb(140, 162, 255);
                                tileArray[row + 1, column].Text = tileArray[row + 1, column].Tag + "";
                            }
                        }
                    }
                }
            }
        }
        //spaces

        private string add_image_mine_path_function()
        {
            int locationLength = Directory.GetCurrentDirectory().Length - 9;
            string fileLocation = Directory.GetCurrentDirectory().Substring(0, locationLength);
            return fileLocation += $@"Resources\mine.png";
        }
        
        private void show_mines_function()
        {
            soundEffect.play_sound_effect_when_winning_or_losing_method(true);
            foreach (var tile in tileArray.OfType<Button>())
            {
                if (tile.Tag == "mine")
                {
                    tile.Image = Image.FromFile(add_image_mine_path_function());
                    tile.BackgroundImageLayout = ImageLayout.Tile;
                    tile.BackColor = Color.BlueViolet; ;
                    //mineBtn.Enabled = false;                
                }
            }
        }

        public void remove_mines_method()
        {
            var tile_container = tileArray[0, 0].Parent;
            //MessageBox.Show(mine_container.GetType().ToString());
            foreach (var tile in tile_container.Controls.OfType<Button>().OrderBy(x=>x.TabIndex))
            {
                tile_container.Controls.Remove(tile);
            }
        }

        public bool check_if_all_tiles_were_clicked_method()
        {
            var tile_container = tileArray[0, 0].Parent;
            int nUnminedTile = (rowLimit * columnLimit) - nMine;
            int nClickedTile = 0;

            foreach (var tile in tile_container.Controls.OfType<Button>().OrderBy(x => x.TabIndex))
            {
                if (tile.BackColor == Color.FromArgb(140, 162, 255)) nClickedTile++;

            }

            return (nUnminedTile == nClickedTile)? true: false;
        }


    }
}
