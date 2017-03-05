using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LargestElementInArray
{
    static void Main()
    {
        var numbersCount = int.Parse(Console.ReadLine());
        var numbers = new int[numbersCount];

        for (int i = 0; i < numbersCount; i++)
        {
            var currentNum = int.Parse(Console.ReadLine());
            numbers[i] = currentNum;
        }
        var result = numbers.Max();
        Console.WriteLine(result);
    }
}
