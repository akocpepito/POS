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
    public partial class frmPOSMain : Form
    {
        public frmPOSMain()
        {
            InitializeComponent();
        }

        DataGridView data;
        DataGridViewRow rowData;
        DataTable dt = new DataTable();
        string[] dataString = new string[5];
        int deleteRowIndex;
        double totalPrice = 0;
        double discount = 0;

        public void setDataTable(DataGridView dt)
        {
            data = dt;
        }

        public DataTable getDataTable()
        {
            return this.dt;
        }

        public Double getTotal()
        {
            return this.totalPrice;
        }

        public void setDataRow(string[] row)
        {
            for (int i = 0; i < 5; i++)
            {
                dataString[i] = row[i];
            }
        }

        public void addRow()
        {
            dt.Rows.Add(dataString[0], dataString[1], dataString[2], dataString[3], dataString[4]);
            MessageBox.Show("An item has been added to the basket.");
        }

        public void ComputeTotal(int _discount)
        {
            if (dt.Rows.Count < 1)
            {
                lblTotalPrice.Text = "0.00";
            }
            else
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    totalPrice = totalPrice + Convert.ToDouble(dt.Rows[i].ItemArray[4]);
                }
                discount = (totalPrice / 100) * _discount;
                totalPrice = totalPrice - discount;
                lblTotalPrice.Text = totalPrice.ToString();
            }
        }

        private void btnPOSAdd_Click(object sender, EventArgs e)
        {
            using (frmPOSAdd f = new frmPOSAdd(this) { })
            {
                f.ShowDialog();
                addRow();
                dgPOSMain.DataSource = dt;
                ComputeTotal(0);
            }
        }

        private void frmPOSMain_Load(object sender, EventArgs e)
        {
            dt.Columns.AddRange(new DataColumn[5] { new DataColumn("Item Code", typeof(string)), new DataColumn("Description", typeof(string)), new DataColumn("Price", typeof(string)), new DataColumn("Quantity", typeof(string)), new DataColumn("Total", typeof(string)) });
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(deleteRowIndex.ToString());
            dt.Rows[deleteRowIndex].Delete();
            dgPOSMain.DataSource = dt;
            ComputeTotal(0);
        }

        private void dgPOSMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            deleteRowIndex = e.RowIndex;
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            using (frmDiscount f = new frmDiscount(this) { })
            {
                f.ShowDialog();
            }
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            using (frmPayment f = new frmPayment(this) { })
            {
                f.ShowDialog();
            
            }
        }
    }
}
