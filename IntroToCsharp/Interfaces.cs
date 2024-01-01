using System;

/*
interface members can't have a definition, they can only have declaration
on the interface members you can't have access modifiers, they are public by default
interface can't contain fields - int ID; etc
if a class is inheriting a interface then it should provide the implementation of all interface members, else compiler error
a class can inherit from multiple interfaces at the same time
interfaces can inherit from other interfaces. A class that inherits this interface must provide implementation of all interface members in the entire interface inheritance chain
we can't create an instance of an interface but an interface ref variable can point to derived class obj
*/

namespace IntroToCsharp
{
    interface ICustomer1
    {
        /*
        interface members can't have definition, they can only have declaration
        void Print()
        {
            Console.WriteLine("Hello");
        }
        */

        //public void Print();  Not possible - interface members can't have access modifiers, they are public by default
        void Print1();

    }

    interface ICustomer2 : ICustomer1
    {
        void Print2();
    }

    class CustomerClass : ICustomer2
    {
        public void Print2()
        {
            Console.WriteLine("Print2");
        }

        //Signature of the method in Class must match with that of Interface, can't write - Print(int Name)
        // Also use the access modifier in the class
        public void Print1()
        {
            Console.WriteLine("Print1");
        }
    }
    internal class Interfaces
    {
        public void Func()
        {
            CustomerClass C1 = new CustomerClass();
            ICustomer1 Cust = new CustomerClass();
            Cust.Print1();
        }
    }
}
