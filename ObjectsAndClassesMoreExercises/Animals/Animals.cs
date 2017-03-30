using System;
using System.Collections.Generic;
using System.Linq;

namespace Animals
{
    class Animals
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var dogs = new List<Dog>();
            var cats = new List<Cat>();
            var snakes = new List<Snake>();

            while (inputLine != "I'm your Huckleberry")
            {
                var inputLineParams = inputLine.Split(' ').ToList();

                var type = inputLineParams[0];

                AddAnimal(inputLine, dogs, cats, snakes, type);

                if (type=="talk")
                {
                    var animalToTalk = inputLineParams[1];
                    foreach (var dog in dogs)
                    {
                        if (dog.Name == animalToTalk)
                        {
                            Dog.Talk();
                        }
                    }
                    foreach (var cat in cats)
                    {
                        if (cat.Name == animalToTalk)
                        {
                            Cat.Talk();
                        }
                    }
                    foreach (var snake in snakes)
                    {
                        if (snake.Name == animalToTalk)
                        {
                            Snake.Talk();
                        }
                    }
                }

                inputLine = Console.ReadLine();
            }
            foreach (var dog in dogs)
            {
                Console.WriteLine($"Dog: {dog.Name}, Age: {dog.Age}, Number Of Legs: {dog.NumberOfLegs}");
            }
            foreach (var cat in cats)
            {
                Console.WriteLine($"Cat: {cat.Name}, Age: {cat.Age}, IQ: {cat.IntelligenceQuotient}");
            }
            foreach (var snake in snakes)
            {
                Console.WriteLine($"Snake: {snake.Name}, Age: {snake.Age}, Cruelty: {snake.CrueltyCoefficient}");
            }
        }

        private static void AddAnimal(string inputLine, List<Dog> dogs, List<Cat> cats, List<Snake> snakes, string type)
        {
            if (type == "Dog")
            {
                var currentDog = Dog.Parse(inputLine);
                dogs.Add(currentDog);
            }
            else if (type == "Cat")
            {
                var currentCat = Cat.Parse(inputLine);
                cats.Add(currentCat);
            }
            else if (type == "Snake")
            {
                var currentSnake = Snake.Parse(inputLine);
                snakes.Add(currentSnake);
            }
        }
    }
}

class Dog
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int NumberOfLegs { get; set; }

    public static Dog Parse(string inputLine)
    {
        var inputLineParams = inputLine.Split(' ').ToList();
        return new Dog()
        {
            Name = inputLineParams[1],
            Age = int.Parse(inputLineParams[2]),
            NumberOfLegs = int.Parse(inputLineParams[3])
        };
    }
    public static void Talk()
    {
        Console.WriteLine("I'm a Distinguishedog, and I will now produce a distinguished sound! Bau Bau.");
    }
}

class Cat
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int IntelligenceQuotient { get; set; }

    public static Cat Parse(string inputLine)
    {
        var inputLineParams = inputLine.Split(' ').ToList();
        return new Cat()
        {
            Name = inputLineParams[1],
            Age = int.Parse(inputLineParams[2]),
            IntelligenceQuotient = int.Parse(inputLineParams[3])
        };
    }
    public static void Talk()
    {
        Console.WriteLine("I'm an Aristocat, and I will now produce an aristocratic sound! Myau Myau.");
    }
}

class Snake
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int CrueltyCoefficient { get; set; }

    public static Snake Parse(string inputLine)
    {
        var inputLineParams = inputLine.Split(' ').ToList();
        return new Snake()
        {
            Name = inputLineParams[1],
            Age = int.Parse(inputLineParams[2]),
            CrueltyCoefficient = int.Parse(inputLineParams[3])
        };
    }

    public static void Talk()
    {
        Console.WriteLine("I'm a Sophistisnake, and I will now produce a sophisticated sound! Honey, I'm home.");
    }
}
