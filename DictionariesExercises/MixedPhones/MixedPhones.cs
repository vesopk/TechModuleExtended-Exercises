using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixedPhones
{
    class MixedPhones
    {
        public static void Main()
        {
            var phoneBook = new Dictionary<string, decimal>();
            while (true)
            {
                var text = Console.ReadLine().Split(new[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries);
                var list = phoneBook.Keys.ToList();
                list.Sort();
                if (text[0]=="Over")
                {
                    foreach (var item in list)
                    {
                        Console.WriteLine($"{item} -> {phoneBook[item]}");
                    }
                    break;
                }
                try
                {
                    var number = decimal.Parse(text[0]);
                    var contact = text[1];
                    if (!phoneBook.ContainsKey(contact))
                    {
                        phoneBook.Add(contact,number);
                    }
                }
                catch (Exception e)
                {
                }
                try
                {
                    var number = decimal.Parse(text[1]);
                    var contact = text[0];
                    if (!phoneBook.ContainsKey(contact))
                    {
                        phoneBook.Add(contact, number);
                    }
                }
                catch (Exception e)
                {
                }
            }
           
        }
    }
}
