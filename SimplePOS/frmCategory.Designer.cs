namespace SimplePOS
{
    partial class frmCategory
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
            this.dgCategory = new System.Windows.Forms.DataGridView();
            this.txtCatCode = new System.Windows.Forms.TextBox();
            this.txtCatDesc = new System.Windows.Forms.TextBox();
            this.pOSDBDataSet4 = new SimplePOS.POSDBDataSet4();
            this.tblCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblCategoryTableAdapter = new SimplePOS.POSDBDataSet4TableAdapters.tblCategoryTableAdapter();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.itemCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDBDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCategoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgCategory
            // 
            this.dgCategory.AllowUserToAddRows = false;
            this.dgCategory.AllowUserToDeleteRows = false;
            this.dgCategory.AutoGenerateColumns = false;
            this.dgCategory.ColumnHeadersHeight = 30;
            this.dgCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemCodeDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dgCategory.DataSource = this.tblCategoryBindingSource;
            this.dgCategory.Location = new System.Drawing.Point(25, 55);
            this.dgCategory.Name = "dgCategory";
            this.dgCategory.ReadOnly = true;
            this.dgCategory.RowHeadersVisible = false;
            this.dgCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCategory.Size = new System.Drawing.Size(228, 129);
            this.dgCategory.TabIndex = 0;
            // 
            // txtCatCode
            // 
            this.txtCatCode.Location = new System.Drawing.Point(348, 81);
            this.txtCatCode.Name = "txtCatCode";
            this.txtCatCode.Size = new System.Drawing.Size(62, 20);
            this.txtCatCode.TabIndex = 1;
            // 
            // txtCatDesc
            // 
            this.txtCatDesc.Location = new System.Drawing.Point(348, 113);
            this.txtCatDesc.Name = "txtCatDesc";
            this.txtCatDesc.Size = new System.Drawing.Size(100, 20);
            this.txtCatDesc.TabIndex = 2;
            // 
            // pOSDBDataSet4
            // 
            this.pOSDBDataSet4.DataSetName = "POSDBDataSet4";
            this.pOSDBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblCategoryBindingSource
            // 
            this.tblCategoryBindingSource.DataMember = "tblCategory";
            this.tblCategoryBindingSource.DataSource = this.pOSDBDataSet4;
            // 
            // tblCategoryTableAdapter
            // 
            this.tblCategoryTableAdapter.ClearBeforeFill = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(271, 152);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(62, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(338, 152);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(62, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(406, 152);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(62, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Item code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Description";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(271, 152);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(62, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // itemCodeDataGridViewTextBoxColumn
            // 
            this.itemCodeDataGridViewTextBoxColumn.DataPropertyName = "ItemCode";
            this.itemCodeDataGridViewTextBoxColumn.HeaderText = "Item Code";
            this.itemCodeDataGridViewTextBoxColumn.Name = "itemCodeDataGridViewTextBoxColumn";
            this.itemCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemCodeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.itemCodeDataGridViewTextBoxColumn.Width = 75;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.descriptionDataGridViewTextBoxColumn.Width = 150;
            // 
            // frmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 196);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCatDesc);
            this.Controls.Add(this.txtCatCode);
            this.Controls.Add(this.dgCategory);
            this.Controls.Add(this.btnSave);
            this.Name = "frmCategory";
            this.Text = "frmCategory";
            this.Load += new System.EventHandler(this.frmCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDBDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCategoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgCategory;
        private System.Windows.Forms.TextBox txtCatCode;
        private System.Windows.Forms.TextBox txtCatDesc;
        private POSDBDataSet4 pOSDBDataSet4;
        private System.Windows.Forms.BindingSource tblCategoryBindingSource;
        private POSDBDataSet4TableAdapters.tblCategoryTableAdapter tblCategoryTableAdapter;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}