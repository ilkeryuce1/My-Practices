using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Asal_Sayı_Kontrolü_Form
{
    public partial class Form1 : Form
    {
 
        double ciro = 0;
        double satıs = 0;
        double komisyon = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox_Ev_K_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Ev_K.Checked)
            {
                textBox1.Text = "";
                panel1.Visible = true;
                label2.Text = "Ev Kiralama";
                checkBox_Arsa_S.Visible = false;
                checkBox_Ev_s.Visible = false;
                checkBox_Arsa_K.Visible = false;
                komisyon = 2;

            }
            else
            {
                panel1.Visible = false;
                checkBox_Arsa_S.Visible = true;
                checkBox_Ev_s.Visible = true;
                checkBox_Arsa_K.Visible = true;
            }

        }

        private void checkBox_Arsa_K_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Arsa_K.Checked)
            {
                textBox1.Text = "";
                panel1.Visible = true;
                label2.Text = "Arsa Kiralama";
                checkBox_Arsa_S.Visible = false;
                checkBox_Ev_s.Visible = false;
                checkBox_Ev_K.Visible = false;
                komisyon = 3;
            }
            else
            {
                panel1.Visible = false;
                checkBox_Arsa_S.Visible = true;
                checkBox_Ev_s.Visible = true;
                checkBox_Ev_K.Visible = true;
            }
        }

        private void checkBox_Ev_s_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Ev_s.Checked)
            {
                textBox1.Text = "";
                panel1.Visible = true;
                label2.Text = "Ev Satışı";

                checkBox_Ev_K.Visible = false;
                checkBox_Arsa_S.Visible = false;
                checkBox_Arsa_K.Visible = false;
                komisyon = 4;


            }
            else
            {
                panel1.Visible = false;
                checkBox_Ev_K.Visible = true;
                checkBox_Arsa_S.Visible = true;
                checkBox_Arsa_K.Visible = true;
            }
        }

        private void checkBox_Arsa_S_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Arsa_S.Checked)
            {
                textBox1.Text = "";
                panel1.Visible = true;
                label2.Text = "Arsa Satışı";
                checkBox_Ev_K.Visible = false;
                checkBox_Ev_s.Visible = false;
                checkBox_Arsa_K.Visible = false;
                komisyon = 5;


            }
            else
            {
                panel1.Visible = false;
                checkBox_Ev_K.Visible = true;
                checkBox_Ev_s.Visible = true;
                checkBox_Arsa_K.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double satıs = double.Parse(textBox1.Text);
            double total = satıs - (satıs * komisyon / 100); // sahıbe gececek para
            label3.Text = ($"Emlakcının Alacağı Komisyon : {(satıs * komisyon / 100)} TL \nÖdenecek toplam tutar : {satıs} TL\nGayrimenkul sahibine verilecek para : {total} TL");

            ciro += (satıs * komisyon / 100);
            textBox1.Text = "";
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
