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
    public partial class frmPOSAdd : Form
    {
        public frmPOSAdd(frmPOSMain fpm)
        {
            InitializeComponent();
            temp = fpm;
        }

        frmPOSMain temp;

        readonly SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-SFOR7QM\SQLEXPRESS;Initial Catalog=POSDB;Integrated Security=True");
        int stockCount;

        public void setFields(string itemCode, string itemName, double itemPrice, int stock)
        {
            this.txtCode.Text = itemCode;
            this.txtItem.Text = itemName;
            this.txtPrice.Text = itemPrice.ToString();
            this.stockCount = stock;
        }

        private void frmPOSAdd_Load(object sender, EventArgs e)
        {
            txtCode.Enabled = false;
            txtItem.Enabled = false;
            txtPrice.Enabled = false;
            txtTotal.Enabled = false;
        }

        private void picSearch_Click(object sender, EventArgs e)
        {
            using (frmPOSItem f = new frmPOSItem(this) { })
            {
                f.ShowDialog();
                lblStockCount.Text = "(In Stock: " + stockCount.ToString() + ")";
                temp.setDataRow(setData());
            }
        }

        private void lblSearch_Click(object sender, EventArgs e)
        {
            using (frmPOSItem f = new frmPOSItem(this) { })
            {
                f.ShowDialog();
                lblStockCount.Text = "(In Stock: " + stockCount.ToString() + ")";
            }
        }

        private string[] setData()
        {
            string[] itemData = new string[5];

            itemData[0] = txtCode.Text;
            itemData[1] = txtItem.Text;
            itemData[2] = txtQty.Text;
            itemData[3] = txtPrice.Text;
            itemData[4] = txtTotal.Text;;

            return itemData;
        }

        private void txtQty_KeyUp(object sender, KeyEventArgs e)
        {
            double Total;
            double discountPrice;
            double DiscountedTotal;

            if (!txtQty.Text.Equals("") && !txtPrice.Text.Equals(""))
            {
                if (txtDiscount.Text.Equals(""))
                {
                    Total = Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtQty.Text);
                    txtTotal.Text = Total.ToString();
                    lblPriceDiscount.Text = "(Price discounted: 0)";
                }
                else
                {
                    Total = Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtQty.Text);
                    discountPrice = (Convert.ToDouble(txtDiscount.Text) / 100) * Total;
                    lblPriceDiscount.Text = "(Price discounted:" + discountPrice.ToString() + ")";

                    DiscountedTotal = Total - discountPrice;
                    txtTotal.Text = DiscountedTotal.ToString();
                }
            }
            else
            {
                txtTotal.Text = "";
                lblPriceDiscount.Text = "(Price discounted: 0)";
            }
        }

        private void txtDiscount_KeyUp(object sender, KeyEventArgs e)
        {
            double Total;
            double discountPrice;
            double DiscountedTotal;

            if (!txtQty.Text.Equals("") && !txtPrice.Text.Equals(""))
            {
                if (txtDiscount.Text.Equals(""))
                {
                    Total = Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtQty.Text);
                    txtTotal.Text = Total.ToString();
                    lblPriceDiscount.Text = "(Price discounted: 0)";
                }
                else
                {
                    Total = Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtQty.Text);
                    discountPrice = (Convert.ToDouble(txtDiscount.Text) / 100) * Total;
                    lblPriceDiscount.Text = "(Price discounted:" + discountPrice.ToString() + ")";

                    DiscountedTotal = Total - discountPrice;
                    txtTotal.Text = DiscountedTotal.ToString();
                }
            }
            else
            {
                txtTotal.Text = "";
                lblPriceDiscount.Text = "(Price discounted: 0)";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            temp.setDataRow(setData());
        }
    }
}
