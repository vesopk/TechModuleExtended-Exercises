using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterBase
{
    class FilterBase
    {
        static void Main()
        { 
            var nameAndAge = new Dictionary<string,int>();
            var nameAndPosition = new Dictionary<string,string>();
            var nameAndSalary = new Dictionary<string,decimal>();
            var text = Console.ReadLine();
            var input = text.Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            while (text != "filter base")
            {

                if (input.Length > 1) 
                {
                    var name = input[0];
                    var value = input[1];
                    var isBothString = true;
                    var isAge = false;
                    try
                    {
                        var valueToInt = int.Parse(value);
                        nameAndAge.Add(name, valueToInt);
                        isBothString = false;
                        isAge = true;
                    }
                    catch (Exception)
                    {
                        // ignored
                    }
                    if (!isAge)
                    {
                        try
                        {
                            var valueToDecimal = decimal.Parse(value);
                            nameAndSalary.Add(name, valueToDecimal);
                            isBothString = false;
                        }
                        catch (Exception)
                        {
                            // ignored
                        }
                    }
                    if (isBothString)
                    {
                        nameAndPosition.Add(name, value);
                    }
                }
                text = Console.ReadLine();
                input = text.Split(new[] {' ', '-', '>'}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
            text = Console.ReadLine();
            input = text.Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            switch (input[0])
            {
                case "Age":
                    foreach (var person in nameAndAge)
                    {
                        Console.WriteLine($"Name: {person.Key}");
                        Console.WriteLine($"Age: {person.Value}");
                        Console.WriteLine("====================");
                    }
                    break;
                case "Position":
                    foreach (var person in nameAndPosition)
                    {
                        Console.WriteLine($"Name: {person.Key}");
                        Console.WriteLine($"Position: {person.Value}");
                        Console.WriteLine("====================");
                    }
                    break;
                case "Salary":
                    foreach (var person in nameAndSalary)
                    {
                        Console.WriteLine($"Name: {person.Key}");
                        Console.WriteLine($"Salary: {person.Value:F2}");
                        Console.WriteLine("====================");
                    }
                    break;
            }
        }
    }
}
