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
        int[] Taulukko = new int[0];
        int[] Loto = new int[10];
        List<String> StriingList = new List<string>();
        Dictionary<string, string> NewDisconary = new Dictionary<string, string>();
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
                again:
                RandomNumero= rand.Next(1, 41);
                if (this.Loto.Contains(RandomNumero))
                {
                    goto again;
                }
                this.Loto[i] = RandomNumero;
            }
            this.Lotto0.Text = Convert.ToString(Loto[0]);
            this.Lotto1.Text = Convert.ToString(Loto[1]);
            this.Lotto2.Text = Convert.ToString(Loto[2]);
            this.Lotto3.Text = Convert.ToString(Loto[3]);
            this.Lotto4.Text = Convert.ToString(Loto[4]);
            this.Lotto5.Text = Convert.ToString(Loto[5]);
            this.Lotto6.Text = Convert.ToString(Loto[6]);
            this.Lotto7.Text = Convert.ToString(Loto[7]);
            this.Lotto8.Text = Convert.ToString(Loto[8]);
        }

        private void maxandMin_Click(object sender, EventArgs e)
        {
            this.AlllotoNumerot.Text = "";
            int temp;
            for (int i = 0; i < this.Loto.Length - 1; i++)
            {
                for (int j = i + 1; j < this.Loto.Length; j++)
                {
                    if (this.Loto[i] > this.Loto[j])
                    {
                        temp = this.Loto[i];
                        this.Loto[i] = this.Loto[j];
                        this.Loto[j] = temp;
                    }
                }
            }
            string loto;
            for (int i = 0; i < this.Loto.Length; i++)
            {
                loto = Convert.ToString(this.Loto[i]);
                this.AlllotoNumerot.Text = AlllotoNumerot.Text + ", " + loto;
            }
        }

        private void OikeinLoto_Click(object sender, EventArgs e)
        {
            this.Oikein.Text = "";
            int KuinkaOikein = 0;
                if (this.Lotto0.Text == PlayerLoto0.Text)
                {
                    KuinkaOikein++;
                }
                if (this.Lotto1.Text == PlayerLoto1.Text)
                {
                    KuinkaOikein++;
                }
                if (this.Lotto2.Text == PlayerLoto2.Text)
                {
                    KuinkaOikein++;
                }
                if (this.Lotto3.Text == PlayerLoto3.Text)
                {
                    KuinkaOikein++;
                }
                if (this.Lotto4.Text == PlayerLoto4.Text)
                {
                    KuinkaOikein++;
                }
                if (this.Lotto5.Text == PlayerLoto5.Text)
                {
                    KuinkaOikein++;
                }
                if (this.Lotto6.Text == PlayerLoto6.Text)
                {
                    KuinkaOikein++;
                }
            this.Oikein.Text = "Lotto oikein: " + KuinkaOikein;
        }

        private void LuodanLista_Click(object sender, EventArgs e)
        {
            this.ButtonLissaList.Enabled = true;
           

        }

        private void ButtonLissaList_Click(object sender, EventArgs e)
        {
            string Add;
            Add=this.LisatanLista.Text;
            this.StriingList.Add(Add);
            this.HaeLista.Enabled = true;
        }

        private void HaeLista_Click(object sender, EventArgs e)
        {
            this.ListBox.Items.Clear();
            foreach (string C in this.StriingList)
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
            this.NewDisconary.Add(key, value);
            this.HaeDisconary.Enabled = true;
        }

        private void HaeDisconary_Click(object sender, EventArgs e)
        {
            string key;
            key = this.HaeKey.Text;
            string value;
            if (this.NewDisconary.ContainsKey(key))
            {
                value = this.NewDisconary[key];
                this.HaeValue.Text = value;
            }
            if (!this.NewDisconary.ContainsKey(key))
            {
                this.HaeValue.Text = "Key not Found";
            }
        }
    }
}
