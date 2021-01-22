namespace SimplePOS
{
    partial class frmPOSItem
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
            this.dgPOSItem = new System.Windows.Forms.DataGridView();
            this.itemDBPOS = new SimplePOS.ItemDBPOS();
            this.tblItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblItemTableAdapter = new SimplePOS.ItemDBPOSTableAdapters.tblItemTableAdapter();
            this.itemCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgPOSItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemDBPOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPOSItem
            // 
            this.dgPOSItem.AllowUserToAddRows = false;
            this.dgPOSItem.AllowUserToDeleteRows = false;
            this.dgPOSItem.AutoGenerateColumns = false;
            this.dgPOSItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPOSItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemCodeDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn,
            this.repLevelDataGridViewTextBoxColumn});
            this.dgPOSItem.DataSource = this.tblItemBindingSource;
            this.dgPOSItem.Location = new System.Drawing.Point(12, 83);
            this.dgPOSItem.Name = "dgPOSItem";
            this.dgPOSItem.ReadOnly = true;
            this.dgPOSItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPOSItem.Size = new System.Drawing.Size(490, 196);
            this.dgPOSItem.TabIndex = 0;
            this.dgPOSItem.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPOSItem_CellDoubleClick);
            // 
            // itemDBPOS
            // 
            this.itemDBPOS.DataSetName = "ItemDBPOS";
            this.itemDBPOS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblItemBindingSource
            // 
            this.tblItemBindingSource.DataMember = "tblItem";
            this.tblItemBindingSource.DataSource = this.itemDBPOS;
            // 
            // tblItemTableAdapter
            // 
            this.tblItemTableAdapter.ClearBeforeFill = true;
            // 
            // itemCodeDataGridViewTextBoxColumn
            // 
            this.itemCodeDataGridViewTextBoxColumn.DataPropertyName = "ItemCode";
            this.itemCodeDataGridViewTextBoxColumn.HeaderText = "ItemCode";
            this.itemCodeDataGridViewTextBoxColumn.Name = "itemCodeDataGridViewTextBoxColumn";
            this.itemCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            this.unitPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sizeDataGridViewTextBoxColumn
            // 
            this.sizeDataGridViewTextBoxColumn.DataPropertyName = "Size";
            this.sizeDataGridViewTextBoxColumn.HeaderText = "Size";
            this.sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
            this.sizeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // repLevelDataGridViewTextBoxColumn
            // 
            this.repLevelDataGridViewTextBoxColumn.DataPropertyName = "RepLevel";
            this.repLevelDataGridViewTextBoxColumn.HeaderText = "RepLevel";
            this.repLevelDataGridViewTextBoxColumn.Name = "repLevelDataGridViewTextBoxColumn";
            this.repLevelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmPOSItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 332);
            this.Controls.Add(this.dgPOSItem);
            this.Name = "frmPOSItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPOSItem";
            this.Load += new System.EventHandler(this.frmPOSItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPOSItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemDBPOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblItemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPOSItem;
        private ItemDBPOS itemDBPOS;
        private System.Windows.Forms.BindingSource tblItemBindingSource;
        private ItemDBPOSTableAdapters.tblItemTableAdapter tblItemTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn repLevelDataGridViewTextBoxColumn;
    }
}