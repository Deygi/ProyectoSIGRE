using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Form_Report_Month : Form
    {
        public Form_Report_Month()
        {
            InitializeComponent();
        }

        private void bntBefore_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
