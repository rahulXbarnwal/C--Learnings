using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToCsharp
{
    internal class TypeConversion
    {
        public void func()
        {
            string str = "100T";
            //int num = Convert.ToInt32(str);
            //int num = int.Parse(str);

            int num;
            bool res = int.TryParse(str, out num);
            Console.WriteLine(num);
        }
    }
}
