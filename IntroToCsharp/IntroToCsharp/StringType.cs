using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToCsharp
{
    internal class StringType
    {
        public void func()
        {
            string Name = "Rahul\nBarnwal";
            Console.WriteLine(Name);

            //string path = "C:\\Rahul\\Barnwal";
            //@ -> Verbatim Literal -> as it is

            string path = @"C:\Rahul\Barnwal";
            Console.WriteLine(path);
        }
    }
}
