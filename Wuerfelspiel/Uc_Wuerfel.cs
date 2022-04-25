using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wuerfelspiel
{
    public partial class Uc_Wuerfel : UserControl
    {

        int W 
        public Uc_Wuerfel()
        {
            InitializeComponent();
            W = new Wuerfel();
        }

        private void Uc_Wuerfel_Load(object sender, EventArgs e)
        {

        }
    }
}
