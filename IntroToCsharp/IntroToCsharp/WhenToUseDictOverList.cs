using System;
using System.Collections.Generic;

/*
 Find() method in the List class loops thru each object in the list until a match is found.
 So if you want to lookup a value using a key, dict is better for performance over a list. 
 So use dict if you know the collection will be primarily used for lookups.
 */

namespace IntroToCsharp
{
    internal class WhenToUseDictOverList
    {
        public static void Func()
        {
            Country country1 = new Country() { Code = "AUS", Name = "AUSTRALIA", Capital = "Canberra" };
            Country country2 = new Country() { Code = "IND", Name = "INDIA", Capital = "New Delhi" };
            Country country3 = new Country() { Code = "USA", Name = "UNITED STATES", Capital = "Washington D.C." };
            Country country4 = new Country() { Code = "GBR", Name = "UNITED KINGDOM", Capital = "London" };
            Country country5 = new Country() { Code = "CAN", Name = "CANADA", Capital = "Ottawa" };

            /*
            List<Country> listCountries = new List<Country>();
            listCountries.Add(country1);
            listCountries.Add(country2);
            listCountries.Add(country3);
            listCountries.Add(country4);
            listCountries.Add(country5);
            */

            Dictionary<string, Country> dictionaryCountries = new Dictionary<string, Country>();
            dictionaryCountries.Add(country1.Code, country1);
            dictionaryCountries.Add(country2.Code, country2);
            dictionaryCountries.Add(country3.Code, country3);
            dictionaryCountries.Add(country4.Code, country4);
            dictionaryCountries.Add(country5.Code, country5);

            string strUserChoice = string.Empty;

            do
            {
                Console.WriteLine("Please enter country code: ");
                string strCountryCode = Console.ReadLine().ToUpper();

                //Country resultCountry = listCountries.Find(country => country.Code == strCountryCode);

                Country resultCountry = dictionaryCountries.ContainsKey(strCountryCode) ? dictionaryCountries[strCountryCode] : null;

                if (resultCountry == null)
                {
                    Console.WriteLine("Country code is not valid");
                }
                else
                {
                    Console.WriteLine("Name = {0}, Capital = {1}", resultCountry.Name, resultCountry.Capital);
                }
                do
                {
                    Console.WriteLine("Do you want to continue - YES or NO?");
                    strUserChoice = Console.ReadLine().ToUpper();
                } while (strUserChoice != "YES" && strUserChoice != "NO");
            } while(strUserChoice == "YES");
        }
    }
    public class Country
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Capital { get; set; }
    }
}
