namespace SimplePOS
{
    partial class FrmPosition
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
            this.dgPosition = new System.Windows.Forms.DataGridView();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPositionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOSDBDataSet3 = new SimplePOS.POSDBDataSet3();
            this.txtPosNo = new System.Windows.Forms.TextBox();
            this.txtPosDesc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tblPositionTableAdapter = new SimplePOS.POSDBDataSet3TableAdapters.tblPositionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPositionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDBDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPosition
            // 
            this.dgPosition.AllowUserToAddRows = false;
            this.dgPosition.AllowUserToDeleteRows = false;
            this.dgPosition.AllowUserToResizeColumns = false;
            this.dgPosition.AllowUserToResizeRows = false;
            this.dgPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgPosition.AutoGenerateColumns = false;
            this.dgPosition.ColumnHeadersHeight = 30;
            this.dgPosition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgPosition.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dgPosition.DataSource = this.tblPositionBindingSource;
            this.dgPosition.Location = new System.Drawing.Point(12, 69);
            this.dgPosition.MultiSelect = false;
            this.dgPosition.Name = "dgPosition";
            this.dgPosition.ReadOnly = true;
            this.dgPosition.RowHeadersVisible = false;
            this.dgPosition.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPosition.Size = new System.Drawing.Size(202, 152);
            this.dgPosition.TabIndex = 0;
            this.dgPosition.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgPosition_CellClick);
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "No";
            this.numberDataGridViewTextBoxColumn.MaxInputLength = 2;
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.Width = 50;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 150;
            // 
            // tblPositionBindingSource
            // 
            this.tblPositionBindingSource.DataMember = "tblPosition";
            this.tblPositionBindingSource.DataSource = this.pOSDBDataSet3;
            // 
            // pOSDBDataSet3
            // 
            this.pOSDBDataSet3.DataSetName = "POSDBDataSet3";
            this.pOSDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtPosNo
            // 
            this.txtPosNo.Location = new System.Drawing.Point(309, 93);
            this.txtPosNo.Name = "txtPosNo";
            this.txtPosNo.Size = new System.Drawing.Size(53, 20);
            this.txtPosNo.TabIndex = 1;
            // 
            // txtPosDesc
            // 
            this.txtPosDesc.Location = new System.Drawing.Point(309, 119);
            this.txtPosDesc.Name = "txtPosDesc";
            this.txtPosDesc.Size = new System.Drawing.Size(144, 20);
            this.txtPosDesc.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Position No. :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Description :";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(236, 159);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(60, 25);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(302, 159);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(60, 25);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(368, 159);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(60, 25);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(434, 159);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(60, 25);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(235, 159);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(60, 25);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // tblPositionTableAdapter
            // 
            this.tblPositionTableAdapter.ClearBeforeFill = true;
            // 
            // frmPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 233);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPosDesc);
            this.Controls.Add(this.txtPosNo);
            this.Controls.Add(this.dgPosition);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmPosition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmPosition_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPositionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDBDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPosition;
        private System.Windows.Forms.TextBox txtPosNo;
        private System.Windows.Forms.TextBox txtPosDesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private POSDBDataSet3 pOSDBDataSet3;
        private System.Windows.Forms.BindingSource tblPositionBindingSource;
        private POSDBDataSet3TableAdapters.tblPositionTableAdapter tblPositionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}