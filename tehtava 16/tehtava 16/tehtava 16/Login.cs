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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Sign_Click(object sender, EventArgs e)
        {
            Form1 frmFirst = this.Owner as Form1;
            string Name;
            Name = this.NamePlayer.Text;
            if (frmFirst.PlayerNameString.Contains(Name))
            {
                frmFirst.PlayerTextBox.Text = "Player: " + Name;
            }
            else
            {
                frmFirst.PlayerLength++;
                frmFirst.PlayerNameString[frmFirst.PlayerLength] = Name;
                frmFirst.PlayerTextBox.Text = "Player: " + Name;
            }
            frmFirst.TotalPlayers.Text = "Total players: " + frmFirst.PlayerLength;
            frmFirst.SignButton.Enabled = false;
            frmFirst.AloittaPeli.Enabled = true;
            frmFirst.PeliInfo.Text = "Napsauta Aloita peli aloittaaksesi pelin";
            this.Close();
        }
    }
}
