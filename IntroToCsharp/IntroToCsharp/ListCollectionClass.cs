using System;
using System.Collections.Generic;
using System.Linq;
using static IntroToCsharp.Dictionary;

/*
 List is one of the generic collection classes present in the Systems.Collection.Generic namespace
 Other generic collection classes are -
 1) Dict, 2) List, 3) Stack, 4) Queue
 A list class can be used to create collection of any type
 e.g. we can create a list of integers, strings and even complex types
 objects stored in the list are accessed by indices
 unlike arrays, list can grow in size automatically
 The class also provides methods to search, sort, and manipulate lists.
 */

namespace IntroToCsharp
{
    internal class ListCollectionClass
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

            List <Customr> customers = new List<Customr> { customer1, customer2 };
            customers.Add(customer3);

            // to insert at specific position
            customers.Insert(0, customer3);

            //get the first index of a particular object
            Console.WriteLine(customers.IndexOf(customer3));

            // second parameter is the position from where you wanted the search to start
            Console.WriteLine(customers.IndexOf(customer3, 1));

            // third param is from 2nd param how many objects i wanted to look up , 1, 3 -> (1, 2, 3) -> 3 items,
            // if not present then -1
            // if out of bound then exception
            Console.WriteLine(customers.IndexOf(customer3, 1, 3));

            //foreach(Customr cust in customers)
            for(int i = 0; i < customers.Count; i++)
            {
                Customr cust = customers[i];
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
            }

            SavingsCustomr sc = new SavingsCustomr();

            // we can add the derived class objects into the list of parent class object
            customers.Add(sc);


            List<Customr> listCustomers = new List<Customr>();
            listCustomers.Add(customer1);
            listCustomers.Add(customer2);
            listCustomers.Add(customer3);

            // Contains
            if(listCustomers.Contains(customer3))
            {
                Console.WriteLine("Customer3 object exists in the list");
            } else
            {
                Console.WriteLine("Customer3 object doesn't exists in the list");
            }

            // Exists - Checks if an items exists but based on some condition
            if(listCustomers.Exists(cust => cust.Name.StartsWith("P")))
            {
                Console.WriteLine("Customer3 object exists in the list");
            } else
            {
                Console.WriteLine("Customer3 object doesn't exists in the list");
            }

            // Find - Searches for an element that matches the conditions defined by the specified lambda expression and returns the first matching item from the list
            Customr c = listCustomers.Find(cust => cust.Salary >= 5000);
            Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", c.ID, c.Name, c.Salary);

            // FindLast - Searches for an element that matches the conditions defined by specified lambda exp and returns tha last matching item from the list
            Customr c1 = listCustomers.FindLast(cust => cust.Salary >= 5000);
            Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", c1.ID, c1.Name, c1.Salary);

            // FindAll - Returns all the items from the list that match the conditions specified by lambda expression
            List<Customr> customrs = listCustomers.FindAll(cust => cust.Salary >= 5000);

            // FindIndex - Returns the index of the first term, that matches the condition specified by lambda exp.
            //There are 2 other overloads which specifies the range of elements to search, within the list
            int ind = listCustomers.FindIndex(cust => cust.Salary > 5000);
            Console.WriteLine(ind);
            int ind1 = listCustomers.FindIndex(1, cust => cust.Salary >= 5000);
            Console.WriteLine(ind1);
            int ind2 = listCustomers.FindIndex(0, 2, cust => cust.Salary >= 5000);
            Console.WriteLine(ind2);

            // FindLastIndex - Returns the index of last item, that matches the condition specified by lambda exp.
            // There are 2 other overloads which specifies the range of elements to search, within the list
            int index = listCustomers.FindLastIndex(cust => cust.Salary >= 5000);
            Console.WriteLine(index);

            // array -> list - ToList() method
            Customr[] customerArray = new Customr[3];
            customerArray[0] = customer1;
            customerArray[1] = customer2;
            customerArray[2] = customer3;

            List<Customr> listCustomrs = customerArray.ToList();

            // list -> array - ToArray() method

            // list -> dictionary - ToDictionary() method
            Dictionary<int, Customr> dictionary = listCustomers.ToDictionary(cust => cust.ID);
        }
        public class SavingsCustomr: Customr
        {

        }
    }

}
