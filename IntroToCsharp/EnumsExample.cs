using System;

namespace IntroToCsharp
{
    internal class EnumsExample
    {
        public static void Func()
        {
            ClassCustomer[] customers = new ClassCustomer[3];
            customers[0] = new ClassCustomer
            {
                Name = "Mark",
                Gender = Gender.Male
            };
            customers[1] = new ClassCustomer
            {
                Name = "Mary",
                Gender = Gender.Female
            };
            customers[2] = new ClassCustomer
            {
                Name = "Sam",
                Gender = Gender.Unknown
            };

            foreach (ClassCustomer customer in customers)
            {
                Console.WriteLine("Name = {0} and Gender = {1}", customer.Name, GetGender(customer.Gender));
            }
        }
        public static string GetGender(Gender gender)
        {
            switch (gender)
            {
                case Gender.Unknown:
                    return "Unknown";
                case Gender.Male:
                    return "Male";
                case Gender.Female:
                    return "Female";
                default:
                    return "Invalid data detected";
            }
        }
    }

    public enum Gender
    {
        Unknown, 
        Male, 
        Female
    };
    //0 - Unknown
    //1 - Male
    //2 - Female
    public class ClassCustomer
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
    }
}
