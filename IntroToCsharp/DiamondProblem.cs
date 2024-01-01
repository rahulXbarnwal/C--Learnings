using System;

namespace IntroToCsharp
{
    class A
    {
        public virtual void Print()
        {
            Console.WriteLine("Class A Implementation");
        }
    }
    class B : A
    {
        public override void Print()
        {
            Console.WriteLine("Class B Overriding Print() Method");
        }
    }
    class C : A
    {
        public override void Print()
        {
            Console.WriteLine("Class C Overriding Print() Method");
        }
    }
    /*
    class D: B, C
    {

    }
    */
    internal class DiamondProblem
    {
        public static void Func()
        {
            //D d = new D();
            //d.Print();
            // Not sure whose print method to call - either B or C, hence ambiguity arises
            // Hence multiple class inheritance not possible
        }
    }
}
