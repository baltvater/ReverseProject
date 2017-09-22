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
    }
}
