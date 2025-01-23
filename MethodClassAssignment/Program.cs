using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instantiate MathOperation3 class
            MathOperation3 mathOp = new MathOperation3();
            //Call the method in the class, passing in two numbers
            Console.WriteLine("Enter an integer ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second integer ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int result = mathOp.MathOperation(num1, num2);
            //Call the method in the class, specifying the parameters by name
            Console.WriteLine(num1 +" is the first integer "  + " + " + num2 + " is the second integer " + " + 6 is a constant number " + " = " + result);
        }
    }
}
