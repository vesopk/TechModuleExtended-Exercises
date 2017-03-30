using System;
using System.Collections.Generic;
using System.Linq;

namespace CottageScraper
{
    class CottageScraper
    {
        public static void Main()
        {
            Dictionary<string, List<int>> logsDictionary = new Dictionary<string, List<int>>();
            var inputLine = Console.ReadLine();
            while (inputLine != "chop chop")
            {
                var inputLineParams = inputLine.Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                var wood = inputLineParams[0];
                var length = int.Parse(inputLineParams[1]);
                Add(logsDictionary, wood, length);
                inputLine = Console.ReadLine();
            }
            var price = 0M;
            var count = 0M;

            foreach (var woods in logsDictionary.Values)
            {
                price += woods.Sum();
                count += woods.Count();
            }
            var pricePermeter = price / count;
            pricePermeter = Math.Round(pricePermeter, 2);

            inputLine = Console.ReadLine();
            var typeOfWoodWanted = inputLine;

            inputLine = Console.ReadLine();
            var lengthRequired = int.Parse(inputLine);

            var usableWoods = logsDictionary[typeOfWoodWanted].Where(x => x > lengthRequired).Sum();
            var usedLogsPrice = usableWoods * pricePermeter;
            usedLogsPrice = Math.Round(usedLogsPrice, 2);

            var unusedLogs = price - usableWoods;
            var unusedLogsPrice = (unusedLogs * pricePermeter) * 0.25M;
            unusedLogsPrice = Math.Round(unusedLogsPrice, 2);

            var totalPrice = unusedLogsPrice + usedLogsPrice;

            Console.WriteLine("Price per meter: ${0:F2}", pricePermeter);
            Console.WriteLine("Used logs price: ${0:F2}", usedLogsPrice);
            Console.WriteLine("Unused logs price: ${0:F2}", unusedLogsPrice);
            Console.WriteLine("CottageScraper subtotal: ${0:F2}", totalPrice);

        }

        private static void Add(Dictionary<string, List<int>> logsDictionary, string wood, int length)
        {
            if (!logsDictionary.ContainsKey(wood))
            {
                logsDictionary[wood] = new List<int>();
            }
            logsDictionary[wood].Add(length);
        }
    }
}
