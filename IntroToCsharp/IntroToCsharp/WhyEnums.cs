using System;

/*
 Enums are strongly typed constants
 If a program uses set of integral numbers, consider replacing them with enums. Otherwise the program becomes less Readable & Maintainable
 */

namespace IntroToCsharp
{
    internal class WhyEnums
    {
        public static void Func()
        {
            Cust[] customers = new Cust[3];
            customers[0] = new Cust
            {
                Name = "Mark",
                Gender = 1
            };
            customers[1] = new Cust
            {
                Name = "Mary",
                Gender = 2
            };
            customers[2] = new Cust
            {
                Name = "Sam",
                Gender = 0
            };

            foreach(Cust customer in customers)
            {
                Console.WriteLine("Name = {0} and Gender = {1}", customer.Name, GetGender(customer.Gender));
            }
        }
        public static string GetGender(int gender)
        {
            switch (gender)
            {
                case 0:
                    return "Unknown";
                case 1:
                    return "Male";
                case 2:
                    return "Female";
                default:
                    return "Invalid data detected";
            }
        }
    }
    //0 - Unknown
    //1 - Male
    //2 - Female
    public class Cust
    {
        public string Name { get; set; }
        public int Gender { get; set; }
    }
}
