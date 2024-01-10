using System;
using System.Reflection;

/*
 Early Binding can flag errors at compile time. With late binding there's a risk of run time exceptions
 Early Binding is much better for performance and should always preferred. 
 Use Late Binding only when working with an objects that are not available at compile time.
 */

namespace IntroToCsharp
{
    internal class LateBinding
    {
        public static void Func()
        {
            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            Type customerType = executingAssembly.GetType("IntroToCsharp.Person");
            object customerInstance = Activator.CreateInstance(customerType);
            MethodInfo getFullNameMethod = customerType.GetMethod("GetFullName");

            string[] parameters = new string[2];
            parameters[0] = "Rahul";
            parameters[1] = "Barnwal";

            string fullName = (string)getFullNameMethod.Invoke(customerInstance, parameters);
            Console.WriteLine(fullName);
        }
    }
    public class Person
    {
        public string GetFullName(string FirstName, string LastName)
        {
            return FirstName + " " + LastName;
        }
    }
}
