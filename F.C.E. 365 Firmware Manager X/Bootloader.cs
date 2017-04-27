using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F.C.E._365_Firmware_Manager_X
{
    public partial class Bootloader : Form
    {
        public Bootloader()
        {
            InitializeComponent();
        }

        private void BootLoader_ARGS_Tick(object sender, EventArgs e)
        {
            PE_Loader.Increment(1);
            if (PE_Loader.Value == 100)
                BootLoader_ARGS.Stop();
        }
    }
}
