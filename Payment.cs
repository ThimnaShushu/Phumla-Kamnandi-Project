using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace PhumlaKamnandiHotel
{
    public class Payment
    {
        // Properties of the Payment
        public int paymentID;
        public Account customerAccount;
        public double amountDue;
        

        // Constructor
        public Payment(int paymentId, Account account, double amount, DateTime paymentDate)
        {
            paymentId = paymentID;
            customerAccount = account;
            amountDue = amount;
             
        }

    }

    
    
}

