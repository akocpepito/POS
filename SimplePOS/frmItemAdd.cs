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
    public partial class FrmItemAdd : Form
    {
        public FrmItemAdd()
        {
            InitializeComponent();
        }

        readonly SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-SFOR7QM\SQLEXPRESS;Initial Catalog=POSDB;Integrated Security=True");
        int itemCount;
        int categoryCount;
        

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

        private void LoadCategory() // initializes the Position Combo Box
        {
            SqlCommand cmd = new SqlCommand("Select Category from tblItem", cn);
            DataTable dt = new DataTable();

            cn.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);

            categoryCount = dt.Rows.Count;

            for (int i = 0; i < categoryCount; i++)
            {
                cbCategory.Items.Add(dt.Rows[i].ItemArray[0].ToString());
            }

            cn.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            CheckItemCount(cbCategory.Text);
            string itemCode = cbCategory.Text + "-" + string.Format("{000}", itemCount);
            SqlCommand cmd = new SqlCommand("INSERT INTO tblItem (ID,ItemCode,Category,Description,Size,Quantity,UnitPrice,RepLevel) VALUES ('" +itemCount+ "','" + txtCode.Text + "','" + cbCategory.Text + "','" + txtDesc.Text + "','" + txtSize.Text + "','" + txtQuantity.Text + "','" + txtPrice.Text + "','" + txtReproduce.Text + "')", cn);

            try
            {
                cn.Open();

                SqlDataReader sdr = cmd.ExecuteReader();
                cn.Close();

                MessageBox.Show("New Item has been added!");
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
            txtCode.Enabled = false;
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckItemCount(cbCategory.Text);
            int decLength = itemCount.ToString("D").Length + 2;
            txtCode.Text = cbCategory.Text +"-"+ itemCount.ToString("D" + decLength.ToString());
        }
    }
}
