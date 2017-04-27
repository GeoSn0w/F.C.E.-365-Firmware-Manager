namespace F.C.E._365_Firmware_Manager_X
{
    partial class partialdl
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ibuildfiles = new System.Windows.Forms.SaveFileDialog();
            this.iTalk_Panel1 = new iTalk.iTalk_Panel();
            this.quoter = new System.Windows.Forms.TextBox();
            this.fsbrowser = new iTalk.iTalk_Button_2();
            this.action_launch1 = new iTalk.iTalk_Button_2();
            this.header = new iTalk.iTalk_HeaderLabel();
            this.https = new iTalk.iTalk_TextBox_Big();
            this.fs = new iTalk.iTalk_TextBox_Big();
            this.saveme = new iTalk.iTalk_TextBox_Big();
            this.label40 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.iTalk_Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::F.C.E._365_Firmware_Manager_X.Properties.Resources.close_48;
            this.pictureBox1.Location = new System.Drawing.Point(658, 4);
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
            this.iTalk_Panel1.Controls.Add(this.label40);
            this.iTalk_Panel1.Controls.Add(this.saveme);
            this.iTalk_Panel1.Controls.Add(this.fs);
            this.iTalk_Panel1.Controls.Add(this.https);
            this.iTalk_Panel1.Controls.Add(this.quoter);
            this.iTalk_Panel1.Controls.Add(this.fsbrowser);
            this.iTalk_Panel1.Controls.Add(this.action_launch1);
            this.iTalk_Panel1.Location = new System.Drawing.Point(17, 53);
            this.iTalk_Panel1.Name = "iTalk_Panel1";
            this.iTalk_Panel1.Padding = new System.Windows.Forms.Padding(5);
            this.iTalk_Panel1.Size = new System.Drawing.Size(671, 275);
            this.iTalk_Panel1.TabIndex = 8;
            this.iTalk_Panel1.Text = "iTalk_Panel1";
            // 
            // quoter
            // 
            this.quoter.Location = new System.Drawing.Point(627, 19);
            this.quoter.Name = "quoter";
            this.quoter.Size = new System.Drawing.Size(25, 20);
            this.quoter.TabIndex = 9;
            this.quoter.Text = "\"";
            this.quoter.Visible = false;
            // 
            // fsbrowser
            // 
            this.fsbrowser.BackColor = System.Drawing.Color.Transparent;
            this.fsbrowser.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.fsbrowser.ForeColor = System.Drawing.Color.White;
            this.fsbrowser.Image = null;
            this.fsbrowser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fsbrowser.Location = new System.Drawing.Point(604, 139);
            this.fsbrowser.Name = "fsbrowser";
            this.fsbrowser.Size = new System.Drawing.Size(48, 41);
            this.fsbrowser.TabIndex = 8;
            this.fsbrowser.Text = "...";
            this.fsbrowser.TextAlignment = System.Drawing.StringAlignment.Center;
            this.fsbrowser.Click += new System.EventHandler(this.fsbrowser_Click);
            // 
            // action_launch1
            // 
            this.action_launch1.BackColor = System.Drawing.Color.Transparent;
            this.action_launch1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.action_launch1.ForeColor = System.Drawing.Color.White;
            this.action_launch1.Image = null;
            this.action_launch1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.action_launch1.Location = new System.Drawing.Point(181, 197);
            this.action_launch1.Name = "action_launch1";
            this.action_launch1.Size = new System.Drawing.Size(308, 53);
            this.action_launch1.TabIndex = 0;
            this.action_launch1.Text = "Download";
            this.action_launch1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.action_launch1.Click += new System.EventHandler(this.iTalk_Button_21_Click);
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.BackColor = System.Drawing.Color.Transparent;
            this.header.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.ForeColor = System.Drawing.Color.White;
            this.header.Location = new System.Drawing.Point(12, 9);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(513, 30);
            this.header.TabIndex = 6;
            this.header.Text = "F.C.E. 365 Firmware Manager - Partial IPSW Download";
            // 
            // https
            // 
            this.https.BackColor = System.Drawing.Color.Transparent;
            this.https.Font = new System.Drawing.Font("Tahoma", 11F);
            this.https.ForeColor = System.Drawing.Color.DimGray;
            this.https.Image = null;
            this.https.Location = new System.Drawing.Point(20, 45);
            this.https.MaxLength = 32767;
            this.https.Multiline = false;
            this.https.Name = "https";
            this.https.ReadOnly = false;
            this.https.Size = new System.Drawing.Size(632, 41);
            this.https.TabIndex = 10;
            this.https.Text = "Link to the file?";
            this.https.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.https.UseSystemPasswordChar = false;
            // 
            // fs
            // 
            this.fs.BackColor = System.Drawing.Color.Transparent;
            this.fs.Font = new System.Drawing.Font("Tahoma", 11F);
            this.fs.ForeColor = System.Drawing.Color.DimGray;
            this.fs.Image = null;
            this.fs.Location = new System.Drawing.Point(20, 92);
            this.fs.MaxLength = 32767;
            this.fs.Multiline = false;
            this.fs.Name = "fs";
            this.fs.ReadOnly = false;
            this.fs.Size = new System.Drawing.Size(632, 41);
            this.fs.TabIndex = 11;
            this.fs.Text = "The file you want to download?";
            this.fs.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.fs.UseSystemPasswordChar = false;
            // 
            // saveme
            // 
            this.saveme.BackColor = System.Drawing.Color.Transparent;
            this.saveme.Font = new System.Drawing.Font("Tahoma", 11F);
            this.saveme.ForeColor = System.Drawing.Color.DimGray;
            this.saveme.Image = null;
            this.saveme.Location = new System.Drawing.Point(20, 139);
            this.saveme.MaxLength = 32767;
            this.saveme.Multiline = false;
            this.saveme.Name = "saveme";
            this.saveme.ReadOnly = false;
            this.saveme.Size = new System.Drawing.Size(578, 41);
            this.saveme.TabIndex = 12;
            this.saveme.Text = "Where should I write it?";
            this.saveme.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.saveme.UseSystemPasswordChar = false;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label40.ForeColor = System.Drawing.Color.Black;
            this.label40.Location = new System.Drawing.Point(16, 17);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(362, 20);
            this.label40.TabIndex = 29;
            this.label40.Text = "Using this tool you can download parts of the IPSW.";
            // 
            // partialdl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(700, 348);
            this.Controls.Add(this.iTalk_Panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "partialdl";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F.C.E. 365 Firmware Manager";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.iTalk_Panel1.ResumeLayout(false);
            this.iTalk_Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private iTalk.iTalk_HeaderLabel header;
        private iTalk.iTalk_Panel iTalk_Panel1;
        private iTalk.iTalk_Button_2 action_launch1;
        private iTalk.iTalk_Button_2 fsbrowser;
        private System.Windows.Forms.SaveFileDialog ibuildfiles;
        private System.Windows.Forms.TextBox quoter;
        private iTalk.iTalk_TextBox_Big saveme;
        private iTalk.iTalk_TextBox_Big fs;
        private iTalk.iTalk_TextBox_Big https;
        internal System.Windows.Forms.Label label40;
    }
}