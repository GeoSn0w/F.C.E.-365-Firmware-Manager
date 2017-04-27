namespace F.C.E._365_Firmware_Manager_X
{
    partial class fcehex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fcehex));
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.viewerPanel = new iTalk.iTalk_Panel();
            this.BinaryHExloadEngine = new iTalk.iTalk_Button_1();
            this.header = new iTalk.iTalk_HeaderLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dummy = new System.Windows.Forms.TextBox();
            this.savedump = new System.Windows.Forms.SaveFileDialog();
            this.iTalk_Button_11 = new iTalk.iTalk_Button_1();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // viewerPanel
            // 
            this.viewerPanel.BackColor = System.Drawing.Color.Transparent;
            this.viewerPanel.Location = new System.Drawing.Point(12, 86);
            this.viewerPanel.Name = "viewerPanel";
            this.viewerPanel.Padding = new System.Windows.Forms.Padding(5);
            this.viewerPanel.Size = new System.Drawing.Size(646, 446);
            this.viewerPanel.TabIndex = 1;
            this.viewerPanel.Text = "iTalk_Panel1";
            this.viewerPanel.Click += new System.EventHandler(this.viewerPanel_Click);
            // 
            // BinaryHExloadEngine
            // 
            this.BinaryHExloadEngine.BackColor = System.Drawing.Color.Transparent;
            this.BinaryHExloadEngine.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BinaryHExloadEngine.Image = null;
            this.BinaryHExloadEngine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BinaryHExloadEngine.Location = new System.Drawing.Point(12, 48);
            this.BinaryHExloadEngine.Name = "BinaryHExloadEngine";
            this.BinaryHExloadEngine.Size = new System.Drawing.Size(173, 32);
            this.BinaryHExloadEngine.TabIndex = 2;
            this.BinaryHExloadEngine.Text = "Import Binary File";
            this.BinaryHExloadEngine.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BinaryHExloadEngine.Click += new System.EventHandler(this.iTalk_Button_11_Click);
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.BackColor = System.Drawing.Color.Transparent;
            this.header.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.ForeColor = System.Drawing.Color.White;
            this.header.Location = new System.Drawing.Point(12, 9);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(406, 30);
            this.header.TabIndex = 10;
            this.header.Text = "F.C.E. 365 Firmware Manager - HEX Viewer";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::F.C.E._365_Firmware_Manager_X.Properties.Resources.close_48;
            this.pictureBox1.Location = new System.Drawing.Point(618, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dummy
            // 
            this.dummy.Location = new System.Drawing.Point(280, 60);
            this.dummy.Name = "dummy";
            this.dummy.Size = new System.Drawing.Size(47, 20);
            this.dummy.TabIndex = 12;
            this.dummy.Text = resources.GetString("dummy.Text");
            this.dummy.Visible = false;
            // 
            // savedump
            // 
            this.savedump.Filter = "\"Dump File|*.txt|All Files|*.*\"";
            // 
            // iTalk_Button_11
            // 
            this.iTalk_Button_11.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Button_11.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.iTalk_Button_11.Image = null;
            this.iTalk_Button_11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iTalk_Button_11.Location = new System.Drawing.Point(191, 48);
            this.iTalk_Button_11.Name = "iTalk_Button_11";
            this.iTalk_Button_11.Size = new System.Drawing.Size(157, 32);
            this.iTalk_Button_11.TabIndex = 13;
            this.iTalk_Button_11.Text = "Save Hex Dump";
            this.iTalk_Button_11.TextAlignment = System.Drawing.StringAlignment.Center;
            this.iTalk_Button_11.Click += new System.EventHandler(this.iTalk_Button_11_Click_1);
            // 
            // fcehex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(670, 544);
            this.Controls.Add(this.viewerPanel);
            this.Controls.Add(this.iTalk_Button_11);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.header);
            this.Controls.Add(this.BinaryHExloadEngine);
            this.Controls.Add(this.dummy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fcehex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F.C.E. 365 Hex";
            this.Load += new System.EventHandler(this.fcehex_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFile;
        private iTalk.iTalk_Panel viewerPanel;
        private iTalk.iTalk_Button_1 BinaryHExloadEngine;
        private iTalk.iTalk_HeaderLabel header;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox dummy;
        private System.Windows.Forms.SaveFileDialog savedump;
        private iTalk.iTalk_Button_1 iTalk_Button_11;

    }
}