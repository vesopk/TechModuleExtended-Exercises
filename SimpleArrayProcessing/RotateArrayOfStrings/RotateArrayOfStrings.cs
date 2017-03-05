using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RotateArrayOfStrings
{
    static void Main()
    {
        var words = Console.ReadLine().Split(' ');
        var result = new string[words.Length];

        for (int i = 1; i <= words.Length-1; i++)
        {
            var lastWord = words[words.Length-1];
            result[0] = lastWord;
            result[i] = words[i-1];
            
        }
        Console.WriteLine(string.Join(" ",result));
    }
}

