using System;

namespace Assignment6DEL_Q3
{
        class Program
        {
        static void Main(string[] args)
            {

            Account cust = new Account(9083456, "Devashri More", 500);
           
            cust.Deposit(4000);
            ZeroBalance z = new ZeroBalance(cust.ZeroBalance);
            del ub = new del(cust.UnderBalance);

            cust.Withdraw(400,ub,z);
             }
        }
    
}
