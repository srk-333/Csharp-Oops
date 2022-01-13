using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProgram.Abstraction.AbstractionTwo
{
    //inheriting
    public class AbstractBank : AbstractClass
    {
        //instance variables
        private int balance = 0;
        public int amount = 0;
        //Constructor
        public AbstractBank(int bal, int amt)
        {
            balance = bal;
            amount = amt; 
        }
        //overriding abstract method
        public override void Bank()
        {
            //condition check then performing statements.
            if (balance >= 0)
            {
                balance = balance + amount;
                Console.WriteLine("Your balance after deposit is : " + balance);
            }
        }
        //overriding abstract method
        public override void Test()
        {
            //condition check then performing statements.
            if (balance >= 1000)
            {
                balance -= amount;
                Console.WriteLine("Your balance after deduction is : " + balance);
            }
        }
    }
}
