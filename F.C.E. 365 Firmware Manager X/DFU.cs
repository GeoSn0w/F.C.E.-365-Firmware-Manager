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
    public partial class DFU : Form
    {
        public DFU()
        {
            InitializeComponent();
        }

        private void phnDetect_Click(object sender, EventArgs e)
        {

        }

        private void DFU_Load(object sender, EventArgs e)
            
        {
            backgroundWorker1.RunWorkerAsync();
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.WorkerReportsProgress = true;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            ProcessStartInfo psi2 = default(ProcessStartInfo);
            Process proc = new Process();
            string pat1 = Application.StartupPath;
            dynamic process3 = pat1 + "/Data/ufd.exe";
            psi2 = new ProcessStartInfo(process3);
            proc.StartInfo = psi2;
            proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            proc.Start();
            proc.WaitForExit();
            if (proc.HasExited == true)
            {
                phnDetect.Invoke((MethodInvoker)delegate
                {
                    phnDetect.Text = "Successfully Found Device in DFU Mode!";
                });
            }
            
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            
                
        }

        private void engine_go_afc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            phnDetect.Text = "Successfully Found Device in DFU Mode!";
        }
    }
}
