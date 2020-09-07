using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Valita Form. Form1= Tehtävä 1-3, Paaformi=Tehtävä 4-10, paaformi2=Tehtävä 11-13 Picture Tehtävä 14.
           // Application.Run(new Form1());
           // Application.Run(new Paaformi());
           // Application.Run(new Paaformi2());
           // Application.Run(new picture());
        }
      
    }
}
