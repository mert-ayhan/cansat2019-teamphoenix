using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;

namespace CanSat
{
    class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        /// 

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            new Program();
        }
    }
}
