using System;
using System.IO;

/*
 An exception is an unforeseen error that occurs when a program is running
 An exception is actually a class that derives from System.Exception class which has several useful properties, that provide valuable info about the exception
 Message will give you the detail of error
 StackTrace will give you the line no. where the exception occured
 Use the most specific exception at the top and general one on the bottom

 finally - Clean and free resources that the class was holding onto during the program execution. Finally block is optional
 Note: It's a good practice to always release resources in finally block, since finally block is guaranteed to execute, irrespective of whether there is an exception or not
 */

namespace IntroToCsharp
{
    internal class ExceptionalHandling
    {
        public static void Func()
        {
            StreamReader streamReader = null;
            try
            {
                streamReader = new StreamReader(@"C:\Sample Files\Data.txt");
                Console.WriteLine(streamReader.ReadToEnd());
                //streamReader.Close();
            }
            catch(FileNotFoundException ex)
            {
                //Console.WriteLine(ex.Message);
                //Console.WriteLine();
                //Console.WriteLine(ex.StackTrace);
                Console.WriteLine("Please check if the file {0} exists", ex.FileName);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if(streamReader != null) streamReader.Close();
                Console.WriteLine("Finally Block");
            }
        }
    }
}
