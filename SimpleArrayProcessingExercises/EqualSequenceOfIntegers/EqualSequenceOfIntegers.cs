using System;
using System.Linq;

class EqualSequenceOfIntegers
{
    public static void Main()
    {
        var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var isEqual = true;

        for (int i = 0; i < numbers.Length; i++)
        {
            var currentNum = numbers[i];
            var lastNum = numbers[numbers.Length - 1];
            if (currentNum != lastNum)
            {
                var nextNum = numbers[i + 1];
                if (currentNum != nextNum)
                {
                    isEqual = false;
                }
            }
            else if (currentNum == lastNum) 
            {
                if (lastNum != currentNum) 
                {
                    isEqual = false;
                }
            }
        }
        if (isEqual)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}

