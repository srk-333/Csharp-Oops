using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProgram.Inheritance.HierarchicalInheritance
{
    // Teacher is a derived class of College
    public class Teacher : College
    {
        // Teacher class Member
        int salary;

        // Creating Method to get Teacher Deatails using Base Class
        public void TeacherDetails()
        {
            College college = new College();
            college.open();                    // calling Base class Method.
            college.name = "Ritesh Singh";    // Initializing Teacher Name using Base Class Member.
            salary = 10000;
            Console.WriteLine("Teacher Details:-\n"+"Name: "+college.name+"\t Salary = "+salary);
        }

    }
}
