﻿using OopsProgram.Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to OOPs program Practice \n ");
            Bike vechile = new Bike();
            vechile.CarBrand();           
            vechile.BikeBrand();
            Console.ReadLine();
        }
    }
}
