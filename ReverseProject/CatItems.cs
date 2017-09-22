using System;

namespace ReverseProject
{
    struct Cat
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class CatItems : IItems<Cat>
    {
        public Cat[] Items
        {
            get => new[]
            {
                new Cat { Name = "Abby", Age = 20 },
                new Cat { Name = "Buffy", Age = 15 },
                new Cat { Name = "Catrina", Age = 10 },
                new Cat { Name = "Dipsy", Age = 5 },
                new Cat { Name = "Eunice", Age = 1 }
            };
        }

        public Cat[] ReversedItems { get; set; }

        public void Reverse(Cat[] input)
        {
            ReversedItems = Helpers.Reverse(input);
        }

        public void WriteItOut(Cat[] input)
        {
            foreach (var i in input)
            {
                Console.WriteLine("Name: {0}, Age: {1}", i.Name, i.Age);
            }
        }
    }
}
