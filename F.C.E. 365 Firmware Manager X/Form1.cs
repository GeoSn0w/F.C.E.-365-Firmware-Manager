using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F.C.E._365_Firmware_Manager_X
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            semaphore_wait();
        }
        private void semaphore_wait()
        {
            var path = Application.StartupPath;
            if (File.Exists(path + "/Data/dmg.exe"))
            {
              //Do absolutely nothing.
            }
            else
            {
                MessageBox.Show("Ooops! Application seem to be incomplete... Make sure you have the Data folder!", "F.C.E. 365 Firmware Manager X - Integrity Check GateKeeper", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
        private void KeysBtn_Click(object sender, EventArgs e)
        {
            ThemKeys frm = new ThemKeys(this);
            frm.Show();
        }

        public string Keys
        {
            get { return AES_KEY_DEC.Text; }
            set { AES_KEY_DEC.Text = value; }
        }
        public string EncKeys
        {
            get { return AES_ENC_KEY.Text; }
            set { AES_ENC_KEY.Text = value; }
        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        private void iTalk_Button_21_Click(object sender, EventArgs e)
        {
            WSI_Panel_FCE_LOG.Visible = true;
        }

        private void iTalk_Button_210_Click(object sender, EventArgs e)
        {
            WSI_Panel_FCE_LOG.SelectedIndex = 1;
        }

        private void iTalk_Button_211_Click(object sender, EventArgs e)
        {
            string pat1 = Application.StartupPath;
            ProcessStartInfo psi = default(ProcessStartInfo);
            dynamic procname = pat1 + "/Data/dmg.exe";
            dynamic filename = OrigDMGFL.Text;
            dynamic shel = "extract";
            dynamic newfile = NewDMGPh.Text;
            dynamic kapa = "-k";
            dynamic key = AES_KEY_DEC.Text;
            dynamic args = string.Format(" {0} {1} {2} {3} {4}", shel, filename, newfile, kapa, key);
            psi = new ProcessStartInfo(procname, args);
            Process proc = new Process();
            proc.StartInfo = psi;
            proc.Start();
        }

        private void iTalk_Button_11_Click(object sender, EventArgs e)
        {
            DialogResult result = DMGEngine.ShowDialog();
            if (result == DialogResult.OK)
            {
                var quote = quoter.Text;
                OrigDMGFL.Text = quote + DMGEngine.FileName + quote;
            }
        }

        private void iTalk_Button_13_Click(object sender, EventArgs e)
        {
            DMGBuilder.Filter = "Apple DMG File | *.dmg";
            DMGBuilder.DefaultExt = ".dmg";
            DMGBuilder.FileName = "Name the file";
            DMGBuilder.Title = "Save the encrypted DMG file...";
            DialogResult result = DMGBuilder.ShowDialog();
            if (result == DialogResult.OK)
            {
                var quote = quoter.Text;
                NewDMGPh.Text = quote + DMGBuilder.FileName + quote;
            }
        }

        private void iTalk_Button_15_Click(object sender, EventArgs e)
        {
            DialogResult result = DMGEngine.ShowDialog();
            if (result == DialogResult.OK)
            {
                var quote = quoter.Text;
                ModDMGFl.Text = quote + DMGEngine.FileName + quote;
            }
        }

        private void iTalk_Button_14_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://theiphonewiki.com/wiki/Firmware");
        }

        private void iTalk_Button_12_Click(object sender, EventArgs e)
        {
            DMGBuilder.Filter = "Apple DMG File | *.dmg";
            DMGBuilder.DefaultExt = ".dmg";
            DMGBuilder.FileName = "Name the file";
            DMGBuilder.Title = "Save the encrypted DMG file...";
            DialogResult result = DMGBuilder.ShowDialog();
            if (result == DialogResult.OK)
            {
                var quote = quoter.Text;
                New_ENC_DMG_PH.Text = quote + DMGBuilder.FileName + quote;
            }
        }

        private void Encryption_Engine_Click(object sender, EventArgs e)
        {
            string pat1 = Application.StartupPath;
            ProcessStartInfo psi = default(ProcessStartInfo);
            dynamic procname = pat1 + "/Data/dmg.exe";
            dynamic filename = ModDMGFl.Text;
            dynamic shel = "build";
            dynamic newfile = New_ENC_DMG_PH.Text;
            dynamic kapa = "-k";
            dynamic key = AES_ENC_KEY.Text;
            dynamic args = string.Format(" {0} {1} {2} {3}{4}", shel, filename, newfile, kapa, key);
            psi = new ProcessStartInfo(procname, args);
            Process proc = new Process();
            proc.StartInfo = psi;
            proc.Start();
        }

        private void iTalk_Button_18_Click(object sender, EventArgs e)
        {
            DMGEngine.Filter = "Apple DMG File | *.dmg*";
            DMGEngine.Title = "Choose the ramdisk DMG file...";
            DMGEngine.FileName = "iOS Ramdisk";
            DialogResult result = DMGEngine.ShowDialog();
            if (result == DialogResult.OK)
            {
                RD_DMG_PH.Text = quoter.Text + DMGEngine.FileName + quoter.Text;
            }
        }

        private void iTalk_Button_16_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://theiphonewiki.com/wiki/Firmware");
        }

        private void iTalk_Button_19_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://theiphonewiki.com/wiki/Firmware");
        }

        private void iTalk_Button_17_Click(object sender, EventArgs e)
        {
            DMGBuilder.Filter = "Apple DMG File | *.dmg";
            DMGBuilder.DefaultExt = ".dmg";
            DMGBuilder.FileName = "Name the file";
            DMGBuilder.Title = "Save the Decrypted Ramdisk file...";
            DialogResult result = DMGBuilder.ShowDialog();
            if (result == DialogResult.OK)
            {
                var quote = quoter.Text;
                DMG_BUILD_ENGINE_PH.Text = quote + DMGBuilder.FileName + quote;
            }
        }

        private void iTalk_Button_212_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = default(ProcessStartInfo);
            string pat1 = Application.StartupPath;
            dynamic procname = pat1 + "/Data/xpwntool.exe";
            dynamic filename = RD_DMG_PH.Text;
            dynamic newfile = DMG_BUILD_ENGINE_PH.Text;
            dynamic kapa = "-k";
            dynamic iv = IV_KBAG_DOOM.Text;
            dynamic ivname = "-iv";
            dynamic key = AES.Text;
            dynamic args = string.Format(" {0} {1} {2} {3} {4} {5}", filename, newfile, kapa, key, ivname, iv);
            psi = new ProcessStartInfo(procname, args);
            Process proc = new Process();
            proc.StartInfo = psi;
            proc.Start();
        }

        private void iTalk_Button_112_Click(object sender, EventArgs e)
        {
            dynamic quote = quoter.Text;
            IMG3Engine.Filter = "IMG3 File (*.img3)|*.img3|DFU File (*.dfu)|*.dfu|ASR and Other files (*.*)|*.*";
            IMG3Engine.Title = "Choose the original file...";
            IMG3Engine.FileName = "IMG3 / IMG3 File...";
            DialogResult result = IMG3Engine.ShowDialog();
            if (result == DialogResult.OK)
            {
                OriginalDFU.Text = quoter.Text + IMG3Engine.FileName + quoter.Text;
            }
        }

        private void iTalk_Button_111_Click(object sender, EventArgs e)
        {
            dynamic quote = quoter.Text;
            IMG3Engine.Filter = "Patch Files | *.patch";
            IMG3Engine.Title = "Open the patch file...";
            IMG3Engine.FileName = "asr.patch";
            IMG3Engine.DefaultExt = ".PATCH";
            DialogResult result = IMG3Engine.ShowDialog();
            if (result == DialogResult.OK)
            {
                PatchFilePf.Text = quoter.Text + IMG3Engine.FileName + quoter.Text;
            }
        }

        private void iTalk_Button_110_Click(object sender, EventArgs e)
        {
            DMGBuilder.Filter = "Patched Files | *.patched";
            DMGBuilder.DefaultExt = ".PATCHED";
            DMGBuilder.FileName = "file.patched";
            DMGBuilder.Title = "Save the patched file...";
            DialogResult result = DMGBuilder.ShowDialog();
            if (result == DialogResult.OK)
            {
                var quote = quoter.Text;
                PatchedFilePf.Text = quote + DMGBuilder.FileName + quote;
            }
        }

        private void iTalk_Button_213_Click(object sender, EventArgs e)
        {
            {
                ProcessStartInfo psi2 = default(ProcessStartInfo);
                Process proc = new Process();
                string pat1 = Application.StartupPath;
                dynamic process3 = pat1 + "/Data/bspatch.exe";
                dynamic asrorigi = OriginalDFU.Text;
                dynamic asrpatch = PatchFilePf.Text;
                dynamic finalpatch = PatchedFilePf.Text;
                dynamic args3 = string.Format(" {0} {1} {2}", asrorigi, finalpatch, asrpatch);
                psi2 = new ProcessStartInfo(process3, args3);
                proc.StartInfo = psi2;
                proc.Start();
                MessageBox.Show("Done creating PATCHED File!", "F.C.E. 365 Firmware Manager X", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void iTalk_Button_113_Click(object sender, EventArgs e)
        {
            dynamic quote = quoter.Text;
            IMG3Engine.Filter = "IMG3 File (*.img3)|*.img3|DFU File (*.dfu)|*.dfu|Other file (*.*)|*.*";
            IMG3Engine.Title = "Choose the IMG3/DFU file...";
            IMG3Engine.FileName = "IMG3 / IMG3 File...";
            DialogResult result = IMG3Engine.ShowDialog();
            if (result == DialogResult.OK)
            {
                OrigIMG3.Text = quoter.Text + IMG3Engine.FileName + quoter.Text;
            }
        }

        private void iTalk_Button_114_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://theiphonewiki.com/wiki/Firmware");
        }

        private void iTalk_Button_115_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://theiphonewiki.com/wiki/Firmware");
        }

        private void iTalk_Button_116_Click(object sender, EventArgs e)
        {
            IMG3Builder.Filter = "IMG3 File (*.img3)|*.img3|DFU File (*.dfu)|*.dfu|Other file (*.*)|*.*";
            IMG3Builder.DefaultExt = ".img3";
            IMG3Builder.FileName = "Name the file";
            IMG3Builder.Title = "Save the decrypted file...";
            DialogResult result = IMG3Builder.ShowDialog();
            if (result == DialogResult.OK)
            {
                var quote = quoter.Text;
                NewIMG3.Text = quote + IMG3Builder.FileName + quote;
            }
        }

        private void iTalk_Button_214_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(OrigIMG3.Text))
            {
                MessageBox.Show("All fields are required!", "F.C.E. 365 Firmware Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (string.IsNullOrEmpty(NewIMG3.Text))
                {
                    MessageBox.Show("All fields are required!", "F.C.E. 365 Firmware Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (string.IsNullOrEmpty(ivimg3.Text))
                    {
                        MessageBox.Show("All fields are required!", "F.C.E. 365 Firmware Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(keyimg3.Text))
                        {
                            MessageBox.Show("All fields are required!", "F.C.E. 365 Firmware Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            ProcessStartInfo psi = default(ProcessStartInfo);
                            string pat1 = Application.StartupPath;
                            dynamic procname = pat1 + "/Data/xpwntool.exe";
                            dynamic filename = OrigIMG3.Text;
                            dynamic newfile = NewIMG3.Text;
                            dynamic kapa = "-k";
                            dynamic iv = ivimg3.Text;
                            dynamic ivname = "-iv";
                            dynamic key = keyimg3.Text;
                            dynamic args = string.Format(" {0} {1} {2} {3} {4} {5}", filename, newfile, kapa, key, ivname, iv);
                            psi = new ProcessStartInfo(procname, args);
                            Process proc = new Process();
                            proc.StartInfo = psi;
                            proc.Start();
                        }
                    }
                }
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iTalk_Button_215_Click(object sender, EventArgs e)
        {
            if (cydia.Checked == true)
            {
                Erase_Restore.Checked = true;
                ProcessStartInfo psi2 = default(ProcessStartInfo);
                Process proc = new Process();
                dynamic parameter1 = "-u --";
                string pat1 = Application.StartupPath;
                dynamic process3 = pat1 + "/Data/idevicerestore.exe";
                dynamic udid = UniqueDeviceID.Text;
                dynamic ipswname1 = IPSWFilePH.Text;
                dynamic nor = "-s";
                dynamic param1 = RestoreParam.Text;
                dynamic args3 = string.Format("{0}{1} {2} {3} {4}", parameter1, udid, param1, nor, ipswname1);
                psi2 = new ProcessStartInfo(process3, args3);
                proc.StartInfo = psi2;
                proc.Start();
                proc.WaitForExit();
                if (proc.HasExited == true)
                {
                    MessageBox.Show("It seems that the restore system has finished the action. Check your phone to see if it does restored! P.S. After the CMD window closes, you need to wait as the phone will still show an Apple logo for a short period of time. Is normal", "F.C.E. 365 Firmware Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            if (NOR.Checked == true)
            {
                Erase_Restore.Checked = true;
                ProcessStartInfo psi2 = default(ProcessStartInfo);
                Process proc = new Process();
                dynamic parameter1 = "-u --";
                string pat1 = Application.StartupPath;
                dynamic process3 = pat1 + "/Data/idevicerestore.exe";
                dynamic udid = UniqueDeviceID.Text;
                dynamic ipswname1 = IPSWFilePH.Text;
                dynamic nor = "-x";
                dynamic param1 = RestoreParam.Text;
                dynamic args3 = string.Format("{0}{1} {2} {3} {4}", parameter1, udid, param1, nor, ipswname1);
                psi2 = new ProcessStartInfo(process3, args3);
                proc.StartInfo = psi2;
                proc.Start();
                proc.WaitForExit();
                if (proc.HasExited == true)
                {
                    MessageBox.Show("It seems that the restore system has finished the action. Check your phone to see if it does restored! P.S. After the CMD window closes, you need to wait as the phone will still show an Apple logo for a short period of time. Is normal", "F.C.E. 365 Firmware Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            if (RestoreParam.Text == "-c")
            {
                ProcessStartInfo psi2 = default(ProcessStartInfo);
                Process proc = new Process();
                dynamic parameter1 = "-u --";
                string pat1 = Application.StartupPath;
                dynamic process3 = pat1 + "/Data/idevicerestore.exe";
                dynamic udid = UniqueDeviceID.Text;
                dynamic ipswname1 = IPSWFilePH.Text;
                dynamic param1 = RestoreParam.Text;
                dynamic args3 = string.Format("{0}{1} {2} {3}", parameter1, udid, param1, ipswname1);
                psi2 = new ProcessStartInfo(process3, args3);
                proc.StartInfo = psi2;
                proc.Start();
                proc.WaitForExit();
                if (proc.HasExited == true)
                {
                    MessageBox.Show("It seems that the restore system has finished the action. Check your phone to see if it does restored! P.S. After the CMD window closes, you need to wait as the phone will still show an Apple logo for a short period of time. Is normal", "F.C.E. 365 Firmware Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (string.IsNullOrEmpty(RestoreParam.Text))
            {
                ProcessStartInfo psi2 = default(ProcessStartInfo);
                Process proc = new Process();
                dynamic parameter1 = "-u --";
                string pat1 = Application.StartupPath;
                dynamic process3 = pat1 + "/Data/idevicerestore.exe";
                dynamic udid = UniqueDeviceID.Text;
                dynamic ipswname1 = IPSWFilePH.Text;
                dynamic param1 = RestoreParam.Text;
                dynamic args3 = string.Format("{0}{1} {2} {3}", parameter1, udid, param1, ipswname1);
                psi2 = new ProcessStartInfo(process3, args3);
                proc.StartInfo = psi2;
                proc.Start();
                proc.WaitForExit();
                if (proc.HasExited == true)
                {
                    MessageBox.Show("It seems that the restore system has finished the action. Check your phone to see if it does restored! P.S. After the CMD window closes, you need to wait as the phone will still show an Apple logo for a short period of time. Is normal", "F.C.E. 365 Firmware Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (RestoreParam.Text == "-e")
            {
                ProcessStartInfo psi2 = default(ProcessStartInfo);
                Process proc = new Process();
                dynamic parameter1 = "-u --";
                string pat1 = Application.StartupPath;
                dynamic process3 = pat1 + "/Data/idevicerestore.exe";
                dynamic udid = UniqueDeviceID.Text;
                dynamic ipswname1 = IPSWFilePH.Text;
                dynamic param1 = RestoreParam.Text;
                dynamic args3 = string.Format("{0}{1} {2} {3}", parameter1, udid, param1, ipswname1);
                psi2 = new ProcessStartInfo(process3, args3);
                proc.StartInfo = psi2;
                proc.Start();
                proc.WaitForExit();
                if (proc.HasExited == true)
                {
                    MessageBox.Show("It seems that the restore system has finished the action. Check your phone to see if it does restored! P.S. After the CMD window closes, you need to wait as the phone will still show an Apple logo for a short period of time. Is normal", "F.C.E. 365 Firmware Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (RestoreParam.Text == "-|")
            {
                ProcessStartInfo psi2 = default(ProcessStartInfo);
                Process proc = new Process();
                dynamic parameter1 = "-u --";
                string pat1 = Application.StartupPath;
                dynamic process3 = pat1 + "/Data/idevicerestore.exe";
                dynamic udid = UniqueDeviceID.Text;
                dynamic ipswname1 = IPSWFilePH.Text;
                dynamic param1 = RestoreParam.Text;
                dynamic args3 = string.Format("{0}{1} {2}", parameter1, udid, param1);
                psi2 = new ProcessStartInfo(process3, args3);
                proc.StartInfo = psi2;
                proc.Start();
                proc.WaitForExit();

                if (proc.HasExited == true)
                {
                    MessageBox.Show("It seems that the restore system has finished the action. Check your phone to see if it does restored! P.S. After the CMD window closes, you need to wait as the phone will still show an Apple logo for a short period of time. Is normal", "F.C.E. 365 Firmware Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void iTalk_Button_118_Click(object sender, EventArgs e)
        {
            string pat1 = Application.StartupPath;
            dynamic procname = pat1 + "/Data/ReadLine5.bat";
            dynamic psi = new ProcessStartInfo(procname);
            Process proc = new Process();
            proc.StartInfo = psi;
            proc.Start();
            try
            {
                System.IO.StreamReader read = default(System.IO.StreamReader);
                read = File.OpenText("c:\\output.txt");
                while (!(read.EndOfStream))
                {
                    UniqueDeviceID.Text = read.ReadLine();
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void iTalk_Button_119_Click(object sender, EventArgs e)
        {
            string pat1 = Application.StartupPath;
            dynamic procname = pat1 + "/Data/ReadLine6.bat";
            dynamic psi = new ProcessStartInfo(procname);
            Process proc = new Process();
            proc.StartInfo = psi;
            proc.Start();
            try
            {
                System.IO.StreamReader read = default(System.IO.StreamReader);
                read = File.OpenText("c:\\output.txt");
                while (!(read.EndOfStream))
                {

                }
            }
            catch (Exception ex)
            {
            }
        }

        private void iTalk_Button_117_Click(object sender, EventArgs e)
        {
            dynamic quote = quoter.Text;
            OpenIPSW.Filter = "IPSW Files | *.ipsw";
            OpenIPSW.Title = "Choose a firmware file...";
            OpenIPSW.FileName = "Please choose an IPSW firmware...";
            DialogResult result = OpenIPSW.ShowDialog();
            if (result == DialogResult.OK)
            {
                IPSWFilePH.Text = quoter.Text + OpenIPSW.FileName + quoter.Text;
            }
        }

        private void iTalk_Button_215_Click_1(object sender, EventArgs e)
        {
            ProcessStartInfo psi2 = default(ProcessStartInfo);
            Process proc = new Process();
            string pat1 = Application.StartupPath;
            dynamic process3 = pat1 + "/Data/idevicerestore.exe";
            dynamic args = "-p";
            psi2 = new ProcessStartInfo(process3, args);
            proc.StartInfo = psi2;
            proc.Start();
        }

        private void iTalk_Button_216_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi2 = default(ProcessStartInfo);
            Process proc = new Process();
            string pat1 = Application.StartupPath;
            dynamic process3 = pat1 + "/Data/iTunnel.exe";
            dynamic args = "--autoboot";
            psi2 = new ProcessStartInfo(process3, args);
            proc.StartInfo = psi2;
            proc.Start();
        }

        private void iTalk_Button_217_Click(object sender, EventArgs e)
        {
            string webAddress = "https://fce365.info/f-a-q-cfw-bypass/";
            Process.Start(webAddress);
        }

        private void iTalk_Button_220_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://youtube.com/fce365official");
        }

        private void iTalk_Button_219_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://theiphonewiki.com/");
        }

        private void iTalk_Button_218_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessStartInfo psi = default(ProcessStartInfo);
                string pat1 = Application.StartupPath;
                dynamic procname = pat1 + "/Data/idevicebackup2.exe";
                dynamic commands = "backup --full c:/";
                dynamic args = string.Format(" {0}", commands);
                psi = new ProcessStartInfo(procname, args);
                Process proc = new Process();
                proc.StartInfo = psi;
                proc.Start();
                if (proc.HasExited)
                {
                    MessageBox.Show("If a device was plogged in and was working, a backup should have been created in C:/ - Please check for it!", "F.C.E. 365 Firmware Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("STOP! Cannot successfully backup!", "F.C.E. 365 Firmware Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void iTalk_Button_223_Click(object sender, EventArgs e)
        {
            IPSWDL IPSWDL = new IPSWDL();
            IPSWDL.Show();
        }

        private void iTalk_Button_222_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://ipswcentral.com/");
        }

        private void iTalk_Button_221_Click(object sender, EventArgs e)
        {
            //Bound to be replaced to work with new patches model soon.
        }

        private void iTalk_Button_226_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://forum.fce365.info");
        }

        private void iTalk_Button_225_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://en.pangu.io");
        }

        private void iTalk_Button_224_Click(object sender, EventArgs e)
        {
            Page2.Visible = true;
        }

        private void iTalk_Button_227_Click(object sender, EventArgs e)
        {
            string webAddress = "https://fce365.info/contact-us/";
            Process.Start(webAddress);
        }

        private void iTalk_HeaderLabel18_Click(object sender, EventArgs e)
        {
            string webAddress = "https://twitter.com/FCE365";
            Process.Start(webAddress);
        }

        private void iTalk_HeaderLabel19_Click(object sender, EventArgs e)
        {
            string webAddress = "https://youtube.com/fce365official";
            Process.Start(webAddress);
        }

        private void iTalk_HeaderLabel20_Click(object sender, EventArgs e)
        {
            string webAddress = "https://www.facebook.com/fce365official/";
            Process.Start(webAddress);
        }

        private void iTalk_HeaderLabel21_Click(object sender, EventArgs e)
        {
            string webAddress = "https://fce365.info";
            Process.Start(webAddress);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            string webAddress = "https://fce365.info";
            Process.Start(webAddress);
        }

        private void Button34_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void iTalk_Button_22_Click(object sender, EventArgs e)
        {
            WSI_Panel_FCE_LOG.SelectedIndex = 2;
        }

        private void iTalk_Button_26_Click(object sender, EventArgs e)
        {
            WSI_Panel_FCE_LOG.SelectedIndex = 3;
        }

        private void iTalk_Button_23_Click(object sender, EventArgs e)
        {
            WSI_Panel_FCE_LOG.SelectedIndex = 4;
        }

        private void iTalk_Button_24_Click(object sender, EventArgs e)
        {
            WSI_Panel_FCE_LOG.SelectedIndex = 5;
        }

        private void iTalk_Button_25_Click(object sender, EventArgs e)
        {
            itools.Visible = true;
        }

        private void iTalk_Button_27_Click(object sender, EventArgs e)
        {
            WSI_Panel_FCE_LOG.SelectedIndex = 7;
        }

        private void iTalk_Button_28_Click(object sender, EventArgs e)
        {
            WSI_Panel_FCE_LOG.SelectedIndex = 8;
        }

        private void iTalk_Button_29_Click(object sender, EventArgs e)
        {
            WSI_Panel_FCE_LOG.SelectedIndex = 9;
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            WSI_Panel_FCE_LOG.SelectedIndex = 0;
        }

        private void iTalk_HeaderLabel3_Click(object sender, EventArgs e)
        {
            string webAddress = "https://youtube.com/fce365official";
            Process.Start(webAddress);
        }

        private void Page1btn_Click(object sender, EventArgs e)
        {
            Page2.Visible = false;
            page1.Visible = true;
        }

        private void iTalk_Button_230_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi2 = default(ProcessStartInfo);
            Process proc = new Process();
            dynamic parameter1 = " deactivate";
            string pat1 = Application.StartupPath;
            dynamic process3 = pat1 + "/Data/ideviceactivation.exe";
            dynamic args3 = string.Format("{0}", parameter1);
            psi2 = new ProcessStartInfo(process3, args3);
            proc.StartInfo = psi2;
            proc.Start();
        }

        private void iTalk_Button_233_Click(object sender, EventArgs e)
        {

            HashCalculator HashCalculator = new HashCalculator();
            HashCalculator.Show();
        }

        private void iTalk_Button_231_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi2 = default(ProcessStartInfo);
            Process proc = new Process();
            dynamic parameter1 = "";
            string pat1 = Application.StartupPath;
            dynamic process3 = pat1 + "/Data/rear.bat";
            dynamic args3 = string.Format("{0}", parameter1);
            psi2 = new ProcessStartInfo(process3, args3);
            proc.StartInfo = psi2;
            proc.Start();
        }

        private void iTalk_Button_234_Click(object sender, EventArgs e)
        {
            string webAddress = "https://winscp.net/eng/download.php";
            Process.Start(webAddress);
        }

        private void iTalk_Button_235_Click(object sender, EventArgs e)
        {
            DFU DFU = new DFU();
            DFU.Show();
        }

        private void iTalk_Button_229_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void iTalk_Button_236_Click(object sender, EventArgs e)
        {
            string webAddress = "http://en.pangu.io/help.html";
            Process.Start(webAddress);
        }

        private void iTalk_Button_237_Click(object sender, EventArgs e)
        {
            cijmod cijmod = new cijmod();
            cijmod.Show();
        }

        private void DMGEngine_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void iTalk_Button_238_Click(object sender, EventArgs e)
        {
            UDIDchallange UDIDchalange = new UDIDchallange();
            UDIDchalange.Show();
        }

        private void iTalk_Button_238_Click_1(object sender, EventArgs e)
        {
            rec rec = new rec();
            rec.Show();
        }

        private void iTalk_Button_239_Click_1(object sender, EventArgs e)
        {
            Page2.Visible = false;
            Page3.Visible = true;

        }

        private void iTalk_Button_251_Click(object sender, EventArgs e)
        {
            Page3.Visible = false;
            Page2.Visible = true;
        }

        private void iTalk_Button_240_Click(object sender, EventArgs e)
        {
            fcehex fcehex = new fcehex();
            fcehex.Show();
        }

        private void iTalk_Button_248_Click(object sender, EventArgs e)
        {
            partialdl partialdl = new partialdl();
            partialdl.Show();
        }

        private void iTalk_Button_239_Click_2(object sender, EventArgs e)
        {
            {
                ProcessStartInfo psi2 = default(ProcessStartInfo);
                Process proc = new Process();
                string pat1 = Application.StartupPath;
                dynamic process3 = pat1 + "/Data/img4.exe";
                dynamic parameter = "-image";
                dynamic buildfl = fpath.Text;
                dynamic orgfl = i10ofile.Text;
                dynamic args3 = string.Format(" {0} {1} {2}", parameter, orgfl, buildfl);
                psi2 = new ProcessStartInfo(process3, args3);
                proc.StartInfo = psi2;
                proc.Start();
                MessageBox.Show("Done creating Decrypted File!", "F.C.E. 365 Firmware Manager X", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            itools.Visible = false;
        }

        private void iTalk_Button_118_Click_1(object sender, EventArgs e)
        {
            DialogResult result = i10od.ShowDialog();
            if (result == DialogResult.OK)
            {
                i10ofile.Text = quoter.Text + i10od.FileName + quoter.Text;
            }
        }
       
        private void itools_Paint(object sender, PaintEventArgs e)
        {
        
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            itools.Visible = false;
        }


        private void iTalk_Button_120_Click(object sender, EventArgs e)
        {
            DialogResult result = svi10f.ShowDialog();
            if (result == DialogResult.OK)
            {
                fpath.Text = quoter.Text + svi10f.FileName + quoter.Text;
            }
        }

        private void iTalk_Button_239_Click_3(object sender, EventArgs e)
        {
            IOApplicationAccellerator IOApplicationAccellerator = new IOApplicationAccellerator();
            IOApplicationAccellerator.Show();
        }

        private void iTalk_Button_240_Click_1(object sender, EventArgs e)
        {
            fcehex fcehex = new fcehex();
            fcehex.Show();
        }

        private void iTalk_Button_241_Click(object sender, EventArgs e)
        {
            framework12 framework12 = new framework12();
            framework12.Show();
        }

        private void iTalk_Button_241_Click_1(object sender, EventArgs e)
        {
            string webAddress = "http://status.fce365.info";
            Process.Start(webAddress);
        }

        private void iTalk_Button_242_Click(object sender, EventArgs e)
        {
            string webAddress = "https://github.com/GeoSn0w/Yalu-Jailbreak-iOS-10.2/tree/master/IPA%20Build";
            Process.Start(webAddress);
        }

        private void Guid_Click(object sender, EventArgs e)
        {

        }
    }
}
