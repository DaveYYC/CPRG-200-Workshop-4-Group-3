using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using Workshop4_DH;

// Coded by: 
namespace cprg200_Workshop
{
    public partial class frmAddNewProductToPackage : Form
    {
        public Package currentPackage;
        List<string> productNameforList = null;
        List<int> packageIDs = null; // list of all package id
        public frmAddNewProductToPackage()
        {
            InitializeComponent();
        }
        private void frmAddNewProductToPackage_Load(object sender, EventArgs e)
        {

            loadComboBox_Package();
            // populate the list of available products in the list
            using (TravelExpertDataContext dataContext = new TravelExpertDataContext())
            {
                productNameforList = (from prod in dataContext.Products
                                      select prod.ProdName).ToList();
                lbxAvailableProducts.DataSource = productNameforList;

            }
        }

        /***************** WORKING ON ADDING PACKAGES INTO the PACKAGE ID *****/
            // add products into the database and save it
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Validator.IsProvided(txtProdSupID, "Prod Supllier ID"))
            {
                try
                {
                 Packages_Products_Supplier newProduct = null;
                    using (TravelExpertDataContext dataContext = new TravelExpertDataContext())
                    {

                        newProduct = new Packages_Products_Supplier
                        {
                            // PackageId = Convert.ToInt32(cboPackageId.SelectedItem),
                            PackageId = currentPackage.PackageId,
                            ProductSupplierId = Convert.ToInt32(txtProdSupID.Text)

                        };// object initializer syntax
                        dataContext.Packages_Products_Suppliers.InsertOnSubmit(newProduct);
                        dataContext.SubmitChanges();
                        MessageBox.Show("Changes have been saved", "Data update");
                    }

                    DialogResult = DialogResult.OK;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(
                        ex.Message,
                        ex.GetType().ToString());
                }
            }
            else // validation failed
            {
                DialogResult = DialogResult.Cancel;
            }
        }

        private void loadComboBox_Package()
        {
            using (TravelExpertDataContext dbContext = new TravelExpertDataContext())
            {
                txtPackageId.Text = currentPackage.PackageId.ToString();             
            }
        }

        private void lbxAvailableSupplier_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            using (TravelExpertDataContext dataContext = new TravelExpertDataContext())
            {
                var y = (from m in dataContext.Products_Suppliers
                         join p in dataContext.Suppliers on m.SupplierId equals p.SupplierId
                         join x in dataContext.Products on m.ProductId equals x.ProductId
                         where p.SupName == lbxAvailableSupplier.SelectedItem.ToString() &&
                         x.ProdName == lbxAvailableProducts.SelectedItem.ToString()
                         select m).ToList();
                foreach (var z in y)
                {
                    txtProdSupID.Text = z.ProductSupplierId.ToString();

                }
            }
        }

        private void lbxAvailableProducts_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            lbxAvailableSupplier.Items.Clear();
            TravelExpertDataContext dataContext = new TravelExpertDataContext();

            var i = lbxAvailableProducts.Items[lbxAvailableProducts.SelectedIndex].ToString();


            var selectedValue = (from m in dataContext.Products_Suppliers
                                 join p in dataContext.Products on m.ProductId equals p.ProductId
                                 join s in dataContext.Suppliers on m.SupplierId equals s.SupplierId
                                 where p.ProdName == i
                                 select s).ToList();

            foreach (var x in selectedValue)
            {
                //lbxAvailableSupplier.Items.Add(x.SupplierId);
                lbxAvailableSupplier.Items.Add(x.SupName);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
