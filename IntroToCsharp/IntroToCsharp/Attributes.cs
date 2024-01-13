using System;
using System.Collections.Generic;

/*
 Attributes allow you to add declarative info to your programs. This info can then be queried at runtime using reflection
 e.g. Obsolete - Marks type & type members outdated
      WebMethod -To expose a method as XML Web Service method
      Serializable - Indicates that a class can be serialized
 It's possible to customize the attribute using params
 An attribute is a class that inherits from System.Attribute base class
 */

namespace IntroToCsharp
{
    internal class Attributes
    {
        public static void Func()
        {
            Calculator.Add(new List<int>() { 10, 20, 30});
        }
    }
    public class Calculator
    {
        [ObsoleteAttribute("Use Add(List <int> Numbers) Method")]
        public static int Add(int FN, int SN)
        {
            return FN + SN;
        }
        public static int Add(List <int> Numbers)
        {
            int Sum = 0;
            foreach(int i in Numbers)
            {
                Sum += i;
            }
            return Sum;
        }
    }
}
