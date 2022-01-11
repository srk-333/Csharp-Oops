using OopsProgram.Inheritance; //importing namespace in our Main namespace
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
            //creating object of Last child class that is Bike
            Bike vechile = new Bike();
            vechile.CarBrand();           //calling Method of Car Class bcz of Multilevel Inheretence
            vechile.BikeBrand();          // calling Method of Bike class.
            Console.ReadLine();
        }
    }
}
