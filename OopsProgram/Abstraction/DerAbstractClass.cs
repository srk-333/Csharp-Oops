using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProgram.Abstraction
{
    //inheriting
    public class DerAbstractClass : AbstractClass
    {
        //overriding absract methods.
        public override void Bank()
        {
            throw new NotImplementedException();
        }
        public override void Test()
        {
            Console.WriteLine("overrided abstract class");
        }
    }
}
