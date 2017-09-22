using System;

namespace ReverseProject
{
    class StringItems : IItems<string>
    {
        public string[] Items { get => new[] { "Abe", "Bob", "Carol", "Denise", "Earl" }; }

        public string[] ReversedItems { get; set; }

        public void Reverse(string[] input)
        {
            ReversedItems = Helpers.Reverse(input);
        }

        public void WriteItOut(string[] input)
        {
            foreach (var i in input)
            {
                Console.WriteLine(i);
            }
        }
    }
}
