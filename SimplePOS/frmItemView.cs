using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SimplePOS
{
    public partial class frmItemView : Form
    {
        public frmItemView()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-SFOR7QM\SQLEXPRESS;Initial Catalog=POSDB;Integrated Security=True");

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (frmItemAdd f = new frmItemAdd() { })
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    refreshGrid();
                }
            }
        }

        private void refreshGrid() // Refreshes DataGridView
        {
            SqlCommand cmd = new SqlCommand("Select * from tblItem", cn);
            DataTable dt = new DataTable();

            cn.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            cn.Close();

            dgItem.DataSource = dt;

        }

        private void frmItemView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'itemDB.tblItem' table. You can move, or remove it, as needed.
            this.tblItemTableAdapter.Fill(this.itemDB.tblItem);

        }

        private void dgItem_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in dgItem.Rows)
            {
                int qty = Convert.ToInt32(row.Cells[5].Value);
                int limit = Convert.ToInt32(row.Cells[7].Value);

                if (qty <= limit)
                {
                    row.DefaultCellStyle.BackColor = Color.Tomato;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.Lime;
                }
            
            }
        }
    }
}
