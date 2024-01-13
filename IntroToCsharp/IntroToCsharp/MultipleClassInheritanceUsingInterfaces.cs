using System;

namespace IntroToCsharp
{
    interface IA
    {
        void AMethod();
    }
    class AClass : IA
    {
        public void AMethod()
        {
            Console.WriteLine("A");
        }
    }
    interface IB
    {
        void BMethod();
    }
    class BClass : IB
    {
        public void BMethod()
        {
            Console.WriteLine("B");
        }
    }
    class AB: IA, IB
    {
        AClass a = new AClass();
        BClass b = new BClass();

        // since the class is inheriting from interfaces, it has to provide the implementation of its methods
        public void AMethod()
        {
            // You don't have to provide the implementation again, you just use the implementation provided by the AClass & BClass 
            a.AMethod();
        }
        public void BMethod()
        {
            b.BMethod();
        }
    }
    internal class MultipleClassInheritanceUsingInterfaces
    {
        public static void Func()
        {
            AB ab = new AB();
            ab.AMethod();
            ab.BMethod();
        }
    }
}
