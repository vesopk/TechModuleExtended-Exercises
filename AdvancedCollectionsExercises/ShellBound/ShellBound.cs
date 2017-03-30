using System;
using System.Collections.Generic;
using System.Linq;
namespace ShellBound
{
    class ShellBound
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var lineData = input.Split(' ').ToArray();
            Dictionary<string,HashSet<long>> shellsDictionary = new Dictionary<string, HashSet<long>>();
            while (input!="Aggregate")
            {
                var city = lineData[0];
                var shellSize = long.Parse(lineData[1]);
                AddShell(shellsDictionary,city,shellSize);
                input = Console.ReadLine();
                lineData = input.Split(' ').ToArray();
            }
            foreach (var shellCitys in shellsDictionary)
            {
                var shellsAverage = shellCitys.Value.Average();
                var shellsSum = shellCitys.Value.Sum();
                var giantShell = Math.Ceiling(shellsSum - shellsAverage);
                Console.WriteLine($"{shellCitys.Key} -> {string.Join(", ",shellCitys.Value)} ({giantShell})");
            }
        }

        private static void AddShell(Dictionary<string, HashSet<long>> shellsDictionary, string city, long shellSize)
        {
            if (!shellsDictionary.ContainsKey(city))
            {
                shellsDictionary[city] = new HashSet<long>();
            }
            shellsDictionary[city].Add(shellSize);
        }
    }
}
