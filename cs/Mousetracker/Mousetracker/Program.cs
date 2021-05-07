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
        static void Game()
        {
            int MouX = MouseTracker.MousePosition.X;
            int MouY = MouseTracker.MousePosition.Y;
            Console.WriteLine(MouY + MouX);
        }
    }
}
