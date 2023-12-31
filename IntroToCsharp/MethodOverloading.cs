using System;

/*
 Method Overloading allows a class to have multiple methods with same name but diff signatures
 Signature - name of method, type, kind(value, ref, output) and no. of formal params
 Sign doesn't include the return type and params modifier
*/

namespace IntroToCsharp
{
    internal class MethodOverloading
    {
        public static void Func()
        {
            Add(2, 3);
        }
        public static void Add (int FN, int SN)
        {
            Console.WriteLine(FN + SN);
        }
        public static void Add(int FN, double SN)
        {
            Console.WriteLine(FN + SN);
        }
        public static void Add(int FN, int SN, int TN)
        {
            Console.WriteLine(FN + SN + TN);
        }

        /*
        Can't do this
        public static void Add(int FN, int SN, params int[] TN)
        {
            Console.WriteLine(FN + SN);
        }
        public static void Add(int FN, int SN, int[] TN)
        {
            Console.WriteLine(FN + SN);
        }
        */
    }
}
