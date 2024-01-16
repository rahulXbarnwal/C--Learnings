using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToCsharp
{
    internal class Assignment_2
    {
        public static void Func()
        {
            //FibonacciSeries();
            //ReverseString();
            //SortArray();
            double ans = PerformOperation(2, 4, "add");
            Console.WriteLine(ans);
        }
        public static void FibonacciSeries()
        {
            Console.WriteLine("Enter the length of fibonacci series: ");
            int n = Convert.ToInt32(Console.ReadLine());
            List<int> series = new List<int>() { 0, 1};
            int prev = 0, curr = 1;
            for(int i = 2; i < n; i++)
            {
                int sum = prev + curr;
                series.Add(sum);
                prev = curr;
                curr = sum;
            }
            for (int i = 0; i < n; i++) Console.Write(series[i] + " ");
            Console.WriteLine();
        }
        public static void ReverseString()
        {
            Console.WriteLine("Enter the string: ");
            string s = Console.ReadLine(), reversedS = String.Empty;
            int i = s.Length - 1;
            while(i >= 0) reversedS += s[i--];
            Console.WriteLine(reversedS);
        }
        public static void SortArray()
        {
            Console.WriteLine("Enter the size of the array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the elements of array: ");

            List <int> list = new List<int>();
            for(int i = 0; i < n; i++)
            {
                int elem = Convert.ToInt32(Console.ReadLine());
                list.Add(elem);
            }
            list.Sort();
            foreach (int num in list) Console.Write(num + " ");
            Console.WriteLine();
        }

        public static double PerformOperation(double operand1, double operand2, string operation)
        {
            double result = 0;

            switch (operation.ToLower())
            {
                case "add":
                    result = Add(operand1, operand2);
                    break;
                case "subtract":
                    result = Subtract(operand1, operand2);
                    break;
                case "divide":
                    result = Divide(operand1, operand2);
                    break;
                default:
                    Console.WriteLine("Invalid operation type.");
                    break;
            }

            return result;
        }

        static double Add(double a, double b)
        {
            return a + b;
        }

        static double Subtract(double a, double b)
        {
            return a - b;
        }

        static double Divide(double a, double b)
        {
            if (b != 0)
            {
                return a / b;
            }
            else
            {
                Console.WriteLine("Cannot divide by zero.");
                return double.NaN;
            }
        }
    }
}
