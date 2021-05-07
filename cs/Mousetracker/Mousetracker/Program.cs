using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mousetracker
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
            Application.Run(new MouseTracker());

        }
        /*  private void Tracker()
          {
              while (true)
              {
                  int x = MousePosition.X;
                  int y = MousePosition.Y;

                  lblx.Text = x.ToString();
                  lbly.Text = y.ToString();
              }   
          } */
    }
}
