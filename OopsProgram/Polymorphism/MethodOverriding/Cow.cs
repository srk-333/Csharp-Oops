using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProgram.Polymorphism.MethodOverriding
{
    // Derived class inheriting base class
    public class Cow : Animal
    {
        // Method to show Animal Detail
        public void CowDetail()
        {
            // Creating Object of Base Class
            Animal a = new Animal();
            a.name = "Tappu";
            Console.WriteLine("\nCow Name: " + a.name);
        }
        // Method Overriding of Sound Method of Base class
        public new void Sound()
        {
            Console.WriteLine("Cow sound is mooo");
        }
    }
}
