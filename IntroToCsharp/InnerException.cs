using System;
using System.IO;

/*
 The InnerException property returns the Exception instance that caused the current exception.
 To retain the original ex pass it to as a parameter to the constructor, of the current ex
 Always check if inner ex is not null before accessing any property of inner exception obj, else you may get Null Ref Ex
 To get the type of InnerEx use GetType() method
 */

namespace IntroToCsharp
{
    internal class InnerException
    {
        public static void Func()
        {
            try
            {
                try
                {
                    Console.WriteLine("Enter First Number");
                    int FN = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Second Number");
                    int SN = Convert.ToInt32(Console.ReadLine());

                    int Result = FN / SN;

                    Console.WriteLine("Result = {0}", Result);
                }
                catch (Exception ex)
                {
                    string filePath = @"C:\Sample Files\Data1.txt";
                    if (File.Exists(filePath))
                    {
                        StreamWriter sw = new StreamWriter(filePath);
                        sw.Write(ex.GetType().Name);
                        sw.WriteLine();
                        sw.Write(ex.Message);
                        sw.Close();
                        Console.WriteLine("There is a Problem, Please try later");
                    }
                    else
                    {
                        throw new FileNotFoundException(filePath + "is not present", ex);
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("Current Exception = {0}", exception.GetType().Name);
                if (exception.InnerException != null)
                {
                    Console.WriteLine("Inner Exception = {0}", exception.InnerException.GetType().Name);
                }
            }
        }
    }
}
