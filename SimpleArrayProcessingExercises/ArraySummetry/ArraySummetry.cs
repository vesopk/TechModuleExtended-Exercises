using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class ArraySummetry
{
    static void Main()
    {
        var words = Console.ReadLine().Split(' ');
        var isEqual = true;
        var arr = words.Reverse().ToArray();
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i]!=arr[i])
            {
                isEqual = false;
            }
        }
        if (isEqual)
        {
            Console.WriteLine("Yes");
        }
        else if (!isEqual)
        {
            Console.WriteLine("No");
        }
    }
}


