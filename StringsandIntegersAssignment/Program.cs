using System;
using System.Collections.Generic;
using System.Text;

namespace StringsandIntegersAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a list of integers
            List<int> intList = new List<int> { 102, 104, 106, 108, 110, 112, 114, 116, 118 };
            //Ask the user for input and loop through the list dividing each number by the input
            bool numValid = false;
            while (!numValid)
            {
                //Using a try/catch block to give error message
                try
                {
                    Console.WriteLine("\nEnter a number to divide the above list by: ");
                    float numDivide = float.Parse(Console.ReadLine());
                    //If statement to check if the user entered 0
                    if (numDivide == 0)
                    {
                        Console.WriteLine("Please introduce a number that is not zero. ");
                    }
                    //Dividing each number in the list by the input
                    else
                    {
                        foreach (int num in intList)
                        {
                            float Divide = num / numDivide;
                            Console.WriteLine(num + "/" + numDivide + " = " + Divide);
                        }
                        numValid = true;
                    }
                }
                catch (FormatException)
                {
                    //Catch block to display error message for string input
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
            //Message to let the user know the program has exited the try/catch block
            Console.WriteLine("The program has exited the try/catch block.");

        }
    }
}
