using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToCsharp
{
    internal class SomeUsefulMethodsOfListCollectionClass
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
                ID = 103,
                Name = "John",
                Salary = 7000
            };
            Custmr customer3 = new Custmr()
            {
                ID = 102,
                Name = "Ken",
                Salary = 5500
            };

            List<Custmr> listCustomers = new List<Custmr> (100);
            listCustomers.Add(customer1);
            listCustomers.Add(customer2);
            listCustomers.Add(customer3);

            // TrueForAll()
            Console.WriteLine("Are all salaries greater than 3000 = " +
                listCustomers.TrueForAll(x => x.Salary > 3000));

            // AsReadOnly()
            ReadOnlyCollection <Custmr> readOnlyCustomers = listCustomers.AsReadOnly();
            Console.WriteLine("Items = " + readOnlyCustomers.Count);

            // TrimExcess() - sets the capacity to the actual no. of elements in the list, if that number is less than a threshold value - 90%
            Console.WriteLine("Capacity before trimming = " + listCustomers.Capacity);
            listCustomers.TrimExcess();
            Console.WriteLine("Capacity after trimming = " + listCustomers.Capacity);
        }
    }
}
