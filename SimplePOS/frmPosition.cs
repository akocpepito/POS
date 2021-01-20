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
    public partial class frmPosition : Form
    {
        
        public frmPosition()
        {
            InitializeComponent();
            //MessageBox.Show(cn.ConnectionString);
        }

        private void frmPosition_Load(object sender, EventArgs e) // Initializes the form
        {
            // TODO: This line of code loads data into the 'pOSDBDataSet3.tblPosition' table. You can move, or remove it, as needed.
            this.tblPositionTableAdapter.Fill(this.pOSDBDataSet3.tblPosition);
       
            txtPosNo.Enabled = false;
            txtPosDesc.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-SFOR7QM\SQLEXPRESS;Initial Catalog=POSDB;Integrated Security=True");
        int indexRow;
        int positionIndex;

        private void refreshGrid() // Refreshes DataGridView
        {
            SqlCommand cmd = new SqlCommand("Select * from tblPosition", cn);
            DataTable dt = new DataTable();

            cn.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            cn.Close();

            dgPosition.DataSource = dt;
        
        }

        private void checkTableIndex() // Checks how many items are in the table and what index to use for next entry
        {
            SqlCommand cmd = new SqlCommand("Select * from tblPosition", cn);
            DataTable dt = new DataTable();

            cn.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            cn.Close();

            if (dt.Rows.Count == 0)
            {
                positionIndex = 1;
            }
            else
            {
                positionIndex = dt.Rows.Count + 1;
            }
        }

        private void ClearFields() // Clears all fields
        {
            txtPosNo.Text = "";
            txtPosDesc.Text = "";
        
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnSave.Visible = true;
            btnAdd.Visible = false;
            txtPosDesc.Enabled = true;
            checkTableIndex();
            txtPosNo.Text = positionIndex.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            SqlCommand cmd = new SqlCommand("INSERT INTO tblPosition (Number,Description) VALUES ('" + txtPosNo.Text + "','" + txtPosDesc.Text + "');", cn);

            try
            {
                btnSave.Visible = false;
                btnAdd.Visible = true;
                txtPosDesc.Enabled = false;
 
                cn.Open();

                SqlDataReader sdr = cmd.ExecuteReader();
                cn.Close();

                MessageBox.Show("New Position has been added!");
               
                ClearFields();

                refreshGrid();

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        } // exits the form when close is pressed

        private void dgPosition_CellClick(object sender, DataGridViewCellEventArgs e) // Updates the fields according to the cell selected in DGV
        {
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            txtPosDesc.Enabled = true;
            
            indexRow = e.RowIndex;
            if (indexRow >= 0)
            {
                DataGridViewRow row = dgPosition.Rows[indexRow];
                txtPosNo.Text = row.Cells[0].Value.ToString();
                txtPosDesc.Text = row.Cells[1].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE tblPosition SET Description='"+txtPosDesc.Text+"' WHERE Number='"+txtPosNo.Text+"'", cn);

            cn.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            cn.Close();

            MessageBox.Show("Position "+txtPosNo.Text+"has been updated!");

            refreshGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM tblPosition WHERE Number='" + txtPosNo.Text + "'", cn);

            cn.Open();

            cmd.ExecuteReader();
            cn.Close();

            MessageBox.Show("Position " + txtPosNo.Text + "has been deleted!");

            ClearFields();
            refreshGrid();
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }
    }
}
