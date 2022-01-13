using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProgram.Construtor
{
    public class ImpCons
    {
        /* constructor name is same as class name
         * Taking Values as ref in x y and z
         * Adding x y and z
         * showing the result
         */
        //instance variables
        int Add;
 
        //compuing x y and z using constructor
        public ImpCons(int x,int y, int z)
        {
            Add = x + y + z;           
        }
        public void show()
        {
            Console.WriteLine("Basic Addition using constructor");
            Console.WriteLine("Addition is: " + Add);
        }
    }
}
