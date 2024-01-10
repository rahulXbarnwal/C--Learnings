using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToCsharp
{
    internal class ConvertToStringVSToString
    {
        public static void Func()
        {
            /*
            Random rnd = new Random();
            string str = Convert.ToString(rnd);  -> IntroToCsharp.Random
            string str = rnd.ToString();         -> IntroToCsharp.Random
            Console.WriteLine(str);
            */

            Random rnd = null;
            string str = Convert.ToString(rnd);     // -> handles null & return empty String
            //string str = rnd.ToString();             -> Unhandled NullReference Exception
            Console.WriteLine(str);
        }
    }
    public class Random
    {
        public string Name { get; set; }
    }
}
