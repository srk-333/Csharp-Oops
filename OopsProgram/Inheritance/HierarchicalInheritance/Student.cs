using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProgram.Inheritance.HierarchicalInheritance
{
    // Student is a derived class of College
    public class Student : College
    {
        //Student Class Member
        int collegeId;

        // Creating Method to get Student Deatails using Base Class
        public void StudentDetail()
        { 
            College college = new College();
            college.name = "Saurav kumar";   // Initializing Student Name using Base Class Member.
            collegeId = 2018;
            Console.WriteLine("Student Detail:-\n"+"Name: "+college.name+"\t Student IdNumber: "+collegeId);
        }
    }
}
