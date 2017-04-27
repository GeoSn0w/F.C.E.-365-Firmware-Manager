namespace F.C.E._365_Firmware_Manager_X
{
    partial class UDIDchallange
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
            this.iTalk_Panel1 = new iTalk.iTalk_Panel();
            this.iTalk_HeaderLabel1 = new iTalk.iTalk_HeaderLabel();
            this.engine_go_afc = new iTalk.iTalk_Button_2();
            this.header = new iTalk.iTalk_HeaderLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.iTalk_Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::F.C.E._365_Firmware_Manager_X.Properties.Resources.close_48;
            this.pictureBox1.Location = new System.Drawing.Point(559, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // iTalk_Panel1
            // 
            this.iTalk_Panel1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Panel1.Controls.Add(this.iTalk_HeaderLabel1);
            this.iTalk_Panel1.Controls.Add(this.engine_go_afc);
            this.iTalk_Panel1.Location = new System.Drawing.Point(12, 50);
            this.iTalk_Panel1.Name = "iTalk_Panel1";
            this.iTalk_Panel1.Padding = new System.Windows.Forms.Padding(5);
            this.iTalk_Panel1.Size = new System.Drawing.Size(577, 156);
            this.iTalk_Panel1.TabIndex = 5;
            this.iTalk_Panel1.Text = "iTalk_Panel1";
            // 
            // iTalk_HeaderLabel1
            // 
            this.iTalk_HeaderLabel1.AutoSize = true;
            this.iTalk_HeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_HeaderLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_HeaderLabel1.ForeColor = System.Drawing.Color.Black;
            this.iTalk_HeaderLabel1.Location = new System.Drawing.Point(18, 25);
            this.iTalk_HeaderLabel1.Name = "iTalk_HeaderLabel1";
            this.iTalk_HeaderLabel1.Size = new System.Drawing.Size(551, 30);
            this.iTalk_HeaderLabel1.TabIndex = 7;
            this.iTalk_HeaderLabel1.Text = "Please connect your device to the computer and unlock it.";
            // 
            // engine_go_afc
            // 
            this.engine_go_afc.BackColor = System.Drawing.Color.Transparent;
            this.engine_go_afc.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.engine_go_afc.ForeColor = System.Drawing.Color.White;
            this.engine_go_afc.Image = null;
            this.engine_go_afc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.engine_go_afc.Location = new System.Drawing.Point(102, 79);
            this.engine_go_afc.Name = "engine_go_afc";
            this.engine_go_afc.Size = new System.Drawing.Size(376, 48);
            this.engine_go_afc.TabIndex = 6;
            this.engine_go_afc.Text = "Start Diagnostics Relay";
            this.engine_go_afc.TextAlignment = System.Drawing.StringAlignment.Center;
            this.engine_go_afc.Click += new System.EventHandler(this.engine_go_afc_Click);
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.BackColor = System.Drawing.Color.Transparent;
            this.header.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.ForeColor = System.Drawing.Color.White;
            this.header.Location = new System.Drawing.Point(7, 9);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(244, 30);
            this.header.TabIndex = 6;
            this.header.Text = "Device Diagnostics Relay";
            // 
            // UDIDchallange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(601, 221);
            this.Controls.Add(this.header);
            this.Controls.Add(this.iTalk_Panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UDIDchallange";
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
        private iTalk.iTalk_Panel iTalk_Panel1;
        private iTalk.iTalk_HeaderLabel header;
        private iTalk.iTalk_HeaderLabel iTalk_HeaderLabel1;
        private iTalk.iTalk_Button_2 engine_go_afc;
    }
}