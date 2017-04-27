namespace F.C.E._365_Firmware_Manager_X
{
    partial class Bootloader
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
            this.components = new System.ComponentModel.Container();
            this.BootLoader_ARGS = new System.Windows.Forms.Timer(this.components);
            this.PE_Loader = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // BootLoader_ARGS
            // 
            this.BootLoader_ARGS.Tick += new System.EventHandler(this.BootLoader_ARGS_Tick);
            // 
            // PE_Loader
            // 
            this.PE_Loader.Location = new System.Drawing.Point(247, 150);
            this.PE_Loader.Name = "PE_Loader";
            this.PE_Loader.Size = new System.Drawing.Size(370, 10);
            this.PE_Loader.TabIndex = 1;
            this.PE_Loader.Visible = false;
            // 
            // Bootloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
           
            this.ClientSize = new System.Drawing.Size(864, 310);
            this.Controls.Add(this.PE_Loader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bootloader";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F.C.E. 365 Firmware Manager X";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer BootLoader_ARGS;
        private System.Windows.Forms.ProgressBar PE_Loader;
    }
}