namespace SimplePOS
{
    partial class frmPOSMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnPOSAdd = new System.Windows.Forms.Button();
            this.dgPOSMain = new System.Windows.Forms.DataGridView();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.frmPOSMainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgPOSMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmPOSMainBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPOSAdd
            // 
            this.btnPOSAdd.Location = new System.Drawing.Point(627, 305);
            this.btnPOSAdd.Name = "btnPOSAdd";
            this.btnPOSAdd.Size = new System.Drawing.Size(75, 23);
            this.btnPOSAdd.TabIndex = 1;
            this.btnPOSAdd.Text = "Add Item";
            this.btnPOSAdd.UseVisualStyleBackColor = true;
            this.btnPOSAdd.Click += new System.EventHandler(this.btnPOSAdd_Click);
            // 
            // dgPOSMain
            // 
            this.dgPOSMain.AllowUserToAddRows = false;
            this.dgPOSMain.AllowUserToDeleteRows = false;
            this.dgPOSMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPOSMain.Location = new System.Drawing.Point(24, 100);
            this.dgPOSMain.Name = "dgPOSMain";
            this.dgPOSMain.ReadOnly = true;
            this.dgPOSMain.Size = new System.Drawing.Size(537, 338);
            this.dgPOSMain.TabIndex = 0;
            this.dgPOSMain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPOSMain_CellClick);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(611, 123);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(91, 42);
            this.lblTotalPrice.TabIndex = 2;
            this.lblTotalPrice.Text = "0.00";
            this.lblTotalPrice.Click += new System.EventHandler(this.lblTotalPrice_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(627, 260);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveItem.TabIndex = 3;
            this.btnRemoveItem.Text = "Remove";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(592, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total Price:";
            // 
            // btnDiscount
            // 
            this.btnDiscount.Location = new System.Drawing.Point(627, 348);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(75, 23);
            this.btnDiscount.TabIndex = 5;
            this.btnDiscount.Text = "Discount";
            this.btnDiscount.UseVisualStyleBackColor = true;
            this.btnDiscount.Click += new System.EventHandler(this.btnDiscount_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(627, 397);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(75, 23);
            this.btnPayment.TabIndex = 6;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // frmPOSMainBindingSource
            // 
            this.frmPOSMainBindingSource.DataSource = typeof(SimplePOS.frmPOSMain);
            // 
            // frmPOSMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.btnDiscount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.btnPOSAdd);
            this.Controls.Add(this.dgPOSMain);
            this.Name = "frmPOSMain";
            this.Text = "frmPOSMain";
            this.Load += new System.EventHandler(this.frmPOSMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPOSMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmPOSMainBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPOSAdd;
        private System.Windows.Forms.BindingSource frmPOSMainBindingSource;
        private System.Windows.Forms.DataGridView dgPOSMain;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.Button btnPayment;
    }
}