using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;


namespace ClassMethod1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //In the Main() method, instatiate the class
            MathOp1 math = new MathOp1();
            Console.WriteLine("Input a number: ");
            int divided = Convert.ToInt32(Console.ReadLine());
            math.MathOp(divided);
            Console.WriteLine(math.Value);
            Console.ReadLine();
            //Call the method with output parameters
            Console.WriteLine("Input a phrasw: ");
            string input = Console.ReadLine();
            string phrase = math.StringCounter(input, out int count);
            Console.WriteLine(phrase);
            Console.WriteLine("Doubled would be: " + (count * 2));
            Console.ReadLine();
            //Call the method of the static class
            Console.WriteLine("Input another phrase:");
            string input3 = Console.ReadLine();
            int i_count = MathOp1.IFinder();
            Console.WriteLine("This phrase has " + i_count + " i's in it.");
            Console.ReadLine();
        }
    }
}
