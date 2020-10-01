namespace cprg200_Workshop
{
    partial class frmModifyPackage
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            this.txtPkgAgencyCommission = new System.Windows.Forms.TextBox();
            this.txtPkgBasePrice = new System.Windows.Forms.TextBox();
            this.txtPkgDesc = new System.Windows.Forms.TextBox();
            this.pkgEndDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txtPkgName = new System.Windows.Forms.TextBox();
            this.pkgStartDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnSaveMod = new System.Windows.Forms.Button();
            this.txtPackageId = new System.Windows.Forms.TextBox();
            this.errorName = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnExit4 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorName)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Georgia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(29, 35);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(125, 23);
            label1.TabIndex = 39;
            label1.Text = "Package Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Georgia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(29, 287);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(218, 23);
            label2.TabIndex = 33;
            label2.Text = "Agency Commission:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Georgia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(29, 200);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(120, 23);
            label3.TabIndex = 34;
            label3.Text = "Base Price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Georgia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(29, 242);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(133, 23);
            label4.TabIndex = 35;
            label4.Text = "Description:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Georgia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(29, 160);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(108, 23);
            label5.TabIndex = 36;
            label5.Text = "End Date:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Georgia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(29, 73);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(162, 23);
            label6.TabIndex = 37;
            label6.Text = "Package Name:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Georgia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.Location = new System.Drawing.Point(29, 117);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(119, 23);
            label7.TabIndex = 38;
            label7.Text = "Start Date:";
            // 
            // txtPkgAgencyCommission
            // 
            this.txtPkgAgencyCommission.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPkgAgencyCommission.Location = new System.Drawing.Point(232, 282);
            this.txtPkgAgencyCommission.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtPkgAgencyCommission.Name = "txtPkgAgencyCommission";
            this.txtPkgAgencyCommission.Size = new System.Drawing.Size(192, 27);
            this.txtPkgAgencyCommission.TabIndex = 16;
            // 
            // txtPkgBasePrice
            // 
            this.txtPkgBasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPkgBasePrice.Location = new System.Drawing.Point(232, 198);
            this.txtPkgBasePrice.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtPkgBasePrice.Name = "txtPkgBasePrice";
            this.txtPkgBasePrice.Size = new System.Drawing.Size(192, 27);
            this.txtPkgBasePrice.TabIndex = 18;
            // 
            // txtPkgDesc
            // 
            this.txtPkgDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPkgDesc.Location = new System.Drawing.Point(229, 240);
            this.txtPkgDesc.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtPkgDesc.Name = "txtPkgDesc";
            this.txtPkgDesc.Size = new System.Drawing.Size(413, 27);
            this.txtPkgDesc.TabIndex = 20;
            // 
            // pkgEndDateDateTimePicker
            // 
            this.pkgEndDateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pkgEndDateDateTimePicker.Location = new System.Drawing.Point(232, 156);
            this.pkgEndDateDateTimePicker.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pkgEndDateDateTimePicker.Name = "pkgEndDateDateTimePicker";
            this.pkgEndDateDateTimePicker.Size = new System.Drawing.Size(180, 27);
            this.pkgEndDateDateTimePicker.TabIndex = 22;
            // 
            // txtPkgName
            // 
            this.txtPkgName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPkgName.Location = new System.Drawing.Point(229, 68);
            this.txtPkgName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtPkgName.Name = "txtPkgName";
            this.txtPkgName.Size = new System.Drawing.Size(413, 27);
            this.txtPkgName.TabIndex = 24;
            // 
            // pkgStartDateDateTimePicker
            // 
            this.pkgStartDateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pkgStartDateDateTimePicker.Location = new System.Drawing.Point(232, 112);
            this.pkgStartDateDateTimePicker.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pkgStartDateDateTimePicker.Name = "pkgStartDateDateTimePicker";
            this.pkgStartDateDateTimePicker.Size = new System.Drawing.Size(180, 27);
            this.pkgStartDateDateTimePicker.TabIndex = 27;
            // 
            // btnSaveMod
            // 
            this.btnSaveMod.BackColor = System.Drawing.Color.LawnGreen;
            this.btnSaveMod.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSaveMod.Location = new System.Drawing.Point(409, 352);
            this.btnSaveMod.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnSaveMod.Name = "btnSaveMod";
            this.btnSaveMod.Size = new System.Drawing.Size(107, 50);
            this.btnSaveMod.TabIndex = 30;
            this.btnSaveMod.Text = "&Save";
            this.btnSaveMod.UseVisualStyleBackColor = false;
            this.btnSaveMod.Click += new System.EventHandler(this.btnSaveMod_Click);
            // 
            // txtPackageId
            // 
            this.txtPackageId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPackageId.Location = new System.Drawing.Point(229, 33);
            this.txtPackageId.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtPackageId.Name = "txtPackageId";
            this.txtPackageId.Size = new System.Drawing.Size(155, 27);
            this.txtPackageId.TabIndex = 31;
            // 
            // errorName
            // 
            this.errorName.ContainerControl = this;
            // 
            // btnExit4
            // 
            this.btnExit4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExit4.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnExit4.Location = new System.Drawing.Point(539, 352);
            this.btnExit4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnExit4.Name = "btnExit4";
            this.btnExit4.Size = new System.Drawing.Size(103, 50);
            this.btnExit4.TabIndex = 32;
            this.btnExit4.Text = "&Cancel";
            this.btnExit4.UseVisualStyleBackColor = false;
            this.btnExit4.Click += new System.EventHandler(this.btnExit4_Click);
            // 
            // frmModifyPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(676, 428);
            this.Controls.Add(label1);
            this.Controls.Add(label2);
            this.Controls.Add(label3);
            this.Controls.Add(label4);
            this.Controls.Add(label5);
            this.Controls.Add(label6);
            this.Controls.Add(label7);
            this.Controls.Add(this.btnExit4);
            this.Controls.Add(this.txtPackageId);
            this.Controls.Add(this.btnSaveMod);
            this.Controls.Add(this.txtPkgAgencyCommission);
            this.Controls.Add(this.txtPkgBasePrice);
            this.Controls.Add(this.txtPkgDesc);
            this.Controls.Add(this.pkgEndDateDateTimePicker);
            this.Controls.Add(this.txtPkgName);
            this.Controls.Add(this.pkgStartDateDateTimePicker);
            this.Font = new System.Drawing.Font("Georgia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "frmModifyPackage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmModifyPackage";
            this.Load += new System.EventHandler(this.frmModifyPackage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPkgAgencyCommission;
        private System.Windows.Forms.TextBox txtPkgBasePrice;
        private System.Windows.Forms.TextBox txtPkgDesc;
        private System.Windows.Forms.DateTimePicker pkgEndDateDateTimePicker;
        private System.Windows.Forms.TextBox txtPkgName;
        private System.Windows.Forms.DateTimePicker pkgStartDateDateTimePicker;
        private System.Windows.Forms.Button btnSaveMod;
        private System.Windows.Forms.TextBox txtPackageId;
        private System.Windows.Forms.ErrorProvider errorName;
        private System.Windows.Forms.Button btnExit4;
    }
}