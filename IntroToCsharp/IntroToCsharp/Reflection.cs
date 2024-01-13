using System;
using System.Reflection;

/*
 Reflection is ability to inspect an assembly's metadata at runtime
 Every type in .net inherits from System.Object, hence it adds additional methods
 */

namespace IntroToCsharp
{
    internal class Reflection
    {
        public static void Func()
        {
            //Type T = Type.GetType("IntroToCsharp.ClassOfCustomer");

            //Type T = typeof(ClassOfCustomer);

            ClassOfCustomer C1 = new ClassOfCustomer();
            Type T = C1.GetType();

            Console.WriteLine("Full Name = {0}", T.FullName);
            Console.WriteLine("Just the Name = {0}", T.Name);
            Console.WriteLine("Just the NameSpace = {0}", T.Namespace);
            Console.WriteLine();

            Console.WriteLine("Properties in ClassOfCustomers");
            PropertyInfo[] properties = T.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.PropertyType.Name + " " + property.Name);
            }
            Console.WriteLine();

            Console.WriteLine("Methods in ClassOfCustomers");
            MethodInfo[] methods = T.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.ReturnType.Name + " " + method.Name);
            }
            Console.WriteLine();

            Console.WriteLine("Constructors in ClassOfCustomers");
            ConstructorInfo[] constructors = T.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.ToString());
            }
        }
    }
    public class ClassOfCustomer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ClassOfCustomer(int ID, string Name)
        {
            this.Id = ID;
            this.Name = Name;
        }
        public ClassOfCustomer() 
        {
            this.Id = -1;
            this.Name = string.Empty;
        }
        public void PrintID()
        {
            Console.WriteLine("ID = {0}", Id);
        }
        public void PrintName() 
        {
            Console.WriteLine("Name = {0}", Name);
        }
    }
}
