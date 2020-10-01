using System;
using System.Data;
using System.Data.Linq;
using System.Linq;
using System.Windows.Forms;
using Workshop4_DH;

namespace cprg200_Workshop
{
    public partial class frmAddEditSupplier : Form
    {
        public bool isAdd; //main form sets it
        public Supplier currentSupplier;  // main form sets it
        public frmAddEditSupplier()
        {
            InitializeComponent();
        }

        private void frmAddEditSupplier_Load(object sender, EventArgs e)
        {
            if(isAdd)
            {
                txtSupplierId.Enabled = true;
                txtSupplierId.Focus();
            }
            else // it is Modify
            {
                DisplayCurrentSupplier(); // display data of the current supplier
                txtSupplierId.Enabled = false; // code is not updatable
                txtSupName.Focus(); // focus on supplier name
            }
        }

        private void DisplayCurrentSupplier()
        {
            // display current Supplier info
            txtSupplierId.Text = (currentSupplier.SupplierId).ToString();
            txtSupName.Text = currentSupplier.SupName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (isAdd) // it is add
            {
                if (Validator.IsProvided(txtSupplierId, "Supplier Id") &&
                    Validator.IsInt32(txtSupplierId) &&
                    Validator.IsProvided(txtSupName, "Supplier Name") && Validator.isNotNumeric(txtSupName, "Supplier Name") &&
                    Validator.IsCorrectLength(txtSupName, 50))
                {

                    // create a supplier by taking data from form inputs
                    Supplier newSupplier = new Supplier
                    {
                        SupplierId = Convert.ToInt32(txtSupplierId.Text),
                        SupName = txtSupName.Text
                    };
                    //save to database
                    using (TravelExpertDataContext dbContext = new TravelExpertDataContext())
                    {
                        dbContext.Suppliers.InsertOnSubmit(newSupplier);
                        dbContext.SubmitChanges(); //submit to database
                        MessageBox.Show("Changes have been saved", "Data update");
                    }

                    DialogResult = DialogResult.OK;
                }
                else // validation  failed
                {
                    DialogResult = DialogResult.Cancel;
                }
            }
            else // it is modify
            {
                if (Validator.IsProvided(txtSupName, "Supplier Name") && Validator.isNotNumeric(txtSupName, "Supplier Name") &&
                    Validator.IsCorrectLength(txtSupName, 50))
                {
                    try
                    {
                        using (TravelExpertDataContext dbContext = new TravelExpertDataContext())
                        {
                            Supplier supplierFromDb = (from sup in dbContext.Suppliers
                                                       where sup.SupplierId == currentSupplier.SupplierId
                                                       select sup).Single();

                            if (supplierFromDb != null)
                            {
                                supplierFromDb.SupName = txtSupName.Text;
                                //submit the changes to db
                                dbContext.SubmitChanges();
                                DialogResult = DialogResult.OK;
                                MessageBox.Show("Changes have been modified", "Data update");
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
