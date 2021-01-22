using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePOS
{
    public partial class frmDiscount : Form
    {
        public frmDiscount(frmPOSMain main)
        {
            InitializeComponent();
            fpm = main;
        }

        frmPOSMain fpm;

        private void frmDiscount_Load(object sender, EventArgs e)
        {

        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            if (!txtDiscount.Text.Equals(""))
                fpm.ComputeTotal(Convert.ToInt32(txtDiscount.Text));
            else {
                this.DialogResult = DialogResult.None;
            }
        }
    }
}
