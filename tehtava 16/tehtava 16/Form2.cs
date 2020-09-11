using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tehtava_16
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frmFirst = this.Owner as Form1;
            if (frmFirst.KysymysNumero == 1)
            {
                frmFirst.VastausBox1.Text = this.txtName.Text;
                frmFirst.Vasstaus1.Enabled = false;
                if (this.txtName.Text == Convert.ToString(frmFirst.Kysymys1 + frmFirst.Kysymys2))
                {
                    frmFirst.LabelVastaus1.Text = "Oikein!";
                    frmFirst.KuinkaOikein++;
                }
                else
                {
                    frmFirst.LabelVastaus1.Text = "Vaarin";
                }
            }
            if (frmFirst.KysymysNumero == 2)
            {
                frmFirst.VastausBox2.Text = this.txtName.Text;
                frmFirst.Vasstaus2.Enabled = false;
                if (this.txtName.Text == Convert.ToString(frmFirst.Kysymys1 + frmFirst.Kysymys2-frmFirst.Kysymys3))
                {
                    frmFirst.LabelVastaus2.Text = "Oikein!";
                    frmFirst.KuinkaOikein++;
                }
                else
                {
                    frmFirst.LabelVastaus2.Text = "Vaarin";
                }
            }
            if (frmFirst.KysymysNumero == 3)
            {
                frmFirst.VastausBox3.Text = this.txtName.Text;
                frmFirst.Vasstaus3.Enabled = false;
                if (this.txtName.Text == Convert.ToString(frmFirst.Kysymys1 * frmFirst.Kysymys2))
                {
                    frmFirst.LabelVastaus3.Text = "Oikein!";
                    frmFirst.KuinkaOikein++;
                }
                else
                {
                    frmFirst.LabelVastaus3.Text = "Vaarin";
                }
            }
            this.Close();
        }

        private void Kysymys_Click(object sender, EventArgs e)
        {
            Form1 frmFirst = this.Owner as Form1;
            if (frmFirst.KysymysNumero == 1)
            {
               this.KysymysBox.Text=frmFirst.Kysymys1+" + " + frmFirst.Kysymys2 + " = ?";
            }
            if (frmFirst.KysymysNumero == 2)
            {
                this.KysymysBox.Text = frmFirst.Kysymys1 + " + " + frmFirst.Kysymys2 + " - "+frmFirst.Kysymys3+" =?";
            }
            if (frmFirst.KysymysNumero == 3)
            {
                this.KysymysBox.Text = frmFirst.Kysymys1 + " * " + frmFirst.Kysymys2 + " =?";
            }
        }
    }
}
