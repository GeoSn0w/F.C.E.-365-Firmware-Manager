using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F.C.E._365_Firmware_Manager_X
{

    public partial class IPSWDL : Form
    {
        public IPSWDL()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progb.Value = e.ProgressPercentage;
        }
        private void iPSW_go_download_semaphore_Click(object sender, EventArgs e)
        {
            
        }
        private void progres_Tick(object sender, EventArgs e)
        {
            progb.Visible = true;
            protxt.Visible = true;
            protxt.Text = progb.Value + " %";
            if (protxt.Text == "100 %")
            {
                progres.Stop();
                MessageBox.Show("The iPSW was successfully downloaded on Desktop.", "F.C.E. 365 Firmware Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                progb.Visible = false;
                protxt.Visible = false;
            }
        }

        private void IPSWDL_Load(object sender, EventArgs e)
        {
            devices.SelectedIndex = 0;
            iosverr.SelectedIndex = 0;
        }

        private void iTalk_Panel1_Click(object sender, EventArgs e)
        {

        }

        private void devicess_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void iTalk_Button_21_Click(object sender, EventArgs e)
        {
            if (devices.SelectedIndex == 0)
            {
                if (iosverr.SelectedIndex == 4)
                {
                    using (WebClient wc = new WebClient())
                    {
                        wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                        wc.DownloadFileAsync(new System.Uri("http://appldnld.apple.com/iOS7.1/031-4812.20140627.cq6y8/iPhone3,1_7.1.2_11D257_Restore.ipsw"), path + "/iPhone3,1_7.1.2_11D257_Restore.ipsw");
                        progres.Start();

                    }
                }
                else
                {
                    MessageBox.Show("iPhone 4 does not support firmware newer than iOS 7.1.2", "F.C.E. 365 Firmware Manager X - Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (devices.SelectedIndex == 1)
            {
                if (iosverr.SelectedIndex == 4)
                {
                    using (WebClient wc = new WebClient())
                    {
                        wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                        wc.DownloadFileAsync(new System.Uri("http://appldnld.apple.com/iOS7.1/031-4785.20140627.zZ42j/iPhone3,2_7.1.2_11D257_Restore.ipsw"), path + "/iPhone3,2_7.1.2_11D257_Restore.ipsw");
                        progres.Start();

                    }
                }
                else
                {
                    MessageBox.Show("iPhone 4 does not support firmware newer than iOS 7.1.2", "F.C.E. 365 Firmware Manager X - Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (devices.SelectedIndex == 2)
            {
                if (iosverr.SelectedIndex == 4)
                {
                    using (WebClient wc = new WebClient())
                    {
                        wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                        wc.DownloadFileAsync(new System.Uri("http://appldnld.apple.com/iOS7.1/031-4768.20140627.DXmmp/iPhone3,3_7.1.2_11D257_Restore.ipsw"), path + "/iPhone3,3_7.1.2_11D257_Restore.ipsw");
                        progres.Start();
                    }
                }
                else
                {
                    MessageBox.Show("iPhone 4 does not support firmware newer than iOS 7.1.2", "F.C.E. 365 Firmware Manager X - Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (devices.SelectedIndex == 3)
            {
                if (iosverr.SelectedIndex == 1)
                {
                    using (WebClient wc = new WebClient())
                    {
                        wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                        wc.DownloadFileAsync(new System.Uri("http://appldnld.apple.com/iOS9.3.5/031-73068-20160825-6A2B99DE-6711-11E6-BB8F-133834D2D062/iPhone4,1_9.3.5_13G36_Restore.ipsw"), path + "/iPhone4,1_9.3.5_13G36_Restore.ipsw");
                        progres.Start();
                    }
                }
                else
                {
                    MessageBox.Show("iPhone 4S does not support firmware newer than iOS 9.3.5 and 7.1.2 is no longer signed.", "F.C.E. 365 Firmware Manager X - Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (devices.SelectedIndex == 4)
            {
                if (iosverr.SelectedIndex == 0)
                {
                    using (WebClient wc = new WebClient())
                    {
                        wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                        wc.DownloadFileAsync(new System.Uri("http://appldnld.apple.com/ios10.0/031-76540-20160907-1701C70E-71FE-11E6-B803-1CB934D2D062/iPhone_4.0_32bit_10.0.1_14A403_Restore.ipsw"), path + "/iPhone_4.0_32bit_10.0.1_14A403_Restore.ipsw");
                        progres.Start();
                    }
                }
                else
                {
                    MessageBox.Show("iPhone 5 does not support the selected firmware because it is no longer signed.", "F.C.E. 365 Firmware Manager X - Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            if (devices.SelectedIndex == 5)
            {
                if (iosverr.SelectedIndex == 0)
                {
                    using (WebClient wc = new WebClient())
                    {
                        wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                        wc.DownloadFileAsync(new System.Uri("http://appldnld.apple.com/ios10.0/031-76540-20160907-1701C70E-71FE-11E6-B803-1CB934D2D062/iPhone_4.0_32bit_10.0.1_14A403_Restore.ipsw"), path + "/iPhone_4.0_32bit_10.0.1_14A403_Restore.ipsw");
                        progres.Start();
                    }
                }
                else
                {
                    MessageBox.Show("iPhone 5 does not support the selected firmware because it is no longer signed.", "F.C.E. 365 Firmware Manager X - Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            if (devices.SelectedIndex == 6)
            {
                if (iosverr.SelectedIndex == 0)
                {
                    using (WebClient wc = new WebClient())
                    {
                        wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                        wc.DownloadFileAsync(new System.Uri("http://appldnld.apple.com/ios10.0/031-76540-20160907-1701C70E-71FE-11E6-B803-1CB934D2D062/iPhone_4.0_32bit_10.0.1_14A403_Restore.ipsw"), path + "/iPhone_4.0_32bit_10.0.1_14A403_Restore.ipsw");
                        progres.Start();
                    }
                }
                else
                {
                    MessageBox.Show("iPhone 5C does not support the selected firmware because it is no longer signed.", "F.C.E. 365 Firmware Manager X - Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            if (devices.SelectedIndex == 7)
            {
                if (iosverr.SelectedIndex == 0)
                {
                    using (WebClient wc = new WebClient())
                    {
                        wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                        wc.DownloadFileAsync(new System.Uri("http://appldnld.apple.com/ios10.0/031-76540-20160907-1701C70E-71FE-11E6-B803-1CB934D2D062/iPhone_4.0_32bit_10.0.1_14A403_Restore.ipsw"), path + "/iPhone_4.0_32bit_10.0.1_14A403_Restore.ipsw");
                        progres.Start();
                    }
                }
                else
                {
                    MessageBox.Show("iPhone 5C does not support the selected firmware because it is no longer signed.", "F.C.E. 365 Firmware Manager X - Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            if (devices.SelectedIndex == 8)
            {
                if (iosverr.SelectedIndex == 0)
                {
                    using (WebClient wc = new WebClient())
                    {
                        wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                        wc.DownloadFileAsync(new System.Uri("http://appldnld.apple.com/ios10.0/031-76074-20160907-17028284-71FE-11E6-938C-0CB934D2D062/iPhone_4.0_64bit_10.0.1_14A403_Restore.ipsw"), path + "/iPhone_4.0_64bit_10.0.1_14A403_Restore.ipsw");
                        progres.Start();
                    }
                }
                else
                {
                    MessageBox.Show("iPhone 5S does not support the selected firmware because it is no longer signed.", "F.C.E. 365 Firmware Manager X - Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            if (devices.SelectedIndex == 9)
            {
                if (iosverr.SelectedIndex == 0)
                {
                    using (WebClient wc = new WebClient())
                    {
                        wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                        wc.DownloadFileAsync(new System.Uri("http://appldnld.apple.com/ios10.0/031-76074-20160907-17028284-71FE-11E6-938C-0CB934D2D062/iPhone_4.0_64bit_10.0.1_14A403_Restore.ipsw"), path + "/iPhone_4.0_64bit_10.0.1_14A403_Restore.ipsw");
                        progres.Start();
                    }
                }
                else
                {
                    MessageBox.Show("iPhone 5S does not support the selected firmware because it is no longer signed.", "F.C.E. 365 Firmware Manager X - Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            if (devices.SelectedIndex == 10)
            {
                if (iosverr.SelectedIndex == 0)
                {
                    using (WebClient wc = new WebClient())
                    {
                        wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                        wc.DownloadFileAsync(new System.Uri("http://appldnld.apple.com/ios10.0/031-76595-20160907-1703F3F8-71FE-11E6-90AF-1DB934D2D062/iPhone_4.7_10.0.1_14A403_Restore.ipsw"), path + "/iPhone_4.7_10.0.1_14A403_Restore.ipsw");
                        progres.Start();
                    }
                }
                else
                {
                    MessageBox.Show("iPhone 6 does not support the selected firmware because it is no longer signed.", "F.C.E. 365 Firmware Manager X - Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            if (devices.SelectedIndex == 11)
            {
                if (iosverr.SelectedIndex == 0)
                {
                    using (WebClient wc = new WebClient())
                    {
                        wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                        wc.DownloadFileAsync(new System.Uri("http://appldnld.apple.com/ios10.0/031-76515-20160907-1706DC08-71FE-11E6-9075-18B934D2D062/iPhone_5.5_10.0.1_14A403_Restore.ipsw"), path + "/iPhone_5.5_10.0.1_14A403_Restore.ipsw");
                        progres.Start();
                    }
                }
                else
                {
                    MessageBox.Show("iPhone 6 Plus does not support the selected firmware because it is no longer signed.", "F.C.E. 365 Firmware Manager X - Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            if (devices.SelectedIndex == 12)
            {
                if (iosverr.SelectedIndex == 0)
                {
                    using (WebClient wc = new WebClient())
                    {
                        wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                        wc.DownloadFileAsync(new System.Uri("http://appldnld.apple.com/ios10.0/031-76595-20160907-1703F3F8-71FE-11E6-90AF-1DB934D2D062/iPhone_4.7_10.0.1_14A403_Restore.ipsw"), path + "/iPhone_4.7_10.0.1_14A403_Restore.ipsw");
                        progres.Start();
                    }
                }
                else
                {
                    MessageBox.Show("iPhone 6S does not support the selected firmware because it is no longer signed.", "F.C.E. 365 Firmware Manager X - Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            if (devices.SelectedIndex == 13)
            {
                if (iosverr.SelectedIndex == 0)
                {
                    using (WebClient wc = new WebClient())
                    {
                        wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                        wc.DownloadFileAsync(new System.Uri("http://appldnld.apple.com/ios10.0/031-76515-20160907-1706DC08-71FE-11E6-9075-18B934D2D062/iPhone_5.5_10.0.1_14A403_Restore.ipsw"), path + "/iPhone_5.5_10.0.1_14A403_Restore.ipsw");
                        progres.Start();
                    }
                }
                else
                {
                    MessageBox.Show("iPhone 6S Plus does not support the selected firmware because it is no longer signed.", "F.C.E. 365 Firmware Manager X - Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            if (devices.SelectedIndex == 14)
            {
                if (iosverr.SelectedIndex == 0)
                {
                    using (WebClient wc = new WebClient())
                    {
                        wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                        wc.DownloadFileAsync(new System.Uri("http://appldnld.apple.com/ios10.0/031-76426-20160907-170397D2-71FE-11E6-B857-16B934D2D062/iPhoneSE_10.0.1_14A403_Restore.ipsw"), path + "/iPhoneSE_10.0.1_14A403_Restore.ipsw");
                        progres.Start();
                    }
                }
                else
                {
                    MessageBox.Show("iPhone SE does not support the selected firmware or it is no longer signed.", "F.C.E. 365 Firmware Manager X - Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            if (devices.SelectedIndex == 15)
            {
                if (iosverr.SelectedIndex == 0)
                {
                    using (WebClient wc = new WebClient())
                    {
                        wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                        wc.DownloadFileAsync(new System.Uri("http://appldnld.apple.com/ios10.0/031-76223-20160907-1701DA0A-71FE-11E6-B30E-10B934D2D062/iPhone9,1_10.0.1_14A403_Restore.ipsw"), path + "/iPhone9,1_10.0.1_14A403_Restore.ipsw");
                        progres.Start();
                    }
                }
                else
                {
                    MessageBox.Show("iPhone 7 does not support the selected firmware.", "F.C.E. 365 Firmware Manager X - Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            if (devices.SelectedIndex == 16)
            {
                if (iosverr.SelectedIndex == 0)
                {
                    using (WebClient wc = new WebClient())
                    {
                        wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                        wc.DownloadFileAsync(new System.Uri("http://appldnld.apple.com/ios10.0/031-76519-20160907-1703BE42-71FE-11E6-AE6D-1AB934D2D062/iPhone9,2_10.0.1_14A403_Restore.ipsw"), path + "/iPhone9,2_10.0.1_14A403_Restore.ipsw");
                        progres.Start();
                    }
                }
                else
                {
                    MessageBox.Show("iPhone 7 Plus does not support the selected firmware.", "F.C.E. 365 Firmware Manager X - Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
