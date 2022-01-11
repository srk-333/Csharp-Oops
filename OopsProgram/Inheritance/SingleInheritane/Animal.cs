using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProgram.Inheritance.SingleInheritane
{
    //Base Class
    public class Animal
    {
        //Members of Base Class
        public string breed;
        public int age;
        // Method of Base Class
        public void Run()
        {
            Console.WriteLine("Running");
        }
        public void Eat()
        {
            Console.WriteLine("Eating");
        }
    }
}
