using System;
using System.Linq;

namespace InsertionSort
{
    class InsertionSort
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (var i = 0; i < numbers.Length-1; i++)
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
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
