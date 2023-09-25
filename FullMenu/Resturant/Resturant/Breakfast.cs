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
    public partial class Breakfast : Form
    {
        public Breakfast()
        {
            InitializeComponent();
        }

        const decimal TAXRATE = 0.0775m;
        const decimal POP = 1.99M;
        const decimal COFFEE = 5.99M;
        const decimal TEA = 4.99M;
        const decimal MILKSHAKE = 6.99M;
        const decimal MUFFIN = 2.99M;
        const decimal CAKE = 2.99M;
        const decimal HASH = 2.99M;

        decimal subtotal, discountPercent, discountAmount, tax, total = 0;
        int selection = 0;

        decimal[] wafflePrice = {13.99M, 13.99M, 11.99M, 12.99M, 15.99M };
        decimal[] pancakePrice = {15.99M, 14.99M, 11.99M, 12.99M, 13.75M, 13.99M};
        decimal[] omletPrice = {6.99M,8.99M,7.99M,10.99M,9.99M,9.99M};
        decimal[] specialPrice = {5.99M,5.99M,5.99M,8.99M,8.99M};


        private void rdoWaffles_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoWaffles.Checked == true) { 
                grpItemDetails.Text = rdoWaffles.Text;
                string[] waffles = {"Please Select a House-Made Waffle", 
                                    "Belgian Waffle Combo - $13.99",
                                    "Chicken Tenders and Waffles - $13.99",
                                    "Belgian Waffle Classic - $11.99",
                                    "Malaysian Waffle Combo - $12.99",
                                    "Chinese Waffle Combo - $15.99"};
                cbxItemDetails.Items.Clear(); 
                foreach (string waffle in waffles) {
                    cbxItemDetails.Items.Add(waffle);
                }
                cbxItemDetails.SelectedIndex = 0;
            }
            txtSubtotal.Clear();
            txtDiscount.Clear();
            txtTax.Clear();
            txtTotal.Clear();
        }

        private void rdoPancakes_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoPancakes.Checked == true)
            {
                grpItemDetails.Text = rdoPancakes.Text;
                string[] pancakes = {"Please Select a World Pancake",
                                    "Authentic Taiwanese Pancake - $15.99",
                                    "Chinese Classic Pancake - $14.99",
                                    "French Oat Pancake - $11.99",
                                    "Italian Strawberry Pancake - $12.99",
                                    "Greek Triple Yogurt Pancake - $13.75",
                                    "Mexican Tres Leches Pancake - $13.99"};
                cbxItemDetails.Items.Clear(); 
                foreach (string pancake in pancakes)
                {
                    cbxItemDetails.Items.Add(pancake);
                }
                cbxItemDetails.SelectedIndex = 0;
            }
            txtSubtotal.Clear();
            txtDiscount.Clear();
            txtTax.Clear();
            txtTotal.Clear();
        }

        private void rdoOmlets_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoOmlets.Checked == true)
            {
                grpItemDetails.Text = rdoOmlets.Text;
                string[] omlets = {"Please Select an Authentic Omlet",
                                    "Cheese Omelet - $6.99",
                                    "Western Omlet - $8.99",
                                    "Vegetable Omlet - $7.99",
                                    "Meat Lover's Omlet - $10.99",
                                    "Spinach Omelet - $9.99",
                                    "Greek Omelet - $9.99"};
                cbxItemDetails.Items.Clear();
                foreach (string omlet in omlets)
                {
                    cbxItemDetails.Items.Add(omlet);
                }
                cbxItemDetails.SelectedIndex = 0;
            }
            txtSubtotal.Clear();
            txtDiscount.Clear();
            txtTax.Clear();
            txtTotal.Clear();
        }

        private void rdoSpecials_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSpecials.Checked == true)
            {
                grpItemDetails.Text = rdoSpecials.Text;
                string[] omlets = {"Please Select a Special",
                                    "Kid Special I (1 Egg + Pancake with 2 pieces of Bacon) - $5.99",
                                    "Kid Special II (1 Egg + Pancake with 1 Sausage patty) - $5.99",
                                    "Kid Special III (1 Egg + Pancake with 2 Sausage links) - $5.99",
                                    "Senior Special I (2 Eggs + Pancakes with 1 sausage and free drink) - $8.99",
                                    "Senior Special II (2 Eggs + Toasts with 1 piece of bacon and free drink) - $8.99"};
                cbxItemDetails.Items.Clear(); 
                foreach (string omlet in omlets)
                {
                    cbxItemDetails.Items.Add(omlet);
                }
                cbxItemDetails.SelectedIndex = 0;
            }
            txtSubtotal.Clear();
            txtDiscount.Clear();
            txtTax.Clear();
            txtTotal.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdoWaffles.Checked = true;
        }

        private void BtnPlaceOrder_Click(object sender, EventArgs e)
        {
            bool addons, goodSelection = false;

            subtotal = 0;
            discountAmount = 0;
            tax = 0;
            total = 0;

            addons = verifyAddOns();

            selection = cbxItemDetails.SelectedIndex - 1; // Get selected item to check against array

            if (selection < 0)
            {
                MessageBox.Show($"{grpItemDetails.Text} Selection Required \n Please select one of these items", "Non-Selection Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                goodSelection = true;
            }

            if (addons == true && goodSelection == true) 
            {
                if (rdoWaffles.Checked == true)
                {
                    subtotal += wafflePrice[selection];
                }
                else if (rdoPancakes.Checked == true) {
                    subtotal += pancakePrice[selection];
                }
                else if (rdoOmlets.Checked == true)
                {
                    subtotal += omletPrice[selection];
                }
                else if (rdoSpecials.Checked == true)
                {
                    subtotal += specialPrice[selection];
                }

                decimal addOnTotals = TotalAddOns();
                subtotal += addOnTotals;

                discountAmount = subtotal * discountPercent;
                subtotal -= discountAmount;
                tax = subtotal * TAXRATE;
                total = subtotal + tax;

                txtSubtotal.Text = subtotal.ToString("c");
                txtDiscount.Text = discountAmount.ToString("c");
                txtTax.Text = tax.ToString("c");
                txtTotal.Text = total.ToString("c");

            }

        }

        private void rdoNoDiscount_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoNoDiscount.Checked == true) {
                lblDiscount.Text = "Discount";
                discountPercent = 0;
            }
            txtSubtotal.Clear();
            txtDiscount.Clear();
            txtTax.Clear();
            txtTotal.Clear();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            subtotal = 0;
            discountAmount = 0;
            tax = 0;
            total = 0;
            chkCoke.Checked = false;
            chkFanta.Checked = false;
            chkAW.Checked = false;
            chkMelloYello.Checked = false;
            chkDrPepper.Checked = false;
            chkEspresso.Checked = false;
            chkFrap.Checked = false;
            chkLatte.Checked = false;
            chkMatcha.Checked = false;
            chkLychee.Checked = false;
            chkGreenTea.Checked = false;
            chkMilkshake.Checked = false;
            chkMuffin.Checked = false;
            chkMarbleCake.Checked = false;
            chkHashbrown.Checked = false;

            txtSubtotal.Clear();
            txtDiscount.Clear();
            txtTax.Clear();
            txtTotal.Clear();

            rdoWaffles.Checked = true;
            rdoNoDiscount.Checked = true;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdoEmpDiscount_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoEmpDiscount.Checked == true)
            {
                lblDiscount.Text = "Discount (25%)";
                discountPercent = 0.25m;
            }
            txtSubtotal.Clear();
            txtDiscount.Clear();
            txtTax.Clear();
            txtTotal.Clear();
        }

        private void rdoMilDiscount_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoMilDiscount.Checked == true)
            {
                lblDiscount.Text = "Discount (15.35%)";
                discountPercent = 0.1535m;
            }
            txtSubtotal.Clear();
            txtDiscount.Clear();
            txtTax.Clear();
            txtTotal.Clear();
        }

        private bool verifyAddOns() {

            bool goodData = false; 

            if (chkCoke.Checked == false && chkFanta.Checked == false && chkAW.Checked == false && chkMelloYello.Checked == false &&
                chkDrPepper.Checked == false && chkEspresso.Checked == false && chkFrap.Checked == false && chkLatte.Checked == false &&
                chkMatcha.Checked == false && chkLychee.Checked == false && chkGreenTea.Checked == false && chkMilkshake.Checked == false &&
                chkMuffin.Checked == false && chkMarbleCake.Checked == false && chkHashbrown.Checked == false) 
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to proceed without any add-on items?", "No Add-On Items Selected", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    goodData = true;
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Please select add-on items", "No Add-On Items Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            else
            {
                goodData = true;
            }

            return goodData;
        }

        private decimal TotalAddOns() {
            decimal addOnTotal = 0;

            if (chkCoke.Checked == true)
            {
                addOnTotal += POP;
            }
            if (chkFanta.Checked == true) {
                addOnTotal += POP;
            }
            if (chkAW.Checked == true)
            {
                addOnTotal += POP;
            }
            if (chkMelloYello.Checked == true)
            {
                addOnTotal += POP;
            }
            if (chkDrPepper.Checked == true)
            {
                addOnTotal += POP;
            }
            if (chkEspresso.Checked == true)
            {
                addOnTotal += COFFEE;
            }
            if (chkFrap.Checked == true)
            {
                addOnTotal += COFFEE;
            }
            if (chkLatte.Checked == true)
            {
                addOnTotal += COFFEE;
            }
            if (chkMatcha.Checked == true)
            {
                addOnTotal += TEA;
            }
            if (chkLychee.Checked == true)
            {
                addOnTotal += TEA;
            }
            if (chkGreenTea.Checked == true)
            {
                addOnTotal += TEA;
            }
            if (chkMilkshake.Checked == true)
            {
                addOnTotal += MILKSHAKE;
            }
            if (chkMuffin.Checked == true)
            {
                addOnTotal += MUFFIN;
            }
            if (chkMarbleCake.Checked == true) {
                addOnTotal += CAKE;
            }
            if (chkHashbrown.Checked == true)
            {
                addOnTotal += HASH;
            }

            return addOnTotal;
        }
    }
}
