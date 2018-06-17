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
    public partial class Form_Into_Data_Product_Beginnig : Form
    {
        public Form_Into_Data_Product_Beginnig()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Form_Into_Sample_Product view = new Form_Into_Sample_Product();
            view.ShowDialog();
        }
    }
}
