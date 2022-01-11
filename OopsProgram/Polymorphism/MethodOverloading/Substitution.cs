using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProgram.Polymorphism.MethodOverloading
{
    public class Substitution
    {
        /* Method overloading / static polymorphism
        * Method name same but diff parameters
        * In parameters we can provide diff order of data type
        */
        public int Sub(int a, int b)
        {
            return a - b;
        }
        public int Sub(int a, int b, int c)
        {
            return a - b - c;
        }
        public float Sub(float a, int b)
        {
            return a - b;
        }
        public float Sub(int a, float b)
        {
            return a - b;
        }
    }
}
