using System;
using System.Collections.Generic;
using System.Linq;

class Batteries
{
    public static void Main()
    {
        var batteriesInMAH = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
        var batteryConsumationPerHour = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
        var hours = int.Parse(Console.ReadLine());
        var result = new List<double>();
        for (int i = 0; i < batteriesInMAH.Count; i++)
        {
            var capacity = batteriesInMAH[i] - (batteryConsumationPerHour[i] * hours);
            result.Add(capacity);
        }
        for (int i = 0; i < batteriesInMAH.Count; i++)
        {
            if (result[i] > 0) 
            {
                double percent = result[i] / batteriesInMAH[i] * 100;
                Console.WriteLine($"Battery {i + 1}: {result[i]:F2} mAh ({percent:F2})%");
            }
            else
            {
                var hoursLasted = batteriesInMAH[i] / batteryConsumationPerHour[i];
                var resultFinal = hoursLasted;
                Console.WriteLine($"Battery {i + 1}: dead (lasted {Math.Ceiling(resultFinal)} hours)");
            }
        }

    }
}

