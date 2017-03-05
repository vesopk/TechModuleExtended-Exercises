using System;
using System.Linq;

class IncreasingSequanceOfElementsInArray
{
    public static void Main()
    {
        var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var isIncreasing = true;
        for (int i = 0; i < numbers.Length; i++)
        {
            var currentNumber = numbers[i];
            var lastNumber = numbers[numbers.Length-1];

            if (currentNumber != lastNumber) 
            {
                var nextNumber = numbers[i + 1];
                if (currentNumber > nextNumber)
                {
                    isIncreasing = false;
                }
            }
            else
            {
                if (lastNumber<currentNumber)
                {
                    isIncreasing = false;
                }
            }
            
        }
        if (isIncreasing)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}