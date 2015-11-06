using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace acIDS
{

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static userData user = new userData();
        public static processHandler phandler = new processHandler();

        [STAThread]
        static void Main()
        {    
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new loginForm());
        }
    }
}
