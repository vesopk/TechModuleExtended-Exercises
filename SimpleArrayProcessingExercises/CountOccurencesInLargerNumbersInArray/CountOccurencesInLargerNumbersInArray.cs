using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class CountOccurencesInLargerNumbersInArray
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        var comparedNum = double.Parse(Console.ReadLine());
        var count = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i]>comparedNum)
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}

