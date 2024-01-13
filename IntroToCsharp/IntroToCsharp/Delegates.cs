using System;

/*
 Delegate is a type safe func pointer, it holds a ref(pointer) to a func
 Sign of Delegate must match the sign of func, the delegate points to, otherwise compiler error
 A delegate is similar to class. You can create instance of it, and when u do so, you pass the func name as param to the delegate constructor, and it is to this func the delegate will point to
 */

namespace IntroToCsharp
{
    public delegate void HelloFunctionDelegate(string Message);
    internal class Delegates
    {
        public static void Func()
        {
            HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
            del("Hello from Delegate");
        }
        public static void Hello(string strMessage)
        {
            Console.WriteLine(strMessage);
        }
    }
}
