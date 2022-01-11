using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProgram.Inheritance
{
    //Derived class car inhereting base class Vechile
    public class Car : Vechile
    {
        /// <summary>
        /// creating Method inside car class which is inhereting Vechile class Properties and Behaviours
        /// </summary>
        public void CarBrand()
        {
            //creating object to access properties and Behaviours of base Class that is Vechile 
            Vechile vechile = new Vechile();
            vechile.brand = "Tata Range Rover";
            vechile.model = 2021;
            Console.WriteLine("Car is: "+vechile.brand+" and Model is: "+vechile.model);
            vechile.Run(); // calling base class Method which is Vechile.
        }
    }
}
