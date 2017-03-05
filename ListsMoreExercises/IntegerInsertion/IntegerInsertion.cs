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

        while (true)
        {
            var cmd = Console.ReadLine();

            if (cmd=="end")
            {
                break;
            }
            else 
            {
                var numberToInsert = int.Parse(cmd);
                var numberToInsertFinal = numberToInsert;
                var numberIndexToInsert = 0;

                while (numberToInsert > 0) 
                {
                    var lastDigit = numberToInsert % 10;
                    numberToInsert = numberToInsert / 10;
                    numberIndexToInsert = lastDigit;
                }

                numbers.Insert(numberIndexToInsert,numberToInsertFinal);
            }
        }
        Console.WriteLine(string.Join(" ",numbers));
    }
}

