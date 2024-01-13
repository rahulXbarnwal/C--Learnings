using System;

/*
 A explicit cast is needed to convert from enum type to integral type and vice versa.
 Also, an enum of one type can't be implicitly assigned to enum of another type even though the underlying value of their members are same
 The default underlying type of enum is int
 Enums are value types
 */

namespace IntroToCsharp
{
    internal class Enums
    {
        public static void Func()
        {
            //Gender_ gender = (Gender_)3;
            //int Num = (int)Gender_.Unknown;

            Gender_ gender = (Gender_)Season.Winter;

            /*
            short[] Values = (short[])Enum.GetValues(typeof(Gender_));
            foreach (short value in Values)
            {
                Console.WriteLine(value);
            }

            string[] Names = Enum.GetNames(typeof(Gender_));
            foreach (string name in Names)
            {
                Console.WriteLine(name);
            }
            */
        }
    }
    public enum Gender_
    {
        Unknown = 1,
        Male,
        Female
    }
    public enum Season
    {
        Winter = 1,
        Spring,
        Summer
    }
}
