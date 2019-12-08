using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pruefung2
{
    public partial class VentilatorControl : Form
    {
        public VentilatorControl()
        {
            InitializeComponent();
        }

        private void VentilatorControl_Load(object sender, EventArgs e)
        {
            pbTunnel.ImageLocation = "..\\..\\img\\tunnel.png";
        }
    }
}
