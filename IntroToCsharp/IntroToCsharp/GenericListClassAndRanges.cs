using System;
using System.Collections.Generic;

namespace IntroToCsharp
{
    internal class GenericListClassAndRanges
    {
        public static void Func()
        {
            Cstmr customer1 = new Cstmr()
            {
                ID = 101,
                Name = "Mark",
                Salary = 4000,
                Type = "RetailCustomer"
            };
            Cstmr customer2 = new Cstmr()
            {
                ID = 102,
                Name = "Pam",
                Salary = 7000,
                Type = "RetailCustomer"
            };
            Cstmr customer3 = new Cstmr()
            {
                ID = 103,
                Name = "Rob",
                Salary = 5500,
                Type = "RetailCustomer"
            };
            Cstmr customer4 = new Cstmr()
            {
                ID = 104,
                Name = "John",
                Salary = 6500,
                Type = "CorporateCustomer"
            };
            Cstmr customer5 = new Cstmr()
            {
                ID = 105,
                Name = "Sam",
                Salary = 3500,
                Type = "CorporateCustomer"
            };

            List<Cstmr> listCustomers = new List<Cstmr>();
            listCustomers.Add(customer1);
            listCustomers.Add(customer2);
            listCustomers.Add(customer3);

            List<Cstmr> listCorporateCustomers = new List<Cstmr>();
            listCorporateCustomers.Add(customer4);
            listCorporateCustomers.Add(customer5);

            // AddRange
            listCustomers.AddRange(listCorporateCustomers);

            // GetRange
            List<Cstmr> cstmrs = listCustomers.GetRange(1, 3);

            // InsertRange
            listCustomers.InsertRange(0, listCorporateCustomers);

            // RemoveAt(index)
            listCustomers.RemoveAt(4);

            // RemoveAll(lambda exp)
            listCustomers.RemoveAll(c => c.Type == "CorporateCustomer");

            // RemoveRange(from index, count)
            listCustomers.RemoveRange(3, 2);
        }

    }
    public class Cstmr
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Type { get; set; }
    }
}
