using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToCsharp
{
    internal class ReadingAndWriting
    {
        public void func()
        {
            Console.WriteLine("Please enter your first name");
            string UserName = Console.ReadLine();
            Console.WriteLine("Hello {0}", UserName);

            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num);
        }
    }
}
