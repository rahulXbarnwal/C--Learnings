using System;

namespace IntroToCsharp
{
    internal class PreventingExceptionHandlingAbuse
    {
        public static void Func()
        {
            try
            {
                Console.WriteLine("Enter Numerator");
                int Numerator;
                bool IsNumeratorConversionSuccessful = int.TryParse(Console.ReadLine(), out Numerator);

                if (IsNumeratorConversionSuccessful)
                {
                    Console.WriteLine("Enter Denominator");
                    int Denominator;
                    bool IsDenominatorConversionSuccessful = int.TryParse(Console.ReadLine(), out Denominator);

                    if(IsDenominatorConversionSuccessful)
                    {
                        if (Denominator == 0)
                        {
                            Console.WriteLine("Denominator can't be zero");
                        }
                        else
                        {
                            int Result = Numerator / Denominator;
                            Console.WriteLine("Result = {0}", Result);
                        }
                    } else
                    {
                        Console.WriteLine("Denominator should be a valid number between {0} and {1}", Int32.MinValue, Int32.MaxValue);
                    }
                } else
                {
                    Console.WriteLine("Numerator should be a valid number between {0} and {1}", Int32.MinValue, Int32.MaxValue);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
