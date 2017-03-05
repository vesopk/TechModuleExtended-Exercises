using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class AppendLists
{
    public static void Main()
    {
        var input = Console.ReadLine().Split('|').ToArray();
        var tokens = new List<int[]>();
        for (int i = 0; i < input.Length; i++)
        {
            var token = input[i].Split(new[] {' '},StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            tokens.Add(token);           
        }
        tokens.Reverse();
        foreach (var item in tokens)
        {
            Console.Write($"{string.Join(" ",item)} ");
        }
        Console.WriteLine();
    }
}

