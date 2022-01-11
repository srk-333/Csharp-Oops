using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProgram.Encapsulation
{
    public class BankBalance
    {
        private int balance=0;

        public void AddBalance(int amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine("\nAccount Total Balance is:" + balance);
            }
            else
                Console.WriteLine("Enter Amount more than zero\n");
        }
        public void DeductBalance(int amount)
        { 
            balance -= amount;
            Console.WriteLine("\nBalance Deducted: " + amount);
            Console.WriteLine("\nTotal Balance after Deduction: "+balance);
        }
    }
}
