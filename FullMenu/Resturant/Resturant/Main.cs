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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        // Initialize the menus
        Breakfast breakfast = new Breakfast();
        Lunch lunch = new Lunch();

        private void BtnBreakfast_Click(object sender, EventArgs e)
        {
            breakfast.ShowDialog();
        }

        private void BtnLunch_Click(object sender, EventArgs e)
        {
            lunch.ShowDialog();
        }

        private void BtnDinner_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Under Construction \n\n Check back later.", "Dinner Menu Not Available", MessageBoxButtons.OK);
        }
    }
}
