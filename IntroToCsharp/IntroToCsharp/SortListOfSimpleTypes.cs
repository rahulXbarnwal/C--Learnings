using System;
using System.Collections.Generic;

/*
 When you do the same thing on complex type like Customer, we get a runtime invalid operation exception - Failed to compare 2 elements in array.
 .NET runtime doesn't know how to sort complex types. We have to tell the way we want data to be sorted in the list by implementing IComparable interface
 The sort functionality works for simple types, because these types (int, string, decimal, char etc.) have implemented Icomparable interface already.
 */

namespace IntroToCsharp
{
    internal class SortListOfSimpleTypes
    {
        public static void Func()
        {
            List<int> numbers = new List<int>() { 1, 8, 7, 5, 2, 3, 4, 9, 6 };

            Console.WriteLine("Numbers before sorting");
            foreach(int number  in numbers)
            {
                Console.WriteLine(number);
            }

            numbers.Sort();

            Console.WriteLine("Numbers after sorting");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            numbers.Reverse();

            Console.WriteLine("Numbers in descending order");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            List<string> alphabets = new List<string>() { "B", "F", "D", "E", "A", "C" };
            Console.WriteLine("Alphabets before sorting");
            foreach(string alphabet in alphabets)
            {
                Console.WriteLine(alphabet);
            }

            alphabets.Sort();

            Console.WriteLine("Alphabets after sorting");
            foreach (string alphabet in alphabets)
            {
                Console.WriteLine(alphabet);
            }

            alphabets.Reverse();

            Console.WriteLine("Alphabets in descending order");
            foreach (string alphabet in alphabets)
            {
                Console.WriteLine(alphabet);
            }
        }
    }
}
