namespace Workshop4_DH
{
    partial class frmAddModifyProducts
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblProdId = new System.Windows.Forms.Label();
            this.lblNewProd = new System.Windows.Forms.Label();
            this.txtProdId = new System.Windows.Forms.TextBox();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LawnGreen;
            this.btnSave.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(528, 77);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 44);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(648, 77);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 44);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblProdId
            // 
            this.lblProdId.AutoSize = true;
            this.lblProdId.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblProdId.Location = new System.Drawing.Point(35, 40);
            this.lblProdId.Name = "lblProdId";
            this.lblProdId.Size = new System.Drawing.Size(113, 20);
            this.lblProdId.TabIndex = 2;
            this.lblProdId.Text = "Product Id:";
            // 
            // lblNewProd
            // 
            this.lblNewProd.AutoSize = true;
            this.lblNewProd.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblNewProd.Location = new System.Drawing.Point(290, 41);
            this.lblNewProd.Name = "lblNewProd";
            this.lblNewProd.Size = new System.Drawing.Size(198, 20);
            this.lblNewProd.TabIndex = 3;
            this.lblNewProd.Text = "Product Description:";
            // 
            // txtProdId
            // 
            this.txtProdId.Location = new System.Drawing.Point(138, 40);
            this.txtProdId.Name = "txtProdId";
            this.txtProdId.ReadOnly = true;
            this.txtProdId.Size = new System.Drawing.Size(131, 26);
            this.txtProdId.TabIndex = 4;
            // 
            // txtProdName
            // 
            this.txtProdName.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdName.Location = new System.Drawing.Point(468, 38);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(275, 26);
            this.txtProdName.TabIndex = 5;
            // 
            // frmAddModifyProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(757, 139);
            this.Controls.Add(this.txtProdName);
            this.Controls.Add(this.txtProdId);
            this.Controls.Add(this.lblNewProd);
            this.Controls.Add(this.lblProdId);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAddModifyProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddModifyProducts";
            this.Load += new System.EventHandler(this.frmAddModifyProducts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblProdId;
        private System.Windows.Forms.Label lblNewProd;
        private System.Windows.Forms.TextBox txtProdId;
        private System.Windows.Forms.TextBox txtProdName;
    }
}