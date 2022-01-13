using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OopsProgram.Abstraction.AbstractionTwo;

namespace OopsProgram.Abstraction
{
    //public abstract class.
    public abstract class AbstractClass
    {
        /*abstract method 
         *abstract method should always be without body in base class. 
         *means abstract doesn't have any body.
         *Declare abstract method only in abstract class
         *Abstract class can have no abstract method too.
         */
        //Test and Bank is here abstract method.
        public abstract void Test();
        public abstract void Bank();
        //Non abstract Method
        public void Show()
        {
            Console.WriteLine("This is non abstract method of abstract class");
        }
    }
}
