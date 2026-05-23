using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApplications
{
    public class DiscountedItem : Item
    {
        private double item_discount;
        private double discounted_price;
        private double payment_amount;
        private double change;

        public DiscountedItem(string name, double price, int quantity, double discount)
            : base(name, price, quantity)
        {
            this.item_discount = discount;
        }

        public override double getTotalPrice()
        {
            double discountRate = item_discount * 0.01;
            discounted_price = item_price * (1 - discountRate);
            total_price = discounted_price * item_quantity;
            return total_price;
        }

        public override void setPayment(double amount)
        {
            this.payment_amount = amount;
        }

        public double getChange()
        {
            change = payment_amount - total_price;
            return change;
        }
    }
}
