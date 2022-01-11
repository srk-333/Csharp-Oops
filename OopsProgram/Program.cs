using OopsProgram.Encapsulation;      //importing namespace in our Main namespace
using OopsProgram.Inheritance;       //importing namespace in our Main namespace
using OopsProgram.Inheritance.HierarchicalInheritance;    //importing namespace in our Main namespace
using OopsProgram.Inheritance.SingleInheritane;          //importing namespace in our Main namespace
using OopsProgram.Polymorphism.MethodOverloading;       //importing namespace in our Main namespace
using OopsProgram.Polymorphism.MethodOverriding;       //importing namespace in our Main namespace
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

            //Creating object of Bike to get Multilevel Inheritance
            Bike vechile = new Bike();
            vechile.CarBrand();           //calling Method of Car Class bcz of Multilevel Inheretence
            vechile.BikeBrand();          // calling Method of Bike class.

            // Creating object of Lion to get Single Inheritance
            Lion lion = new Lion();
            lion.Walk();
            lion.breed = "African Lion";
            lion.age = 7;
            Console.WriteLine("Anmial is: " + lion.breed + "\t, Age: " + lion.age + "yrs");
            lion.Eat();
            lion.Run();

            //Implementing Hierarchical Inheritance
            Console.WriteLine("\nEnter any one number 0 or 1");
            int number = int.Parse(Console.ReadLine());
            if (number == 0)
            {
                Student student = new Student();   //Creating object for Student class
                student.open();                   //calling Method of College class
                student.StudentDetail();         //calling Method of Student class
            }
            else
            {
                Teacher teacher = new Teacher();    //Creating object for Teacher class
                teacher.TeacherDetails();          // calling Method of Teacher class
            }

            //Encapsulation Implementation
            ImpEncapulation encapulation = new ImpEncapulation();  //creating object of ImpEncapulation class
            encapulation.GetStudent();                            // calling method in ImpEncapulation class using object variable.
            encapulation.Bank();

            // Method Overloading / Static Polymorphism Implementation
            ImpMethodOverloading imp = new ImpMethodOverloading();  //creating object of ImpMethodOverloading class
            imp.AddAll();                                          // calling method in ImpMethodOverloading class using object variable.
            imp.Substitue();

            // Method Overriding / Dynamic Polymorphism Implementation
            Dog d = new Dog();         // Creating Object of Dog class
            d.DogDetail();            // calling Method of dog class
            d.Sound();               // calling overriden method in Dog class
            Cow cow = new Cow();    // Creating Object of Cow class
            cow.CowDetail();
            cow.Sound();           // calling overriden method in Cow class
            Console.ReadLine();
        }
    }
}
