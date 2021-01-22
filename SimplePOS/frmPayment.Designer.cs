namespace SimplePOS
{
    partial class frmPayment
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
            this.txtTotalAmt = new System.Windows.Forms.TextBox();
            this.txtCash = new System.Windows.Forms.TextBox();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTotalAmt
            // 
            this.txtTotalAmt.Location = new System.Drawing.Point(181, 52);
            this.txtTotalAmt.Name = "txtTotalAmt";
            this.txtTotalAmt.Size = new System.Drawing.Size(100, 20);
            this.txtTotalAmt.TabIndex = 0;
            // 
            // txtCash
            // 
            this.txtCash.Location = new System.Drawing.Point(181, 90);
            this.txtCash.Name = "txtCash";
            this.txtCash.Size = new System.Drawing.Size(100, 20);
            this.txtCash.TabIndex = 1;
            this.txtCash.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCash_KeyUp);
            // 
            // txtChange
            // 
            this.txtChange.Location = new System.Drawing.Point(181, 126);
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(100, 20);
            this.txtChange.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSubmit.Location = new System.Drawing.Point(181, 177);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 305);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.txtCash);
            this.Controls.Add(this.txtTotalAmt);
            this.Name = "frmPayment";
            this.Text = "frmPayment";
            this.Load += new System.EventHandler(this.frmPayment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTotalAmt;
        private System.Windows.Forms.TextBox txtCash;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.Button btnSubmit;
    }
}