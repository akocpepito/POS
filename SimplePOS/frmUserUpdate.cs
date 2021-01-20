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
    public partial class frmUserUpdate : Form
    {
        public frmUserUpdate(int num)
        {
            InitializeComponent();
            updateID = num;
        }

        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-SFOR7QM\SQLEXPRESS;Initial Catalog=POSDB;Integrated Security=True");
        readonly int updateID;
        int posCount;

        private void frmUserUpdate_Load(object sender, EventArgs e)
        {
            loadPosition();
            LoadFormEntries();
            txtStaffNo.Enabled = false;

        }

        private void LoadFormEntries() // loads values on the update form
        {
            SqlCommand cmd = new SqlCommand("Select * from tblUser where ID = '"+updateID+"'", cn);
            DataTable dt = new DataTable();

            cn.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            cn.Close();

            txtStaffNo.Text = dt.Rows[0].ItemArray[0].ToString();
            txtUname.Text = dt.Rows[0].ItemArray[1].ToString();
            txtPwd.Text = dt.Rows[0].ItemArray[2].ToString();
            txtLname.Text = dt.Rows[0].ItemArray[3].ToString();
            txtFname.Text = dt.Rows[0].ItemArray[4].ToString();
            txtMname.Text = dt.Rows[0].ItemArray[5].ToString();
            txtAddress.Text = dt.Rows[0].ItemArray[6].ToString();
            txtContactNum.Text = dt.Rows[0].ItemArray[7].ToString();
            cbPosition.Text = dt.Rows[0].ItemArray[8].ToString();
            
        }

        private void loadPosition() // initializes the Position Combo Box
        {
            SqlCommand cmd = new SqlCommand("Select Description from tblPosition", cn);
            DataTable dt = new DataTable();

            cn.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);

            posCount = dt.Rows.Count;

            for (int i = 0; i < posCount; i++)
            {
                cbPosition.Items.Add(dt.Rows[i].ItemArray[0].ToString());
            }

            cn.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtLname.Text + ", " + txtFname.Text + " " + txtMname.Text + ".";
            SqlCommand cmd = new SqlCommand("UPDATE tblUser SET Username = '"+txtUname.Text+"', Password = '"+txtPwd.Text+"', LastName = '"+txtLname.Text+"', FirstName = '"+txtFname.Text+"', MiddleName = '"+txtMname.Text+"', Address = '"+txtAddress.Text+"', ContactNum = '"+txtContactNum.Text+"', Position = '"+cbPosition.Text+"', Name = '"+name+"' WHERE ID = '"+txtStaffNo.Text+"'", cn); 

            try
            {
                cn.Open();

                SqlDataReader sdr = cmd.ExecuteReader();
                cn.Close();

                MessageBox.Show("User has been updated!");

//                ClearFields();

  //              refreshGrid();

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

    }
}
