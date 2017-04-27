using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F.C.E._365_Firmware_Manager_X
{
    public partial class rec : Form
    {
        public rec()
        {
            InitializeComponent();
        }

        private void rec_call_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi2 = default(ProcessStartInfo);
            Process proc = new Process();
            dynamic parameter1 = udid.Text;
            string pat1 = Application.StartupPath;
            dynamic process3 = pat1 + "/Data/ideviceenterrecovery.exe";
            dynamic args3 = string.Format("{0}", parameter1);
            psi2 = new ProcessStartInfo(process3, args3);
            proc.StartInfo = psi2;
            proc.Start();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
