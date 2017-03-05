using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ArrayContainsElement
{
    public static void Main()
    {
        var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        var numberToFind = int.Parse(Console.ReadLine());
        var result = Contains(numbers,numberToFind);
        Console.WriteLine(result);
    }

    private static string Contains(List<int> numbers, int numberToFind)
    {
        var isFound = false;
        foreach (var number in numbers)
        {
            if (number==numberToFind)
            {
                isFound = true;
            }
        }
        return isFound ? "yes" : "no";
    }
}

