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
    public partial class frmUserAdd : Form
    {
        public frmUserAdd()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-SFOR7QM\SQLEXPRESS;Initial Catalog=POSDB;Integrated Security=True");
        int posCount;
        int userIndex;

        public void SetID(string _id)
        {
            this.txtStaffNo.Text = _id; 
        }





        private void frmUserAdd_Load(object sender, EventArgs e)
        {
            checkTableIndex();
            loadPosition(); // initializes the Position Combo Box
            txtStaffNo.Enabled = false;
            txtStaffNo.Text = userIndex.ToString();
            MessageBox.Show("No. of Users in DB: " + (userIndex-1));

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

        private void checkTableIndex() // Checks how many items are in the table and what index to use for next entry
        {
            SqlCommand cmd = new SqlCommand("Select * from tblUser", cn);
            DataTable dt = new DataTable();

            cn.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            cn.Close();

            if (dt.Rows.Count == 0)
            {
                userIndex = 1;
            }
            else
            {
                userIndex = dt.Rows.Count + 1;
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtLname.Text + ", " + txtFname.Text + " " + txtMname.Text + ".";
            SqlCommand cmd = new SqlCommand("INSERT INTO tblUser (ID,Username,Password,LastName,FirstName,MiddleName,Address,ContactNum,Position,Name) VALUES ('" + txtStaffNo.Text + "','" + txtUname.Text + "','" + txtPwd.Text + "','" + txtLname.Text + "','" + txtFname.Text + "','" + txtMname.Text + "','" + txtAddress.Text + "','" + txtContactNum.Text + "','" + cbPosition.Text + "','" + name + "');", cn);

            try
            {
                cn.Open();

                SqlDataReader sdr = cmd.ExecuteReader();
                cn.Close();

                MessageBox.Show("New User has been added!");

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
