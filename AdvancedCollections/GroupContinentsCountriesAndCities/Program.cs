using System;
using System.Collections.Generic;

namespace GroupContinentsCountriesAndCities
{
    class Program
    {
        public static void Main()
        {
            var count = int.Parse(Console.ReadLine());
            SortedDictionary<string, SortedDictionary<string, SortedSet<string>>> townDictionary =
                new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();
            for (int i = 0; i < count; i++)
            {
                var lineData = Console.ReadLine().Split(' ');
                var continent = lineData[0];
                var country = lineData[1];
                var city = lineData[2];
                AddTown(townDictionary, continent, country, city);
            }
            foreach (var continent in townDictionary.Keys)
            {
                Console.WriteLine($"{continent}:");
                foreach (var country in townDictionary[continent])
                {
                    Console.WriteLine($"  {country.Key} -> {string.Join(", ", country.Value)}");
                }
            }
        }

        private static void AddTown(SortedDictionary<string, SortedDictionary<string, SortedSet<string>>> townDictionary, string continent, string country, string city)
        {
            if (!townDictionary.ContainsKey(continent))
            {
                townDictionary[continent] = new SortedDictionary<string, SortedSet<string>>();
            }
            if (!townDictionary[continent].ContainsKey(country))
            {
                townDictionary[continent][country] = new SortedSet<string>();
            }
            townDictionary[continent][country].Add(city);
        }
    }
}
