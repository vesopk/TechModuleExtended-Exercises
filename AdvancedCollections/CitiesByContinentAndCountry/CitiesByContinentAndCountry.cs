using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitiesByContinentAndCountry
{
    class CitiesByContinentAndCountry
    {
        public static void Main()
        {
            var count = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> townDictionary =
                new Dictionary<string, Dictionary<string, List<string>>>();
            for (int i = 0; i < count; i++)
            {
                var lineData = Console.ReadLine().Split(' ');
                var continent = lineData[0];
                var country = lineData[1];
                var city = lineData[2];
                AddTown(townDictionary,continent,country,city);
            }
            foreach (var continent in townDictionary.Keys)
            {
                Console.WriteLine($"{continent}:");
                foreach (var country in townDictionary[continent])
                {
                    Console.WriteLine($"{country.Key} -> {string.Join(", ",country.Value)}");
                }
            }
        }

        private static void AddTown(Dictionary<string, Dictionary<string, List<string>>> townDictionary, string continent, string country, string city)
        {
            if (!townDictionary.ContainsKey(continent))
            {
                townDictionary[continent] = new Dictionary<string, List<string>>();
            }
            if (!townDictionary[continent].ContainsKey(country))
            {
                townDictionary[continent][country] = new List<string>();
            }
            townDictionary[continent][country].Add(city);
        }
    }
}
