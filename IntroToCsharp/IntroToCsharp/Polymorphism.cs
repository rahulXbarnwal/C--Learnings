using System;

//Polymorphism enables us to invoke derived class methods using base class reference variable during Run-Time

namespace IntroToCsharp
{
    public class Emp
    {
        public string FirstName = "FN", LastName = "LN";
        public virtual void PrintFullName ()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }
    public class PartTimeEmp : Emp
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + " - Part Time");
        }
    }
    public class FullTimeEmp : Emp
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + " - Full Time");
        }
    }
    public class TemporaryEmp : Emp
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + " - Temporary Time");
        }
    }
    internal class Polymorphism
    {
        public void Func()
        {
            Emp[] employee = new Emp[4];
            employee[0] = new Emp();
            employee[1] = new PartTimeEmp();
            employee[2] = new FullTimeEmp();
            employee[3] = new TemporaryEmp();

            foreach(Emp e in employee)
            {
                e.PrintFullName();
            }
        }
    }
}
