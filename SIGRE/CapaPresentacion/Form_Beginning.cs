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
    public partial class Form_Beginning : Form
    {
        public Form_Beginning()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIntoData_Click(object sender, EventArgs e)
        {
            Form_Into_Data_Product_Beginnig view = new Form_Into_Data_Product_Beginnig();
            view.ShowDialog();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            Form_Report_Beginning view = new Form_Report_Beginning();
            view.ShowDialog();
        }
    }
}
