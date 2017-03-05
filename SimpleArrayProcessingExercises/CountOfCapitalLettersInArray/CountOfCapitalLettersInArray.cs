using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CountOfCapitalLettersInArray
{
    static void Main()
    {
        var words = Console.ReadLine().Split(' ');
        var upperLettersCount = 0;
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length==1)
            {
                var letter = char.Parse(words[i]);
                if (Char.IsUpper(letter))
                {
                    upperLettersCount++;
                }
            }
        }
        Console.WriteLine(upperLettersCount);
    }
}

