using System;
using System.Collections.Generic;
using System.Linq;

namespace OptimizedBankSystem
{
    class OptimizedBankSystem
    {
        public static void Main()
        {
            var bankAccounts = new List<BankAccount>();
            var inputLine = Console.ReadLine();
            while (inputLine!="end")
            {
                var currentBankAccount = BankAccount.Parse(inputLine);
                bankAccounts.Add(currentBankAccount);
                inputLine = Console.ReadLine();
            }
            foreach (var bankAccount in bankAccounts.OrderByDescending(b => b.Balance).ThenBy(n => n.Bank.Length))
            {
                Console.WriteLine($"{bankAccount.Name} -> {bankAccount.Balance} ({bankAccount.Bank})");
            }
        }
    }
}

class BankAccount
{
    public string Name { get; set; }
    public string Bank { get; set; }
    public decimal Balance { get; set; }

    public static BankAccount Parse(string inputLine)
    {
        var inputLineParams = inputLine
            .Split(new[] {' ', '|'}, StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        return new BankAccount()
        {
            Name = inputLineParams[1],
            Bank = inputLineParams[0],
            Balance = decimal.Parse(inputLineParams[2])
        };
    }
}