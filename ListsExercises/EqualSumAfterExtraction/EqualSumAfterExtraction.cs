using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    public static void Main()
    {
        var firstArrOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        var secondArrOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        var resultList = new List<int>();
        for (int i = 0; i < secondArrOfNumbers.Count; i++)
        {
            var currentSecondArrNum = secondArrOfNumbers[i];
            
            var containsNum = false;
            for (int j = 0; j < firstArrOfNumbers.Count; j++)
            {
                var currentFirstArrNum = firstArrOfNumbers[j];
                if (currentSecondArrNum==currentFirstArrNum)
                {
                    containsNum = true;
                } 
            }
            if (!containsNum)
            {
                resultList.Add(currentSecondArrNum);
            }
        }
        var resultSum = resultList.Sum();
        var firstListSum = firstArrOfNumbers.Sum();
        if (resultSum == firstListSum)
        {
            Console.WriteLine($"Yes. Sum: {firstListSum}");
        }
        else if (resultSum != firstListSum) 
        {
            var diff = resultSum - firstListSum;
            var absDiff = Math.Abs(diff);
            Console.WriteLine($"No. Diff: {absDiff}");

        }
    }
}
