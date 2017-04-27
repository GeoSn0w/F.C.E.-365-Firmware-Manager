namespace F.C.E._365_Firmware_Manager_X
{
    partial class cijmod
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
            this.placeholder = new iTalk.iTalk_Panel();
            this.jailbreak_airport_screen = new System.Windows.Forms.PictureBox();
            this.iTalk_HeaderLabel1 = new iTalk.iTalk_HeaderLabel();
            this.header = new iTalk.iTalk_HeaderLabel();
            this.closer = new System.Windows.Forms.PictureBox();
            this.placeholder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jailbreak_airport_screen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closer)).BeginInit();
            this.SuspendLayout();
            // 
            // placeholder
            // 
            this.placeholder.BackColor = System.Drawing.Color.Transparent;
            this.placeholder.Controls.Add(this.jailbreak_airport_screen);
            this.placeholder.Controls.Add(this.iTalk_HeaderLabel1);
            this.placeholder.Location = new System.Drawing.Point(12, 51);
            this.placeholder.Name = "placeholder";
            this.placeholder.Padding = new System.Windows.Forms.Padding(5);
            this.placeholder.Size = new System.Drawing.Size(772, 381);
            this.placeholder.TabIndex = 6;
            this.placeholder.Text = "iTalk_Panel1";
            this.placeholder.Click += new System.EventHandler(this.placeholder_Click);
            // 
            // jailbreak_airport_screen
            // 
            this.jailbreak_airport_screen.Image = global::F.C.E._365_Firmware_Manager_X.Properties.Resources.Capture;
            this.jailbreak_airport_screen.Location = new System.Drawing.Point(8, 38);
            this.jailbreak_airport_screen.Name = "jailbreak_airport_screen";
            this.jailbreak_airport_screen.Size = new System.Drawing.Size(756, 334);
            this.jailbreak_airport_screen.TabIndex = 6;
            this.jailbreak_airport_screen.TabStop = false;
            this.jailbreak_airport_screen.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // iTalk_HeaderLabel1
            // 
            this.iTalk_HeaderLabel1.AutoSize = true;
            this.iTalk_HeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_HeaderLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_HeaderLabel1.ForeColor = System.Drawing.Color.Black;
            this.iTalk_HeaderLabel1.Location = new System.Drawing.Point(8, 5);
            this.iTalk_HeaderLabel1.Name = "iTalk_HeaderLabel1";
            this.iTalk_HeaderLabel1.Size = new System.Drawing.Size(442, 30);
            this.iTalk_HeaderLabel1.TabIndex = 5;
            this.iTalk_HeaderLabel1.Text = "These are the Jailbreak able firmware versions:";
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.BackColor = System.Drawing.Color.Transparent;
            this.header.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.ForeColor = System.Drawing.Color.White;
            this.header.Location = new System.Drawing.Point(7, 2);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(443, 30);
            this.header.TabIndex = 7;
            this.header.Text = "F.C.E. 365 Firmware Manager - Jailbreak Status";
            // 
            // closer
            // 
            this.closer.Image = global::F.C.E._365_Firmware_Manager_X.Properties.Resources.close_48;
            this.closer.Location = new System.Drawing.Point(755, 2);
            this.closer.Name = "closer";
            this.closer.Size = new System.Drawing.Size(40, 43);
            this.closer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closer.TabIndex = 8;
            this.closer.TabStop = false;
            this.closer.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cijmod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(796, 447);
            this.Controls.Add(this.placeholder);
            this.Controls.Add(this.closer);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "cijmod";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F.C.E. 365 Firmware Manager - Can I Jailbreak?";
            this.placeholder.ResumeLayout(false);
            this.placeholder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jailbreak_airport_screen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private iTalk.iTalk_Panel placeholder;
        private iTalk.iTalk_HeaderLabel iTalk_HeaderLabel1;
        private System.Windows.Forms.PictureBox closer;
        private iTalk.iTalk_HeaderLabel header;
        private System.Windows.Forms.PictureBox jailbreak_airport_screen;
    }
}