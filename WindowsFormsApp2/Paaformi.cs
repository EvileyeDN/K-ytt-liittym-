using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp2
{
    public partial class Paaformi : Form
    {
        int[] taulukko = new int[0];
        int[] loto = new int[10];
        List<String> stringList = new List<string>();
        Dictionary<string, string> newDictionary = new Dictionary<string, string>();
        public Paaformi()
        {
            InitializeComponent();
  

        }
        private void ButtonClick(object sender, EventArgs e)

        {

            Button painettuNappi = sender as Button;
            int switch1 = painettuNappi.TabIndex;
            switch (switch1)
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

        private async void StartrButton_Click(object sender, EventArgs e)
        {
            int numero=0;
            this.StartButton.Enabled = false;
            bool go = true;
            IsDigitsOnly1(this.TimetTexBox.Text);
            string IsDigitsOnly1(string str)
            {

                bool showText = false;
                foreach (char c in str)
                {
                    if (c < '0' || c > '9')
                    {
                        showText = true;
                        go = false;
                        
                    }

                    

                }
                if (showText == true)
                {
                    MessageBox.Show("Vain numerot");
                    showText = false;
                }
                return str;
            }
            if (this.TimetTexBox.Text == "")
            {
                go = false;
            }
            if (go == true)
            {
                int B;
                B=Convert.ToInt32(this.TimetTexBox.Text);
                for (numero = 0; numero <= B; numero++)
                {
                    
                    await Task.Delay(500);
                    
                    this.TimerLabel.Text = Convert.ToString(numero);
                }
            }
            this.StartButton.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int i = 0;
            i = Convert.ToInt32(this.TaulukkoKokoBox.Text);

            Array.Resize(ref this.taulukko, i + 1);
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

            
            

            switch (Switch)
            {
                case 2:
                   
                        int Indeksi;
                    int Numero = 1;
                    Numero = Convert.ToInt32(this.TallenusNumero.Text);
                    Indeksi = Convert.ToInt32(this.TallenusIndeksi.Text);
                    this.taulukko[Indeksi] = Numero;
                        
                    
                    break;
                case 3:
                    int Indeks;
                    int Hae;
                    Indeks = Convert.ToInt32(this.textBox5.Text);
                    Hae = this.taulukko[Indeks];
                    this.textBox6.Text = Convert.ToString(Hae);
                    break;
            }

        }

        private void Lotto_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            int RandomNumero = 0;
            for (int i = 0; i < 10; i++)
            {
                again:
                RandomNumero= rand.Next(1, 41);
                if (this.loto.Contains(RandomNumero))
                {
                    goto again;
                }
                this.loto[i] = RandomNumero;
            }
            this.Lotto0.Text = Convert.ToString(loto[0]);
            this.Lotto1.Text = Convert.ToString(loto[1]);
            this.Lotto2.Text = Convert.ToString(loto[2]);
            this.Lotto3.Text = Convert.ToString(loto[3]);
            this.Lotto4.Text = Convert.ToString(loto[4]);
            this.Lotto5.Text = Convert.ToString(loto[5]);
            this.Lotto6.Text = Convert.ToString(loto[6]);
            this.Lotto7.Text = Convert.ToString(loto[7]);
            this.Lotto8.Text = Convert.ToString(loto[8]);
        }

        private void maxandMin_Click(object sender, EventArgs e)
        {
            this.AlllotoNumerot.Text = "";
            int temp;
            for (int i = 0; i < this.loto.Length - 1; i++)
            {
                for (int j = i + 1; j < this.loto.Length; j++)
                {
                    if (this.loto[i] > this.loto[j])
                    {
                        temp = this.loto[i];
                        this.loto[i] = this.loto[j];
                        this.loto[j] = temp;
                    }
                }
            }
            string loto;
            for (int i = 0; i < this.loto.Length; i++)
            {
                loto = Convert.ToString(this.loto[i]);
                this.AlllotoNumerot.Text = AlllotoNumerot.Text + ", " + loto;
            }
        }

        private void OikeinLoto_Click(object sender, EventArgs e)
        {
            this.Oikein.Text = "";
            int kuinkaoikein = 0;
                if (this.Lotto0.Text == PlayerLoto0.Text)
                {
                    kuinkaoikein++;
                }
                if (this.Lotto1.Text == PlayerLoto1.Text)
                {
                    kuinkaoikein++;
                }
                if (this.Lotto2.Text == PlayerLoto2.Text)
                {
                    kuinkaoikein++;
                }
                if (this.Lotto3.Text == PlayerLoto3.Text)
                {
                    kuinkaoikein++;
                }
                if (this.Lotto4.Text == PlayerLoto4.Text)
                {
                    kuinkaoikein++;
                }
                if (this.Lotto5.Text == PlayerLoto5.Text)
                {
                    kuinkaoikein++;
                }
                if (this.Lotto6.Text == PlayerLoto6.Text)
                {
                    kuinkaoikein++;
                }
            this.Oikein.Text = "Lotto oikein: " + kuinkaoikein;
        }

        private void LuodanLista_Click(object sender, EventArgs e)
        {
            this.ButtonLissaList.Enabled = true;
           

        }

        private void ButtonLissaList_Click(object sender, EventArgs e)
        {
            string add;
            add=this.LisatanLista.Text;
            this.stringList.Add(add);
            this.HaeLista.Enabled = true;
        }

        private void HaeLista_Click(object sender, EventArgs e)
        {
            this.ListBox.Items.Clear();
            foreach (string C in this.stringList)
            {
                this.ListBox.Items.Add(C);
               
            }
        }

        private void LuoDisconary_Click(object sender, EventArgs e)
        {
            this.LissäDisconary.Enabled = true;
        }

        private void LissäDisconary_Click(object sender, EventArgs e)
        {
            string key;
            string value;
            key = this.Key.Text;
            value = this.Value.Text;
            this.newDictionary.Add(key, value);
            this.HaeDisconary.Enabled = true;
        }

        private void HaeDisconary_Click(object sender, EventArgs e)
        {
            string key;
            key = this.HaeKey.Text;
            string value;
            if (this.newDictionary.ContainsKey(key))
            {
                value = this.newDictionary[key];
                this.HaeValue.Text = value;
            }
            if (!this.newDictionary.ContainsKey(key))
            {
                this.HaeValue.Text = "Key not Found";
            }
        }
    }
}
