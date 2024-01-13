using System;

/*
 Every type inherits from System.Object
 Generics make your code type independent, also u get strongly typed nature,also it prevents unnecessary boxing & unboxing
 */

namespace IntroToCsharp
{
    internal class Generics
    {
        public static void Func()
        {
            bool Equal = Calc.AreEqual<string>("AB", "AB");
            //bool Equal = Calc<string>.AreEqual("AB", "AB");
            if (Equal)
            {
                Console.WriteLine("Equal");
            }else
            {
                Console.WriteLine("Not Equal");
            }
        }
    }

    public class Calc /*<T>*/
    {
        //public static bool AreEqual(T val1, T val2)
        public static bool AreEqual <T> (T val1, T val2)
        {
            return val1.Equals (val2);
        }
        /*
        public static bool AreEqual (object Value1, object Value2)
        {
            return Value1 == Value2;
            
            But there are 2 problems here -
            1. At the runtime, the value type (int or structure) needs to be converted to ref (object) type, also called as boxing.
               So this unnecessary boxing and unboxing just for comparison, the performance gonna degraded
            2. Method will no longer be strongly typed e.g. 10, "AB" will be accepted at compile time.
        }
        */
    }
}
