using System;

/*
 When a class inherits from 2 interfaces and both the interfaces have the same method name. 
 How should the class implement the method for both the interfaces -

1. Use Explicit interface implementation technique to solve this problem
2. Note: When a class explicitly implements, an interface member, the interface member can no longer be accessed
   thru class ref variable, but only thru the interface ref variable
3. Access modifiers are not allowed on explicitly implemented interface members

 If you want to make one of the interface method, the default then implement that method normally and the other method
 explicitly. This makes the default method to be accessible thru class instance
 */

namespace IntroToCsharp
{
    interface I1 {
        void InterfaceMethod();
    }
    interface I2 { 
        void InterfaceMethod();
    }
    internal class ExplicitInterfacesImplementation : I1, I2
    {
        /* NET thinks that class has implemented both of the methods
        public void InterfaceMethod() {
            Console.WriteLine("I1 Interface Method");
        } */

        // default implementation
        public void InterfaceMethod() {
            Console.WriteLine("I1 (Default) Interface Method");
        }

        // remove the access modifier and write like this for individual implementation -
        //void I1.InterfaceMethod() { Console.WriteLine("I1 Interface Method"); }
        void I2.InterfaceMethod() { Console.WriteLine("I2 Interface Method"); }  
        public static void Func()
        {
            ExplicitInterfacesImplementation P = new ExplicitInterfacesImplementation();
            /* 
            P.InterfaceMethod();
            Can't do, since there will be ambiguity of whose method to call, hence compile error
            */
            ((I1)P).InterfaceMethod();
            ((I2)P).InterfaceMethod();

            // can also do this
            I1 i1 = new ExplicitInterfacesImplementation();
            I2 i2 = new ExplicitInterfacesImplementation();
            i1.InterfaceMethod();
            i2.InterfaceMethod();

            // default is now I1
            ExplicitInterfacesImplementation P1 = new ExplicitInterfacesImplementation();
            P1.InterfaceMethod();
            ((I2)P).InterfaceMethod();
        }
    }
}
