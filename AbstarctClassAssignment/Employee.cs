using System;
using System.Security.Cryptography.X509Certificates;


namespace AbstractClassAssignment
{
    //Create another class, "Employee" and have it inherit from the Person class
    public class Employee : Person, IQuittable
    {
        public int Id { get; set; }
        //Implement the SayName() method inside of the Employee class
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
        public void Quite(Employee employee)
        {
            Console.WriteLine(" Me ");
        }
    }
}
