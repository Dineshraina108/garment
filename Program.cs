using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOGIN_MODEL
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
            /* Login fLogin = new Login();
              if (fLogin.ShowDialog() == DialogResult.OK)
              {
                 Application.EnableVisualStyles();
                  Application.SetCompatibleTextRenderingDefault(false);
                  fLogin.Close();
                  Application.Run(new PRODUCT.Home());
              }
              else
              {          
                 Application.Exit();
              }*/
              Application.Run(new Login());

        }
    }
}
