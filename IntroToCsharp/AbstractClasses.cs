using System;

/*
 abstract class is an incomplete class and hence can't be instantiated
 abstract class can only be used as a base class
 abstract class can't be sealed coz abstract & sealed contradict each other
 abstract method can't have an implementation
 the class that is inheriting the abstract class must provide the implementation of all its abstract methods (if its not marked as abstract)
 if the inherited class doesn't wish to provide the implementation, then it should also be marked as abstract
 abstract class may contain abstract members but its not mandatory
 abstract class ref variable can point to derived class obj
 a class can have all members implemented and still be abstract
 */

namespace IntroToCsharp
{
    public abstract class C1
    {
        public abstract void Print();
    }
    internal class AbstractClasses : C1
    {
        public override void Print()
        {
            Console.WriteLine("Print");
        }
        public static void Func()
        {
            AbstractClasses P = new AbstractClasses();
            P.Print();

            C1 P1 = new AbstractClasses();
            P1.Print();
        }
    }
}
