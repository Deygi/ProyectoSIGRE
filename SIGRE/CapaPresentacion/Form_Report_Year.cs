using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;
namespace CapaPresentacion
{
    public partial class Form_Report_Year : Form
    {
        public Form_Report_Year()
        {
            InitializeComponent();
        }

        private void bntBefore_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
