using System;
using System.Text;

/*
 System.String is immutable
 System.Text.StringBuilder is Mutable - offers better performance 
 */

namespace IntroToCsharp
{
    internal class StringVSStringBuilder
    {
        public static void Func()
        {
            /*
             string userString = "C#";
             userString += " Video";
             userString += " Tutorial";
             userString += " For";
             userString += " Beginners";
             */
            StringBuilder userString = new StringBuilder("C#");
            userString.Append(" Video");
            userString.Append(" Tutorial");
            userString.Append(" For");
            userString.Append(" Beginners");
            Console.WriteLine(userString.ToString());
        }
    }
}
