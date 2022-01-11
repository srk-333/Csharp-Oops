using OopsProgram.Inheritance; //importing namespace in our Main namespace
using OopsProgram.Inheritance.SingleInheritane; //importing namespace in our Main namespace
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProgram
{
    internal class Program
    {
        // Entry Point
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to OOPs program Practice \n ");
            // Creating object of Bike to get Multilevel Inheritance
            Bike vechile = new Bike();
            vechile.CarBrand();           //calling Method of Car Class bcz of Multilevel Inheretence
            vechile.BikeBrand();          // calling Method of Bike class.

            // Creating object of Lion to get Single Inheritance
            Lion lion = new Lion();
            lion.Walk();
            lion.breed = "African Lion";
            lion.age = 7;
            Console.WriteLine("Anmial is: "+lion.breed+"\t, Age: "+lion.age+"yrs");
            lion.Eat();
            lion.Run();
            Console.ReadLine();
        }
    }
}
