using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tehtava_16
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        public double Kysymys1, Kysymys2, Kysymys3;
        string[] PlayerNameString = new string[100];
        int PlayerLength = 0;
       public int KysymysNumero;
        public bool negavitinenVastaus, kokonaislukua;
        public int KuinkaOikein=0;

        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            this.KysymysNumero = 1;
            var Rand = new Random();
            if (negavitinenVastaus==true && kokonaislukua==false)
            {
                this.Kysymys1 = Rand.Next(-100, 50);
                this.Kysymys2 = Rand.Next(-100, 50);
            }
            if (negavitinenVastaus==false && kokonaislukua == true)
            {
                this.Kysymys1 = GetRandomNumber(1, 50);
                this.Kysymys2 = GetRandomNumber(1, 50);

            }
            if (negavitinenVastaus==true && kokonaislukua == true)
            {
                this.Kysymys1 = GetRandomNumber(-50, 50);
                this.Kysymys2 = GetRandomNumber(-50, 50);
            }
            if (negavitinenVastaus==false && kokonaislukua == false)
            {
                this.Kysymys1 = Rand.Next(1, 50);
                this.Kysymys2 = Rand.Next(1, 50);
            }
            Form2 frmSecond = new Form2();
            frmSecond.Show(this);
        }
            double GetRandomNumber(double minimum, double maximum)
        {
            
            return this.random.NextDouble() * (maximum - minimum) + minimum;
        }

        private void setting_Click(object sender, EventArgs e)
        {
            Setting settingForm = new Setting();
            settingForm.Show(this);
        }

        private void Vasstaus2_Click(object sender, EventArgs e)
        {
            this.KysymysNumero = 2;
            var Rand = new Random();
            if (negavitinenVastaus == true && kokonaislukua == false)
            {
                this.Kysymys1 = Rand.Next(-100, 50);
                this.Kysymys2 = Rand.Next(-100, 50);
                this.Kysymys3 = Rand.Next(-100, 50);
            }
            if (negavitinenVastaus == false && kokonaislukua == true)
            {
                this.Kysymys1 = GetRandomNumber(1, 50);
                this.Kysymys2 = GetRandomNumber(1, 50);
                this.Kysymys3 = GetRandomNumber(1, 50);
            }
            if (negavitinenVastaus == true && kokonaislukua == true)
            {
                this.Kysymys1 = GetRandomNumber(-50, 50);
                this.Kysymys2 = GetRandomNumber(-50, 50);
                this.Kysymys3 = GetRandomNumber(-50, 50);
            }
            if (negavitinenVastaus == false && kokonaislukua == false)
            {
                this.Kysymys1 = Rand.Next(1, 50);
                this.Kysymys2 = Rand.Next(1, 50);
                this.Kysymys3 = Rand.Next(1, 50);
            }
            Form2 frmSecond = new Form2();
            frmSecond.Show(this);
        }

        private void Palkinto_Click(object sender, EventArgs e)
        {
            if (KuinkaOikein == 0)
            {
                this.PalkintoTextBox.Text = "Sinulla ei ole oikeita vastauksia, et saa mitään";
            }
            if (KuinkaOikein == 1)
            {
                this.PalkintoTextBox.Text = "Sinulla on yksi oikea vastaus, saat 1000 euroa";
            }
            if (KuinkaOikein == 2)
            {
                this.PalkintoTextBox.Text = "Sinulla on kaksi oikea vastaus, saat 1500 euroa";
            }
            if (KuinkaOikein == 3)
            {
                this.PalkintoTextBox.Text = "Vastasit kaikkiin kysymyksiin! PALKINNOSI 5 miljoonaa euroa!";
            }
        }

        private void Vasstaus3_Click(object sender, EventArgs e)
        {
            this.KysymysNumero = 3;
            var Rand = new Random();
            if (negavitinenVastaus == true && kokonaislukua == false)
            {
                this.Kysymys1 = Rand.Next(-5, 5);
                this.Kysymys2 = Rand.Next(-5, 5);
            }
            if (negavitinenVastaus == false && kokonaislukua == true)
            {
                this.Kysymys1 = GetRandomNumber(1, 5);
                this.Kysymys2 = GetRandomNumber(1, 5);
            }
            if (negavitinenVastaus == true && kokonaislukua == true)
            {
                this.Kysymys1 = GetRandomNumber(-5, 5);
                this.Kysymys2 = GetRandomNumber(-5, 5);
            }
            if (negavitinenVastaus == false && kokonaislukua == false)
            {
                this.Kysymys1 = Rand.Next(1, 5);
                this.Kysymys2 = Rand.Next(1, 5);
            }
            Form2 frmSecond = new Form2();
            frmSecond.Show(this);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SignButton_Click(object sender, EventArgs e)
        {
            
            string Name;
            Name = this.NamePlayer.Text;
            if (this.PlayerNameString.Contains(Name))
            {
                this.PlayerTextBox.Text = "Player: " + Name;
            }
            else
            {
                this.PlayerLength++;
                this.PlayerNameString[PlayerLength] = Name;
                this.PlayerTextBox.Text = "Player: " + Name;
            }
            this.TotalPlayers.Text = "Total players: " + this.PlayerLength;
            this.Vasstaus1.Enabled = true;
            this.Vasstaus2.Enabled = true;
            this.Vasstaus3.Enabled = true;
            this.Ulos.Enabled = true;
            this.SignButton.Enabled = false;
            this.NamePlayer.Text = "";
            this.NamePlayer.Enabled = false;
            this.Palkinto.Enabled = true;
        }

        private void Ulos_Click(object sender, EventArgs e)
        {
            this.LabelVastaus1.Text = "Ei ole Vastaus";
            this.LabelVastaus2.Text = "Ei ole Vastaus";
            this.LabelVastaus3.Text = "Ei ole Vastaus";
            this.NamePlayer.Text = "";
            this.PlayerTextBox.Text = "Player: ";
            this.PalkintoTextBox.Text = "";
            this.KuinkaOikein = 0;
            this.Palkinto.Enabled = false;
            this.Vasstaus1.Enabled = false;
            this.Vasstaus2.Enabled = false;
            this.Vasstaus3.Enabled = false;
            this.Ulos.Enabled = false;
            this.SignButton.Enabled = true;
            this.NamePlayer.Enabled = true;
        }
    }
}
