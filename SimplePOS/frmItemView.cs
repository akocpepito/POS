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
    public partial class FrmItemView : Form
    {
        public FrmItemView()
        {
            InitializeComponent();
        }

        readonly SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-SFOR7QM\SQLEXPRESS;Initial Catalog=POSDB;Integrated Security=True");
        int updateIndex;
        int updateID;

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            using (FrmItemAdd f = new FrmItemAdd() { })
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    RefreshGrid();
                }
            }
        }

        private void RefreshGrid() // Refreshes DataGridView
        {
            SqlCommand cmd = new SqlCommand("Select * from tblItem", cn);
            DataTable dt = new DataTable();

            cn.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            cn.Close();

            dgItem.DataSource = dt;

        }

        private void FrmItemView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'itemDB.tblItem' table. You can move, or remove it, as needed.
            this.tblItemTableAdapter.Fill(this.itemDB.tblItem);

        }

        private void DgItem_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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

        private void dgItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate.Enabled = true;

            int indexRow = e.RowIndex;
            if (indexRow >= 0)
            {
                updateIndex = e.RowIndex;
                updateID = Convert.ToInt32(dgItem.Rows[e.RowIndex].Cells[0].Value);

                Console.WriteLine(updateIndex + " " + dgItem.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (FrmItemUpdate f = new FrmItemUpdate(updateID) { })
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    RefreshGrid();
                }
            }
        }
    }
}
