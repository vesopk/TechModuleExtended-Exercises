using System;
using System.Collections.Generic;
using System.Linq;

class ShootListElements
{
    static void Main()
    {
        var numbers = new List<double>();
        var lastNumber = 0.0;
        while (true)
        {
            var commands = Console.ReadLine();
            if (commands == "stop")
            {
                if (numbers.Count != 0) 
                {
                    Console.WriteLine($"survivors: {string.Join(" ",numbers)}");
                }
                else
                {
                    Console.WriteLine($"you shot them all. last one was {lastNumber}");
                }
                break;
            }
            if ((numbers.Count == 0)&&(commands=="bang"))
            {
                Console.WriteLine($"nobody left to shoot! last one was {lastNumber}");
                break;
            }
            if (commands == "bang")
            {
                var average = numbers.Average();
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] > average) continue;
                    Console.WriteLine($"shot {numbers[i]}");
                    lastNumber = numbers[i];
                    numbers.Remove(numbers[i]);
                    break;
                }
                for (int i = 0; i < numbers.Count; i++)
                {
                    numbers[i] = numbers[i] - 1;
                }
                
            }
            else
            {
                var number = double.Parse(commands);
                if (!numbers.Contains(number))
                {
                    numbers.Insert(0,number);
                }
            }
        }
    }
}

