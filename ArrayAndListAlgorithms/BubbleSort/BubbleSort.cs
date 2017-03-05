using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BubbleSort
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        for (var write = 0; write < numbers.Length; write++)
        {
            for (var sort = 0; sort < numbers.Length - 1; sort++)
            {
                var currentNumber = numbers[sort];
                var nextNumber = numbers[sort + 1];
                if (currentNumber <= nextNumber) continue;
                var temp = numbers[sort + 1];
                numbers[sort + 1] = numbers[sort];
                numbers[sort] = temp;
            }
        }
        Console.WriteLine(string.Join(" ",numbers));
    }
}

