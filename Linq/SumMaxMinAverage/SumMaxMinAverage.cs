using System;
using System.Collections.Generic;
using System.Linq;

namespace SumMaxMinAverage
{
    public class SumMaxMinAverage
    {
        public static void Main()
        {
            var numbersCount = int.Parse(Console.ReadLine());
            var numbers = new List<int>();
            for (int i = 0; i < numbersCount; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());
                numbers.Add(currentNumber);
            }
            var sum = numbers.Sum();
            var max = numbers.Max();
            var min = numbers.Min();
            var average = numbers.Average();
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Average = {average}");
        }
    }
}
