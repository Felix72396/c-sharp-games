using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Panel[,] cas = new Panel[100, 100];
        Label[,] num = new Label[100, 100];
        
        int prc=0,i, j, px = 5, py = 5,c=0,cas1,cas2,tag1,tag2,n1=0,n2=0,n3=0,n4=0,n5=0,cantcas=100;

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(sec == 15)
            {
                timer2.Stop();
                foreach (var pnl in this.Controls.OfType<Panel>())
                {
                    if (pnl.Tag != "square") continue;
                    pnl.Enabled = true;
                    pnl.BackColor = Color.Black;

                    foreach(var lbl in pnl.Controls.OfType<Label>())
                    {
                        lbl.Visible = false;
                    }
                }
            }
            sec++;

        }

        int sec = 0;
        bool busy = false;

        private void Clickcas(object sender, EventArgs e)
        {
            c++;

            if (c < 3)
            {
                if (busy == false)
                {
                    Panel a = (Panel)sender;


                    if (a.BackColor == Color.Black | a.BackColor == Color.Yellow)
                    {
                        a.BackColor = Color.Blue;


                        foreach (var b in a.Controls)
                        {
                            if (b is Label)
                            {
                                ((Label)b).Visible = true;
                                if (c == 1)
                                {
                                    cas1 = int.Parse(((Label)b).Text);
                                    tag1 = ((Label)b).TabIndex;
                                }
                                else
                                {
                                    cas2 = int.Parse(((Label)b).Text);
                                    tag2 = ((Label)b).TabIndex;
                                }
                            }
                        }


                    }
                    else
                    {
                        a.BackColor = Color.Black;
                    }
                }
            }
               
            
            
             if(c==2)
            {
                timer1.Enabled = true;
                busy = true;
                c = 0;
            }
            
        }

        private void Overcas(object sender, EventArgs e)
        {


            Panel b = (Panel)sender;
            if (b.BackColor == Color.Black)
            {
                b.BackColor = Color.Yellow;
            }


        }

        private void Leavecas(object sender, EventArgs e)
        {

            foreach (var c in Controls)
            {
                if (c is Panel )
                {
                    if (((Panel)c).BackColor == Color.Yellow)
                    {
                       ( (Panel)c).BackColor = Color.Black;
                    }
                }
            }
           


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Random azar=new Random();
            label2.Text = cantcas+"";
            int tag=0,ncas=0;
            bool asignado = false;
            for (i = 1; i <= 10; i++)
            {
                px = 5;
                for (j = 1; j <= 10; j++)
                {
                    tag++;
                    cas[i, j] = new Panel();
                    cas[i, j].Width = 50;
                    cas[i, j].Height = 50;
                    cas[i, j].TabIndex = tag;
                    cas[i, j].BackColor = Color.Black;
                    cas[i, j].Location = new Point(px, py);
                    cas[i, j].Click += new EventHandler(Clickcas);
                    cas[i, j].MouseHover += new EventHandler(Overcas);
                    cas[i, j].MouseLeave += new EventHandler(Leavecas);
                    cas[i, j].Tag = "square";
                    px += 52;
                    this.Controls.Add(cas[i, j]);

                   num[i, j] = new Label();
                   asignado = false;
                   while (asignado == false)
                   {                  
                           ncas = azar.Next(1, 6);
                           if (ncas == 1)
                           {
                               if (n1 != 20)
                               {
                               n1++;
                               asignado = true;
                               }
                           }
                           if (ncas == 2)
                           {
                               if (n2 != 20)
                               {
                                   n2++;
                                   asignado = true;
                               }
                           }
                           if (ncas == 3)
                           {
                               if (n3 != 20)
                               {
                                   n3++;
                                   asignado = true;
                               }
                           }
                           if (ncas == 4)
                           {
                               if (n4 != 20)
                               {
                                   n4++;
                                   asignado = true;
                               }
                           }
                           if (ncas == 5)
                           {
                               if (n5 != 20)
                               {
                                   n5++;
                                   asignado = true;
                               }
                           }           
                   }


                   num[i, j].Text = ncas.ToString();
                   num[i, j].Width = 20;
                   num[i, j].Height = 27;
                   num[i, j].TabIndex = tag;
                   num[i, j].Font = new Font("", 20f, FontStyle.Bold);
                  
                   num[i, j].ForeColor = Color.Orange;
                   num[i, j].Location = new Point(11, 8);
                  
                   num[i, j].Visible = false;
                   cas[i,j].Controls.Add(num[i, j]);
                }
                py += 52;
            }

            showNumbers();
        }

        private void showNumbers()
        {
            foreach(var pnl in this.Controls.OfType<Panel>())
            {
                if (pnl.Tag != "square") continue;
                pnl.BackColor = Color.Blue;
                foreach (var lbl in pnl.Controls.OfType<Label>())
                {
                    lbl.Visible = true;
                    
                    pnl.Enabled = false;
                }
            }
            sec = 0;

            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int c2 = 0;
            busy = true;
            c = 0;
            foreach (var p in Controls)
            {
                if (p is Panel & p != panel1 )
                {
                    if (((Panel)p).BackColor != Color.Gray)
                    {
                        ((Panel)p).BackColor = Color.Black;
                    }

                    if (cas1 == cas2)
                    {
                        if (((Panel)p).TabIndex == tag1 || ((Panel)p).TabIndex == tag2)
                        {
                            c2++;
                            ((Panel)p).BackColor = Color.Gray;
                            ((Panel)p).Enabled = false;
                        
                            if (cantcas > 0)
                            {
                                cantcas--;
                                label2.Text = cantcas + "";
                                prc++;
                                progressBar1.Value = prc;
                                label3.Text = $"PORCENTAJE {prc}%";
                                //progressBar1.Increment(prc);
                            }          
                        }
                    }

                    foreach (var o in ((Panel)p).Controls)
                    {
                        if (o is Label)
                        {
                            ((Label)o).Visible = false;
                        }
                    }
                }
            }


            
            if (cantcas == 0)
            {
                label2.Left = 40;
            }
                           
                            if (cantcas>9 & cantcas < 100)
                            {

                                label2.Left = 30;
                            }
                            else if (cantcas>0 & cantcas < 10)
                            {
                               
                                label2.Left = 38;
                            }
                        
                 

            ///para resolver un error me quede en esto

           // foreach (var o in Controls)
          //  {

          //      if (o is Panel & o != panel1)
             //   {
              //      if (c2 != 2)
              //      {

              //          if (((Panel)o).TabIndex == tag1 | ((Panel)o).TabIndex == tag2)
                   //     {

                 //           ((Panel)o).BackColor = Color.Black;
                      //      ((Panel)o).Enabled = true;

                   //     }
                 //   }
            //    }

        //    }

                           
            if (prc == 100)
            {


              
                cantcas = 100;
                prc = 0;
                label2.Text = cantcas + "";
                label3.Text = "PORCENTAJE " + prc + "%";
                tag1 = 0;
                tag2 = 0;

                if (cantcas == 100)
                {

                    label2.Left = 15;

                }
                MessageBox.Show("¡Juego terminado!");
               

                foreach (var p in Controls)
                {

                    if (p is Panel & p!=panel1)
                    {
                       
                        ((Panel)p).Enabled = true;
                        ((Panel)p).BackColor=Color.Black;
                      
                    }

                }

                showNumbers();
            }

            
            timer1.Enabled = false;
            busy = false;

            cas1 = 0;
            cas2 = -1;
            tag1 = 0;
            tag2 = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
          
        }
        
       
    }
}

