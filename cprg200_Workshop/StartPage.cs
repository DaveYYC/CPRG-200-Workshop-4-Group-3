using System;
using System.Windows.Forms;

/* 
 * Title: CPRG 200 Workshop 4.
 * Description: Application development with C#.NET.
 *              GUI for Travel Experts Travel Agent to work with their database.
 * Author: Group 3 - Larisa Steig, Parvathy , and David Hahner.
 * Date: Sept 2020.
 * 
 */

// Start page created by David Hahner
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
