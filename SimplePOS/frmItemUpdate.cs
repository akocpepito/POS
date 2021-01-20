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
    public partial class FrmItemUpdate : Form
    {
        public FrmItemUpdate(int num)
        {
            InitializeComponent();
            updateID = num;
        }

        readonly SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-SFOR7QM\SQLEXPRESS;Initial Catalog=POSDB;Integrated Security=True");
        readonly int updateID;
        int itemCount;
        

        private void CheckItemCount(string item)
        {
            SqlCommand cmd = new SqlCommand("Select * from tblItem where Category = '"+item+"'", cn);
            DataTable dt = new DataTable();

            cn.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            cn.Close();

            if (dt.Rows.Count == 0)
            {
                itemCount = 1;
            }
            else
            {
                itemCount = dt.Rows.Count + 1;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE tblItem SET Category = '" + cbCategory.Text + "', Description = '" + txtDesc.Text + "', Size = '" + txtSize.Text + "', Quantity = '" + txtQuantity.Text + "', UnitPrice = '" + txtPrice.Text + "', RepLevel = '" + txtReproduce.Text + "' WHERE ItemCode = '" + txtCode.Text + "'", cn);

            try
            {
                cn.Open();

                SqlDataReader sdr = cmd.ExecuteReader();
                cn.Close();

                MessageBox.Show("Item has been updated!");

                //                ClearFields();

                //              refreshGrid();

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }            
        }

        private void FrmItemAdd_Load(object sender, EventArgs e)
        {
            cbCategory.Items.Add("Test");
            LoadFormEntries();
        }

        private void LoadFormEntries() // loads values on the update form
        {
            SqlCommand cmd = new SqlCommand("Select * from tblItem where ID = '" + updateID + "'", cn);
            DataTable dt = new DataTable();

            cn.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            cn.Close();

            cbCategory.Text = dt.Rows[0].ItemArray[2].ToString();
            txtCode.Text = dt.Rows[0].ItemArray[1].ToString();
            txtDesc.Text = dt.Rows[0].ItemArray[3].ToString();
            txtSize.Text = dt.Rows[0].ItemArray[4].ToString();
            txtQuantity.Text = dt.Rows[0].ItemArray[5].ToString();
            txtPrice.Text = dt.Rows[0].ItemArray[6].ToString();
            txtReproduce.Text = dt.Rows[0].ItemArray[7].ToString();
            /*
            txtStaffNo.Text = dt.Rows[0].ItemArray[0].ToString();
            txtUname.Text = dt.Rows[0].ItemArray[1].ToString();
            txtPwd.Text = dt.Rows[0].ItemArray[2].ToString();
            txtLname.Text = dt.Rows[0].ItemArray[3].ToString();
            txtFname.Text = dt.Rows[0].ItemArray[4].ToString();
            txtMname.Text = dt.Rows[0].ItemArray[5].ToString();
            txtAddress.Text = dt.Rows[0].ItemArray[6].ToString();
            txtContactNum.Text = dt.Rows[0].ItemArray[7].ToString();
            cbPosition.Text = dt.Rows[0].ItemArray[8].ToString();
            */

        }
    }
}
