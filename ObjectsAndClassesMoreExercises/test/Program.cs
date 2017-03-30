using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> {1, 2, 3, 4, 5};
            var numbersToString = new List<string>();
            foreach (var number in numbers)
            {
                numbersToString.Add($"[{number}]");
            }
            Console.WriteLine(string.Join("&",numbersToString));
        }
    }
}
