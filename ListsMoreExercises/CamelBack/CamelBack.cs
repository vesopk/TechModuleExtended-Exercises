using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class CamelBack
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        var numbersCount = numbers.Count;
        var camelBack = int.Parse(Console.ReadLine());
        var count = 0;

        while (numbers.Count > camelBack) 
        {
            numbers.RemoveAt(0);
            numbers.RemoveAt(numbers.Count-1);
            count++;
        }

        if (count > 0) 
        {
            Console.WriteLine($"{count} rounds");
            Console.WriteLine($"remaining: {string.Join(" ", numbers)}");
        }
        else
        {
            Console.WriteLine($"already stable: {string.Join(" ",numbers)}");
        }

    }
}

