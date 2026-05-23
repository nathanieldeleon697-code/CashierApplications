using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApplications
{
    public abstract class UserAccount
    {
        protected string full_name;
        protected string user_name;
        protected string password;


        public UserAccount(string name, string uName, string password)
        {
            full_name = name;
            user_name = uName;
            this.password = password;
        }
        
        public abstract bool ValidateLogin(string uName, string password);

    }
}
