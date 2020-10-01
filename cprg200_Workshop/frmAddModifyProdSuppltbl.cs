using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using cprg200_Workshop;

namespace Workshop_Shell_Project
{
    public partial class frmAddModifyProdSuppltbl : Form
    {
        public bool isModify;
        List<int> productIdList = null;
        List<int> supplierIdList = null;

        public Products_Supplier activeProdSuppId;

        public frmAddModifyProdSuppltbl()
        {
            InitializeComponent();
        }

        private void frmAddModifyProdSuppltbl_Load(object sender, EventArgs e)
        {

            using (TravelExpertDataContext dataContext = new TravelExpertDataContext())
            {
                productIdList = (from m in dataContext.Products
                                 select m.ProductId).ToList();
                productIdComboBox.DataSource = productIdList;
                productIdComboBox.Text = "Select Product ID";

                supplierIdList = (from m in dataContext.Suppliers
                                  select m.SupplierId).ToList();
                supplierIdcomboBox.DataSource = supplierIdList;
                supplierIdcomboBox.Text = "Select Supplier ID";
            }

            if (isModify)
            {
                txtproductSupplierId.Text = activeProdSuppId.ProductSupplierId.ToString();
                productIdComboBox.Text = activeProdSuppId.ProductId.ToString();
                supplierIdcomboBox.Text = activeProdSuppId.SupplierId.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
            using (TravelExpertDataContext dataContext = new TravelExpertDataContext())
                {
                    Products_Supplier prodSupplier = null;
                    if (isModify)// MODIFY ITEM
                    {
                        prodSupplier = (from m in dataContext.Products_Suppliers
                                        where m.ProductSupplierId == Convert.ToInt32(txtproductSupplierId.Text)
                                        select m).Single();
                        prodSupplier.ProductId = Convert.ToInt32(productIdComboBox.SelectedItem);
                        prodSupplier.SupplierId = Convert.ToInt32(supplierIdcomboBox.SelectedItem);
                    }
                    else // ADD NEW ITEM
                    {
                        prodSupplier = new Products_Supplier
                        {
                            ProductId = Convert.ToInt32(productIdComboBox.SelectedItem),
                            SupplierId = Convert.ToInt32(supplierIdcomboBox.SelectedItem)

                        };// object initializer syntax
                        dataContext.Products_Suppliers.InsertOnSubmit(prodSupplier);
                    }

                    dataContext.SubmitChanges();
                    MessageBox.Show("Changes have been saved", "Data update");
                    DialogResult = DialogResult.OK;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
             
            }
        }
              
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void productIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (TravelExpertDataContext dataContext = new TravelExpertDataContext())
            {
                var selectedValue = (from m in dataContext.Products
                                     where m.ProductId == Convert.ToInt32(productIdComboBox.SelectedValue)
                                     select m).Single();

                prodNameTextBox.Text = selectedValue.ProdName;
            }
        }

        private void supplierIdcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (TravelExpertDataContext dataContext = new TravelExpertDataContext())
            {
                var selectedValue = (from m in dataContext.Suppliers
                                     where m.SupplierId == Convert.ToInt32(supplierIdcomboBox.SelectedValue)
                                     select m).Single();

                supNameTextBox.Text = selectedValue.SupName;
            }
        }
    }
}






