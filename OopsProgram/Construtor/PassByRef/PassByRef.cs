using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProgram.Construtor.PassByRef
{
    public class PassByRef
    {
        //instace Variable
        string name;
        int age;
        private long phone;
        //constructor
        public PassByRef(string x,int y, long z)
        {
            Console.WriteLine("pass by reference Example");
            name = x;
            age = y;    
            phone = z;           
            Console.WriteLine("student data: "+name+" "+age+" "+phone);
        }
    }
}
