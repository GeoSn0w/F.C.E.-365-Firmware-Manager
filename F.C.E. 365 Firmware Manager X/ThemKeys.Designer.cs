namespace F.C.E._365_Firmware_Manager_X
{
    partial class ThemKeys
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
            this.placeholder = new iTalk.iTalk_Panel();
            this.iTalk_HeaderLabel1 = new iTalk.iTalk_HeaderLabel();
            this.keychain_export = new iTalk.iTalk_Button_2();
            this.iosprovate = new System.Windows.Forms.ComboBox();
            this.device = new System.Windows.Forms.ComboBox();
            this.header = new iTalk.iTalk_HeaderLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.placeholder.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::F.C.E._365_Firmware_Manager_X.Properties.Resources.close_48;
            this.pictureBox1.Location = new System.Drawing.Point(482, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // placeholder
            // 
            this.placeholder.BackColor = System.Drawing.Color.Transparent;
            this.placeholder.Controls.Add(this.iTalk_HeaderLabel1);
            this.placeholder.Controls.Add(this.keychain_export);
            this.placeholder.Controls.Add(this.iosprovate);
            this.placeholder.Controls.Add(this.device);
            this.placeholder.Location = new System.Drawing.Point(14, 52);
            this.placeholder.Name = "placeholder";
            this.placeholder.Padding = new System.Windows.Forms.Padding(5);
            this.placeholder.Size = new System.Drawing.Size(499, 201);
            this.placeholder.TabIndex = 0;
            this.placeholder.Text = "iTalk_Panel1";
            // 
            // iTalk_HeaderLabel1
            // 
            this.iTalk_HeaderLabel1.AutoSize = true;
            this.iTalk_HeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_HeaderLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_HeaderLabel1.ForeColor = System.Drawing.Color.Black;
            this.iTalk_HeaderLabel1.Location = new System.Drawing.Point(14, 22);
            this.iTalk_HeaderLabel1.Name = "iTalk_HeaderLabel1";
            this.iTalk_HeaderLabel1.Size = new System.Drawing.Size(294, 30);
            this.iTalk_HeaderLabel1.TabIndex = 5;
            this.iTalk_HeaderLabel1.Text = "Chose iDevice and iOS version";
            // 
            // keychain_export
            // 
            this.keychain_export.BackColor = System.Drawing.Color.Transparent;
            this.keychain_export.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.keychain_export.ForeColor = System.Drawing.Color.White;
            this.keychain_export.Image = null;
            this.keychain_export.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.keychain_export.Location = new System.Drawing.Point(73, 126);
            this.keychain_export.Name = "keychain_export";
            this.keychain_export.Size = new System.Drawing.Size(357, 48);
            this.keychain_export.TabIndex = 2;
            this.keychain_export.Text = "Export keys";
            this.keychain_export.TextAlignment = System.Drawing.StringAlignment.Center;
            this.keychain_export.Click += new System.EventHandler(this.keychain_export_Click);
            // 
            // iosprovate
            // 
            this.iosprovate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iosprovate.FormattingEnabled = true;
            this.iosprovate.Items.AddRange(new object[] {
            "iOS 7.1.2",
            "iOS 9.3.1",
            "iOS 9.2.1",
            "iOS 9.3.3",
            "iOS 9.3.4"});
            this.iosprovate.Location = new System.Drawing.Point(255, 69);
            this.iosprovate.Name = "iosprovate";
            this.iosprovate.Size = new System.Drawing.Size(226, 25);
            this.iosprovate.TabIndex = 1;
            this.iosprovate.Text = "Chose iOS version";
            // 
            // device
            // 
            this.device.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.device.FormattingEnabled = true;
            this.device.Items.AddRange(new object[] {
            "iPhone 3,1",
            "iPhone 3,2",
            "iPhone 3,3",
            "iPhone 4S",
            "iPhone 5,1",
            "iPhone 5,2",
            "iPhone 5,3",
            "iPhone 5,4"});
            this.device.Location = new System.Drawing.Point(19, 69);
            this.device.Name = "device";
            this.device.Size = new System.Drawing.Size(217, 25);
            this.device.TabIndex = 0;
            this.device.Text = "Chose iDevice";
            this.device.SelectedIndexChanged += new System.EventHandler(this.idevice_SelectedIndexChanged);
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.BackColor = System.Drawing.Color.Transparent;
            this.header.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.ForeColor = System.Drawing.Color.White;
            this.header.Location = new System.Drawing.Point(7, 9);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(383, 30);
            this.header.TabIndex = 4;
            this.header.Text = "F.C.E. 365 Firmware Manager - Keychain";
            // 
            // ThemKeys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(525, 271);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.placeholder);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThemKeys";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F.C.E. 365 Firmware Manager- Key Picker";
            this.Load += new System.EventHandler(this.ThemKeys_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.placeholder.ResumeLayout(false);
            this.placeholder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private iTalk.iTalk_Panel placeholder;
        private System.Windows.Forms.ComboBox device;
        private System.Windows.Forms.PictureBox pictureBox1;
        private iTalk.iTalk_HeaderLabel header;
        private iTalk.iTalk_Button_2 keychain_export;
        private System.Windows.Forms.ComboBox iosprovate;
        private iTalk.iTalk_HeaderLabel iTalk_HeaderLabel1;
    }
}