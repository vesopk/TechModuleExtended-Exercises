using System;
using System.Collections.Generic;
using System.Linq;

namespace AverageStudentGrades
{
    class AverageStudentGrades
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            Dictionary<string,List<double>> studentsGrades = new Dictionary<string, List<double>>();
            for (int i = 0; i < n; i++)
            {
                var nameAndGrade = Console.ReadLine().Split(' ');
                var name = nameAndGrade[0];
                var grade = double.Parse(nameAndGrade[1]);
                if (!studentsGrades.ContainsKey(name))
                {
                    studentsGrades[name] = new List<double>();
                }
                studentsGrades[name].Add(grade);
            }
            foreach (var nameAndGrade in studentsGrades)
            {
                Console.WriteLine($"{nameAndGrade.Key} -> {string.Join(" ",nameAndGrade.Value.Select(p => $"{p:F2}"))} (avg: {nameAndGrade.Value.Average():F2})");
            }
        }
    }
}
