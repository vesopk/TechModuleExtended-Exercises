using System;
using System.Linq;

class SmallestElementInArray
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var result = numbers.Min();
        Console.WriteLine(result);
    }
}

