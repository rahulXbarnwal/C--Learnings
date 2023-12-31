using System;

namespace IntroToCsharp
{
    public class ClassEmployee
    {
        public string FirstName, LastName;
        public void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }

    public class ClassPartTimeEmployee : ClassEmployee
    {

    }
    public class ClassFullTimeEmployee : ClassEmployee
    {
        public new void PrintFullName()
        {
            base.PrintFullName();
            Console.WriteLine(FirstName + " " + LastName + " - Contractor");
        }
    }
    internal class MethodHiding
    {
        public void Func()
        {
            ClassFullTimeEmployee FTE = new ClassFullTimeEmployee();
            FTE.FirstName = "FullTime";
            FTE.LastName = "Employee";
            FTE.PrintFullName();

            ClassPartTimeEmployee PTE = new ClassPartTimeEmployee();
            PTE.FirstName = "PartTime";
            PTE.LastName = "Employee";
            ((ClassEmployee)PTE).PrintFullName();

            //ClassPartTimeEmployee PTE = new ClassEmployee();
            //Not possible, since object of ClassEmployee can't fulfill all responsibilities of PartTimeEmployee

            //A parent class reference variable can point to child class object
            //but a child class reference variable can't point to parent class object
        }
    }
}
