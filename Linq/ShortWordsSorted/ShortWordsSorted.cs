using System;
using System.Linq;

namespace ShortWordsSorted
{
    class ShortWordsSorted
    {
        public static void Main()
        {
            var separators = new[] {' ',',',';',':','(',')','[',']','\'','"','/','\\','!','?'};
            var words = Console.ReadLine()
                .ToLower()
                .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                .OrderBy(w => w)
                .Where(w => w.Length<5)
                .Distinct()
                .ToList();
            Console.WriteLine(string.Join(", ",words));
        }
    }
}
