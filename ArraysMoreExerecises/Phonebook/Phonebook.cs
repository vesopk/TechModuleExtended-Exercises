using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Phonebook
{
    public static void Main()
    {
        var phoneNumbers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var contacts = Console.ReadLine().Split(new[] {' '},StringSplitOptions.RemoveEmptyEntries);
        while (true)
        {
            var cmd = Console.ReadLine();
            if (cmd=="done")
            {
                break;
            }
            for (int i = 0; i < contacts.Length; i++)
            {
                if (cmd==contacts[i])
                {
                    Console.WriteLine($"{contacts[i]} -> {phoneNumbers[i]}");
                }
            }

        }
    }
}

