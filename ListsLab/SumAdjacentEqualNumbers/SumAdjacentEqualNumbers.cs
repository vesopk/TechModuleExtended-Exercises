using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    public static void Main()
    {
        var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        for (int i = 0; i < numbers.Count; i++)
        {
            var currentNumber = numbers[i];
            var lastNum = numbers[numbers.Count-1];
            var sum = 0;

            if (currentNumber!=lastNum)
            {
                var nextNum = numbers[i + 1];
                
                if (currentNumber == nextNum)
                {
                    sum = currentNumber + nextNum;
                    numbers.Remove(currentNumber);
                    numbers.Remove(nextNum);
                    numbers.Insert(i, sum);
                }  
            }
            else if (currentNumber == lastNum)
            {
                if (currentNumber == lastNum)
                {
                    sum = currentNumber + lastNum;
                    numbers.Remove(currentNumber);
                    numbers.Remove(lastNum);
                    numbers.Insert(i, sum);
                }
            }
            if (i<0)
            {
                i = 0;
            }
            else if (i>0)
            {
                i -= 2;
            }
        }
        Console.WriteLine($"{string.Join(" ",numbers)}");
    }
}

