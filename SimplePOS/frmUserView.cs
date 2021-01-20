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
    public partial class FrmUserView : Form
    {
        public FrmUserView()
        {
            InitializeComponent();
        }

        private void FrmUserView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'userDBset.tblUser' table. You can move, or remove it, as needed.
            this.tblUserTableAdapter.Fill(this.userDBset.tblUser);
            btnUpdate.Enabled = false;

        }

        readonly SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-SFOR7QM\SQLEXPRESS;Initial Catalog=POSDB;Integrated Security=True");
        int updateIndex;
        int updateID;

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            using (FrmUserAdd f = new FrmUserAdd() { })
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    RefreshGrid();
                }
            }
        }

        private void RefreshGrid() // Refreshes DataGridView
        {
            SqlCommand cmd = new SqlCommand("Select * from tblUser", cn);
            DataTable dt = new DataTable();

            cn.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            cn.Close();

            dgUser.DataSource = dt;

        }

        private void DgUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate.Enabled = true;

            int indexRow = e.RowIndex;
            if (indexRow >= 0)
            {
                updateIndex = e.RowIndex;
                updateID = Convert.ToInt32(dgUser.Rows[e.RowIndex].Cells[0].Value);

                Console.WriteLine(updateIndex + " " + dgUser.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            using (FrmUserUpdate f = new FrmUserUpdate(updateID) { })
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    RefreshGrid();
                }
            }

        }

        private void TxtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtSearch.Text.Length > 0)
            {
                SqlCommand cmd = new SqlCommand("Select * from tblUser where LastName = '" + txtSearch.Text + "'", cn);
                DataTable dt = new DataTable();

                cn.Open();

                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);
                cn.Close();

                dgUser.DataSource = dt;
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }
    }
}
