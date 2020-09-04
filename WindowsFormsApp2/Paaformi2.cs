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
    public partial class Paaformi2 : Form
    {
        Point piste = new Point(0, 0);
        int i=1;
        public Paaformi2()
        {
            InitializeComponent();
        }

        private void Paaformi2_Paint(object sender, PaintEventArgs e)
        {
            Graphics Graf = e.Graphics;



            // - Pää 

            Graf.FillEllipse(Brushes.IndianRed, piste.X - 4, piste.Y - 8, 49, 49);

            Graf.DrawEllipse(Pens.Black, piste.X - 4, piste.Y - 8, 49, 49);

            // - Selkä 

            Graf.DrawLine(Pens.Black, piste.X + 21, piste.Y + 41,

            piste.X + 21, piste.Y + 131);

            // - Kädet 

            Graf.DrawLine(Pens.Black, piste.X - 30, piste.Y + 60,

            piste.X + 70, piste.Y + 60);

            // - Jalat 

            Graf.DrawLine(Pens.Black, piste.X + 21, piste.Y + 131,

            piste.X - 30, piste.Y + 181);

            Graf.DrawLine(Pens.Black, piste.X + 21, piste.Y + 131,

            piste.X + 70, piste.Y + 181);





            // Kutsutaan DrawCoordinates()-metodia. 

            DrawCordinates(Graf);
        }
        private void DrawCordinates(Graphics Graf)

        {

            // Piirretään piikoordinaattien arvot näytölle. 

            Graf.DrawString("(" + piste.X + " ," + piste.Y + ")",

                            new Font("Arial", 14, System.Drawing.FontStyle.Regular),

                            new SolidBrush(Color.Black), 8, 30);

        }

        private void koordinaatin_Click(object sender, EventArgs e)
        {
            int X;
            int Y;
            X = Convert.ToInt32(this.KoordinatiX.Text);
            Y = Convert.ToInt32(this.koordinatiY.Text);
            this.piste.X = X;
            this.piste.Y = Y;
            Invalidate();

        }
        private void MainForm_MouseDown(object sender, MouseEventArgs e)

        {
            if (e.Button == MouseButtons.Left)
               
            {
               

                // Talletetaan hiiren klikkauskohdan koordinaatit. Piste (0, 0) 

                // on formin työalueen vasemmassa ylä nurkassa 

                piste = e.Location;



                // Merkitään formin työalue epäkelvoksi, jolloin saadaan aikaiseksi 

                // paint-eventin signalointi ja tämän jälkeen Paint()-metodin kutsu. 

                Invalidate();

            }

        }

        private void Paaformi2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.W)
            {
                this.piste.Y = this.piste.Y - 1;
            }
            if (e.KeyCode == Keys.S)
            {
                this.piste.Y = this.piste.Y + 1;
            }
            if (e.KeyCode == Keys.D)
            {
                this.piste.X = this.piste.X + 1;
            }
            if (e.KeyCode == Keys.A)
            {
                this.piste.X = this.piste.X - 1;
            }
            if (e.KeyCode == Keys.Enter)
            {
                this.koordinatiY.Enabled = true;
                this.KoordinatiX.Enabled = true;
                this.OnOff.Enabled = true;
                this.koordinaatin.Enabled = true;
            }
            Invalidate();
        }

        private void Paaformi2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                this.piste.Y = this.piste.Y - 1;
            }
            if (e.KeyCode == Keys.S)
            {
                this.piste.Y = this.piste.Y + 1;
            }
            if (e.KeyCode == Keys.D)
            {
                this.piste.X = this.piste.X + 1;
            }
            if (e.KeyCode == Keys.A)
            {
                this.piste.X = this.piste.X - 1;
            }
            if (e.KeyCode == Keys.Enter)
            {
                this.koordinatiY.Enabled = true;
                this.KoordinatiX.Enabled = true;
                this.OnOff.Enabled = true;
                this.koordinaatin.Enabled = true;
            }
            Invalidate();
        }

        private void OnOff_Click(object sender, EventArgs e)
        {
            this.koordinatiY.Enabled = false;
            this.KoordinatiX.Enabled = false;
            this.OnOff.Enabled = false;
            this.koordinaatin.Enabled = false;
           
           
        }
    }
}
