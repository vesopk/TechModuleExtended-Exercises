using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MultiplyArrayOfDouble
{
    public static void Main()
    {
        var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        var numberToMultiply = double.Parse(Console.ReadLine());
        var result = new double[numbers.Length];

        for (int i = 0; i < numbers.Length; i++)
        {
            result[i] = numbers[i] * numberToMultiply;
        }

        Console.WriteLine(string.Join(" ",result));
    }
}

