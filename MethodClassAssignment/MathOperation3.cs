using System;


namespace MethodClassAssignment
{
    public class MathOperation3
    {
        //Create a method that takes two integers as parameters
        //Have the method do a math operation on the first integer and display the second integer to the screen
        public int MathOperation(int i, int j)
        { 
            
            Console.WriteLine("Second integer is: " + j);
            int result = i + j + 6;
            return result;
        }
    }
}
