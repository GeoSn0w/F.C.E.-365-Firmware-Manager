namespace F.C.E._365_Firmware_Manager_X
{
    partial class framework12
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
            this.Lorem_IPSUM_Sits_On_A_Coffee_Table = new iTalk.iTalk_Panel();
            this.plistparseengine_dowork = new iTalk.iTalk_Button_1();
            this.IOPlistP = new iTalk.iTalk_TextBox_Big();
            this.mir = new System.Windows.Forms.TextBox();
            this.Lorem_IPSUM_Sits_On_A_Coffee_Table.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lorem_IPSUM_Sits_On_A_Coffee_Table
            // 
            this.Lorem_IPSUM_Sits_On_A_Coffee_Table.BackColor = System.Drawing.Color.Transparent;
            this.Lorem_IPSUM_Sits_On_A_Coffee_Table.Controls.Add(this.mir);
            this.Lorem_IPSUM_Sits_On_A_Coffee_Table.Location = new System.Drawing.Point(12, 72);
            this.Lorem_IPSUM_Sits_On_A_Coffee_Table.Name = "Lorem_IPSUM_Sits_On_A_Coffee_Table";
            this.Lorem_IPSUM_Sits_On_A_Coffee_Table.Padding = new System.Windows.Forms.Padding(5);
            this.Lorem_IPSUM_Sits_On_A_Coffee_Table.Size = new System.Drawing.Size(869, 488);
            this.Lorem_IPSUM_Sits_On_A_Coffee_Table.TabIndex = 0;
            this.Lorem_IPSUM_Sits_On_A_Coffee_Table.Text = "iTalk_Panel1";
            // 
            // plistparseengine_dowork
            // 
            this.plistparseengine_dowork.BackColor = System.Drawing.Color.Transparent;
            this.plistparseengine_dowork.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.plistparseengine_dowork.Image = null;
            this.plistparseengine_dowork.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.plistparseengine_dowork.Location = new System.Drawing.Point(715, 26);
            this.plistparseengine_dowork.Name = "plistparseengine_dowork";
            this.plistparseengine_dowork.Size = new System.Drawing.Size(166, 40);
            this.plistparseengine_dowork.TabIndex = 1;
            this.plistparseengine_dowork.Text = "Parse Plist File";
            this.plistparseengine_dowork.TextAlignment = System.Drawing.StringAlignment.Center;
            this.plistparseengine_dowork.Click += new System.EventHandler(this.iTalk_Button_11_Click);
            // 
            // IOPlistP
            // 
            this.IOPlistP.BackColor = System.Drawing.Color.Transparent;
            this.IOPlistP.Font = new System.Drawing.Font("Tahoma", 11F);
            this.IOPlistP.ForeColor = System.Drawing.Color.DimGray;
            this.IOPlistP.Image = null;
            this.IOPlistP.Location = new System.Drawing.Point(12, 25);
            this.IOPlistP.MaxLength = 32767;
            this.IOPlistP.Multiline = false;
            this.IOPlistP.Name = "IOPlistP";
            this.IOPlistP.ReadOnly = false;
            this.IOPlistP.Size = new System.Drawing.Size(697, 41);
            this.IOPlistP.TabIndex = 2;
            this.IOPlistP.Text = "...";
            this.IOPlistP.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.IOPlistP.UseSystemPasswordChar = false;
            // 
            // mir
            // 
            this.mir.Location = new System.Drawing.Point(8, 8);
            this.mir.Multiline = true;
            this.mir.Name = "mir";
            this.mir.Size = new System.Drawing.Size(853, 472);
            this.mir.TabIndex = 0;
            // 
            // framework12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(893, 572);
            this.Controls.Add(this.IOPlistP);
            this.Controls.Add(this.plistparseengine_dowork);
            this.Controls.Add(this.Lorem_IPSUM_Sits_On_A_Coffee_Table);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "framework12";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F.C.E. 365 Firmware Manager";
            this.Load += new System.EventHandler(this.framework12_Load);
            this.Lorem_IPSUM_Sits_On_A_Coffee_Table.ResumeLayout(false);
            this.Lorem_IPSUM_Sits_On_A_Coffee_Table.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private iTalk.iTalk_Panel Lorem_IPSUM_Sits_On_A_Coffee_Table;
        private iTalk.iTalk_Button_1 plistparseengine_dowork;
        private iTalk.iTalk_TextBox_Big IOPlistP;
        private System.Windows.Forms.TextBox mir;
    }
}