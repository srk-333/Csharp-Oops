using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProgram.Encapsulation
{
    public class StudentDet
    {
        /* private access specifier member
         * used only in student class
         * private member cann't be accessed outside of this class.
         */
        private string Name { get; set; }
        private int Age { get; set; }
        private string Id { get; set; }

        //Creating Method to set and Get Student Members.
        public void StudentDetail()
        {
            //setting values of Student class Members.
            Name = "Saurav";
            Age = 24;
            Id = "101";

            // getting values of student class Members.
            Console.WriteLine("\nName is: " + Name);
            Console.WriteLine("Age is: " + Age);
            Console.WriteLine("Student Id is: " + Id);
        }
    }
}
