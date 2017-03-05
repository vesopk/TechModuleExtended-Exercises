using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    public static void Main()
    {
        var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var result = new int[numbers.Length];
        for (int i = 1; i < numbers.Length - 1; i++)
        {
            var firstNum = numbers[0];
            var lastNum = numbers[numbers.Length - 1];
            result[0] = firstNum;
            result[result.Length - 1] = lastNum;

            var currentNum = numbers[i];
            var replacedNum = numbers[numbers.Length - 1 - i];
            var tempNum = 0;
            tempNum = currentNum;
            currentNum = replacedNum;
            replacedNum = tempNum;
            result[i] = currentNum;
            result[result.Length - 1 - i] = replacedNum;

        }
        Console.WriteLine(string.Join(" ",result));
    }
}

