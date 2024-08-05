using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Porje_Odev
{
    public partial class Form1 : Form
    {
        bool isGasOpen = false;
        int sayac = 0;
        


        public Form1()
        {
            InitializeComponent();
            engel.Visible = false;
         
            engel2.Visible = false;
            engel3.Visible = false;

        }

        private void gase_MouseEnter(object sender, EventArgs e)
        {
            isGasOpen = true;
        }

        private void brake_MouseEnter(object sender, EventArgs e)
        {
            isGasOpen = false;
        }




        private void timer1_Tick(object sender, EventArgs e)
        {
           

            if (isGasOpen )
                
              {
                sayac++;
                puan.Text = sayac.ToString();
                

                if (sayac > 10)
                {
                    // ENGEL GÖRÜNÜRLÜK
                    engel.Visible = true;
                    // ENGEL KONUMU
                    engel.Location = new Point(engel.Location.X, engel.Location.Y+1);

                    if (engel.Location.Y + 75 == carPanel.Location.Y && engel.Location.X == carPanel.Location.X)  
                    {
                        isGasOpen = false;
                        MessageBox.Show("Kaybettiniz. \n SKOR:" + sayac);
                        
                    }
                  


                }
                if(sayac > 85){
                    engel2.Visible = true;
                    engel2.Location = new Point(engel2.Location.X, engel2.Location.Y + 1);
                    if (engel2.Location.Y + 75 == carPanel.Location.Y && engel2.Location.X == carPanel.Location.X)
                    {
                        isGasOpen = false;
                        MessageBox.Show("Kaybettiniz. \n SKOR:" + sayac);
                        
                    }

                }
                if (sayac > 117)
                {
                    engel3.Visible = true;
                    engel3.Location = new Point(engel3.Location.X, engel3.Location.Y + 1);
                    if (engel3.Location.Y + 75 == carPanel.Location.Y && engel3.Location.X == carPanel.Location.X)
                    {
                        isGasOpen = false;
                        MessageBox.Show("Kaybettiniz. \n SKOR:" +  sayac );
                        
                        
                    }

                }



                // yolda olan şeritlerin hareketini sağlayan kodlar

                panel80.Location = new Point(panel80.Location.X, panel80.Location.Y + 1);
                  panel81.Location = new Point(panel81.Location.X, panel81.Location.Y + 1);
                  panel82.Location = new Point(panel82.Location.X, panel82.Location.Y + 1);  
                  panel83.Location = new Point(panel83.Location.X, panel83.Location.Y + 1);
                  panel84.Location = new Point(panel84.Location.X, panel84.Location.Y + 1);
                  panel85.Location = new Point(panel85.Location.X, panel85.Location.Y + 1);
                  panel86.Location = new Point(panel86.Location.X, panel86.Location.Y + 1);
                  panel87.Location = new Point(panel87.Location.X, panel87.Location.Y + 1);
                  panel88.Location = new Point(panel88.Location.X, panel88.Location.Y + 1);
                  panel89.Location = new Point(panel89.Location.X, panel89.Location.Y + 1);
                  panel90.Location = new Point(panel90.Location.X, panel90.Location.Y + 1);
                  panel91.Location = new Point(panel91.Location.X, panel91.Location.Y + 1);

                  if(panel85.Location.Y > 504)
                  {
                      panel85.Location = new Point(panel85.Location.X, 484);
                      panel91.Location = new Point(panel91.Location.X, 484 );
                  }

                  if (panel84.Location.Y > 410)
                  {
                      panel84.Location = new Point(panel84.Location.X, 390);
                      panel90.Location = new Point(panel90.Location.X, 390 );
                  }
                  if (panel83.Location.Y > 312)
                  {
                      panel83.Location = new Point(panel83.Location.X, 292);
                      panel89.Location = new Point(panel89.Location.X, 292 );
                  }
                  if (panel82.Location.Y > 217)
                  {
                      panel82.Location = new Point(panel82.Location.X, 197 );
                      panel88.Location = new Point(panel88.Location.X, 197);
                  }
                  if (panel81.Location.Y > 120)
                  {
                      panel81.Location = new Point(panel81.Location.X, 100);
                      panel87.Location = new Point(panel87.Location.X, 100 );
                  }
                  if (panel80.Location.Y > 30)
                  {
                      panel80.Location = new Point(panel80.Location.X, 10);
                      panel86.Location = new Point(panel86.Location.X, 10);

                  }




              } 

            



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // sağ sol tuş butonlar 
        private void button1_Click(object sender, EventArgs e)
        {
          if(carPanel.Location.X == engel.Location.X)
            {
                carPanel.Location = new Point(engel3.Location.X, carPanel.Location.Y);
            }
          if(carPanel.Location.X == engel2.Location.X)
            {
                carPanel.Location = new Point(engel.Location.X, carPanel.Location.Y);
            }
          
       

        }

        private void button2_Click(object sender, EventArgs e)
        {
           if(carPanel.Location.X == engel.Location.X)
            {
                carPanel.Location = new Point(engel2.Location.X, carPanel.Location.Y);
            }
            if (carPanel.Location.X == engel3.Location.X)
            {
                carPanel.Location = new Point(engel.Location.X, carPanel.Location.Y);
            }

        }

    }
}
