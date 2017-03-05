using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var result = new List<int>();
        for (int i = 0; i < numbers.Length; i++)
        {
            var currentNumber = numbers[i];
            if (!result.Contains(currentNumber))
            {
                result.Add(currentNumber);
            }
        }
        Console.WriteLine(string.Join(" ",result));
    }
}

