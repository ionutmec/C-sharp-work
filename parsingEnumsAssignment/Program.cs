using System;

namespace parsingEnumsAssignment
{
    class Program
    {
        //Create an enum for the days of the week.
        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            bool isValid = false;
            while (!isValid)
            {
                try
                {
                    //Prompt the user to enter the current day of the week.
                    Console.WriteLine("Enter the current day of the week");
                    string dayinput = Console.ReadLine();
                    //Assign the value to a variable of that enum data type you just created.
                    DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), dayinput);
                    Console.WriteLine("Have a nice " + day);
                    Console.ReadLine();
                    isValid = true;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Please enter an actual day of the week");
                }
            }
        }
    }
}
