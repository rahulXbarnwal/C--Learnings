using System;

/*
Structs are sealed type
Structs are value types but classes are ref Type
Structs are stored in Stack , classes in heap
Structs can't have destructors
Structs can't have explicit parameter less constructor whereas a class can
Struct can't inherit from another class whereas class can, Both struct and class can inherit from interface
A class or struct can't inherit from another struct
*/

namespace IntroToCsharp
{
    public struct CustomerStructure
    {
        private int _id;
        private string _name;
        public string Name { get { return _name; } set { _name = value; } }
        public int ID { get { return _id; } set { _id = value; } } 
        public CustomerStructure(int Id, string Name)
        {
            _id = Id;
            _name = Name;
        }
        public void PrintDetails()
        {
            Console.WriteLine("Id = {0} && Name = {1}", this._id, this._name);
        }
    }
    internal class Structs
    {
        public void Func()
        {
            CustomerStructure C1 = new CustomerStructure(101, "Mark");
            C1.PrintDetails();

            CustomerStructure C2 = new CustomerStructure();
            C2.ID = 102;
            C2.Name = "John";
            C2.PrintDetails();

            // Object Initializer Syntax, It can be used in Classes as well as Structs
            CustomerStructure C3 = new CustomerStructure
            {
                ID = 103,
                Name = "Rob"
            };
            C3.PrintDetails();
        }
    }
}
