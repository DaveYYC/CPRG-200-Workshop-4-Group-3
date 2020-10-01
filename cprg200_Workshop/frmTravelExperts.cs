using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Workshop_Shell_Project;
using Workshop4_DH;

/* Group 3 collaborated on the frmTravelExperts layout using tabs */
// Each group member added the applicable code here for their repective form(s).

// code written by: 
namespace cprg200_Workshop
{
    public partial class btnSaveProducts : Form
    {
        List<int> supplierIDs = null; // all members IDs
        List<int> packageIDs = null; // list of all package id
        List<string> productNames = new List<string>(); // list of all productNames

        public Products_Supplier activeSupplier;
        List<int> productSupIds = null;

        public btnSaveProducts()
        {
            InitializeComponent();
            tabControl1.SelectedIndex = 0;
        }

        // populate combo box as the form loads
        private void Form1_Load(object sender, EventArgs e)
        {
            loadComboBox_Package();
            loadComboBox_Supplier();
          
            using (TravelExpertDataContext dataContext = new TravelExpertDataContext())
            {
                productSupIds = (from m in dataContext.Products_Suppliers
                                 select m.ProductSupplierId).ToList();
                productSupplierIdComboBox.DataSource = productSupIds;
                productSupplierIdComboBox.SelectedIndex = 0;
            }

            using (TravelExpertDataContext dbContext = new TravelExpertDataContext())
            {
                productDataGridView.DataSource = from prod in dbContext.Products
                                                 orderby prod.ProdName
                                                 select prod;
            }
            {
                RefreshGridView();
            }
        }

        // load combo box for Package Tab
        private void loadComboBox_Package()
        {
            using (TravelExpertDataContext dbContext = new TravelExpertDataContext())
            {
                packageIDs = (from pack in dbContext.Packages
                              select pack.PackageId).ToList();
                cboPackageId.DataSource = packageIDs;
                cboPackageId.SelectedIndex = 0;
            }
        }

        //load package form fields when selected id is changed
        private void cboPackageId_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstCurrentProducts.Items.Clear();
            int selectedID = Convert.ToInt32(cboPackageId.SelectedValue);
            TravelExpertDataContext dbContext = new TravelExpertDataContext();

            // retrieve data from Packages table
            var selectedPackage = (from pack in dbContext.Packages
                                   where pack.PackageId == selectedID
                                   select pack).Single();

            if (selectedPackage != null)
            {
                txtPkgName.Text = selectedPackage.PkgName;
                pkgStartDateDateTimePicker.Value = Convert.ToDateTime(selectedPackage.PkgStartDate);
                pkgEndDateDateTimePicker.Value = Convert.ToDateTime(selectedPackage.PkgEndDate);
                txtPkgDesc.Text = selectedPackage.PkgDesc;
                txtPkgBasePrice.Text = Convert.ToDouble(selectedPackage.PkgBasePrice).ToString("c");
                txtPkgAgencyCommission.Text = Convert.ToDouble(selectedPackage.PkgAgencyCommission).ToString("c");

                //retrieve data from Packages_Products_Supplier
                var selectedPackProdSup = (from p in dbContext.Packages_Products_Suppliers
                                           where p.PackageId == selectedID
                                           select p).ToList();
                // cboPPS.DataSource = selectedPackProdSup;

                foreach (var x in selectedPackProdSup)
                {
                    var pId = (from p in dbContext.Products_Suppliers
                               where p.ProductSupplierId == x.ProductSupplierId
                               select p).Single();

                    var selectedProd = (from p in dbContext.Products
                                        where p.ProductId == pId.ProductId
                                        select p.ProdName).Single();

                    lstCurrentProducts.Items.Add(selectedProd);
                }
            }
            else
            {
                loadComboBox_Package();
            }
        }

        // load combo box for Supplier Tab
        private void loadComboBox_Supplier()
        {
            using (TravelExpertDataContext dbContext = new TravelExpertDataContext())
            {
                supplierIDs = (from sup in dbContext.Suppliers
                               select sup.SupplierId).ToList();
                cboSupplierId.DataSource = supplierIDs;
                cboSupplierId.SelectedIndex = 0;
            }
        }

        //load Supplier form fields when selected id is changed
        private void cboSupplierId_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int selectedID = Convert.ToInt32(cboSupplierId.SelectedValue);
                {
                    using (TravelExpertDataContext dbContext = new TravelExpertDataContext())
                    {
                        var selected = (from sup in dbContext.Suppliers
                                        where sup.SupplierId == selectedID
                                        select sup).Single();
                        if (selected != null)
                        {
                            txtSupName.Text = selected.SupName;
                        }
                        else
                        {
                            loadComboBox_Supplier();
                        }
                    }

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error while retrieving member with selected ID: " + ex.Message,
                        ex.GetType().ToString());
            }
        }

        //When user clicks add button in Supplier Tab
        
        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            
            frmAddEditSupplier secondFormSupplier = new frmAddEditSupplier();
            secondFormSupplier.isAdd = true;
            secondFormSupplier.currentSupplier = null;
            DialogResult result = secondFormSupplier.ShowDialog(); // display second form modal
            if (result == DialogResult.OK) // new row got inserted
            {
                loadComboBox_Supplier();
            }
        }
        
        //When user clicks edit button in Supplier Tab
        private void btnEditSupplier_Click(object sender, EventArgs e)
        {
            //get the current supplier id to pass on to 2nd form
            this.tabControl1.SelectedTab = tabSupplier;
            int sup_id = Convert.ToInt32(cboSupplierId.SelectedValue);

            using (TravelExpertDataContext dbContext = new TravelExpertDataContext())
            {
                Supplier currentSup = (from sup in dbContext.Suppliers
                                       where sup.SupplierId == sup_id
                                       select sup).Single();

                frmAddEditSupplier secondformSupplier = new frmAddEditSupplier();
                secondformSupplier.isAdd = false;
                secondformSupplier.currentSupplier = currentSup;

                DialogResult result = secondformSupplier.ShowDialog(); // display second form modal
                if (result == DialogResult.OK || result == DialogResult.Retry) // successful update or concurrency exception
                {
                    loadComboBox_Supplier();
                }
            }
        }
        
        private void btnDeleteSupplier_Click(object sender, EventArgs e)
        {
            // get the key of the current product 
            int sup_id = Convert.ToInt32(cboSupplierId.SelectedValue);
            DialogResult answer = MessageBox.Show("Are you sure you want to delete Supplier Id: " + sup_id + "?", "Confirm", MessageBoxButtons.OKCancel);
            if (answer == DialogResult.OK)
            {
                try
                {
                    using (TravelExpertDataContext dbContext = new TravelExpertDataContext())
                    {
                        Supplier currentSup = (from sup in dbContext.Suppliers
                                               where sup.SupplierId == sup_id
                                               select sup).Single();

                        dbContext.Suppliers.DeleteOnSubmit(currentSup);
                        dbContext.SubmitChanges();
                        loadComboBox_Supplier();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       //*************************************** Product Tab ********************************************
       // code written by David Hahner
        private void tabProducts_Click(object sender, EventArgs e)
        {
            using (TravelExpertDataContext dbContext = new TravelExpertDataContext())
            {
                productDataGridView.DataSource = from prod in dbContext.Products
                                                 orderby prod.ProdName
                                                 select prod;
            }
            {
                RefreshGridView();
            }
        }

        private void RefreshGridView()
        {
            TravelExpertDataContext dbContext = new TravelExpertDataContext();
            productDataGridView.DataSource = dbContext.Products;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddModifyProducts secondForm = new frmAddModifyProducts();
            secondForm.isAdd = true;
            secondForm.currentProduct = null; // no current product when inserting
            DialogResult result = secondForm.ShowDialog(); // display second form modal
            if (result == DialogResult.OK) // new row got inserted
            {
                RefreshGridView();
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            // get the key of the current product in the data grid view
            int rowNum = productDataGridView.CurrentCell.RowIndex; // index of the current row
            string productId = productDataGridView["productIdDataGridViewTextBoxColumn", rowNum].Value.ToString(); // Column for ProductCode

            Product currentProduct;
            using (TravelExpertDataContext dbContext = new TravelExpertDataContext())
            {
                currentProduct = (from p in dbContext.Products // this is a query in the brackets
                                  where p.ProductId == Convert.ToInt32(productId)
                                  select p).SingleOrDefault(); // or Singleordefault, if no product for the code
            }

            frmAddModifyProducts secondForm = new frmAddModifyProducts();
            secondForm.isAdd = false; // it Modify
            secondForm.currentProduct = currentProduct;
            DialogResult result = secondForm.ShowDialog(); // display second form modal
            if (result == DialogResult.OK || result == DialogResult.Retry) // successful update or concurrency exception
            {
                RefreshGridView();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // get the key of the current product in the data grid view
            int rowNum = productDataGridView.CurrentCell.RowIndex; // index of the current row
            string productId = productDataGridView["productIdDataGridViewTextBoxColumn", rowNum].Value.ToString(); // Column for ProductId

            DialogResult answer = MessageBox.Show("Are you sure you want to delete product Id " + productId + "?", "Confirm", MessageBoxButtons.OKCancel);
            if (answer == DialogResult.OK)
            {
                using (TravelExpertDataContext dbContext = new TravelExpertDataContext())
                {
                    try
                    {
                        Product currentProduct = (from p in dbContext.Products
                                                  where p.ProductId == Convert.ToInt32(productId)
                                                  select p).SingleOrDefault();

                        dbContext.Products.DeleteOnSubmit(currentProduct);
                        dbContext.SubmitChanges();
                        RefreshGridView();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
            }
        }

        private void btnExit2_Click(object sender, EventArgs e)
        {
            Close();
        }
        // ******************************** Product Supplier Tab ***************************************************
        // code written by:
        private void productSupplierIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TravelExpertDataContext dataContext = new TravelExpertDataContext();


            var selectedValue = (from m in dataContext.Products_Suppliers
                                 where m.ProductSupplierId == Convert.ToInt32(productSupplierIdComboBox.SelectedValue)
                                 select m).Single();

            productIdTextBox.Text = selectedValue.ProductId.ToString();

            supplierIdTextBox.Text = selectedValue.SupplierId.ToString();

            var productName = (from m in dataContext.Products
                               where m.ProductId == Convert.ToInt32(selectedValue.ProductId)
                               select m).Single();
            prodNameTextBox.Text = productName.ProdName;

            var supplierName = (from m in dataContext.Suppliers
                                where m.SupplierId == Convert.ToInt32(selectedValue.SupplierId)
                                select m).Single();
            supNameTextBox.Text = supplierName.SupName;
        }

        private void btnAddProdSup_Click(object sender, EventArgs e)
        {
            frmAddModifyProdSuppltbl secondform = new frmAddModifyProdSuppltbl();
            DialogResult result = secondform.ShowDialog();
            using (TravelExpertDataContext dataContext = new TravelExpertDataContext()) // refresh the grid
            {
                if (result == DialogResult.OK)
                {
                    productSupIds = (from m in dataContext.Products_Suppliers
                                     select m.ProductSupplierId).ToList();
                    productSupplierIdComboBox.DataSource = productSupIds;
                }
            }
        }

        private void btnModProdSup_Click(object sender, EventArgs e)
        {
            frmAddModifyProdSuppltbl secondform = new frmAddModifyProdSuppltbl();
            secondform.isModify = true;
            int prodId = Convert.ToInt32(productIdTextBox.Text);
            int supplId = Convert.ToInt32(supplierIdTextBox.Text);
            using (TravelExpertDataContext dataContext = new TravelExpertDataContext())
            {
                secondform.activeProdSuppId = (from m in dataContext.Products_Suppliers
                                               where m.ProductId == prodId && m.SupplierId == supplId
                                               select m).Single();
            }
            DialogResult result = secondform.ShowDialog();

            using (TravelExpertDataContext dataContext = new TravelExpertDataContext()) // refresh the grid
            {
                if (result == DialogResult.OK)
                {
                    productSupIds = (from m in dataContext.Products_Suppliers
                                     select m.ProductSupplierId).ToList();
                    productSupplierIdComboBox.DataSource = productSupIds;

                }

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeleteProductSup_Click(object sender, EventArgs e)
        {
            TravelExpertDataContext dbContext = new TravelExpertDataContext();
            int sup_id = Convert.ToInt32(productSupplierIdComboBox.SelectedItem);
            DialogResult answer = MessageBox.Show("Are you sure you want to delete Supplier Id: " + sup_id + "?", "Confirm", MessageBoxButtons.OKCancel); 
            if (answer == DialogResult.OK)
            {
                using (TravelExpertDataContext dataContext = new TravelExpertDataContext())
                {
                    try
                    {
                        Products_Supplier selectedValue = (from m in dataContext.Products_Suppliers
                                                           where m.ProductSupplierId == sup_id
                                                           select m).Single();

                        dataContext.Products_Suppliers.DeleteOnSubmit(selectedValue);
                        dataContext.SubmitChanges();
                       
                        productSupIds = (from m in dataContext.Products_Suppliers
                                         select m.ProductSupplierId).ToList();
                        productSupplierIdComboBox.DataSource = productSupIds;                       
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
            }
        }

        /******* Attempt to separate the main window ability to add new product to database****/

        private void btnNewProducts_Click(object sender, EventArgs e)
        {
            int pack_id = Convert.ToInt32(cboPackageId.SelectedValue);

            using (TravelExpertDataContext dbContext = new TravelExpertDataContext())
            {
                Package currentPack = (from pack in dbContext.Packages
                                       where pack.PackageId == pack_id
                                       select pack).Single();

                frmAddNewProductToPackage secondform = new frmAddNewProductToPackage();

                secondform.currentPackage = currentPack;


                DialogResult result = secondform.ShowDialog();

                if (result == DialogResult.OK)// successful Add
                {
                    packageIDs = (from pack in dbContext.Packages
                                  select pack.PackageId).ToList();
                    cboPackageId.DataSource = packageIDs;
                    cboPackageId.SelectedIndex = 0;   // refresh grid
                }
            }

        }
        // When user clicks add button on Travel Package tab
        private void btnAddPackage_Click(object sender, EventArgs e)
        {
            frmAddPackage secondFormAddPackage = new frmAddPackage();
            secondFormAddPackage.isAdd = true;
            secondFormAddPackage.currentPackage = null;
            DialogResult result = secondFormAddPackage.ShowDialog(); // display second form modal
            if (result == DialogResult.OK) // new row got inserted
            {
                loadComboBox_Package();
            }
        }
        // when user clicks modify button on Travel Package tab
        private void btnModPackage_Click(object sender, EventArgs e)
        {
            int pkgId = Convert.ToInt32(cboPackageId.SelectedValue);
            using (TravelExpertDataContext dbContext = new TravelExpertDataContext())
            {
                Package currentPackage = (from p in dbContext.Packages
                                          where p.PackageId == pkgId
                                          select p).Single();

                frmModifyPackage secondFormModifyPackage = new frmModifyPackage();
                secondFormModifyPackage.isAdd = false;
                secondFormModifyPackage.currentPackage = currentPackage;
                DialogResult result = secondFormModifyPackage.ShowDialog(); // display second form modal
                if (result == DialogResult.OK) // new row got inserted
                {
                    loadComboBox_Package();
                }
            }
        }

        private void btnExitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tabProductSupplier_Click(object sender, EventArgs e)
        {
        }
    }
}
