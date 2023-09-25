using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant
{
    public partial class Lunch : Form
    {
        public Lunch()
        {
            InitializeComponent();
        }

        // Set constants for menu iteams and discounts
        const decimal TAXRATE = 0.0775m;
        const decimal HAMBURGER = 6.95M;
        const decimal PIZZA = 5.95M;
        const decimal SALAD = 4.95M;
        const decimal LTO = 0.75M;
        const decimal CONDIMENTS = 0.75M;
        const decimal FRIES = 0.75M;
        const decimal EMP_DISCOUNT = 0.25m;
        const decimal MIL_DISCOUNT = 0.15m;

        // Create variables for the total fields
        decimal subtotal, discount, tax, total = 0;

        private void chk_CheckedChanged(object sender, EventArgs e)
        {
            txtSubtotal.Clear(); 
            txtDiscount.Clear();
            txtTax.Clear();
            txtOrderTotal.Clear();
        }

        private void ButtonPlaceOrder_Click(object sender, EventArgs e)
        {
            //reset values to 0
            subtotal = 0;
            discount = 0;
            tax = 0;
            total = 0;

            // Add the main item to the subtotal
            if (radioMainHamburger.Checked == true)
            {
                subtotal += HAMBURGER;
            }
            else if (radioMainPizza.Checked == true)
            {
                subtotal += PIZZA;
            }
            else {
                subtotal += SALAD;
            }

            // Add any add-on items to the subtotal
            if (chkLTO.Checked == true) {
                subtotal += LTO;
            }
            if (chkCondiments.Checked == true) {
                subtotal += CONDIMENTS;
            }
            if (chkFries.Checked == true) {
                subtotal += FRIES;
            }

            // Determine amount of discount
            if (radioDiscountEmp.Checked == true)
            {
                discount = subtotal * EMP_DISCOUNT;
            }
            else if (radioDiscountMil.Checked == true)
            {
                discount = subtotal * MIL_DISCOUNT;
            }
            else {
                discount = 0.00M;
            }

            // Caclulate totals to print
            subtotal -= discount;
            tax = subtotal * TAXRATE;
            total = subtotal + tax;

            txtSubtotal.Text = subtotal.ToString("c");
            txtDiscount.Text = discount.ToString("c");
            txtTax.Text = tax.ToString("c");
            txtOrderTotal.Text = total.ToString("c");
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            txtSubtotal.Clear();
            txtDiscount.Clear();
            txtTax.Clear();
            txtOrderTotal.Clear();
            radioMainHamburger.Checked = true;
            radioDiscountNone.Checked = true;
            chkLTO.Checked = false;
            chkCondiments.Checked = false;
            chkFries.Checked = false;
            subtotal = 0;
            discount = 0;
            tax = 0;
            total = 0;
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
