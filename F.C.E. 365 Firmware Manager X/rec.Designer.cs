namespace F.C.E._365_Firmware_Manager_X
{
    partial class rec
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
            this.header = new iTalk.iTalk_HeaderLabel();
            this.panscm = new iTalk.iTalk_Panel();
            this.rec_call = new iTalk.iTalk_Button_2();
            this.iTalk_HeaderLabel1 = new iTalk.iTalk_HeaderLabel();
            this.udid = new iTalk.iTalk_TextBox_Big();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panscm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::F.C.E._365_Firmware_Manager_X.Properties.Resources.close_48;
            this.pictureBox1.Location = new System.Drawing.Point(536, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.BackColor = System.Drawing.Color.Transparent;
            this.header.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.ForeColor = System.Drawing.Color.White;
            this.header.Location = new System.Drawing.Point(12, 9);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(498, 30);
            this.header.TabIndex = 9;
            this.header.Text = "F.C.E. 365 Firmware Manager - Enter Recovery Mode";
            // 
            // panscm
            // 
            this.panscm.BackColor = System.Drawing.Color.Transparent;
            this.panscm.Controls.Add(this.rec_call);
            this.panscm.Controls.Add(this.iTalk_HeaderLabel1);
            this.panscm.Controls.Add(this.udid);
            this.panscm.Location = new System.Drawing.Point(12, 54);
            this.panscm.Name = "panscm";
            this.panscm.Padding = new System.Windows.Forms.Padding(5);
            this.panscm.Size = new System.Drawing.Size(553, 163);
            this.panscm.TabIndex = 10;
            // 
            // rec_call
            // 
            this.rec_call.BackColor = System.Drawing.Color.Transparent;
            this.rec_call.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.rec_call.ForeColor = System.Drawing.Color.White;
            this.rec_call.Image = null;
            this.rec_call.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rec_call.Location = new System.Drawing.Point(123, 97);
            this.rec_call.Name = "rec_call";
            this.rec_call.Size = new System.Drawing.Size(280, 40);
            this.rec_call.TabIndex = 11;
            this.rec_call.Text = "Enter Recovery Mode";
            this.rec_call.TextAlignment = System.Drawing.StringAlignment.Center;
            this.rec_call.Click += new System.EventHandler(this.rec_call_Click);
            // 
            // iTalk_HeaderLabel1
            // 
            this.iTalk_HeaderLabel1.AutoSize = true;
            this.iTalk_HeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_HeaderLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_HeaderLabel1.ForeColor = System.Drawing.Color.Black;
            this.iTalk_HeaderLabel1.Location = new System.Drawing.Point(8, 11);
            this.iTalk_HeaderLabel1.Name = "iTalk_HeaderLabel1";
            this.iTalk_HeaderLabel1.Size = new System.Drawing.Size(301, 25);
            this.iTalk_HeaderLabel1.TabIndex = 10;
            this.iTalk_HeaderLabel1.Text = "Paste your UDID from iTunes here:";
            // 
            // udid
            // 
            this.udid.BackColor = System.Drawing.Color.Transparent;
            this.udid.Font = new System.Drawing.Font("Tahoma", 11F);
            this.udid.ForeColor = System.Drawing.Color.DimGray;
            this.udid.Image = null;
            this.udid.Location = new System.Drawing.Point(8, 39);
            this.udid.MaxLength = 32767;
            this.udid.Multiline = false;
            this.udid.Name = "udid";
            this.udid.ReadOnly = false;
            this.udid.Size = new System.Drawing.Size(537, 41);
            this.udid.TabIndex = 0;
            this.udid.Text = "Paste UDID Here";
            this.udid.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.udid.UseSystemPasswordChar = false;
            // 
            // rec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(577, 233);
            this.Controls.Add(this.panscm);
            this.Controls.Add(this.header);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "rec";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F.C.E. 365 Firmware Manager";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panscm.ResumeLayout(false);
            this.panscm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private iTalk.iTalk_HeaderLabel header;
        private iTalk.iTalk_Panel panscm;
        private iTalk.iTalk_TextBox_Big udid;
        private iTalk.iTalk_Button_2 rec_call;
        private iTalk.iTalk_HeaderLabel iTalk_HeaderLabel1;
    }
}