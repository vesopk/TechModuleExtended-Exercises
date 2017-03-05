using System;
using System.Linq;

class SumArrayElements
{
    static void Main()
    {
        int numbersCount = int.Parse(Console.ReadLine());
        var numbers = new int[numbersCount];

        for (int i = 0; i < numbersCount; i++)
        {
            int currentNum = int.Parse(Console.ReadLine());
            numbers[i] = currentNum;
        }
        var result = numbers.Sum();
        Console.WriteLine(result);
    }
}

