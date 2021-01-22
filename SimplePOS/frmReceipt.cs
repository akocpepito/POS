using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePOS
{
    public partial class frmReceipt : Form
    {
        public frmReceipt(DataTable _data)
        {
            InitializeComponent();
            data = _data;
        }

        DataTable data;

        private void frmReceipt_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Resibo: "+data.Rows[0].ItemArray[0].ToString());
           // listView1.Layout = ListView.tem

            //this.Height = 600;
            //this.Width = 50;
            //this.listView1.Height = 200;
            //this.listView1.Width = 20;
            //this.listView1.Dock = DockStyle.Fill;

            PopulateListView();
        }

        public void PopulateListView()
        {
            int x = 50;
            int y = 100;
            Label[] myLBL = new Label[5];

            for (int i = 0; i < 5; i++)
            {
                myLBL[i] = new Label();
                myLBL[i].Text = "pota";
                myLBL[i].Location = new Point(x,y=y+20);
                this.Controls.Add(myLBL[i]);
                Console.WriteLine(data.Rows[0].ItemArray[i].ToString()+"------"+myLBL[i]);
            }
        }
    }
}
