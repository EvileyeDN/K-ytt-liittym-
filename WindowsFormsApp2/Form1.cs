using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }


        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ohjelman tekijän: Nikita Ivanov");
        }


        private void UssiTietue_Button_Click(object sender, EventArgs e)
        {
            DateTime date1 = new DateTime();
            date1 = DateTime.Now;
            this.IdTextBox.Text = "1";
            this.NimiTextBox.Text = "Syötä elokuvan nimi";
            this.VuosiTextBox.Text = Convert.ToString(date1.Year);
            this.KestoTextBox.Text = "";
            this.ArvioRichtexBox.Text = "";
           
        }

        private void poistuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime date1 = new DateTime();
            date1 = DateTime.Now;
            if (this.NimiTextBox.Text == "")
            {
                this.NimiTextBox.Text = "Syötä elokuvan nimi";
            }
            if (this.VuosiTextBox.Text == "")
            {
                this.VuosiTextBox.Text = Convert.ToString(date1.Year);
            }
            Application.Exit();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
 
                
                if (this.NimiTextBox.Text == "Syötä elokuvan nimi")
                {
                    this.NimiTextBox.Text = "";
                }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string check=this.VuosiTextBox.Text;
            string check2 = this.KestoTextBox.Text;
            bool checkok = true;
            IsDigitsOnly(check);
            IsDigitsOnly(check2);
            string IsDigitsOnly(string str)
            {
                
                bool showText = false;
                foreach (char c in str)
                {
                    if (c < '0' || c > '9')
                    {
                        showText = true;
                        checkok = false;
                    }



                }
                if (showText == true)
                {
                    if (str == check && showText == true)
                    {
                        MessageBox.Show("Julkaisvuosi ei ole oikein. Vain Numerot");
                        showText = false;
                        check = "";

                    }
                    if (str == check2 && showText == true)
                    {
                        MessageBox.Show("Kesto ei ole oikein. Vain Numerot");
                        showText = false;
                    }


                    
                }
                return str;

            }
            if (this.VuosiTextBox.Text == "")
            {
                MessageBox.Show("Julkaisvuosi ei ole oikein. Ei saa tyhjäksi");
                checkok = false;
            }
            if (this.KestoTextBox.Text == "")
            {
                MessageBox.Show("Kesto ei ole oikein. Ei saa tyhjäksi");
                checkok = false;
            }
            if (checkok == true)
            {
                MessageBox.Show("Check OK!");
            }
            
        }
    }
}

