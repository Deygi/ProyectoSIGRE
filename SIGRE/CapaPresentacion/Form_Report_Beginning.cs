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
    public partial class Form_Report_Beginning : Form
    {
        public Form_Report_Beginning()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReportMonth_Click(object sender, EventArgs e)
        {
            Form_Report_Month view = new Form_Report_Month();
            view.ShowDialog();
        }

        private void btnReportYear_Click(object sender, EventArgs e)
        {
            Form_Report_Year view = new Form_Report_Year();
            view.ShowDialog();
        }
    }
}
