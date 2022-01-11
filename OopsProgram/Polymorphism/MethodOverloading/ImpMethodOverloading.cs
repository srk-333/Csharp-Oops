using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProgram.Polymorphism.MethodOverloading
{
    public class ImpMethodOverloading
    {
        public void AddAll()
        { 
            Addition a = new Addition();        
            Console.WriteLine ("\n" + a.Add(10,20));
            Console.WriteLine (a.Add(20,30,40));
            Console.WriteLine(a.Add(30.30f, 20));
            Console.WriteLine(a.Add(30, 20.90f));
        }
        public void Substitue()
        {
            Substitution s = new Substitution();
            Console.WriteLine("\n" + s.Sub(30, 10));
            Console.WriteLine(s.Sub(50, 20, 10));
            Console.WriteLine(s.Sub(30.50f, 10));
            Console.WriteLine(s.Sub(30, 15.50f));
        }

    }
}
