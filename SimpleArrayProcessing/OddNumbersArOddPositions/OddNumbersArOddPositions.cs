﻿using System;
using System.Linq;

class OddNumbersArOddPositions
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        for (int i = 0; i < numbers.Length; i++)
        {
            if ((numbers[i] % 2 != 0) && (i % 2 != 0)) 
            {
                Console.WriteLine($"Index {i} -> {numbers[i]}");
            }
        }
    }
}

