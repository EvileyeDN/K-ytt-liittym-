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
    public partial class Setting : Form
    {
        int KysymysNumero=1;
        public Setting()
        {
            InitializeComponent();
        }

        private void Jo_Click(object sender, EventArgs e)
        {
            Form1 frmFirst = this.Owner as Form1;
            Button painettuNappi = sender as Button;
            int switch1 = painettuNappi.TabIndex;
           if (KysymysNumero == 1)
            {
                switch (switch1)
                {
                    case 1:
                        frmFirst.negavitinenVastaus = true;
                        break;
                    case 2:
                        frmFirst.negavitinenVastaus = false;
                        break;
                }
                this.label1.Text = "ovatko luvut vain kokonaislukuja?";
                KysymysNumero++;
                return;
            }
           if (KysymysNumero == 2)
            {
                switch (switch1)
                {
                    case 1:
                        frmFirst.kokonaislukua = true;
                        break;
                    case 2:
                        frmFirst.kokonaislukua = false;
                        break;
                }
                frmFirst.setting.Enabled = false;
                frmFirst.SignButton.Enabled = true;
                frmFirst.PeliInfo.Text = "Kirjoita nimesi napsauttamalla Sign-painiketta";
                this.Close();
            }
        }
    }
}
