using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApplications
{
    public class Cashier : UserAccount
    {
        private string department;

        public Cashier(string name, string department, string uName, string password)
            : base(name, uName, password)
        {
            this.department = department;
        }
        public override bool ValidateLogin(string uName, string password)
        {
            return this.user_name == uName && this.password == password;
        }
        public string getFullName()
        {
            return this.full_name;
        }

        public string getDepartment()
        {
            return department;
        }
    }
}
