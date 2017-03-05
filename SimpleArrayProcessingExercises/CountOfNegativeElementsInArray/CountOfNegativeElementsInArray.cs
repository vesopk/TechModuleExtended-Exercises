using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class CountOfNegativeElementsInArray
{
    public static void Main()
    {
        var numbersCount = int.Parse(Console.ReadLine());
        var numbers = new int[numbersCount];
        int count = 0;

        for (int i = 0; i < numbersCount; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());
            numbers[i] = currentNumber;
        }
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < 0)
            {
                count++;
            }
        }

        Console.WriteLine(count);
    }
}

