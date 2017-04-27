namespace F.C.E._365_Firmware_Manager_X
{
    partial class DFU
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
            this.FirmwareManagerCalculatorEngine = new iTalk.iTalk_Panel();
            this.phnDetect = new iTalk.iTalk_HeaderLabel();
            this.engine_go_afc = new iTalk.iTalk_Button_2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.FirmwareManagerCalculatorEngine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.BackColor = System.Drawing.Color.Transparent;
            this.header.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.ForeColor = System.Drawing.Color.White;
            this.header.Location = new System.Drawing.Point(7, 9);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(485, 30);
            this.header.TabIndex = 5;
            this.header.Text = "F.C.E. 365 Firmware Manager - DFU Mode Detector";
            // 
            // FirmwareManagerCalculatorEngine
            // 
            this.FirmwareManagerCalculatorEngine.BackColor = System.Drawing.Color.Transparent;
            this.FirmwareManagerCalculatorEngine.Controls.Add(this.phnDetect);
            this.FirmwareManagerCalculatorEngine.Controls.Add(this.engine_go_afc);
            this.FirmwareManagerCalculatorEngine.Location = new System.Drawing.Point(12, 54);
            this.FirmwareManagerCalculatorEngine.Name = "FirmwareManagerCalculatorEngine";
            this.FirmwareManagerCalculatorEngine.Padding = new System.Windows.Forms.Padding(5);
            this.FirmwareManagerCalculatorEngine.Size = new System.Drawing.Size(544, 175);
            this.FirmwareManagerCalculatorEngine.TabIndex = 4;
            // 
            // phnDetect
            // 
            this.phnDetect.AutoSize = true;
            this.phnDetect.BackColor = System.Drawing.Color.Transparent;
            this.phnDetect.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phnDetect.ForeColor = System.Drawing.Color.Black;
            this.phnDetect.Location = new System.Drawing.Point(73, 51);
            this.phnDetect.Name = "phnDetect";
            this.phnDetect.Size = new System.Drawing.Size(383, 30);
            this.phnDetect.TabIndex = 6;
            this.phnDetect.Text = "Still waiting for any DFU Mode iDevice...";
            this.phnDetect.Click += new System.EventHandler(this.phnDetect_Click);
            // 
            // engine_go_afc
            // 
            this.engine_go_afc.BackColor = System.Drawing.Color.Transparent;
            this.engine_go_afc.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.engine_go_afc.ForeColor = System.Drawing.Color.White;
            this.engine_go_afc.Image = null;
            this.engine_go_afc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.engine_go_afc.Location = new System.Drawing.Point(85, 127);
            this.engine_go_afc.Name = "engine_go_afc";
            this.engine_go_afc.Size = new System.Drawing.Size(376, 40);
            this.engine_go_afc.TabIndex = 5;
            this.engine_go_afc.Text = "Dismiss";
            this.engine_go_afc.TextAlignment = System.Drawing.StringAlignment.Center;
            this.engine_go_afc.Click += new System.EventHandler(this.engine_go_afc_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::F.C.E._365_Firmware_Manager_X.Properties.Resources.close_48;
            this.pictureBox1.Location = new System.Drawing.Point(527, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // DFU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(568, 245);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.header);
            this.Controls.Add(this.FirmwareManagerCalculatorEngine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DFU";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F.C.E. 365 Firmware Manager X";
            this.Load += new System.EventHandler(this.DFU_Load);
            this.FirmwareManagerCalculatorEngine.ResumeLayout(false);
            this.FirmwareManagerCalculatorEngine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private iTalk.iTalk_HeaderLabel header;
        private iTalk.iTalk_Panel FirmwareManagerCalculatorEngine;
        private iTalk.iTalk_Button_2 engine_go_afc;
        private iTalk.iTalk_HeaderLabel phnDetect;
        public System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}