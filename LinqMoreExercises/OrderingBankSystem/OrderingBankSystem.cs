using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderingBankSystem
{
    class OrderingBankSystem
    {
        public static void Main()
        {
            Dictionary<string,Dictionary<string,decimal>> balanceDictionary = new Dictionary<string, Dictionary<string, decimal>>();
            var inputData = Console.ReadLine();

            while (inputData!="end")
            {
                var inputDataParams = inputData.Split(new[] {' ', '-', '>'}, StringSplitOptions.RemoveEmptyEntries);
                var bank = inputDataParams[0];
                var user = inputDataParams[1];
                var money = decimal.Parse(inputDataParams[2]);
                if (!balanceDictionary.ContainsKey(bank))
                { 
                    balanceDictionary.Add(bank,new Dictionary<string, decimal>());
                }

                if (!balanceDictionary[bank].ContainsKey(user))
                {
                    balanceDictionary[bank].Add(user,0);
                }

                    balanceDictionary[bank][user] += money; 

                inputData = Console.ReadLine();
            }
            balanceDictionary
                .OrderByDescending(bank => bank.Value.Sum(account => account.Value))
                .ThenByDescending(bank => bank.Value.Max(account => account.Value))
                .ToList()
                .ForEach(bank => bank.Value.OrderByDescending(account => account.Value)
                    .ToList()
                    .ForEach(account => Console.WriteLine($"{account.Key} -> {account.Value} ({bank.Key})")));
        }
    }
}
