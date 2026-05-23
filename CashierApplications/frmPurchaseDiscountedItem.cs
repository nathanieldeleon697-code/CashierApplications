using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierApplications
{
    public partial class frmPurchaseDiscountedItem : Form
    {
        private DiscountedItem item;
        public frmPurchaseDiscountedItem()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtItemName.Text;
            double price = Convert.ToDouble(txtPrice.Text);
            double discount = Convert.ToDouble(txtDiscount.Text);
            int quantity = Convert.ToInt32(txtQuantity.Text);

            item = new DiscountedItem(name, price, quantity, discount);

            double totalAmount = item.getTotalPrice();
            lblTotalAmount.Text = totalAmount.ToString("0.00");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (item != null)
            {
                double payment = Convert.ToDouble(txtPayment.Text);

                item.setPayment(payment);

                double change = item.getChange();
                lblChange.Text = change.ToString("0.00");
            }
            else
            {
                MessageBox.Show("ERROR", "WARNING");
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
