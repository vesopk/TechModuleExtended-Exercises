using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class ArrayElementsEqualToTheirIndex
{
    public static void Main()
    {
        var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var result = new List<int>();

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == i)
            {
                result.Add(numbers[i]);
            }
        }
        Console.WriteLine(string.Join(" ",result));
    }
}

