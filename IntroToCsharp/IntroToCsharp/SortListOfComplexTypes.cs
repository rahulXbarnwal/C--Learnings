using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 When you don't own the class code, but you want to change the default sort functionality, 
 then you can provide your own , by implementing IComparer interface. 
 e.g. if i want the customers to sorted by name instead of salary

 Step 1: Implement Comparer Interface 
 Step 2: Pass an instance of the class that implements IComparer interface, as an argument to Sort() method
 */

namespace IntroToCsharp
{
    internal class SortListOfComplexTypes
    {
        public static void Func()
        {
            Custmr customer1 = new Custmr()
            {
                ID = 101,
                Name = "Mark",
                Salary = 4000
            };
            Custmr customer2 = new Custmr()
            {
                ID = 102,
                Name = "Pam",
                Salary = 7000
            };
            Custmr customer3 = new Custmr()
            {
                ID = 103,
                Name = "Rob",
                Salary = 5500
            };

            List<Custmr> listCustomers = new List<Custmr>() { customer1, customer2, customer3};

            Console.WriteLine("Before Sorting");
            foreach(Custmr c in  listCustomers)
            {
                Console.WriteLine(c.Salary);
            }

            listCustomers.Sort(); // will build successfully, but at runtime - InvalidOperationException
            listCustomers.Reverse();
            Console.WriteLine("After Sorting");
            foreach (Custmr c in listCustomers)
            {
                Console.WriteLine(c.Salary);
            }

            // using custom sorting method
            SortByName sortByName = new SortByName();
            listCustomers.Sort(sortByName);

            Console.WriteLine("Sorting by Name");
            foreach (Custmr c in listCustomers)
            {
                Console.WriteLine(c.Name);
            }

            // using overloaded version of sort accepting delegate as parameter
            Comparison<Custmr> customerComparer = new Comparison<Custmr>(CompareCustomer);

            Console.WriteLine("Before Sorting");
            foreach (Custmr c in listCustomers)
            {
                Console.WriteLine(c.ID);
            }

            listCustomers.Sort(customerComparer);

            listCustomers.Sort(delegate (Custmr c1, Custmr c2) { return c1.ID.CompareTo(c2.ID); });

            listCustomers.Sort((x, y) =>  x.ID.CompareTo(y.ID) );

            Console.WriteLine("After Sorting");
            foreach (Custmr c in listCustomers)
            {
                Console.WriteLine(c.ID);
            }
        }
        private static int CompareCustomer(Custmr x, Custmr y)
        {
            return x.ID.CompareTo(y.ID);
        }
    }
    public class SortByName : IComparer<Custmr>
    {
        public int Compare(Custmr x, Custmr y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
    public class Custmr: IComparable<Custmr>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set;}
        public int CompareTo(Custmr other)
        {
            /*
            if (this.Salary > other.Salary) return 1;
            else if (this.Salary < other.Salary) return -1;
            return 0;
            */

            return this.Salary.CompareTo(other.Salary);
        }
    }
}
