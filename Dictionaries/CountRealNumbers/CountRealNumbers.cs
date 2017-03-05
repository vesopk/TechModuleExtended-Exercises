using System;
using System.Collections.Generic;
using System.Linq;

class CountRealNumbers
{
    public static void Main()
    {
        var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
        var sortedNums = new SortedDictionary<double,int>();
        foreach (double number in numbers)
        {
            if (!sortedNums.ContainsKey(number))
            {
                sortedNums.Add(number,1);
            }
            else
            {
                sortedNums[number] += 1;
            }
        }
        foreach (var item in sortedNums)
        {
            Console.WriteLine($"{item.Key} -> {item.Value}");
        }
    }
}

