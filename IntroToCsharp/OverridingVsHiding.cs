using System;

/*
In MethodOverriding:
    A base class ref variable pointing to a child class object will invoke overriden method in child class

In MethodHiding:
    A base class ref variable pointing to a child class object will invoke hidden method in the base class
*/

namespace IntroToCsharp
{
    public class BaseClass
    {
        public virtual void Print()
        {
            Console.WriteLine("I am a Base Class Print Method");
        }
    }

    public class DerivedClass : BaseClass
    {
        public override void Print()
        {
            Console.WriteLine("I am a Derived Class Print Method");
        }
        /* 
        public new void Print()
        {
            Console.WriteLine("I am a Derived Class Print Method");
        } 
        */
    }
    internal class OverridingVsHiding
    {
        public void Func()
        {
            BaseClass B = new DerivedClass();
            B.Print();
        }
    }
}
