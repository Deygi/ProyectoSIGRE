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
    public partial class Form_Into_Sample_Product : Form
    {
        public Form_Into_Sample_Product()
        {
            InitializeComponent();
        }

        private void btnSeeList_Click(object sender, EventArgs e)
        {
            Form_List_Product_Into view = new Form_List_Product_Into();
            view.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
