using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F.C.E._365_Firmware_Manager_X
{
    public partial class HashCalculator : Form
    {
        public HashCalculator()
        {
            InitializeComponent();
        }

        private void AES_Start_Click(object sender, EventArgs e)
        {
            try
            {
                String sourceFileName = AES_FileLocation.Text;
                Byte[] shaHash;
                using (var shaForStream = new SHA256Managed())
                using (Stream sourceFileStream = File.Open(sourceFileName, FileMode.Open))
                using (Stream sourceStream = new CryptoStream(sourceFileStream, shaForStream, CryptoStreamMode.Read))
                {

                    while (sourceStream.ReadByte() != -1) ;
                    shaHash = shaForStream.Hash;
                }

                HashISOS.Text = (Convert.ToBase64String(shaHash));
            }
            catch (Exception ex) {
                MessageBox.Show("Something clearly went wrong." + "\n" + ex.Message, "F.C.E. 365 Firmware Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AES_LoadFile_Click(object sender, EventArgs e)
        {
            DialogResult result = HashLoader.ShowDialog();
            if (result == DialogResult.OK)
            {
                var quote = quoter.Text;
                AES_FileLocation.Text = HashLoader.FileName;
            }
        }
    }
}
