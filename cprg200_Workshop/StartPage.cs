using System;
using System.Windows.Forms;

namespace cprg200_Workshop
{
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void btnPackageTab_Click(object sender, EventArgs e)
        {
            btnSaveProducts frm = new btnSaveProducts();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
