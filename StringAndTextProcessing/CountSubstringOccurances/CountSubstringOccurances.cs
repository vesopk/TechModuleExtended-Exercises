using System;

namespace CountSubstringOccurances
{
    class CountSubstringOccurances
    {
        static void Main()
        {
            var text = Console.ReadLine().ToLower();
            var pattern = Console.ReadLine().ToLower();

            var count = 0;
            var index = -1;

            while (true)
            {
                index = text.IndexOf(pattern, index + 1);

                if (index < 0)
                {
                    break;
                }

                count++;
            }
            Console.WriteLine(count);
        }
    }
}
