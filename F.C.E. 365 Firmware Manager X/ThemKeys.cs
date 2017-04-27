using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F.C.E._365_Firmware_Manager_X
{
    public partial class ThemKeys : Form
    {
        private Form1 mainForm = null;
        public ThemKeys(Form callingForm)
        {
            mainForm = callingForm as Form1; 
            InitializeComponent();
        }

        private void ThemKeys_Load(object sender, EventArgs e)
        {

        }

        private void keychain_export_Click(object sender, EventArgs e)
        {
            if (device.SelectedIndex == 0)
            {
                if (iosprovate.SelectedIndex == 0)
                {
                    this.mainForm.Keys = "38d0320d099b9dd34ffb3308c53d397f14955b347d6a433fe173acc2ced1ae78756b3684";
                    this.mainForm.EncKeys = "38d0320d099b9dd34ffb3308c53d397f14955b347d6a433fe173acc2ced1ae78756b3684";
                    this.Close();
                }
                else 
                {
                    MessageBox.Show("iPhone 4 does not support iOS 9.x.", "F.C.E. 365 Firmware Manager X - Keychain", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (device.SelectedIndex == 1)
            {
                if (iosprovate.SelectedIndex == 0)
                {
                    this.mainForm.Keys = "10a8d34290659b33117f5b6dfe59055d6a38400819dbbecfd3ad50b7b68619c5bf10f852";
                    this.mainForm.EncKeys = "10a8d34290659b33117f5b6dfe59055d6a38400819dbbecfd3ad50b7b68619c5bf10f852";
                    this.Close();
                }
                else
                {
                    MessageBox.Show("iPhone 4 does not support iOS 9.x.", "F.C.E. 365 Firmware Manager X - Keychain", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (device.SelectedIndex == 2)
            {
                if (iosprovate.SelectedIndex == 0)
                {
                    this.mainForm.Keys = "423b3503689b7058d1398d1b5d56a7b1ccf4d79e1c3e6ba853122b4f86820a9e3bc911f6";
                    this.mainForm.EncKeys = "423b3503689b7058d1398d1b5d56a7b1ccf4d79e1c3e6ba853122b4f86820a9e3bc911f6";
                    this.Close();
                }
                else
                {
                    MessageBox.Show("iPhone 4 does not support iOS 9.x.", "F.C.E. 365 Firmware Manager X - Keychain", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (device.SelectedIndex == 3)
            {
                if (iosprovate.SelectedIndex == 1)
                {
                    this.mainForm.Keys = "9b797f07d566104364c32b960247710702d2c2c2d8daa857588a1acb1854c327e1d5aeb9";
                    this.mainForm.EncKeys = "9b797f07d566104364c32b960247710702d2c2c2d8daa857588a1acb1854c327e1d5aeb9";
                    this.Close();
                }
                else if (iosprovate.SelectedIndex == 0)
                {
                    this.mainForm.Keys = "9147090b03e8f0888e74676c6a23eacd8c857ea26b7824c06563dbc1e9040857aa2e8253";
                    this.mainForm.EncKeys = "9147090b03e8f0888e74676c6a23eacd8c857ea26b7824c06563dbc1e9040857aa2e8253";
                    this.Close();
                }
                else if (iosprovate.SelectedIndex == 2)
                {
                    this.mainForm.Keys = "b6644378699052dbd0a53f596f5916c9ac68a3ca8650454dd0a431bb8b617b2e9149b2b8";
                    this.mainForm.EncKeys = "b6644378699052dbd0a53f596f5916c9ac68a3ca8650454dd0a431bb8b617b2e9149b2b8";
                    this.Close();
                }
                else if (iosprovate.SelectedIndex == 3)
                {
                    this.mainForm.Keys = "0962e1a9308abd629272347638a1a157e98a00c9c37a3ac9ca926a4a3a3b0d012be678f4";
                    this.mainForm.EncKeys = "0962e1a9308abd629272347638a1a157e98a00c9c37a3ac9ca926a4a3a3b0d012be678f4";
                    this.Close();
                }
                else if (iosprovate.SelectedIndex == 4)
                {
                    this.mainForm.Keys = "1c016b9999d81b0a624bb3f0a5b11a354bd0ff8666d7e5c26e4f7d117b978198bb4195c9";
                    this.mainForm.EncKeys = "1c016b9999d81b0a624bb3f0a5b11a354bd0ff8666d7e5c26e4f7d117b978198bb4195c9";
                    this.Close();
                }

            }
            if (device.SelectedIndex == 4)
            {
                if (iosprovate.SelectedIndex == 2)
                {
                    this.mainForm.Keys = "a6cb6e3c31f8e008555fc849a4ca018c629428aee14381f7036cf05c619a0ffe41782620";
                    this.mainForm.EncKeys = "a6cb6e3c31f8e008555fc849a4ca018c629428aee14381f7036cf05c619a0ffe41782620";
                    this.Close();
                }
                else if (iosprovate.SelectedIndex == 0)
                {
                    this.mainForm.Keys = "8c30eed8dd8eadf2176503e7572dfb2e224cde1a23a592fc2494809c31a06c8b2e072738";
                    this.mainForm.EncKeys = "8c30eed8dd8eadf2176503e7572dfb2e224cde1a23a592fc2494809c31a06c8b2e072738";
                    this.Close();
                }
                else if (iosprovate.SelectedIndex == 3)
                {
                    this.mainForm.Keys = "f3383acd6f0c441cef2a6c03dadd4d9887d72f0bf2fd010a349ab445f781f9d466abc5bc";
                    this.mainForm.EncKeys = "f3383acd6f0c441cef2a6c03dadd4d9887d72f0bf2fd010a349ab445f781f9d466abc5bc";
                    this.Close();
                }
                else if (iosprovate.SelectedIndex == 4)
                {
                    this.mainForm.Keys = "1374cbbd339ced80d47ab8e7cf9db8ed4b5b887a1b5c92bf6f8e27c93a433bd4facdf92a";
                    this.mainForm.EncKeys = "1374cbbd339ced80d47ab8e7cf9db8ed4b5b887a1b5c92bf6f8e27c93a433bd4facdf92a";
                    this.Close();
                }
                else if (iosprovate.SelectedIndex == 1)
                {
                    MessageBox.Show("There are no keys published yet.", "F.C.E. 365 Firmware Manager X - Keychain", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (device.SelectedIndex == 5)
            {
                if (iosprovate.SelectedIndex == 2)
                {
                    this.mainForm.Keys = "fe672b9836cf46a73276dfd7989328e3a1ac798bc8a325884ea840a441c549f39b5f4fd8";
                    this.mainForm.EncKeys = "fe672b9836cf46a73276dfd7989328e3a1ac798bc8a325884ea840a441c549f39b5f4fd8";
                    this.Close();
                }
                else if (iosprovate.SelectedIndex == 0)
                {
                    this.mainForm.Keys = "16f99aba62c8325456e9f9c36c9ad31b4498c6f034042540222321b81ec4734b1a3780d0";
                    this.mainForm.EncKeys = "16f99aba62c8325456e9f9c36c9ad31b4498c6f034042540222321b81ec4734b1a3780d0";
                    this.Close();
                }
                else if (iosprovate.SelectedIndex == 3)
                {
                    this.mainForm.Keys = "67da145061b429b059ecfafafbf32bfa8df7c3d02c0aa544a77c1c6a080af0371390af8c";
                    this.mainForm.EncKeys = "67da145061b429b059ecfafafbf32bfa8df7c3d02c0aa544a77c1c6a080af0371390af8c";
                    this.Close();
                }
                else if (iosprovate.SelectedIndex == 4)
                {
                    this.mainForm.Keys = "e8cb388c76d94dfdf4634b09a93f13cf96c71e80df5a375aa6a3fdd65774739b281a78dc";
                    this.mainForm.EncKeys = "e8cb388c76d94dfdf4634b09a93f13cf96c71e80df5a375aa6a3fdd65774739b281a78dc";
                    this.Close();
                }
                else if (iosprovate.SelectedIndex == 1)
                {
                    MessageBox.Show("There are no keys published yet.", "F.C.E. 365 Firmware Manager X - Keychain", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (device.SelectedIndex == 6)
            {
                if (iosprovate.SelectedIndex == 2)
                {
                    this.mainForm.Keys = "93043525c717b1223ce2fbb7b59e50ddf3e116424a4d6b906ea139dbd6691a26cc76d9ef";
                    this.mainForm.EncKeys = "93043525c717b1223ce2fbb7b59e50ddf3e116424a4d6b906ea139dbd6691a26cc76d9ef";
                    this.Close();
                }
                else if (iosprovate.SelectedIndex == 0)
                {
                    this.mainForm.Keys = "caaa25959d0b0dcdad4dcacee631ad072928a6a992142f5b1458dd85aa705f8378cd89b7";
                    this.mainForm.EncKeys = "caaa25959d0b0dcdad4dcacee631ad072928a6a992142f5b1458dd85aa705f8378cd89b7";
                    this.Close();
                }
                else if (iosprovate.SelectedIndex == 3)
                {
                    this.mainForm.Keys = "8d82d03bdef93b72636b227332b06b71964ea275d4409887a83869835029c4ea2693261c";
                    this.mainForm.EncKeys = "8d82d03bdef93b72636b227332b06b71964ea275d4409887a83869835029c4ea2693261c";
                    this.Close();
                }
                else if (iosprovate.SelectedIndex == 4)
                {
                    this.mainForm.Keys = "1d057f3d18e1cefdaa939c52a8fc0a8c6ca7aea872e21cb80f25741635ebf3158e19bef0";
                    this.mainForm.EncKeys = "1d057f3d18e1cefdaa939c52a8fc0a8c6ca7aea872e21cb80f25741635ebf3158e19bef0";
                    this.Close();
                }
                else if (iosprovate.SelectedIndex == 1)
                {
                    MessageBox.Show("There are no keys published yet.", "F.C.E. 365 Firmware Manager X - Keychain", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (device.SelectedIndex == 7)
            {
                if (iosprovate.SelectedIndex == 2)
                {
                    this.mainForm.Keys = "b78a8d2cfd91984d192f634d7221443c9e2e322030b19006cf39e41a13353761dd990db4";
                    this.mainForm.EncKeys = "b78a8d2cfd91984d192f634d7221443c9e2e322030b19006cf39e41a13353761dd990db4";
                    this.Close();
                }
                else if (iosprovate.SelectedIndex == 0)
                {
                    this.mainForm.Keys = "b4f5be8525b506e0edfcc5140c9bdbbac81303ffb8442e052a12a0d8db41c5e3e3ad9b16";
                    this.mainForm.EncKeys = "b4f5be8525b506e0edfcc5140c9bdbbac81303ffb8442e052a12a0d8db41c5e3e3ad9b16";
                    this.Close();
                }
                else if (iosprovate.SelectedIndex == 3)
                {
                    this.mainForm.Keys = "b6827cde00de28ac5a8cf1c70be3a32f592e2dfa5015a291a2c4611693462280cef3921c";
                    this.mainForm.EncKeys = "b6827cde00de28ac5a8cf1c70be3a32f592e2dfa5015a291a2c4611693462280cef3921c";
                    this.Close();
                }
                else if (iosprovate.SelectedIndex == 4)
                {
                    this.mainForm.Keys = "67fc7fabc60e327474bcc2e55257ce91f0265cc01bdb839ccd405b4113023c4f8bfefa07";
                    this.mainForm.EncKeys = "67fc7fabc60e327474bcc2e55257ce91f0265cc01bdb839ccd405b4113023c4f8bfefa07";
                    this.Close();
                }
                else if (iosprovate.SelectedIndex == 1)
                {
                    MessageBox.Show("There are no keys published yet.", "F.C.E. 365 Firmware Manager X - Keychain", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void idevice_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
