using System;

/*
 A Multicast delegate has a ref to more than one func. When it is invoked, all the functions it is pointing to, are invoked
 + or += to register a method with the delegate
 - or -= to un-register a method with the delegate
 A multicase delegate, invokes the methods in the invocation list, in the same order in which they are added
 If the delegate has a ret type other than void and if the delegate is a multicast, only the value of last invoked method will be returned.
 Along the same lines if the delegate has an out param, the value of the out param, will be value assigned by last method

 Where do you use Multicast Delegates -
 It makes implementation of observer design pattern very simple. Observer pattern is also called as publish/subscribe pattern
 */

namespace IntroToCsharp
{
    //public delegate void SampleDelegate();
    //public delegate int SampleDelegate();
    public delegate void SampleDelegate(out int Integer);
    internal class MulticastDelegates
    {
        public static void Func()
        {
            /*
            SampleDelegate del1, del2, del3, del4;

            del1 = new SampleDelegate(SampleMethodOne);
            del2 = new SampleDelegate(SampleMethodTwo);
            del3 = new SampleDelegate(SampleMethodThree);

            del4 = del1 + del2 + del3;
            // del4 = del1 + del2 + del3 - del2;
            del4();
            */

            /*
            SampleDelegate del = new SampleDelegate(SampleMethodOne);
            del += SampleMethodTwo;
            del += SampleMethodThree;
            del -= SampleMethodOne;

            del();
            */

            /*
            SampleDelegate del = new SampleDelegate(SampleMethodOne);
            del += SampleMethodTwo;

            int DelegateReturnedValue = del();
            Console.WriteLine(DelegateReturnedValue);
            */

            
            SampleDelegate del = new SampleDelegate(SampleMethodOne);
            del += SampleMethodTwo;

            int DelegateOutputParamValue = -1;
            del(out DelegateOutputParamValue);
            
            Console.WriteLine(DelegateOutputParamValue);
        }

        /*
        public static void SampleMethodOne()
        {
            Console.WriteLine("SampleMethodOne Invoked");
        }
        */

        /*
        public static int SampleMethodOne()
        {
            return 1;
        }
        */

        public static void SampleMethodOne(out int Number)
        {
            Number = 1;
        }

        /*
        public static void SampleMethodTwo()
        {
            Console.WriteLine("SampleMethodTwo Invoked");
        }
        */

        /*
        public static int SampleMethodTwo()
        {
            return 2;
        }
        */

        public static void SampleMethodTwo(out int Number)
        {
            Number = 2;
        }
        public static void SampleMethodThree()
        {
            Console.WriteLine("SampleMethodThree Invoked");
        }
    }
}
