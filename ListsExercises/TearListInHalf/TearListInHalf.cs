using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var firstArr = numbers.Take(numbers.Length / 2).ToArray();
        var firstReversedNums = numbers.Reverse().ToArray();
        var secondArr = firstReversedNums.Take(numbers.Length / 2);
        var secondReversedNums = secondArr.Reverse().ToArray();
        var result = new List<int>();

        for (int i = 0; i < firstArr.Length; i++)
        {
            var currentNum = secondReversedNums[i];
            var firstNum = currentNum / 10;
            var secondNum = currentNum % 10;
            var item = $"{firstNum} {numbers[i]} {secondNum}";
            var tokens = item.Split(' ').Select(int.Parse).ToArray();
            for (int k = 0; k < tokens.Length; k++)
            {
                result.Add(tokens[k]);
            }

        }
        Console.WriteLine(string.Join(" ",result));
    }
}

