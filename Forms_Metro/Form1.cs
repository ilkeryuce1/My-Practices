using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_Metro
{
    public partial class Form1 : Form
    {

        Random random = new Random();
       

        public Form1()
        {
            InitializeComponent();
        }
        int a = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x = random.Next(255);
            int y = random.Next(255);
            int z = random.Next(255);


            
            a++;
            label6.Text = a.ToString();
            #region gidis
            if (a < 23)
            {
                pictureBox1.Left += 5;

            }
            if (a >= 23 && a <= 43)
            {
                label1.BackColor = Color.FromArgb(x, y, z);
            }
            else if (a > 43 && a < 67)
            {
                label1.BackColor = Color.Transparent;
                pictureBox1.Left += 5;
            }

            else if (a >= 67 && a <= 77)
            {
                label2.BackColor = Color.FromArgb(x, y, z);
            }

            else if (a > 77 && a < 105
                )
            {
                label2.BackColor = Color.Transparent;
                pictureBox1.Left += 5;
            }

            else if (a >= 105 && a <= 130)
            {
                label3.BackColor = Color.FromArgb(x, y, z);
            }

            else if (a > 130 && a < 160)
            {
                label3.BackColor = Color.Transparent;
                pictureBox1.Left += 5;
            }

            else if (a >= 160 && a < 180)
            {
                label4.BackColor = Color.FromArgb(x, y, z);
            }

            else if (a == 180)
            {
                label4.BackColor = Color.Transparent;
                timer1.Stop();
            }
            #endregion

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            timer1.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int x = random.Next(255);
            int y = random.Next(255);
            int z = random.Next(255);
            a--;
            
            if (a >= 180)
            {
                pictureBox1.Left -= 5;
               
            }
            else if (a < 180 && a >= 160)
            {
                label4.BackColor = Color.FromArgb(x, y, z);
            }
            else if (a > 130 && a < 160)
            {
                label4.BackColor = Color.Transparent;
                pictureBox1.Left -= 5;
            }
            else if (a >= 105 && a <= 130)
            {
                label3.BackColor = Color.FromArgb(x, y, z);
            }
            else if (a > 77 && a < 105
              )
            {
                label3.BackColor = Color.Transparent;
                pictureBox1.Left -= 5;
            }
            else if (a >= 67 && a <= 77)
            {
                label2.BackColor = Color.FromArgb(x, y, z);
            }
            else if (a > 43 && a < 67)
            {
                label2.BackColor = Color.Transparent;
                pictureBox1.Left -= 5;
            }
            if (a >= 23 && a <= 43)
            {
                label1.BackColor = Color.FromArgb(x, y, z);
            }

            if (a < 23)
            {
                pictureBox1.Left -= 5;
                label1.BackColor = Color.Transparent;

            }
            if (a==0)
            {
                timer2.Stop();
            }
           
           

            

           

            
            //if (a < 23)
            //{
            //    pictureBox1.Left -= 5;

            //}
            //if (a >= 23 && a <= 43)
            //{
            //    label1.BackColor = Color.FromArgb(x, y, z);
            //}
            //else if (a > 43 && a < 67)
            //{
            //    label1.BackColor = Color.Transparent;
            //    pictureBox1.Left -= 5;
            //}

            //else if (a >= 67 && a <= 77)
            //{
            //    label2.BackColor = Color.FromArgb(x, y, z);
            //}

            //else if (a > 77 && a < 105
            //    )
            //{
            //    label2.BackColor = Color.Transparent;
            //    pictureBox1.Left -= 5;
            //}

            //else if (a >= 105 && a <= 130)
            //{
            //    label3.BackColor = Color.FromArgb(x, y, z);
            //}

            //else if (a > 130 && a < 160)
            //{
            //    label3.BackColor = Color.Transparent;
            //    pictureBox1.Left -= 5;
            //}
        }
    }
}
