using System;


namespace AbstractClassAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //In the main method, instantiate an Employee object
            Employee sam = new Employee() { firstName = "Sample", lastName = " Student" };
            //Call the SayName method on the object
            sam.SayName();
            Console.ReadLine();
        }
    }
}
