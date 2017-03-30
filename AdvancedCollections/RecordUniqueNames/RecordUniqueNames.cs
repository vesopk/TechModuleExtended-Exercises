using System;
using System.Collections.Generic;
namespace RecordUniqueNames
{
    class RecordUniqueNames
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            HashSet<string> names = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                var lineData = Console.ReadLine();
                names.Add(lineData);
            }
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
