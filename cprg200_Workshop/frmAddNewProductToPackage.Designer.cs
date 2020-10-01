namespace cprg200_Workshop
{
    partial class frmAddNewProductToPackage
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
            System.Windows.Forms.Label packageIdLabel1;
            System.Windows.Forms.Label label1;
            this.lbxAvailableSupplier = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbxAvailableProducts = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtProdSupID = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtPackageId = new System.Windows.Forms.TextBox();
            packageIdLabel1 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // packageIdLabel1
            // 
            packageIdLabel1.AutoSize = true;
            packageIdLabel1.Location = new System.Drawing.Point(48, 74);
            packageIdLabel1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            packageIdLabel1.Name = "packageIdLabel1";
            packageIdLabel1.Size = new System.Drawing.Size(114, 20);
            packageIdLabel1.TabIndex = 29;
            packageIdLabel1.Text = "Package Id:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(380, 74);
            label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(190, 20);
            label1.TabIndex = 33;
            label1.Text = "Product Supplier Id";
            // 
            // lbxAvailableSupplier
            // 
            this.lbxAvailableSupplier.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxAvailableSupplier.FormattingEnabled = true;
            this.lbxAvailableSupplier.ItemHeight = 18;
            this.lbxAvailableSupplier.Location = new System.Drawing.Point(383, 187);
            this.lbxAvailableSupplier.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lbxAvailableSupplier.Name = "lbxAvailableSupplier";
            this.lbxAvailableSupplier.Size = new System.Drawing.Size(296, 202);
            this.lbxAvailableSupplier.TabIndex = 28;
            this.lbxAvailableSupplier.SelectedIndexChanged += new System.EventHandler(this.lbxAvailableSupplier_SelectedIndexChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(380, 159);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Available Suppliers:";
            // 
            // lbxAvailableProducts
            // 
            this.lbxAvailableProducts.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxAvailableProducts.FormattingEnabled = true;
            this.lbxAvailableProducts.ItemHeight = 18;
            this.lbxAvailableProducts.Location = new System.Drawing.Point(51, 187);
            this.lbxAvailableProducts.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lbxAvailableProducts.Name = "lbxAvailableProducts";
            this.lbxAvailableProducts.Size = new System.Drawing.Size(250, 202);
            this.lbxAvailableProducts.TabIndex = 26;
            this.lbxAvailableProducts.SelectedIndexChanged += new System.EventHandler(this.lbxAvailableProducts_SelectedIndexChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Available Products:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LawnGreen;
            this.btnSave.Location = new System.Drawing.Point(479, 411);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 42);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtProdSupID
            // 
            this.txtProdSupID.Location = new System.Drawing.Point(555, 71);
            this.txtProdSupID.Margin = new System.Windows.Forms.Padding(4);
            this.txtProdSupID.Name = "txtProdSupID";
            this.txtProdSupID.ReadOnly = true;
            this.txtProdSupID.Size = new System.Drawing.Size(104, 26);
            this.txtProdSupID.TabIndex = 32;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancel.Location = new System.Drawing.Point(594, 411);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 42);
            this.btnCancel.TabIndex = 34;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtPackageId
            // 
            this.txtPackageId.Enabled = false;
            this.txtPackageId.Location = new System.Drawing.Point(147, 71);
            this.txtPackageId.Name = "txtPackageId";
            this.txtPackageId.ReadOnly = true;
            this.txtPackageId.Size = new System.Drawing.Size(114, 26);
            this.txtPackageId.TabIndex = 35;
            // 
            // frmAddNewProductToPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(712, 479);
            this.Controls.Add(this.txtPackageId);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(label1);
            this.Controls.Add(this.txtProdSupID);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(packageIdLabel1);
            this.Controls.Add(this.lbxAvailableSupplier);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbxAvailableProducts);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAddNewProductToPackage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddNewProductToPackage";
            this.Load += new System.EventHandler(this.frmAddNewProductToPackage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxAvailableSupplier;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbxAvailableProducts;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtProdSupID;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtPackageId;
    }
}