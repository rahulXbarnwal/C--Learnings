using System;

// sealed keyword is used before class keyword to avoid inheritance from that class
// e.g. public sealed class Employee {}

//Mutiple Inheritance is not supported , 
//    But Multiple Interface and multi-level Inheritance is supported

namespace IntroToCsharp
{
    public class Employee
    {
        public string FirstName, LastName, Email;
        public void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }

    public class FullTimeEmployee : Employee
    {
        public float YearlySalary;
    }

    public class PartTimeEmployee : Employee
    {
        public float HourlyRate;
    }
    internal class Inheritance
    {
        public void func()
        {
            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.FirstName = "Rahul";
            FTE.LastName = "Barnwal";
            FTE.YearlySalary = 10000000;
            FTE.PrintFullName();

            PartTimeEmployee PTE = new PartTimeEmployee();
            PTE.FirstName = "Pragim";
            PTE.LastName = "Tech";
            PTE.HourlyRate = 5000000;
            PTE.PrintFullName();
        }
    }
}
