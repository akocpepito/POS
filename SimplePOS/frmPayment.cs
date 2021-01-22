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
    public partial class frmPayment : Form
    {
        public frmPayment(frmPOSMain f)
        {
            InitializeComponent();

            fm = f;
        }

        frmPOSMain fm;
        DataTable dt;
        double totalPrice;

        private void frmPayment_Load(object sender, EventArgs e)
        {
            dt = fm.getDataTable();
            totalPrice = fm.getTotal();
            txtTotalAmt.Enabled = false;
            txtTotalAmt.Text = totalPrice.ToString();
        }

        private void txtCash_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtCash.Text.Equals(""))
            {
                txtChange.Text = "";
            }
            else {
                double change = Convert.ToDouble(txtCash.Text) - totalPrice;
                txtChange.Text = change.ToString();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            using (frmReceipt f = new frmReceipt() { })
            {
                f.ShowDialog();
            }
        }
    }
}
