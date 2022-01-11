using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProgram.Inheritance
{
    //Base class of all the classes
    public class Vechile
    {
        //Vechile class public members/instance variables
        public string brand;
        public int model;
        //Method to Run Vechile
        public void Run()
        {
            Console.WriteLine("Vechile is in Running Condition \n ");
        }
    }
}
