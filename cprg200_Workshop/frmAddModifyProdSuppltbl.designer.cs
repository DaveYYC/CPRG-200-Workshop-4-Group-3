namespace Workshop_Shell_Project
{
    partial class frmAddModifyProdSuppltbl
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
            System.Windows.Forms.Label productSupplierIdLabel;
            System.Windows.Forms.Label supNameLabel;
            System.Windows.Forms.Label supplierIdLabel;
            System.Windows.Forms.Label prodNameLabel;
            System.Windows.Forms.Label productIdLabel;
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtproductSupplierId = new System.Windows.Forms.TextBox();
            this.supplierIdcomboBox = new System.Windows.Forms.ComboBox();
            this.productIdComboBox = new System.Windows.Forms.ComboBox();
            this.supNameTextBox = new System.Windows.Forms.TextBox();
            this.prodNameTextBox = new System.Windows.Forms.TextBox();
            productSupplierIdLabel = new System.Windows.Forms.Label();
            supNameLabel = new System.Windows.Forms.Label();
            supplierIdLabel = new System.Windows.Forms.Label();
            prodNameLabel = new System.Windows.Forms.Label();
            productIdLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // productSupplierIdLabel
            // 
            productSupplierIdLabel.AutoSize = true;
            productSupplierIdLabel.Location = new System.Drawing.Point(36, 49);
            productSupplierIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            productSupplierIdLabel.Name = "productSupplierIdLabel";
            productSupplierIdLabel.Size = new System.Drawing.Size(196, 20);
            productSupplierIdLabel.TabIndex = 31;
            productSupplierIdLabel.Text = "Product Supplier Id:";
            // 
            // supNameLabel
            // 
            supNameLabel.AutoSize = true;
            supNameLabel.Location = new System.Drawing.Point(466, 119);
            supNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            supNameLabel.Name = "supNameLabel";
            supNameLabel.Size = new System.Drawing.Size(138, 20);
            supNameLabel.TabIndex = 35;
            supNameLabel.Text = "Suplier Name:";
            // 
            // supplierIdLabel
            // 
            supplierIdLabel.AutoSize = true;
            supplierIdLabel.Location = new System.Drawing.Point(36, 122);
            supplierIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            supplierIdLabel.Name = "supplierIdLabel";
            supplierIdLabel.Size = new System.Drawing.Size(119, 20);
            supplierIdLabel.TabIndex = 32;
            supplierIdLabel.Text = "Supplier Id:";
            // 
            // prodNameLabel
            // 
            prodNameLabel.AutoSize = true;
            prodNameLabel.Location = new System.Drawing.Point(466, 82);
            prodNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            prodNameLabel.Name = "prodNameLabel";
            prodNameLabel.Size = new System.Drawing.Size(144, 20);
            prodNameLabel.TabIndex = 33;
            prodNameLabel.Text = "Product Name:";
            // 
            // productIdLabel
            // 
            productIdLabel.AutoSize = true;
            productIdLabel.Location = new System.Drawing.Point(36, 84);
            productIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            productIdLabel.Name = "productIdLabel";
            productIdLabel.Size = new System.Drawing.Size(113, 20);
            productIdLabel.TabIndex = 30;
            productIdLabel.Text = "Product Id:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LawnGreen;
            this.btnSave.Location = new System.Drawing.Point(678, 166);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 42);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancel.Location = new System.Drawing.Point(794, 166);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 42);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtproductSupplierId
            // 
            this.txtproductSupplierId.Enabled = false;
            this.txtproductSupplierId.Location = new System.Drawing.Point(232, 39);
            this.txtproductSupplierId.Margin = new System.Windows.Forms.Padding(4);
            this.txtproductSupplierId.Name = "txtproductSupplierId";
            this.txtproductSupplierId.ReadOnly = true;
            this.txtproductSupplierId.Size = new System.Drawing.Size(148, 26);
            this.txtproductSupplierId.TabIndex = 37;
            // 
            // supplierIdcomboBox
            // 
            this.supplierIdcomboBox.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierIdcomboBox.FormattingEnabled = true;
            this.supplierIdcomboBox.Location = new System.Drawing.Point(232, 119);
            this.supplierIdcomboBox.Margin = new System.Windows.Forms.Padding(4);
            this.supplierIdcomboBox.Name = "supplierIdcomboBox";
            this.supplierIdcomboBox.Size = new System.Drawing.Size(180, 26);
            this.supplierIdcomboBox.TabIndex = 39;
            this.supplierIdcomboBox.SelectedIndexChanged += new System.EventHandler(this.supplierIdcomboBox_SelectedIndexChanged);
            // 
            // productIdComboBox
            // 
            this.productIdComboBox.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productIdComboBox.FormattingEnabled = true;
            this.productIdComboBox.Location = new System.Drawing.Point(232, 79);
            this.productIdComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.productIdComboBox.Name = "productIdComboBox";
            this.productIdComboBox.Size = new System.Drawing.Size(180, 26);
            this.productIdComboBox.TabIndex = 38;
            this.productIdComboBox.SelectedIndexChanged += new System.EventHandler(this.productIdComboBox_SelectedIndexChanged);
            // 
            // supNameTextBox
            // 
            this.supNameTextBox.Enabled = false;
            this.supNameTextBox.Location = new System.Drawing.Point(590, 116);
            this.supNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.supNameTextBox.Name = "supNameTextBox";
            this.supNameTextBox.ReadOnly = true;
            this.supNameTextBox.Size = new System.Drawing.Size(271, 26);
            this.supNameTextBox.TabIndex = 36;
            // 
            // prodNameTextBox
            // 
            this.prodNameTextBox.Enabled = false;
            this.prodNameTextBox.Location = new System.Drawing.Point(590, 81);
            this.prodNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.prodNameTextBox.Name = "prodNameTextBox";
            this.prodNameTextBox.ReadOnly = true;
            this.prodNameTextBox.Size = new System.Drawing.Size(194, 26);
            this.prodNameTextBox.TabIndex = 34;
            // 
            // frmAddModifyProdSuppltbl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(920, 227);
            this.Controls.Add(this.txtproductSupplierId);
            this.Controls.Add(this.supplierIdcomboBox);
            this.Controls.Add(this.productIdComboBox);
            this.Controls.Add(productSupplierIdLabel);
            this.Controls.Add(supNameLabel);
            this.Controls.Add(this.supNameTextBox);
            this.Controls.Add(supplierIdLabel);
            this.Controls.Add(prodNameLabel);
            this.Controls.Add(this.prodNameTextBox);
            this.Controls.Add(productIdLabel);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAddModifyProdSuppltbl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddModifyProdSuppltbl";
            this.Load += new System.EventHandler(this.frmAddModifyProdSuppltbl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtproductSupplierId;
        private System.Windows.Forms.ComboBox supplierIdcomboBox;
        private System.Windows.Forms.ComboBox productIdComboBox;
        private System.Windows.Forms.TextBox supNameTextBox;
        private System.Windows.Forms.TextBox prodNameTextBox;
    }
}