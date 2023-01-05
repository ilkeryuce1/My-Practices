using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Form_Carpım_Tablosu
{
    public partial class Çarpım_Tabl : Form
    {
        int a = 0;
        ListBox listBox;
        public Çarpım_Tabl()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            string secim;
            int a = 0;
             a = int.Parse(textBox1.Text);


           
            if (a > 10 || a < 1)
                {
                    MessageBox.Show("1 ile 10 arasında bir sayı giriniz");

                }
                else
                {
              
               

                for (int i = 0; i < a; i++)
                    {


                        listBox = new ListBox();
                    
                        listBox.Location = new Point(80 * i, 150);
                        listBox.Size = new Size(80, 150);
                        listBox.Name = i.ToString();
                        this.Controls.Add(listBox);

                 


                    for (int k = 1; k <= 10; k++)
                        {

                            listBox.Items.Add($"{i + 1}x{k} = {(i + 1) * k}");

                        }
                    }


                }
           

            



            
           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
               
            
        }
    }
}
