using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    class Exercises
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var exersises = new List<Exercise>();
            while (inputLine!="go go go")
            {
                var currentExercise = Exercise.Parse(inputLine);
                exersises.Add(currentExercise);
                inputLine = Console.ReadLine();
            }
            foreach (var exercise in exersises)
            {
                Console.WriteLine("Exercises: {0}",exercise.Topic);
                Console.WriteLine("Problems for exercises and homework for the \"{0}\" course @ SoftUni.", exercise.CourseName);
                Console.WriteLine("Check your solutions here: {0}",exercise.JudgeContestLink);
                var i = 1;
                foreach (var problem in exercise.Problems)
                {
                    Console.WriteLine("{0}. {1}",i,problem);
                    i++;
                }
                i = 1;
            }
        }
    }
}

class Exercise
{
    public string Topic { get; set; }
    public string CourseName { get; set; }
    public string JudgeContestLink { get; set; }
    public List<string> Problems { get; set; }

    public static Exercise Parse(string inputString)
    {
        var inputStringParams = inputString.Split(new[] {'-', '>'},StringSplitOptions.RemoveEmptyEntries)
            .Select(s => s.Trim())
            .ToList();

        var problems = inputStringParams[3].Split(new[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        return new Exercise()
        {
            Topic = inputStringParams[0],
            CourseName = inputStringParams[1],
            JudgeContestLink = inputStringParams[2],
            Problems = problems
        };
    }
}