using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProgram.Inheritance
{
    public class Car : Vechile
    {
        /// <summary>
        /// creating Method inside car class which is inhereting Vechile class Properties and Behaviours
        /// </summary>
        public void CarBrand()
        {
            //creating object to access properties and Behaviours of Vechile Class
            Vechile vechile = new Vechile();
            vechile.brand = "Tata Range Rover";
            vechile.model = 2021;
            Console.WriteLine("Car is: "+vechile.brand+" and Model is: "+vechile.model);
            vechile.Run();
        }
    }
}
