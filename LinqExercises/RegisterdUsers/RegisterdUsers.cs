using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterdUsers
{
    class RegisterdUsers
    {
        static void Main()
        {
            var inputData = Console.ReadLine();
            Dictionary<string,DateTime> usersDictionary = new Dictionary<string, DateTime>();
            while (inputData!="end")
            {
                var inputDataParams = inputData.Split(new[] {' ','-','>'}, StringSplitOptions.RemoveEmptyEntries);
                var user = inputDataParams[0];
                var format = "dd/MM/yyyy";
                var dateString = inputDataParams[1];
                var date = DateTime.ParseExact(dateString,format,CultureInfo.InvariantCulture);
                AddUser(usersDictionary,user,date);
                inputData = Console.ReadLine();
            }
            Dictionary<string, DateTime> orderedUsernames = usersDictionary
                .Reverse()
                .OrderBy(x => x.Value)
                .Take(5)
                .OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, x => x.Value);
            foreach (var orderedUsers in orderedUsernames)
            {
                Console.WriteLine("{0}",orderedUsers.Key);
            }
        }

        private static void AddUser(Dictionary<string, DateTime> usersDictionary, string user, DateTime date)
        {
            if (!usersDictionary.ContainsKey(user))
            {
                usersDictionary[user] = date;
            }
        }
    }
}
