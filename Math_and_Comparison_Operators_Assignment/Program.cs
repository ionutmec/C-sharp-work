﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_and_Comparison_Operators_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly rate?");
            string hourlyRate1 = Console.ReadLine();
            Console.WriteLine("Hours Worked per week?");
            string hours1 = Console.ReadLine();
            int salary1 = Convert.ToInt32(hourlyRate1) * Convert.ToInt32(hours1) *52;
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly rate?");
            string hourlyRate2 = Console.ReadLine();
            Console.WriteLine("Hours Worked per week?");
            string hours2 = Console.ReadLine();
            int salary2 = Convert.ToInt32(hourlyRate2) * Convert.ToInt32(hours2) * 52;
            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine(salary1);
            Console.WriteLine("Annual salary of Person 2:");
            Console.WriteLine(salary2);
            Console.WriteLine("Does Person 1 makes more money than Person 2?");
            bool isMore = salary1 > salary2;
            Console.WriteLine(isMore);
            Console.ReadLine();
        }
    }
}
