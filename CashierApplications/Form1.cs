using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CashierApplications
{
    public partial class frmLoginAccount : Form
    {
        private Cashier cashier;
        public frmLoginAccount()
        {
            InitializeComponent();
            cashier = new Cashier("Nathaniel De Leon", "Finance", "Cashing2", "Nathan1234");
        }

     

       
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (cashier.ValidateLogin(txtLogin.Text, txtPassword.Text))
            {
                string name = cashier.getFullName();
                string dept = cashier.getDepartment();
                MessageBox.Show($"Welcome {name} of {dept}!", "Login Sucessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Invalid Password");
                frmPurchaseDiscountedItem purchaseForm = new frmPurchaseDiscountedItem();
                purchaseForm.Show();
 
            }
            else
            {
                
          
            }
        }
    }
    }

