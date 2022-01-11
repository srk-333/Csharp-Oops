using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProgram.Inheritance
{
    /*Bike is a Derived class inheriting Car and Vechile class
     * This is Multilevel Inhereting example. 
     * */
    internal class Bike : Car
    {
        /// <summary>
        /// creating Method inside Bike class which is inhereting Car and Vechile class Properties and Behaviours
        /// </summary>
        public void BikeBrand()
        {
            //creating object to access properties of Vechile Class
            Vechile vechile = new Vechile();
            vechile.brand = "Yamaha";
            vechile.model = 2018;
            Console.WriteLine("Bike is: "+vechile.brand+" and Model is: "+vechile.model);
            vechile.Run(); // calling base class Method that is Vechile.
        }
    }
}
