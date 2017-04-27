using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Design;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.Design;

namespace F.C.E._365_Firmware_Manager_X
{
    public partial class fcehex : Form
    {
        public fcehex()
        {
            InitializeComponent();
            _myByteViewer = new System.ComponentModel.Design.ByteViewer { Dock = DockStyle.Fill, BorderStyle = BorderStyle.None };
            viewerPanel.Controls.Add(_myByteViewer);
            string pat1 = Application.StartupPath;
            try
            {
                _myByteViewer.SetFile(pat1 + "/Data/hex.dump");
            }
            catch (Exception ex)
            {
            }
        }

        private void fcehex_Load(object sender, EventArgs e)
        {

        }
        private System.ComponentModel.Design.ByteViewer
           _myByteViewer;


        private void iTalk_Button_11_Click(object sender, EventArgs e)
        {
            openFile.Title = "F.C.E. 365 Firmware Manager - Import Binary File";
            openFile.DefaultExt = "All files *.*";
            openFile.FileName = "Choose file...";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                _myByteViewer.SetFile(openFile.FileName);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fcehex_Load_1(object sender, EventArgs e)
        {

        }

        private void iTalk_Button_11_Click_1(object sender, EventArgs e)
        {
            savedump.Title = "F.C.E. 365 Firmware Manager - Save Hex Dump";
            savedump.DefaultExt = ".txt";
            savedump.FileName = "FileHexDump";

            if (savedump.ShowDialog() == DialogResult.OK)
            {
                _myByteViewer.SaveToFile(savedump.FileName);
            }
        }

        private void viewerPanel_Click(object sender, EventArgs e)
        {

        }
    }
}
