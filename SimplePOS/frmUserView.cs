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
    public partial class frmUserView : Form
    {
        public frmUserView()
        {
            InitializeComponent();
        }

        private void frmUserView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'userDBset.tblUser' table. You can move, or remove it, as needed.
            this.tblUserTableAdapter.Fill(this.userDBset.tblUser);
            btnUpdate.Enabled = false;

        }

        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-SFOR7QM\SQLEXPRESS;Initial Catalog=POSDB;Integrated Security=True");
        int updateIndex;
        int updateID;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (frmUserAdd f = new frmUserAdd() { })
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    refreshGrid();
                }
            }
        }

        private void refreshGrid() // Refreshes DataGridView
        {
            SqlCommand cmd = new SqlCommand("Select * from tblUser", cn);
            DataTable dt = new DataTable();

            cn.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            cn.Close();

            dgUser.DataSource = dt;

        }

        private void dgUser_CellClick(object sender, DataGridViewCellEventArgs e)
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (frmUserUpdate f = new frmUserUpdate(updateID) { })
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    refreshGrid();
                }
            }

        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            refreshGrid();
        }
    }
}
