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
    public partial class frmCategory : Form
    {
        public frmCategory()
        {
            InitializeComponent();
        }

        readonly SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-SFOR7QM\SQLEXPRESS;Initial Catalog=POSDB;Integrated Security=True");

        private void frmCategory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pOSDBDataSet4.tblCategory' table. You can move, or remove it, as needed.
            this.tblCategoryTableAdapter.Fill(this.pOSDBDataSet4.tblCategory);
            btnSave.Visible = false;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Visible = false;
            btnSave.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO tblCategory (ItemCode,Description) VALUES ('" + txtCatCode.Text + "','" + txtCatDesc.Text + "');", cn);

            try
            {
                btnSave.Visible = false;
                btnAdd.Visible = true;

                cn.Open();

                SqlDataReader sdr = cmd.ExecuteReader();
                cn.Close();

                MessageBox.Show("New Position has been added!");

                //ClearFields();
                // RefreshGrid();

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }
    }
}
