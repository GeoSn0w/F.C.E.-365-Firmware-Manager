namespace F.C.E._365_Firmware_Manager_X
{
    partial class HashCalculator
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
            this.header = new iTalk.iTalk_HeaderLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HashEngine_AES = new iTalk.iTalk_Panel();
            this.quoter = new System.Windows.Forms.TextBox();
            this.iTalk_HeaderLabel1 = new iTalk.iTalk_HeaderLabel();
            this.InitFile = new iTalk.iTalk_HeaderLabel();
            this.HashISOS = new iTalk.iTalk_TextBox_Big();
            this.AES_Start = new iTalk.iTalk_Button_2();
            this.AES_LoadFile = new iTalk.iTalk_Button_2();
            this.AES_FileLocation = new iTalk.iTalk_TextBox_Big();
            this.HashLoader = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.HashEngine_AES.SuspendLayout();
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
            this.header.Size = new System.Drawing.Size(466, 30);
            this.header.TabIndex = 4;
            this.header.Text = "F.C.E. 365 Firmware Manager - Base64 Checksum";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::F.C.E._365_Firmware_Manager_X.Properties.Resources.close_48;
            this.pictureBox1.Location = new System.Drawing.Point(637, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // HashEngine_AES
            // 
            this.HashEngine_AES.BackColor = System.Drawing.Color.Transparent;
            this.HashEngine_AES.Controls.Add(this.quoter);
            this.HashEngine_AES.Controls.Add(this.iTalk_HeaderLabel1);
            this.HashEngine_AES.Controls.Add(this.InitFile);
            this.HashEngine_AES.Controls.Add(this.HashISOS);
            this.HashEngine_AES.Controls.Add(this.AES_Start);
            this.HashEngine_AES.Controls.Add(this.AES_LoadFile);
            this.HashEngine_AES.Controls.Add(this.AES_FileLocation);
            this.HashEngine_AES.Location = new System.Drawing.Point(13, 58);
            this.HashEngine_AES.Name = "HashEngine_AES";
            this.HashEngine_AES.Padding = new System.Windows.Forms.Padding(5);
            this.HashEngine_AES.Size = new System.Drawing.Size(664, 304);
            this.HashEngine_AES.TabIndex = 6;
            this.HashEngine_AES.Text = "iTalk_Panel1";
            // 
            // quoter
            // 
            this.quoter.Location = new System.Drawing.Point(624, 20);
            this.quoter.Name = "quoter";
            this.quoter.ReadOnly = true;
            this.quoter.Size = new System.Drawing.Size(24, 20);
            this.quoter.TabIndex = 9;
            this.quoter.Text = "\"";
            this.quoter.Visible = false;
            // 
            // iTalk_HeaderLabel1
            // 
            this.iTalk_HeaderLabel1.AutoSize = true;
            this.iTalk_HeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_HeaderLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_HeaderLabel1.ForeColor = System.Drawing.Color.Black;
            this.iTalk_HeaderLabel1.Location = new System.Drawing.Point(12, 103);
            this.iTalk_HeaderLabel1.Name = "iTalk_HeaderLabel1";
            this.iTalk_HeaderLabel1.Size = new System.Drawing.Size(420, 25);
            this.iTalk_HeaderLabel1.TabIndex = 8;
            this.iTalk_HeaderLabel1.Text = "The Base64 Hash of the SHA-1 Hash of the file is:";
            // 
            // InitFile
            // 
            this.InitFile.AutoSize = true;
            this.InitFile.BackColor = System.Drawing.Color.Transparent;
            this.InitFile.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InitFile.ForeColor = System.Drawing.Color.Black;
            this.InitFile.Location = new System.Drawing.Point(12, 20);
            this.InitFile.Name = "InitFile";
            this.InitFile.Size = new System.Drawing.Size(388, 25);
            this.InitFile.TabIndex = 7;
            this.InitFile.Text = "Load a file here for SHA-1 Base64 Checksum:";
            // 
            // HashISOS
            // 
            this.HashISOS.BackColor = System.Drawing.Color.Transparent;
            this.HashISOS.Font = new System.Drawing.Font("Tahoma", 11F);
            this.HashISOS.ForeColor = System.Drawing.Color.DimGray;
            this.HashISOS.Image = null;
            this.HashISOS.Location = new System.Drawing.Point(17, 136);
            this.HashISOS.MaxLength = 32767;
            this.HashISOS.Multiline = false;
            this.HashISOS.Name = "HashISOS";
            this.HashISOS.ReadOnly = true;
            this.HashISOS.Size = new System.Drawing.Size(639, 41);
            this.HashISOS.TabIndex = 3;
            this.HashISOS.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.HashISOS.UseSystemPasswordChar = false;
            // 
            // AES_Start
            // 
            this.AES_Start.BackColor = System.Drawing.Color.Transparent;
            this.AES_Start.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.AES_Start.ForeColor = System.Drawing.Color.White;
            this.AES_Start.Image = null;
            this.AES_Start.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AES_Start.Location = new System.Drawing.Point(162, 197);
            this.AES_Start.Name = "AES_Start";
            this.AES_Start.Size = new System.Drawing.Size(330, 57);
            this.AES_Start.TabIndex = 2;
            this.AES_Start.Text = "Calculate Checksum";
            this.AES_Start.TextAlignment = System.Drawing.StringAlignment.Center;
            this.AES_Start.Click += new System.EventHandler(this.AES_Start_Click);
            // 
            // AES_LoadFile
            // 
            this.AES_LoadFile.BackColor = System.Drawing.Color.Transparent;
            this.AES_LoadFile.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.AES_LoadFile.ForeColor = System.Drawing.Color.White;
            this.AES_LoadFile.Image = null;
            this.AES_LoadFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AES_LoadFile.Location = new System.Drawing.Point(498, 48);
            this.AES_LoadFile.Name = "AES_LoadFile";
            this.AES_LoadFile.Size = new System.Drawing.Size(158, 40);
            this.AES_LoadFile.TabIndex = 1;
            this.AES_LoadFile.Text = "Load File";
            this.AES_LoadFile.TextAlignment = System.Drawing.StringAlignment.Center;
            this.AES_LoadFile.Click += new System.EventHandler(this.AES_LoadFile_Click);
            // 
            // AES_FileLocation
            // 
            this.AES_FileLocation.BackColor = System.Drawing.Color.Transparent;
            this.AES_FileLocation.Font = new System.Drawing.Font("Tahoma", 11F);
            this.AES_FileLocation.ForeColor = System.Drawing.Color.DimGray;
            this.AES_FileLocation.Image = null;
            this.AES_FileLocation.Location = new System.Drawing.Point(17, 48);
            this.AES_FileLocation.MaxLength = 32767;
            this.AES_FileLocation.Multiline = false;
            this.AES_FileLocation.Name = "AES_FileLocation";
            this.AES_FileLocation.ReadOnly = false;
            this.AES_FileLocation.Size = new System.Drawing.Size(475, 41);
            this.AES_FileLocation.TabIndex = 0;
            this.AES_FileLocation.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.AES_FileLocation.UseSystemPasswordChar = false;
            // 
            // HashLoader
            // 
            this.HashLoader.FileName = "Any file...";
            this.HashLoader.Title = "F.C.E. 365 Firmware Manager X";
            // 
            // HashCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(689, 384);
            this.Controls.Add(this.HashEngine_AES);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HashCalculator";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F.C.E. 365 Firmware Manager X";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.HashEngine_AES.ResumeLayout(false);
            this.HashEngine_AES.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private iTalk.iTalk_HeaderLabel header;
        private iTalk.iTalk_Panel HashEngine_AES;
        private iTalk.iTalk_Button_2 AES_Start;
        private iTalk.iTalk_Button_2 AES_LoadFile;
        private iTalk.iTalk_TextBox_Big AES_FileLocation;
        private iTalk.iTalk_TextBox_Big HashISOS;
        private iTalk.iTalk_HeaderLabel iTalk_HeaderLabel1;
        private iTalk.iTalk_HeaderLabel InitFile;
        private System.Windows.Forms.OpenFileDialog HashLoader;
        private System.Windows.Forms.TextBox quoter;
    }
}