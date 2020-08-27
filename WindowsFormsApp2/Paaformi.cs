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
    public partial class Paaformi : Form
    {
        int[] Taulukko = new int[0];
        int[] Loto = new int[10];
        public Paaformi()
        {
            InitializeComponent();
  

        }
        private void ButtonClick(object sender, EventArgs e)

        {

            Button painettuNappi = sender as Button;
            int Switch = painettuNappi.TabIndex;
            switch (Switch)
            {
                case 0:
                    MessageBox.Show("1");
                    break;
                case 1:
                    MessageBox.Show("2");
                    break;
                case 2:
                    MessageBox.Show("3");
                    break;
                case 3:
                    MessageBox.Show("4");
                    break;
                default:
                    MessageBox.Show("Default");
                    break;
                
            }
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            int Numero=0;
            this.button5.Enabled = false;
            bool Go = true;
            IsDigitsOnly1(this.textBox1.Text);
            string IsDigitsOnly1(string str)
            {

                bool showText = false;
                foreach (char c in str)
                {
                    if (c < '0' || c > '9')
                    {
                        showText = true;
                        Go = false;
                        
                    }

                    

                }
                if (showText == true)
                {
                    MessageBox.Show("Vain numerot");
                    showText = false;
                }
                return str;
            }
            if (this.textBox1.Text == "")
            {
                Go = false;
            }
            if (Go == true)
            {
                int B;
                B=Convert.ToInt32(this.textBox1.Text);
                for (Numero = 0; Numero <= B; Numero++)
                {
                    
                    await Task.Delay(500);
                    
                    this.label1.Text = Convert.ToString(Numero);
                }
            }
            this.button5.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int I = 0;
            I = Convert.ToInt32(this.TaulukkoKokoBox.Text);

            Array.Resize(ref this.Taulukko, I + 1);
            this.TaulukkoKokoBox.ReadOnly = true;
            this.LuoTaulukko2.Enabled = false;
        }

        private void startwhile_Click(object sender, EventArgs e)
        {
            bool while2= true;
            
            while (while2)
            {
                if(MessageBox.Show("Haluatko jatka?", "Huom!", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    while2 = false;
                }
            }
        }

        private void LuoTaulukko_Click(object sender, EventArgs e)
        {
           
            Button painettuNappi = sender as Button;
            int Switch = painettuNappi.TabIndex;
            bool Case1true = false;
            
            

            switch (Switch)
            {
                case 2:
                   
                        int Indeksi;
                    int Numero = 1;
                    Numero = Convert.ToInt32(this.TallenusNumero.Text);
                    Indeksi = Convert.ToInt32(this.TallenusIndeksi.Text);
                    this.Taulukko[Indeksi] = Numero;
                        
                    
                    break;
                case 3:
                    int Indeks;
                    int Hae;
                    Indeks = Convert.ToInt32(this.textBox5.Text);
                    Hae = this.Taulukko[Indeks];
                    this.textBox6.Text = Convert.ToString(Hae);
                    break;
            }

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            var rand = new Random();
            int RandomNumero = 0;
            for (int i = 0; i < 10; i++)
            {
                RandomNumero= rand.Next(1, 41);
                this.Loto[i] = RandomNumero;
              

            }
        }
    }
    //foreach(int check in this.Loto.Distinct())
    // {
    //     string check2 = Convert.ToString(check);
    //    this.textBox10.Text = this.textBox10.Text+check2;
    // }
}
