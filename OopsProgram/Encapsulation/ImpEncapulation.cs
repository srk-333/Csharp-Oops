using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProgram.Encapsulation
{
    public class ImpEncapulation
    {
        // Method to get Student Details
        public void GetStudent()
        {
            StudentDet student = new StudentDet();   //object creation to access void type method in class
            student.StudentDetail();                //Method call
        }

        // Method to get BankBalance Details
        public void Bank()
        { 
            BankBalance balance = new BankBalance();     //object creation to access void type method in class
            balance.AddBalance(1000);                   //Method call with parameters
            balance.DeductBalance(500);                //Method call with parameters
        }
    }
}
