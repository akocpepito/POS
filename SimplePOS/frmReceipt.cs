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
    public partial class frmReceipt : Form
    {
        public frmReceipt(DataTable _data)
        {
            InitializeComponent();
            data = _data;
        }

        DataTable data;

        private void frmReceipt_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Resibo: "+data.Rows[0].ItemArray[0].ToString());

            this.Height = 600;
            this.Width = 50;
            this.listView1.Height = 200;
            this.listView1.Width = 20;
            this.listView1.Dock = DockStyle.Fill;
        }

        public void PopulateListView()
        {
            for (int i = 0; i < data.Rows.Count; i++)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.SubItems.Add(data.Rows[i].ItemArray[0].ToString());
                listView1.Items.Add(lvi);
            }
            listView1.Refresh();
        }
    }
}
