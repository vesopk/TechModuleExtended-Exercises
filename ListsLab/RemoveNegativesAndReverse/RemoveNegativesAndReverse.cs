using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RemoveNegativesAndReverse
{
    public static void Main()
    {
        var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i]<0)
            {
                numbers.Remove(numbers[i]);
            }
        }
        if (numbers.Count-1==0)
        {
            Console.WriteLine("empty");
        }
        else
        {
            numbers.Reverse();
            Console.WriteLine($"{string.Join(" ",numbers)}");
        }
    }
}

