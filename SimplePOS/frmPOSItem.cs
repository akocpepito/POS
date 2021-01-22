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
    public partial class frmPOSItem : Form
    {
        public frmPOSItem(frmPOSAdd f)
        {
            InitializeComponent();
            temp = f;
        }

        private frmPOSAdd temp;

        private void frmPOSItem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'itemDBPOS.tblItem' table. You can move, or remove it, as needed.
            this.tblItemTableAdapter.Fill(this.itemDBPOS.tblItem);
        }

        private void dgPOSItem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            temp.setFields(dgPOSItem.CurrentRow.Cells[0].Value.ToString(), dgPOSItem.CurrentRow.Cells[1].Value.ToString(), Convert.ToDouble(dgPOSItem.CurrentRow.Cells[2].Value),Convert.ToInt32(dgPOSItem.CurrentRow.Cells[3].Value));
            this.DialogResult = DialogResult.OK;
        }
    }
}
