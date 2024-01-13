using System;

/*
 == checks the reference equality
 .Equals checks for value equality
 reference equality guarantees for value equality but the reverse is not true
 when you want the objects to be comparable in proper way then override the equals 
 */

namespace IntroToCsharp
{
    internal class EqualsOverriding
    {
        public static void Func()
        {
            Info C1 = new Info();
            C1.FirstName = "Rahul";
            C1.LastName = "Barnwal";

            /*
            Info C2 = C1;
            Console.WriteLine(C1 == C2);         True (coz the ref variables are pointing to same object)
            Console.WriteLine(C1.Equals(C2));    True (coz the value of the objects are same)
            */

            Info C2 = new Info();
            C2.FirstName = "Rahul";
            C2.LastName = "Barnwal";

            Console.WriteLine(C1 == C2);
            Console.WriteLine(C1.Equals(C2));
        }
    }
    public class Info
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            if (!(obj is Info)) return false;

            return this.FirstName == ((Info)obj).FirstName
                && this.LastName == ((Info)obj).LastName;
        }
        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode();
        }
    }
}
