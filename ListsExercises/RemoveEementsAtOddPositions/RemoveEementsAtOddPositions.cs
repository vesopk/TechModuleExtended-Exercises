using System;
using System.Collections.Generic;
class RemoveEementsAtOddPositions
{
    public static void Main()
    {
        var input = Console.ReadLine().Split(' ');
        var result = new List<string>();
        for (int i = 0; i < input.Length; i++)
        {
            var currentWord = input[i];
            if (i % 2 != 0) 
            {
                result.Add(currentWord);
            }
        }
        Console.WriteLine(string.Join("",result));
    }
}

