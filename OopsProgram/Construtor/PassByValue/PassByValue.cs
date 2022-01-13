using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProgram.Construtor.PassByValue
{
    public class PassByValue
    {
        //private instance variable.
        private int Multiply;
        //constructor to multiply x and y
        public PassByValue(int x = 0, int y=0)
        {
            Multiply = x * y;
            Console.WriteLine( "Multiply of x and y = "+Multiply );
        }
    }
}
