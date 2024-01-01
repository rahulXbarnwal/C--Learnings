using System;
using System.Collections.Generic;

namespace IntroToCsharp
{
    delegate bool IsPromotable(Empl emp);
    class Empl
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }
        public static void PromoteEmployee(List <Empl> employeeList, IsPromotable IsEligibleToPromote)
        {
            foreach(Empl employee in employeeList)
            {
                //if(employee.Experience >= 5)
                if (IsEligibleToPromote(employee))
                {
                    Console.WriteLine(employee.Name + " promoted");
                }
            }
        }
    }
    internal class DelegatesUsage
    {
        public static void Func()
        {
            List <Empl> empList = new List <Empl>();
            empList.Add(new Empl() { ID = 101, Name = "Mary", Salary = 5000, Experience = 5 });
            empList.Add(new Empl() { ID = 102, Name = "Mike", Salary = 4000, Experience = 4 });
            empList.Add(new Empl() { ID = 103, Name = "John", Salary = 6000, Experience = 6 });
            empList.Add(new Empl() { ID = 104, Name = "Todd", Salary = 3000, Experience = 3 });

            IsPromotable isPromotable = new IsPromotable(Promote);

            Empl.PromoteEmployee(empList, isPromotable);

            /*
             Using Lambda Exp - No need to use delegate
             Empl.PromoteEmployee(empList, emp => emp.Experience >= 5);
             */
        }   
        public static bool Promote(Empl emp) {
            if (emp.Experience >= 5) return true;
            else return false;
        }
    }
}
