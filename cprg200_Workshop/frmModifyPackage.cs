using System;
using System.Data.Linq;
using System.Linq;
using System.Windows.Forms;
using Workshop4_DH;

namespace cprg200_Workshop
{
    public partial class frmModifyPackage : Form
    {
        public bool isAdd;              // main form sets it
        public Package currentPackage;

        public frmModifyPackage()
        {
            InitializeComponent();
        }

        //
        private void frmModifyPackage_Load(object sender, EventArgs e)
        {
            DisplayCurrentPackage();
            txtPackageId.Enabled = false;
            txtPkgName.Focus();
        }

        //
        private void DisplayCurrentPackage()
        {
            // display currently selected package details to modify
            txtPackageId.Text = (currentPackage.PackageId).ToString();
            txtPkgName.Text = currentPackage.PkgName;
            pkgStartDateDateTimePicker.Value = Convert.ToDateTime(currentPackage.PkgStartDate);
            pkgEndDateDateTimePicker.Value = Convert.ToDateTime(currentPackage.PkgEndDate);
            txtPkgDesc.Text = currentPackage.PkgDesc;
            txtPkgBasePrice.Text = Convert.ToDecimal(currentPackage.PkgBasePrice).ToString("f2");
            txtPkgAgencyCommission.Text = Convert.ToDecimal(currentPackage.PkgAgencyCommission).ToString("f2");
        }
        
        //
        private void btnSaveMod_Click(object sender, EventArgs e)
        {
            if (Validator.IsProvided(txtPkgName,"Package Name") &&
                Validator.IsProvided(txtPkgDesc, "Description") &&
                Validator.IsNonNegativeDouble(txtPkgBasePrice, "Base Price") &&
                Validator.IsNonNegativeDouble(txtPkgAgencyCommission, "Commission") &&
                Validator.IsCorrectLength(txtPkgName, 50))
            {
            if (Convert.ToDecimal(txtPkgBasePrice.Text) <= Convert.ToDecimal(txtPkgAgencyCommission.Text))
            {
                MessageBox.Show("Base Price must be greater then commission", "Entry error");
                txtPkgBasePrice.Focus();
            }
            else if (pkgEndDateDateTimePicker.Value <= pkgStartDateDateTimePicker.Value)
            {
                MessageBox.Show(" Package End Date Must be greater then Start Date", "Entry error");
                pkgStartDateDateTimePicker.Focus();
            }
            else

                try
                {
                    using (TravelExpertDataContext dbContext = new TravelExpertDataContext())
                    {
                        // get the product with Code from the current text box
                        Package package = dbContext.Packages.Single(p => p.PackageId == Convert.ToInt32(txtPackageId.Text));
                     
                            // make changes by copying values from text boxes
                            package.PkgName = Convert.ToString(txtPkgName.Text);
                            package.PkgStartDate = Convert.ToDateTime(pkgStartDateDateTimePicker.Value);
                            package.PkgEndDate = Convert.ToDateTime(pkgEndDateDateTimePicker.Value);
                            package.PkgDesc = Convert.ToString(txtPkgDesc.Text);
                            package.PkgBasePrice = Convert.ToDecimal(txtPkgBasePrice.Text);
                            package.PkgAgencyCommission = Convert.ToDecimal(txtPkgAgencyCommission.Text);

                        dbContext.SubmitChanges();
                        DialogResult = DialogResult.OK;
                        MessageBox.Show("Package changed successfully!", "Package Modified");
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
        }

        private void btnExit4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
 }










