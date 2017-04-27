using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Be.Windows.Forms;

namespace F.C.E._365_Firmware_Manager_X
{
    static class Program
    {
        public const string SoftwareName = "F.C.E. 365 Firmware Manager";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
