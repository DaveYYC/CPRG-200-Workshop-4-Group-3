using cprg200_Workshop;
using System;
using System.Data.Linq;
using System.Linq;
using System.Windows.Forms;

// coded by: David Hahner
namespace Workshop4_DH
{
    public partial class frmAddModifyProducts : Form
    {
        //public frmProducts mainForm; // link to the main form
        public bool isAdd;              // main form sets it
        public Product currentProduct;  // main form sets it

        public frmAddModifyProducts()
        {
            InitializeComponent();
        }

        private void frmAddModifyProducts_Load(object sender, EventArgs e)
        {
            if (isAdd)
            {
                txtProdId.Enabled = false;
                            }
            else // it is Modify
            {
                DisplayCurrentProduct(); // display data of the current product
                txtProdId.Enabled = false; // code is not updatable
                txtProdId.Focus(); // focus on description
            }
        }
        private void DisplayCurrentProduct()
        {
            txtProdId.Text = currentProduct.ProductId.ToString();
            txtProdName.Text = currentProduct.ProdName;
        }

        private void ClearTextBoxes()
        {
            txtProdId.Text = "";
            txtProdName.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isAdd)
            {
                if (Validator.IsProvided(txtProdName,"Product Name") && Validator.isNotNumeric(txtProdName, "Product Name") &&
                    Validator.IsCorrectLength(txtProdName, 50)  // the number 50 is the # of characters (length)
                    )
                // data validation: all fields provided, code unique, 
                // price and quantity appropriate numeric type and non-negative
                {
                    Product newProduct = new Product // create product using provided data
                    {
                        ProdName = txtProdName.Text,
                    }; // object initializer

                    using (TravelExpertDataContext dbContext = new TravelExpertDataContext())
                    {
                        // insert through data context object from the main form
                        dbContext.Products.InsertOnSubmit(newProduct);
                        dbContext.SubmitChanges(); // submit to the database
                    }
                    DialogResult = DialogResult.OK;
                }
                else // validation  failed
                {
                    DialogResult = DialogResult.Cancel;
                }
            }
            else // it is Modify
            {
                if (Validator.IsProvided(txtProdName, "Product Name") && Validator.isNotNumeric(txtProdName, "Product Name") &&
                    Validator.IsCorrectLength(txtProdName, 50)
                    )
                {
                    try
                    {
                        using (TravelExpertDataContext dbContext = new TravelExpertDataContext())
                        {
                            // get the product with Code from the current text box
                            Product prod = dbContext.Products.Single(p => p.ProductId== Convert.ToInt32(txtProdId.Text));

                            if (prod != null)
                            {
                                // make changes by copying values from text boxes
                                prod.ProdName = txtProdName.Text;  //****check this code***
                                // submit changes 
                                dbContext.SubmitChanges();
                                DialogResult = DialogResult.OK;
                            }
                        }
                    }
                    catch (ChangeConflictException)
                    {
                        MessageBox.Show("Another user changed or deleted the current record", "Concurrency Exception");
                        DialogResult = DialogResult.Retry;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
                else // validation failed
                {
                    DialogResult = DialogResult.Cancel;
                }
            }
        }
    }
 }
    


    

