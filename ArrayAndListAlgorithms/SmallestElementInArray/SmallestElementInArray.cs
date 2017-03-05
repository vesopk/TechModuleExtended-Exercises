using System;
using System.Collections.Generic;
using System.Linq;

class SmallestElementInArray
{
    public static void Main()
    {
        var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        var result = FindSmallestElement(numbers);
        Console.WriteLine(result);
    }

    private static int FindSmallestElement(List<int> numbers)
    {
        var smallestElement = int.MaxValue;
        foreach (var curremtElement in numbers)
        {
            if (curremtElement<smallestElement)
            {
                smallestElement = curremtElement;
            }
        }
        return smallestElement;
    }
}

