using System;
using System.Runtime.InteropServices;

/*
 There are 4 ways that can be used to make method parameters optional
 1. Use params array
 2. Method overloading
 3. Specify parameter defaults (The optional parameter must appear after all the required params)
 4. Use optional attribute that is present in System.Runtime.InteropServices namespace

 A params array must be the last parameter in a formal parameter list.
 */

namespace IntroToCsharp
{
    internal class OptionalParameter
    {
        public static void Func()
        {
            AddNumbers(10, 20);
            AddNumbers(10, 20, new int[] { 30, 40, 50 });
            //Test(1, c: 2);

            //AddNumbers(10, 20, new object[] { 30, 40, 50 });
        }
        public static void AddNumbers(int FN, int SN, [OptionalAttribute] int[] restOfNumbers)
        {
            int res = FN + SN;
            if (restOfNumbers != null)
            {
                foreach (int i in restOfNumbers)
                {
                    res += i;
                }
            }
            Console.WriteLine(res);
        }

        /*
        public static void Test(int a, int b = 10, int c = 20)
        {
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
        }
        public static void AddNumbers(int FN, int SN, int[] restOfNumbers = null)
        {
            int res = FN + SN;
            if (restOfNumbers != null)
            {
                foreach (int i in restOfNumbers)
                {
                    res += i;
                }
            }
            Console.WriteLine(res);
        }
        */

        /*
        public static void AddNumbers(int FN, int SN)
        {
            AddNumbers(FN, SN, null);
        }
        public static void AddNumbers(int FN, int SN, int[] restOfNumbers)
        {
            int res = FN + SN;
            if (restOfNumbers != null)
            {
                foreach (int i in restOfNumbers)
                {
                    res += i;
                }
            }
            Console.WriteLine(res);
        }
        */


        /*
        public static void AddNumbers(int FN, int SN, params object[] restOfNumbers)
        {
            int res = FN + SN;
            if(restOfNumbers != null)
            {
                foreach(int i in restOfNumbers)
                {
                    res += i;
                }
            }
            Console.WriteLine(res);
        }
         */
    }
}
