using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SortArrayOfStrings
{
    static void Main()
    {
        var text = Console.ReadLine().Split(' ').ToList();

        for (int i = 0; i < text.Count-1; i++)
        {
            var j = i + 1;
            while (j > 0)
            {
                var currentText = text[j];
                var previousText = text[j - 1];
                if (string.Compare(currentText, previousText, false) == -1)  
                {
                    var temp = currentText;
                    text[j] = text[j - 1];
                    text[j - 1] = temp;
                }
                j--;
            }
        }
        
        Console.WriteLine(string.Join(" ",text));
    }
}

