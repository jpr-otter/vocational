using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankAccount
{
    internal class AccountManagement
    {
        List<Account> accounts = new List<Account>();       
        public void CreateAccount(Customer customer)
        {
            var account = new Account(customer);
            accounts.Add(account);
        }
    }
}
