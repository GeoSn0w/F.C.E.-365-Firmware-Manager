namespace F.C.E._365_Firmware_Manager_X
{
    partial class IOApplicationAccellerator
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
            this.OffsetPointStopBySize = new System.Windows.Forms.PictureBox();
            this.fileparserattr = new System.Windows.Forms.OpenFileDialog();
            this.processor = new System.ComponentModel.BackgroundWorker();
            this.GO_Offset_container = new iTalk.iTalk_Panel();
            this.warnax_1 = new System.Windows.Forms.Label();
            this.ploader = new iTalk.iTalk_Button_2();
            this.viewerPanel = new iTalk.iTalk_Panel();
            this.hexi = new Be.Windows.Forms.HexBox();
            this.iTalk_GroupBox2 = new iTalk.iTalk_GroupBox();
            this.GDBase64 = new System.Windows.Forms.TextBox();
            this.sizeforeparse = new System.Windows.Forms.Label();
            this.DefOffsetSPoint = new System.Windows.Forms.Label();
            this.GDBase64P = new System.Windows.Forms.Label();
            this.sizeoffile = new System.Windows.Forms.Label();
            this.iTalk_GroupBox1 = new iTalk.iTalk_GroupBox();
            this.CS_bypass_enforcement = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.go_patch_apptype_inv = new System.Windows.Forms.CheckBox();
            this.caller = new iTalk.iTalk_Button_1();
            this.IOFileSystemFile = new iTalk.iTalk_TextBox_Big();
            this.AppHeaderParser = new iTalk.iTalk_HeaderLabel();
            ((System.ComponentModel.ISupportInitialize)(this.OffsetPointStopBySize)).BeginInit();
            this.GO_Offset_container.SuspendLayout();
            this.viewerPanel.SuspendLayout();
            this.iTalk_GroupBox2.SuspendLayout();
            this.iTalk_GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OffsetPointStopBySize
            // 
            this.OffsetPointStopBySize.Image = global::F.C.E._365_Firmware_Manager_X.Properties.Resources.close_48;
            this.OffsetPointStopBySize.Location = new System.Drawing.Point(763, 5);
            this.OffsetPointStopBySize.Name = "OffsetPointStopBySize";
            this.OffsetPointStopBySize.Size = new System.Drawing.Size(40, 43);
            this.OffsetPointStopBySize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OffsetPointStopBySize.TabIndex = 8;
            this.OffsetPointStopBySize.TabStop = false;
            this.OffsetPointStopBySize.Click += new System.EventHandler(this.OffsetPointStopBySize_Click);
            // 
            // fileparserattr
            // 
            this.fileparserattr.DefaultExt = "*.* All Files";
            this.fileparserattr.FileName = "Please select the Setup.App Executable file!";
            this.fileparserattr.Title = "F.C.E. 365 Firmware Manager - Setup.App Patch";
            // 
            // processor
            // 
            this.processor.DoWork += new System.ComponentModel.DoWorkEventHandler(this.processor_DoWork);
            // 
            // GO_Offset_container
            // 
            this.GO_Offset_container.BackColor = System.Drawing.Color.Transparent;
            this.GO_Offset_container.Controls.Add(this.warnax_1);
            this.GO_Offset_container.Controls.Add(this.ploader);
            this.GO_Offset_container.Controls.Add(this.viewerPanel);
            this.GO_Offset_container.Controls.Add(this.iTalk_GroupBox2);
            this.GO_Offset_container.Controls.Add(this.iTalk_GroupBox1);
            this.GO_Offset_container.Controls.Add(this.caller);
            this.GO_Offset_container.Controls.Add(this.IOFileSystemFile);
            this.GO_Offset_container.Location = new System.Drawing.Point(12, 54);
            this.GO_Offset_container.Name = "GO_Offset_container";
            this.GO_Offset_container.Padding = new System.Windows.Forms.Padding(5);
            this.GO_Offset_container.Size = new System.Drawing.Size(800, 524);
            this.GO_Offset_container.TabIndex = 10;
            this.GO_Offset_container.Click += new System.EventHandler(this.GO_Offset_container_Click);
            // 
            // warnax_1
            // 
            this.warnax_1.AutoSize = true;
            this.warnax_1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warnax_1.ForeColor = System.Drawing.Color.Firebrick;
            this.warnax_1.Location = new System.Drawing.Point(9, 496);
            this.warnax_1.Name = "warnax_1";
            this.warnax_1.Size = new System.Drawing.Size(227, 20);
            this.warnax_1.TabIndex = 10;
            this.warnax_1.Text = "Compatible with iOS 10.x ONLY!";
            // 
            // ploader
            // 
            this.ploader.BackColor = System.Drawing.Color.Transparent;
            this.ploader.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.ploader.ForeColor = System.Drawing.Color.White;
            this.ploader.Image = null;
            this.ploader.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ploader.Location = new System.Drawing.Point(258, 472);
            this.ploader.Name = "ploader";
            this.ploader.Size = new System.Drawing.Size(291, 44);
            this.ploader.TabIndex = 9;
            this.ploader.Text = "Build Patched File";
            this.ploader.TextAlignment = System.Drawing.StringAlignment.Center;
            this.ploader.Click += new System.EventHandler(this.iTalk_Button_21_Click);
            // 
            // viewerPanel
            // 
            this.viewerPanel.BackColor = System.Drawing.Color.Transparent;
            this.viewerPanel.Controls.Add(this.hexi);
            this.viewerPanel.Location = new System.Drawing.Point(8, 202);
            this.viewerPanel.Name = "viewerPanel";
            this.viewerPanel.Padding = new System.Windows.Forms.Padding(5);
            this.viewerPanel.Size = new System.Drawing.Size(783, 264);
            this.viewerPanel.TabIndex = 8;
            this.viewerPanel.Text = "HEX";
            // 
            // hexi
            // 
            this.hexi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hexi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.hexi.Location = new System.Drawing.Point(5, 5);
            this.hexi.Name = "hexi";
            this.hexi.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.hexi.Size = new System.Drawing.Size(773, 254);
            this.hexi.StringViewVisible = true;
            this.hexi.TabIndex = 0;
            this.hexi.VScrollBarVisible = true;
            this.hexi.Click += new System.EventHandler(this.hexi_Click);
            // 
            // iTalk_GroupBox2
            // 
            this.iTalk_GroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_GroupBox2.Controls.Add(this.GDBase64);
            this.iTalk_GroupBox2.Controls.Add(this.sizeforeparse);
            this.iTalk_GroupBox2.Controls.Add(this.DefOffsetSPoint);
            this.iTalk_GroupBox2.Controls.Add(this.GDBase64P);
            this.iTalk_GroupBox2.Controls.Add(this.sizeoffile);
            this.iTalk_GroupBox2.Location = new System.Drawing.Point(365, 55);
            this.iTalk_GroupBox2.MinimumSize = new System.Drawing.Size(136, 50);
            this.iTalk_GroupBox2.Name = "iTalk_GroupBox2";
            this.iTalk_GroupBox2.Padding = new System.Windows.Forms.Padding(5, 28, 5, 5);
            this.iTalk_GroupBox2.Size = new System.Drawing.Size(427, 141);
            this.iTalk_GroupBox2.TabIndex = 4;
            this.iTalk_GroupBox2.Text = "File Details";
            // 
            // GDBase64
            // 
            this.GDBase64.Location = new System.Drawing.Point(58, 51);
            this.GDBase64.Name = "GDBase64";
            this.GDBase64.Size = new System.Drawing.Size(360, 20);
            this.GDBase64.TabIndex = 8;
            // 
            // sizeforeparse
            // 
            this.sizeforeparse.AutoSize = true;
            this.sizeforeparse.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeforeparse.Location = new System.Drawing.Point(76, 31);
            this.sizeforeparse.Name = "sizeforeparse";
            this.sizeforeparse.Size = new System.Drawing.Size(108, 20);
            this.sizeforeparse.TabIndex = 4;
            this.sizeforeparse.Text = "No file Loaded";
            // 
            // DefOffsetSPoint
            // 
            this.DefOffsetSPoint.AutoSize = true;
            this.DefOffsetSPoint.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DefOffsetSPoint.Location = new System.Drawing.Point(9, 74);
            this.DefOffsetSPoint.Name = "DefOffsetSPoint";
            this.DefOffsetSPoint.Size = new System.Drawing.Size(217, 20);
            this.DefOffsetSPoint.TabIndex = 3;
            this.DefOffsetSPoint.Text = "Default Start Point: 0x00000000";
            // 
            // GDBase64P
            // 
            this.GDBase64P.AutoSize = true;
            this.GDBase64P.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GDBase64P.Location = new System.Drawing.Point(9, 51);
            this.GDBase64P.Name = "GDBase64P";
            this.GDBase64P.Size = new System.Drawing.Size(52, 20);
            this.GDBase64P.TabIndex = 1;
            this.GDBase64P.Text = "HASH:";
            // 
            // sizeoffile
            // 
            this.sizeoffile.AutoSize = true;
            this.sizeoffile.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeoffile.Location = new System.Drawing.Point(9, 31);
            this.sizeoffile.Name = "sizeoffile";
            this.sizeoffile.Size = new System.Drawing.Size(66, 20);
            this.sizeoffile.TabIndex = 0;
            this.sizeoffile.Text = "File Size:";
            // 
            // iTalk_GroupBox1
            // 
            this.iTalk_GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_GroupBox1.Controls.Add(this.CS_bypass_enforcement);
            this.iTalk_GroupBox1.Controls.Add(this.checkBox2);
            this.iTalk_GroupBox1.Controls.Add(this.checkBox1);
            this.iTalk_GroupBox1.Controls.Add(this.go_patch_apptype_inv);
            this.iTalk_GroupBox1.Location = new System.Drawing.Point(8, 55);
            this.iTalk_GroupBox1.MinimumSize = new System.Drawing.Size(136, 50);
            this.iTalk_GroupBox1.Name = "iTalk_GroupBox1";
            this.iTalk_GroupBox1.Padding = new System.Windows.Forms.Padding(5, 28, 5, 5);
            this.iTalk_GroupBox1.Size = new System.Drawing.Size(351, 141);
            this.iTalk_GroupBox1.TabIndex = 2;
            this.iTalk_GroupBox1.Text = "Patching Options";
            // 
            // CS_bypass_enforcement
            // 
            this.CS_bypass_enforcement.AutoSize = true;
            this.CS_bypass_enforcement.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CS_bypass_enforcement.Location = new System.Drawing.Point(17, 96);
            this.CS_bypass_enforcement.Name = "CS_bypass_enforcement";
            this.CS_bypass_enforcement.Size = new System.Drawing.Size(202, 25);
            this.CS_bypass_enforcement.TabIndex = 3;
            this.CS_bypass_enforcement.Text = "I know how to bypass CS";
            this.CS_bypass_enforcement.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(17, 74);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(129, 25);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "Mach-O is x64";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(17, 51);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(210, 25);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Instruction To Patch Mode";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // go_patch_apptype_inv
            // 
            this.go_patch_apptype_inv.AutoSize = true;
            this.go_patch_apptype_inv.Checked = true;
            this.go_patch_apptype_inv.CheckState = System.Windows.Forms.CheckState.Checked;
            this.go_patch_apptype_inv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.go_patch_apptype_inv.Location = new System.Drawing.Point(17, 31);
            this.go_patch_apptype_inv.Name = "go_patch_apptype_inv";
            this.go_patch_apptype_inv.Size = new System.Drawing.Size(192, 25);
            this.go_patch_apptype_inv.TabIndex = 0;
            this.go_patch_apptype_inv.Text = "Application Invalidation";
            this.go_patch_apptype_inv.UseVisualStyleBackColor = true;
            // 
            // caller
            // 
            this.caller.BackColor = System.Drawing.Color.Transparent;
            this.caller.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.caller.Image = null;
            this.caller.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.caller.Location = new System.Drawing.Point(620, 9);
            this.caller.Name = "caller";
            this.caller.Size = new System.Drawing.Size(166, 40);
            this.caller.TabIndex = 1;
            this.caller.Text = "Load File";
            this.caller.TextAlignment = System.Drawing.StringAlignment.Center;
            this.caller.Click += new System.EventHandler(this.file_offset_parser_Click);
            // 
            // IOFileSystemFile
            // 
            this.IOFileSystemFile.BackColor = System.Drawing.Color.Transparent;
            this.IOFileSystemFile.Font = new System.Drawing.Font("Tahoma", 11F);
            this.IOFileSystemFile.ForeColor = System.Drawing.Color.DimGray;
            this.IOFileSystemFile.Image = null;
            this.IOFileSystemFile.Location = new System.Drawing.Point(8, 8);
            this.IOFileSystemFile.MaxLength = 32767;
            this.IOFileSystemFile.Multiline = false;
            this.IOFileSystemFile.Name = "IOFileSystemFile";
            this.IOFileSystemFile.ReadOnly = false;
            this.IOFileSystemFile.Size = new System.Drawing.Size(606, 41);
            this.IOFileSystemFile.TabIndex = 0;
            this.IOFileSystemFile.Text = "...";
            this.IOFileSystemFile.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.IOFileSystemFile.UseSystemPasswordChar = false;
            // 
            // AppHeaderParser
            // 
            this.AppHeaderParser.AutoSize = true;
            this.AppHeaderParser.BackColor = System.Drawing.Color.Transparent;
            this.AppHeaderParser.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppHeaderParser.ForeColor = System.Drawing.Color.White;
            this.AppHeaderParser.Location = new System.Drawing.Point(12, 9);
            this.AppHeaderParser.Name = "AppHeaderParser";
            this.AppHeaderParser.Size = new System.Drawing.Size(533, 30);
            this.AppHeaderParser.TabIndex = 9;
            this.AppHeaderParser.Text = "F.C.E. 365 Firmware Manager - Setup.App Patcher - Beta";
            // 
            // IOApplicationAccellerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(815, 592);
            this.Controls.Add(this.GO_Offset_container);
            this.Controls.Add(this.AppHeaderParser);
            this.Controls.Add(this.OffsetPointStopBySize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IOApplicationAccellerator";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F.C.E. 365 Firmware Manager";
            this.Load += new System.EventHandler(this.IOApplicationAccellerator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OffsetPointStopBySize)).EndInit();
            this.GO_Offset_container.ResumeLayout(false);
            this.GO_Offset_container.PerformLayout();
            this.viewerPanel.ResumeLayout(false);
            this.iTalk_GroupBox2.ResumeLayout(false);
            this.iTalk_GroupBox2.PerformLayout();
            this.iTalk_GroupBox1.ResumeLayout(false);
            this.iTalk_GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox OffsetPointStopBySize;
        private iTalk.iTalk_HeaderLabel AppHeaderParser;
        private iTalk.iTalk_Panel GO_Offset_container;
        private iTalk.iTalk_GroupBox iTalk_GroupBox1;
        private iTalk.iTalk_Button_1 caller;
        private iTalk.iTalk_TextBox_Big IOFileSystemFile;
        private iTalk.iTalk_GroupBox iTalk_GroupBox2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox go_patch_apptype_inv;
        private System.Windows.Forms.Label sizeforeparse;
        private System.Windows.Forms.Label DefOffsetSPoint;
        private System.Windows.Forms.Label GDBase64P;
        private System.Windows.Forms.Label sizeoffile;
        private System.Windows.Forms.OpenFileDialog fileparserattr;
        private iTalk.iTalk_Panel viewerPanel;
        private System.ComponentModel.BackgroundWorker processor;
        private System.Windows.Forms.TextBox GDBase64;
        private Be.Windows.Forms.HexBox hexi;
        private iTalk.iTalk_Button_2 ploader;
        private System.Windows.Forms.CheckBox CS_bypass_enforcement;
        private System.Windows.Forms.Label warnax_1;
    }
}