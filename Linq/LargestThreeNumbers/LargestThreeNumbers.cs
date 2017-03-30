﻿using System;
using System.Linq;

namespace LargestThreeNumbers
{
    public class LargestThreeNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            var result = numbers.OrderByDescending(x => x).Take(3).ToList();
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
