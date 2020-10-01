namespace cprg200_Workshop
{
    partial class StartPage
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
            this.btnPackageTab = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPackageTab
            // 
            this.btnPackageTab.BackColor = System.Drawing.Color.Lime;
            this.btnPackageTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPackageTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPackageTab.Location = new System.Drawing.Point(686, 707);
            this.btnPackageTab.Name = "btnPackageTab";
            this.btnPackageTab.Size = new System.Drawing.Size(294, 65);
            this.btnPackageTab.TabIndex = 1;
            this.btnPackageTab.Text = "&ENTER";
            this.btnPackageTab.UseVisualStyleBackColor = false;
            this.btnPackageTab.Click += new System.EventHandler(this.btnPackageTab_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::cprg200_Workshop.Properties.Resources.logo_wht_bg;
            this.pictureBox1.Location = new System.Drawing.Point(14, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1840, 578);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatabase.Location = new System.Drawing.Point(1140, 209);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(373, 46);
            this.lblDatabase.TabIndex = 10;
            this.lblDatabase.Text = "Database Manager";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1261, 707);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(294, 65);
            this.button1.TabIndex = 11;
            this.button1.Text = "&EXIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1866, 1091);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblDatabase);
            this.Controls.Add(this.btnPackageTab);
            this.Controls.Add(this.pictureBox1);
            this.Name = "StartPage";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPackageTab;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.Button button1;
    }
}