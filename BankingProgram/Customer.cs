using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankAccount
{
    internal class Customer
    {
        string? CustomerName { get; set; }

        int CustomerID { get; set; }

        static int CustomerCounter = 0;

        Account CustomerAccount { get; set; }

        public Customer ( string CustomerName)
        {            
            this.CustomerName = CustomerName;
            CustomerAccount = new Account( 0, this);
            this.CustomerID = CustomerCounter++;
        }       

    }
}
