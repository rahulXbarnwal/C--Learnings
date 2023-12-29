using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToCsharp
{
    class Customer
    {
        string _firstName;
        string _lastName;

        public Customer() : this("No FirstName Provided", "No LastName Provided")
        {

        }
        public Customer(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }
        public void PrintFullName()
        {
            Console.WriteLine("Full Name = {0}", this._firstName + " " +  this._lastName);
        }

        ~Customer()
        {
            // Clean Up Code
        }
    }
    internal class IntroToClasses
    {
        public void SomeFunction()
        {
            Customer C1 = new Customer();
            C1.PrintFullName();
        }
    }
}
