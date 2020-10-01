using cprg200_Workshop;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Workshop4_DH
{
    public static class Validator
    {
        // tests if text box is not empty (required fields)
        public static bool IsProvided(TextBox tb, string name)
        {
            bool result = true; // "innocent until proven guilty"
            if (tb.Text == "")   // empty textbox
            {
                result = false;
                MessageBox.Show("Please enter the " + name);
                tb.Focus();
            }
            return result;
        }
        
        public static bool IsCorrectLength(TextBox textBox, int maxLen)
        {
            if ((textBox.Text).Length > maxLen)
            {
                MessageBox.Show(textBox.Tag + " can be at most " + maxLen.ToString() + " long", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }
        public static bool IsDecimal(TextBox textBox)
        {
            decimal number = 0m;
            if (Decimal.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(textBox.Tag + " must be a decimal value.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }

        public static bool IsInt32(TextBox textBox)
        {
            int number = 0;
            if (Int32.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(textBox.Tag + " must be an integer.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }
        //test if input is a non-negative decimal
        public static bool IsNonNegativeDouble(TextBox tb, string name)
        {
            bool result = true;
            double num; // parsed number
            if (!Double.TryParse(tb.Text, out num)) // test if input is not integer
            {
                result = false;
                MessageBox.Show(name + ": Please enter a floating point number", "Please re-enter");
                tb.SelectAll(); // select all text to facilitate change
                tb.Focus();
            }
            else // a double value; check if non-negative
            {
                if (num < 0)
                {
                    result = false;
                    MessageBox.Show(name + ": Please enter a positive number or zero", "Please re-enter");
                    tb.SelectAll(); // select all text and focus
                    tb.Focus();
                }
            }
            return result;
        }

        // test if input is a non-negative integer
        public static bool IsNonNegativeInt(TextBox tb, string name)
        {
            bool result = true;
            int num; // parsed number
            if (!Int32.TryParse(tb.Text, out num)) // test if input is not integer
            {
                result = false;
                MessageBox.Show(name + ": Please enter a whole number", "Please re-enter");
                tb.SelectAll(); // select all text to facilitate change
                tb.Focus();
            }
            else // a decimal value; check if non-negative
            {
                if (num < 0)
                {
                    result = false;
                    MessageBox.Show(name + ": Please enter a positive number or zero", "Please re-enter");
                    tb.SelectAll(); // select all text and focus
                    tb.Focus();
                }
            }
            return result;
        }
        // test if it entry value is a string
        public static bool isNotNumeric(TextBox tb, string name)
        {
            bool isValid = true;
            int val;
            if (int.TryParse(tb.Text, out val)) // is an int
            {
                isValid = false;
                MessageBox.Show(name + " cannot be a number", "Input Error");
                tb.SelectAll();
                tb.Focus();
            }
            else if (val < 0) // negative
            {
                isValid = false;
                MessageBox.Show(name + " cannot be a number", "Input Error");
                tb.SelectAll();
                tb.Focus();
            }
            return isValid;
        }

        public static bool IsUnique(ComboBox comboBox, TextBox textbox, List<Packages_Products_Supplier> list, string name)
        {
            foreach (var c in list)
            {
                if (c.PackageId == Convert.ToInt32(comboBox.SelectedItem) && c.ProductSupplierId == Convert.ToInt32(textbox.Text)) // if has already existed
                {
                    MessageBox.Show("The " + name + " has already been used, please re-enter.");
                    comboBox.SelectAll();
                    comboBox.Focus();
                    return false;
                }
            }
            return true;
        }
    }
}
