using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LargestNElements
{
    public static void Main()
    {
        var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        var numbersToTake = int.Parse(Console.ReadLine());

        for (int i = 0; i < numbers.Count - 1; i++)
        {
            var j = i + 1;
            while (j > 0) 
            {
                var currentNumber = numbers[j];
                var previousNumber = numbers[j - 1];
                if (currentNumber < previousNumber)
                {
                    var temp = currentNumber;
                    numbers[j] = numbers[j - 1];
                    numbers[j - 1] = temp;
                }
                j--;
            }
        }
        for (int i = 0; i < numbers.Count / 2; i++)
        {
            var rollLeft = i;
            var rollRight = numbers.Count - 1 - i;
            var temp = numbers[rollLeft];
            numbers[rollLeft] = numbers[rollRight];
            numbers[rollRight] = temp;

        }
        var result = numbers.Take(numbersToTake);
        Console.WriteLine(string.Join(" ",result));
    }
}

