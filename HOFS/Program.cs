using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOFS
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
            Application.Run(new UserController());
            


            /// CHANGE A TITEL FOR FORM 
            //Form f1 = new UserController();
            //f1.Text = "Homes for sale";
            //f1.ShowDialog();


        }
    }
}
