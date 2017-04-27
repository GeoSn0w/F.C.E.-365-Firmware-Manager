namespace F.C.E._365_Firmware_Manager_X
{
    partial class IPSWDL
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.header = new iTalk.iTalk_HeaderLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iTalk_Panel1 = new iTalk.iTalk_Panel();
            this.iTalk_HeaderLabel2 = new iTalk.iTalk_HeaderLabel();
            this.iPSWDLgo = new iTalk.iTalk_Button_2();
            this.protxt = new System.Windows.Forms.Label();
            this.progb = new System.Windows.Forms.ProgressBar();
            this.iTalk_Panel5 = new iTalk.iTalk_Panel();
            this.iosverr = new System.Windows.Forms.ComboBox();
            this.iTalk_Panel4 = new iTalk.iTalk_Panel();
            this.devices = new System.Windows.Forms.ComboBox();
            this.progres = new System.Windows.Forms.Timer(this.components);
            this.prog = new iTalk.iTalk_HeaderLabel();
            this.ipswdlprog = new System.Windows.Forms.ProgressBar();
            this.iTalk_HeaderLabel1 = new iTalk.iTalk_HeaderLabel();
            this.iPSW_go_download_semaphore = new iTalk.iTalk_Button_2();
            this.iTalk_Panel3 = new iTalk.iTalk_Panel();
            this.iosver = new System.Windows.Forms.ComboBox();
            this.iTalk_Panel2 = new iTalk.iTalk_Panel();
            this.device = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.iTalk_Panel1.SuspendLayout();
            this.iTalk_Panel5.SuspendLayout();
            this.iTalk_Panel4.SuspendLayout();
            this.iTalk_Panel3.SuspendLayout();
            this.iTalk_Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.BackColor = System.Drawing.Color.Transparent;
            this.header.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.ForeColor = System.Drawing.Color.White;
            this.header.Location = new System.Drawing.Point(12, 9);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(492, 30);
            this.header.TabIndex = 8;
            this.header.Text = "F.C.E. 365 Firmware Manager -  IPSW File Download";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::F.C.E._365_Firmware_Manager_X.Properties.Resources.close_48;
            this.pictureBox1.Location = new System.Drawing.Point(557, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // iTalk_Panel1
            // 
            this.iTalk_Panel1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Panel1.Controls.Add(this.iTalk_HeaderLabel2);
            this.iTalk_Panel1.Controls.Add(this.iPSWDLgo);
            this.iTalk_Panel1.Controls.Add(this.protxt);
            this.iTalk_Panel1.Controls.Add(this.progb);
            this.iTalk_Panel1.Controls.Add(this.iTalk_Panel5);
            this.iTalk_Panel1.Controls.Add(this.iTalk_Panel4);
            this.iTalk_Panel1.Location = new System.Drawing.Point(12, 51);
            this.iTalk_Panel1.Name = "iTalk_Panel1";
            this.iTalk_Panel1.Padding = new System.Windows.Forms.Padding(5);
            this.iTalk_Panel1.Size = new System.Drawing.Size(575, 227);
            this.iTalk_Panel1.TabIndex = 9;
            this.iTalk_Panel1.Click += new System.EventHandler(this.iTalk_Panel1_Click);
            // 
            // iTalk_HeaderLabel2
            // 
            this.iTalk_HeaderLabel2.AutoSize = true;
            this.iTalk_HeaderLabel2.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_HeaderLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_HeaderLabel2.ForeColor = System.Drawing.Color.Black;
            this.iTalk_HeaderLabel2.Location = new System.Drawing.Point(8, 18);
            this.iTalk_HeaderLabel2.Name = "iTalk_HeaderLabel2";
            this.iTalk_HeaderLabel2.Size = new System.Drawing.Size(404, 21);
            this.iTalk_HeaderLabel2.TabIndex = 9;
            this.iTalk_HeaderLabel2.Text = "Select a device and an iOS version to download the IPSW";
            // 
            // iPSWDLgo
            // 
            this.iPSWDLgo.BackColor = System.Drawing.Color.Transparent;
            this.iPSWDLgo.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.iPSWDLgo.ForeColor = System.Drawing.Color.White;
            this.iPSWDLgo.Image = null;
            this.iPSWDLgo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iPSWDLgo.Location = new System.Drawing.Point(136, 153);
            this.iPSWDLgo.Name = "iPSWDLgo";
            this.iPSWDLgo.Size = new System.Drawing.Size(328, 47);
            this.iPSWDLgo.TabIndex = 5;
            this.iPSWDLgo.Text = "Download IPSW";
            this.iPSWDLgo.TextAlignment = System.Drawing.StringAlignment.Center;
            this.iPSWDLgo.Click += new System.EventHandler(this.iTalk_Button_21_Click);
            // 
            // protxt
            // 
            this.protxt.AutoSize = true;
            this.protxt.Font = new System.Drawing.Font("Segoe UI Semibold", 12.05F, System.Drawing.FontStyle.Bold);
            this.protxt.Location = new System.Drawing.Point(529, 109);
            this.protxt.Name = "protxt";
            this.protxt.Size = new System.Drawing.Size(33, 23);
            this.protxt.TabIndex = 4;
            this.protxt.Text = "0%";
            this.protxt.Visible = false;
            // 
            // progb
            // 
            this.progb.Location = new System.Drawing.Point(26, 119);
            this.progb.Name = "progb";
            this.progb.Size = new System.Drawing.Size(497, 10);
            this.progb.TabIndex = 3;
            this.progb.Visible = false;
            // 
            // iTalk_Panel5
            // 
            this.iTalk_Panel5.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Panel5.Controls.Add(this.iosverr);
            this.iTalk_Panel5.Location = new System.Drawing.Point(238, 53);
            this.iTalk_Panel5.Name = "iTalk_Panel5";
            this.iTalk_Panel5.Padding = new System.Windows.Forms.Padding(5);
            this.iTalk_Panel5.Size = new System.Drawing.Size(329, 43);
            this.iTalk_Panel5.TabIndex = 2;
            this.iTalk_Panel5.Text = "iTalk_Panel5";
            // 
            // iosverr
            // 
            this.iosverr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.iosverr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iosverr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iosverr.FormattingEnabled = true;
            this.iosverr.Items.AddRange(new object[] {
            "iOS 10.0.1 <-Signed for all compatible devices",
            "iOS 9.3.5 <-Signed for iPhone 4S",
            "iOS 9.3.4 <-No longer signed.",
            "iOS 9.3.3 <-No longer signed.",
            "iOS 7.1.2 <-Signed for iPhone 4"});
            this.iosverr.Location = new System.Drawing.Point(10, 8);
            this.iosverr.Name = "iosverr";
            this.iosverr.Size = new System.Drawing.Size(311, 29);
            this.iosverr.TabIndex = 0;
            // 
            // iTalk_Panel4
            // 
            this.iTalk_Panel4.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Panel4.Controls.Add(this.devices);
            this.iTalk_Panel4.Location = new System.Drawing.Point(8, 53);
            this.iTalk_Panel4.Name = "iTalk_Panel4";
            this.iTalk_Panel4.Padding = new System.Windows.Forms.Padding(5);
            this.iTalk_Panel4.Size = new System.Drawing.Size(224, 43);
            this.iTalk_Panel4.TabIndex = 1;
            this.iTalk_Panel4.Text = "iTalk_Panel4";
            // 
            // devices
            // 
            this.devices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.devices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.devices.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.devices.FormattingEnabled = true;
            this.devices.Items.AddRange(new object[] {
            "iPhone 4 (3,1)",
            "iPhone 4 (3,2)",
            "iPhone 4 (3,3)",
            "iPhone 4S (4,1)",
            "iPhone 5 (5,1)",
            "iPhone 5 (5,2)",
            "iPhone 5C (5,3)",
            "iPhone 5C (5,4)",
            "iPhone 5S (6,1)",
            "iPhone 5S (6,2)",
            "iPhone 6 (7,2)",
            "iPhone 6 Plus (7,1)",
            "iPhone 6S (8,1)",
            "iPhone 6S Plus (8,2)",
            "iPhone SE (8,4)",
            "iPhone 7 (9,1)",
            "iPhone 7 Plus (9,2)"});
            this.devices.Location = new System.Drawing.Point(8, 6);
            this.devices.Name = "devices";
            this.devices.Size = new System.Drawing.Size(209, 29);
            this.devices.TabIndex = 0;
            // 
            // progres
            // 
            this.progres.Tick += new System.EventHandler(this.progres_Tick);
            // 
            // prog
            // 
            this.prog.AutoSize = true;
            this.prog.BackColor = System.Drawing.Color.Transparent;
            this.prog.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prog.ForeColor = System.Drawing.Color.Black;
            this.prog.Location = new System.Drawing.Point(518, 110);
            this.prog.Name = "prog";
            this.prog.Size = new System.Drawing.Size(38, 25);
            this.prog.TabIndex = 11;
            this.prog.Text = "0%";
            this.prog.Visible = false;
            // 
            // ipswdlprog
            // 
            this.ipswdlprog.Location = new System.Drawing.Point(33, 120);
            this.ipswdlprog.Name = "ipswdlprog";
            this.ipswdlprog.Size = new System.Drawing.Size(482, 10);
            this.ipswdlprog.TabIndex = 10;
            this.ipswdlprog.Visible = false;
            // 
            // iTalk_HeaderLabel1
            // 
            this.iTalk_HeaderLabel1.AutoSize = true;
            this.iTalk_HeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_HeaderLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_HeaderLabel1.ForeColor = System.Drawing.Color.Black;
            this.iTalk_HeaderLabel1.Location = new System.Drawing.Point(15, 21);
            this.iTalk_HeaderLabel1.Name = "iTalk_HeaderLabel1";
            this.iTalk_HeaderLabel1.Size = new System.Drawing.Size(552, 25);
            this.iTalk_HeaderLabel1.TabIndex = 9;
            this.iTalk_HeaderLabel1.Text = "Please select a device and an iOS version to download the IPSW.";
            // 
            // iPSW_go_download_semaphore
            // 
            this.iPSW_go_download_semaphore.BackColor = System.Drawing.Color.Transparent;
            this.iPSW_go_download_semaphore.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.iPSW_go_download_semaphore.ForeColor = System.Drawing.Color.White;
            this.iPSW_go_download_semaphore.Image = null;
            this.iPSW_go_download_semaphore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iPSW_go_download_semaphore.Location = new System.Drawing.Point(100, 159);
            this.iPSW_go_download_semaphore.Name = "iPSW_go_download_semaphore";
            this.iPSW_go_download_semaphore.Size = new System.Drawing.Size(376, 48);
            this.iPSW_go_download_semaphore.TabIndex = 7;
            this.iPSW_go_download_semaphore.Text = "Download selected iPSW";
            this.iPSW_go_download_semaphore.TextAlignment = System.Drawing.StringAlignment.Center;
            this.iPSW_go_download_semaphore.Click += new System.EventHandler(this.iPSW_go_download_semaphore_Click);
            // 
            // iTalk_Panel3
            // 
            this.iTalk_Panel3.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Panel3.Controls.Add(this.iosver);
            this.iTalk_Panel3.Location = new System.Drawing.Point(239, 58);
            this.iTalk_Panel3.Name = "iTalk_Panel3";
            this.iTalk_Panel3.Padding = new System.Windows.Forms.Padding(5);
            this.iTalk_Panel3.Size = new System.Drawing.Size(328, 37);
            this.iTalk_Panel3.TabIndex = 2;
            // 
            // iosver
            // 
            this.iosver.Location = new System.Drawing.Point(0, 0);
            this.iosver.Name = "iosver";
            this.iosver.Size = new System.Drawing.Size(121, 21);
            this.iosver.TabIndex = 0;
            // 
            // iTalk_Panel2
            // 
            this.iTalk_Panel2.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Panel2.Controls.Add(this.device);
            this.iTalk_Panel2.Location = new System.Drawing.Point(8, 58);
            this.iTalk_Panel2.Name = "iTalk_Panel2";
            this.iTalk_Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.iTalk_Panel2.Size = new System.Drawing.Size(225, 37);
            this.iTalk_Panel2.TabIndex = 1;
            this.iTalk_Panel2.Text = "iTalk_Panel2";
            // 
            // device
            // 
            this.device.Location = new System.Drawing.Point(0, 0);
            this.device.Name = "device";
            this.device.Size = new System.Drawing.Size(121, 21);
            this.device.TabIndex = 0;
            // 
            // IPSWDL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(599, 289);
            this.Controls.Add(this.iTalk_Panel1);
            this.Controls.Add(this.header);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IPSWDL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F.C.E. 365 Firmware Manager";
            this.Load += new System.EventHandler(this.IPSWDL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.iTalk_Panel1.ResumeLayout(false);
            this.iTalk_Panel1.PerformLayout();
            this.iTalk_Panel5.ResumeLayout(false);
            this.iTalk_Panel4.ResumeLayout(false);
            this.iTalk_Panel3.ResumeLayout(false);
            this.iTalk_Panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private iTalk.iTalk_HeaderLabel header;
        private System.Windows.Forms.PictureBox pictureBox1;
        private iTalk.iTalk_Panel iTalk_Panel1;
        private iTalk.iTalk_Panel iTalk_Panel3;
        private System.Windows.Forms.ComboBox iosver;
        private iTalk.iTalk_Panel iTalk_Panel2;
        private System.Windows.Forms.ComboBox device;
        private iTalk.iTalk_HeaderLabel iTalk_HeaderLabel1;
        private iTalk.iTalk_Button_2 iPSW_go_download_semaphore;
        private System.Windows.Forms.ProgressBar ipswdlprog;
        private iTalk.iTalk_HeaderLabel prog;
        private System.Windows.Forms.Timer progres;
        private System.Windows.Forms.ComboBox devices;
        private System.Windows.Forms.ComboBox iosverr;
        private iTalk.iTalk_Panel iTalk_Panel5;
        private iTalk.iTalk_Panel iTalk_Panel4;
        private iTalk.iTalk_Button_2 iPSWDLgo;
        private System.Windows.Forms.Label protxt;
        private System.Windows.Forms.ProgressBar progb;
        private iTalk.iTalk_HeaderLabel iTalk_HeaderLabel2;
    }
}