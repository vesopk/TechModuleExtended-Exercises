using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class OddNumsCount
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int count = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 != 0) 
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}

