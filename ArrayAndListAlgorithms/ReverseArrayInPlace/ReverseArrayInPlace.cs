using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReverseArrayInPlace
{
    public static void Main()
    {
        var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        for (int i = 0; i < numbers.Length/2; i++)
        {
            var rollLeft = i;
            var rollRight = numbers.Length - 1 - i;
            var temp = numbers[rollLeft];
            numbers[rollLeft] = numbers[rollRight];
            numbers[rollRight] = temp;

        }
        Console.WriteLine(string.Join(" ",numbers));
    }
}

