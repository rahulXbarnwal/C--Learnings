using System;

namespace IntroToCsharp
{
    class EmployeeClass
    {
        public string Name
        {
            get; set;
        }
        public int ID
        {
            get; set;
        }
        public virtual void GetEmployeeDetails()
        {
            Console.WriteLine("EmpId: {0}, Name: {1}", Name, ID);
        }
        public void GetEmployeeDetails(string additionalInfo)
        {
            Console.WriteLine("EmpId: {0}, Name: {1}, {2}", Name, ID, additionalInfo);
        }
        public void SomeMethod()
        {
            Console.WriteLine("This is some random method of BASE CLASS");
        }
    }

    class PermanentEmployee : EmployeeClass
    {
        public double Salary
        {
            get; set;
        }
        public override void GetEmployeeDetails()
        {
            base.GetEmployeeDetails();
            Console.WriteLine("Salary: {0}", Salary);
        }

        public new void SomeMethod()
        {
            Console.WriteLine("Method in PERMANENT EMPLOYEE class (hides base class method)");
        }
    }

    class ContractualEmployee : EmployeeClass
    {
        public double HourlyRate
        {
            get; set;
        }
        public override void GetEmployeeDetails()
        {
            base.GetEmployeeDetails();
            Console.WriteLine("Hourly Rate: {0}", HourlyRate);
        }
        public new void SomeMethod()
        {
            Console.WriteLine("Method in CONTRACTUAL EMPLOYEE class (hides base class method)");
        }
    }
    internal class Assignment_1
    {
        public void Func()
        {
            PermanentEmployee permEmployee = new PermanentEmployee();
            permEmployee.ID = 1;
            permEmployee.Name = "Person 1";
            permEmployee.Salary = 50000;

            ContractualEmployee contractEmployee = new ContractualEmployee();
            contractEmployee.ID = 2;
            contractEmployee.Name = "Person 2";
            contractEmployee.HourlyRate = 20.5;

            permEmployee.GetEmployeeDetails();
            permEmployee.GetEmployeeDetails("Love Singing!");
            permEmployee.SomeMethod();
        }
    }
}
