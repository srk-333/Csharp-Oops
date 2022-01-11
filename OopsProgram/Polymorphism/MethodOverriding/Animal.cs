using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProgram.Polymorphism.MethodOverriding
{
    // Base Class 
    public class Animal
    {
        // public Member
        public string name;

        // Method creation
        public void Sound()
        {
            Console.WriteLine("Animal Sound");
        }
    }
}
