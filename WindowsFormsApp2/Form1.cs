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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tiedostoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void testaaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Toiminolisuus_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ohjelman tekijän: Nikita Ivanov");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime date1 = new DateTime();
            date1 = DateTime.Now;
            this.textBox1.Text = "1";
            this.textBox2.Text = "Syötä elokuvan nimi";
            this.textBox3.Text = Convert.ToString(date1.Year);
            this.textBox4.Text = "";
            this.richTextBox1.Text = "";
           
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void poistuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime date1 = new DateTime();
            date1 = DateTime.Now;
            if (this.textBox2.Text == "")
            {
                this.textBox2.Text = "Syötä elokuvan nimi";
            }
            if (this.textBox3.Text == "")
            {
                this.textBox3.Text = Convert.ToString(date1.Year);
            }
            Application.Exit();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
 
                
                if (this.textBox2.Text == "Syötä elokuvan nimi")
                {
                    this.textBox2.Text = "";
                }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Check=this.textBox3.Text;
            string Check2 = this.textBox4.Text;
            bool CheckOk = true;
            IsDigitsOnly(Check);
            IsDigitsOnly(Check2);
            string IsDigitsOnly(string str)
            {
                
                bool showText = false;
                foreach (char c in str)
                {
                    if (c < '0' || c > '9')
                    {
                        showText = true;
                        CheckOk = false;
                    }



                }
                if (showText == true)
                {
                    if (str == Check && showText == true)
                    {
                        MessageBox.Show("Julkaisvuosi ei ole oikein. Vain Numerot");
                        showText = false;
                        Check = "";

                    }
                    if (str == Check2 && showText == true)
                    {
                        MessageBox.Show("Kesto ei ole oikein. Vain Numerot");
                        showText = false;
                    }


                    
                }
                return str;

            }
            if (this.textBox3.Text == "")
            {
                MessageBox.Show("Julkaisvuosi ei ole oikein. Ei saa tyhjäksi");
                CheckOk = false;
            }
            if (this.textBox4.Text == "")
            {
                MessageBox.Show("Kesto ei ole oikein. Ei saa tyhjäksi");
                CheckOk = false;
            }
            if (CheckOk == true)
            {
                MessageBox.Show("Check OK!");
            }
            
        }
    }
}

