using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProgram.Polymorphism.MethodOverriding
{
    // Derived class inheriting base class
    public class Dog : Animal
    {
        // Method to show Animal Detail
        public void DogDetail()
        {
            // Creating Object of Base Class
            Animal a = new Animal();  
            a.name = "Tommy";
            Console.WriteLine("\nDog Name: "+a.name);
        }
        // Method Overriding of Sound Method of Base class
        public new void Sound()
        {
            Console.WriteLine("Dog Sound is bhau");
        }
    }
}
