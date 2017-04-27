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
    public partial class partialdl : Form
    {
        public partialdl()
        {
            InitializeComponent();
        }

        private void iTalk_Button_21_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi2 = default(ProcessStartInfo);
            Process proc = new Process();
            dynamic linker = https.Text;
            string pat1 = Application.StartupPath;
            dynamic process3 = pat1 + "/Data/pzip.exe";
            dynamic filesystem = fs.Text;
            dynamic usrsbin = saveme.Text;
            dynamic args3 = string.Format("{0} {1} {2}", linker, filesystem, usrsbin);
            psi2 = new ProcessStartInfo(process3, args3);
            proc.StartInfo = psi2;
            proc.Start();
            proc.WaitForExit();
            if (proc.HasExited == true)
            {
                MessageBox.Show("It seems like the file was successfully downloaded.", "F.C.E. 365 Firmware Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void fsbrowser_Click(object sender, EventArgs e)
        {
            dynamic quote = quoter.Text;
            ibuildfiles.Filter = "Any kind of file | *.*";
            ibuildfiles.Title = "Saving a partial zip...";
            ibuildfiles.FileName = "Please choose where to save...";
            DialogResult result = ibuildfiles.ShowDialog();
            if (result == DialogResult.OK)
            {
                saveme.Text = quoter.Text + ibuildfiles.FileName + quoter.Text;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
