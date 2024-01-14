using System;
using System.Collections.Generic;
using System.Linq;

/*
 A dict is a collection of (key, value) pairs
 Dictionary class is present in System.Collections.Generic namespace
 When creating a dict, we need to specify the type for key and value
 Keys in dict must be unique
 */

namespace IntroToCsharp
{
    internal class Dictionary
    {
        public static void Func()
        {
            Customr customer1 = new Customr()
            {
                ID = 101,
                Name = "Mark",
                Salary = 5000
            };
            Customr customer2 = new Customr()
            {
                ID = 110,
                Name = "Pam",
                Salary = 6500
            };
            Customr customer3 = new Customr()
            {
                ID = 119,
                Name = "John",
                Salary = 3500
            };

            Dictionary<int, Customr> dictionaryCustomers = new Dictionary<int, Customr>();
            dictionaryCustomers.Add(customer1.ID, customer1);
            dictionaryCustomers.Add(customer2.ID, customer2);
            dictionaryCustomers.Add(customer3.ID, customer3);

            if (dictionaryCustomers.ContainsKey(135))
            {
                Customr cust = dictionaryCustomers[135];
                // apply this condition, else keynotfound exception
            }

            Customr customer119 = dictionaryCustomers[119];

            Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", customer119.ID, customer119.Name, customer119.Salary);

            //foreach (var customerKeyValuePair in dictionaryCustomers)
            foreach (KeyValuePair<int, Customr> customerKeyValuePair in dictionaryCustomers)
            {
                Console.WriteLine("Key = {0}", customerKeyValuePair.Key);
                Customr cust = customerKeyValuePair.Value;
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
                Console.WriteLine("----------------------------------------------------------");
            }

            foreach(int key in dictionaryCustomers.Keys)
            {
                Console.WriteLine(key);
            }

            foreach(Customr cust in dictionaryCustomers.Values)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
                Console.WriteLine("----------------------------------------------------------");
            }

            //TryGetValue
            Customr cstmr;
            if(dictionaryCustomers.TryGetValue(101, out cstmr))
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cstmr.ID, cstmr.Name, cstmr.Salary);
            } else
            {
                Console.WriteLine("The key is not found!");
            }

            //Count
            Console.WriteLine("Total Items = {0}", dictionaryCustomers.Count);

            // use System.Linq to use Count as a function
            Console.WriteLine("Total Items = {0}", dictionaryCustomers.Count(kvp => kvp.Value.Salary > 4000));

            // Remove
            // even if key is not present then no exception
            dictionaryCustomers.Remove(999);

            // Clear - remove everything, all key, values

            /*
            Customr[] customers = new Customr[3];
            customers[0] = customer1;
            customers[1] = customer2;
            customers[2] = customer3;
            */

            List<Customr> customers = new List<Customr>();
            customers.Add(customer1);
            customers.Add(customer2);
            customers.Add(customer3);

            Dictionary <int, Customr> dict = customers.ToDictionary(cust => cust.ID, cust => cust);

            foreach(KeyValuePair<int, Customr> kvp in dict)
            {
                Console.WriteLine("Key = {0}", kvp.Key);
                Customr cust = kvp.Value;
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
            }
        }
        public class Customr
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public int Salary { get; set; }
        }
    }
}
