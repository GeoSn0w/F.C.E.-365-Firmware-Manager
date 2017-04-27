using Be.Windows.Forms;
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

    public partial class IOApplicationAccellerator : Form
    {
        private Be.Windows.Forms.HexBox hexFind;
        string _fileName;
        private FindOptions _findOptions;

        public FindOptions FindOptions
        {
            get
            {
                return _findOptions;
            }
            set
            {
                _findOptions = value;

            }
        }

        public HexBox HexBox { get; set; }
        public void FindNext()
        {


        }
        void DisplayText()
        {

            if (_fileName != null && _fileName.Length > 0)
            {
                string textFormat = "{0}{1} - {2}";
                string readOnly = ((DynamicFileByteProvider)hexi.ByteProvider).ReadOnly
                    ? strings.Readonly : "";
                string text = Path.GetFileName(_fileName);
                this.Text = string.Format(textFormat, text, readOnly, Program.SoftwareName);
            }
            else
            {
                this.Text = Program.SoftwareName;
            }

        }
        public IOApplicationAccellerator()
        {
            InitializeComponent();
        }

        private void OffsetPointStopBySize_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IOApplicationAccellerator_Load(object sender, EventArgs e)
        {
            _myByteViewer = new System.ComponentModel.Design.ByteViewer { Dock = DockStyle.Fill, Size = new System.Drawing.Size(715, 226), ClientSize = new System.Drawing.Size(715, 226), BorderStyle = BorderStyle.None };
            viewerPanel.Controls.Add(_myByteViewer);
        }

        private void GO_Offset_container_Click(object sender, EventArgs e)
        {
            //Bound to be replaced soon.
        }
        private System.ComponentModel.Design.ByteViewer
          _myByteViewer;

        private void file_offset_parser_Click(object sender, EventArgs e)
        {

            dynamic quote = "\"";
            fileparserattr.FileName = "Please load an Application...";
            DialogResult result = fileparserattr.ShowDialog();
            if (result == DialogResult.OK)
            {
                processor.RunWorkerAsync();
            }
        }

        private void caller_Click(object sender, EventArgs e)
        {
            //Bound to be replaced soon to use new patch format.
        }

        private void AppContainer_TextChanged(object sender, EventArgs e)
        {
            //Bound to be replaced to work with new patches model soon.
        }

        private void processor_DoWork(object sender, DoWorkEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                sizeforeparse.Text = new FileInfo(fileparserattr.FileName).Length.ToString();
                IOFileSystemFile.Text = fileparserattr.FileName;
                String sourceFileName = IOFileSystemFile.Text;
                Byte[] shaHash;
                using (var shaForStream = new SHA256Managed())
                using (Stream sourceFileStream = File.Open(sourceFileName, FileMode.Open))
                using (Stream sourceStream = new CryptoStream(sourceFileStream, shaForStream, CryptoStreamMode.Read))
                {

                    while (sourceStream.ReadByte() != -1) ;
                    shaHash = shaForStream.Hash;
                }

                GDBase64.Text = (Convert.ToBase64String(shaHash));

                try
                {
                    DynamicFileByteProvider dynamicFileByteProvider;
                    {
                        dynamicFileByteProvider = new DynamicFileByteProvider(fileparserattr.FileName);
                    }
                    hexi.ByteProvider = dynamicFileByteProvider;
                    _fileName = fileparserattr.FileName;
                    DisplayText();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something clearly went wrong." + "\n" + ex.Message, "F.C.E. 365 Firmware Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            });
        }

        private void test_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            //Bound to be replaced to work with new patches model soon.
        }

        private void iTalk_Button_21_Click(object sender, EventArgs e)
        {
            //Bound to be replaced to work with new patches model soon.
        }
    }
    }
  