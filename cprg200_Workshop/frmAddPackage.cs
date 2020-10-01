using System;
using System.CodeDom;
using System.Windows.Forms;
using Workshop4_DH;

//Coded by:
namespace cprg200_Workshop
{
    public partial class frmAddPackage : Form
    {
        public bool isAdd; //main form sets it
        public Package currentPackage;  // main form sets it
        public frmAddPackage()
        {
            InitializeComponent();
        }

        private void frmAddPackage_Load(object sender, EventArgs e)
        {
                txtName.Focus();
        }

        private void btnAddPackage_Click(object sender, EventArgs e)
        {
            if (Validator.IsProvided(txtName, "Package Name") && 
                Validator.IsProvided(txtDescription, "Description") &&
                Validator.IsNonNegativeDouble(txtPrice, "Base Price") &&
                Validator.IsNonNegativeDouble(txtCommision, "Commission") && 
                Validator.IsCorrectLength(txtName, 50))
            {
                if (Convert.ToDecimal(txtPrice.Text) <= Convert.ToDecimal(txtCommision.Text))
                {
                    MessageBox.Show("Base Price must be greater then commision", "Entry error");
                    txtPrice.Focus();
                }
                else if (pkgEndDateDateTimePicker.Value <= pkgStartDateDateTimePicker.Value)
                {
                    MessageBox.Show(" Package End Date Must be greater then Start Date", "Entry error");
                    pkgStartDateDateTimePicker.Focus();
                }
                else

                if (isAdd) // it is add
                {
                    Package newPackage = new Package
                    {
                        PkgName = txtName.Text.ToString(),
                        PkgStartDate = Convert.ToDateTime(pkgStartDateDateTimePicker.Value),
                        PkgEndDate = Convert.ToDateTime(pkgEndDateDateTimePicker.Value),
                        PkgDesc = txtDescription.Text.ToString(),
                        PkgBasePrice = Convert.ToDecimal(txtPrice.Text),
                        PkgAgencyCommission = Convert.ToDecimal(txtCommision.Text)
                    };
                    //save to database
                    using (TravelExpertDataContext dbContext = new TravelExpertDataContext())
                    {
                        dbContext.Packages.InsertOnSubmit(newPackage);
                        dbContext.SubmitChanges(); //submit to database
                    }
                    DialogResult = DialogResult.OK;
                }
            }
        }

        // closes the form
        private void btnExit5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
