using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class CountOfGivenElement
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int searchedNumber = int.Parse(Console.ReadLine());
        int count = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i]==searchedNumber)
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}

