using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace SimplePOS
{
    class Basket
    {
        public Basket()
        {
//            dgvr = _dgvr;
            dt.Columns.AddRange(new DataColumn[8] { new DataColumn("Item Code", typeof(string)), new DataColumn("Description", typeof(string)), new DataColumn("Price", typeof(string)), new DataColumn("Quantity", typeof(string)), new DataColumn("ID", typeof(string)), new DataColumn("Category", typeof(string)), new DataColumn("Size", typeof(string)), new DataColumn("Rep Level", typeof(string)) });
        }

        DataTable dt = new DataTable();
       // DataGridViewRow dgvr;
        public DataGridView dgItem;

        public void addItem(DataGridViewRow row)
        {
            dt.Rows.Add(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString(), row.Cells[4].Value.ToString(), row.Cells[5].Value.ToString(), row.Cells[6].Value.ToString(), row.Cells[7].Value.ToString());
            dgItem.DataSource = dt;
        }

        public DataGridView getData()
        {
            return this.dgItem;
        }
             
    }
}
