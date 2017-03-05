using System;
using System.Collections.Generic;
using System.Linq;

class UnunionList
{
    public static void Main()
    {
        var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        var numbersToString = numbers.Select(x => x.ToString()).ToList();
        var addingNumbersArrays = int.Parse(Console.ReadLine());

        for (var i = 0; i < addingNumbersArrays; i++)
        {
            var currentArray = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var currentArrayToString = currentArray.Select(x => x.ToString()).ToList();
            var newList = currentArrayToString.ToList();
            foreach (var number in currentArrayToString)
            {
                if (!numbersToString.Contains(number)) continue;
                while (numbersToString.Contains(number))
                {
                    numbersToString.Remove(number);
                    while (newList.Contains(number))
                    {
                        newList.Remove(number);
                    }
                }
            }
            numbersToString = numbersToString.Concat(newList).ToList();
        }
        numbersToString.Sort();
        Console.WriteLine(string.Join(" ",numbersToString));
    }
}

