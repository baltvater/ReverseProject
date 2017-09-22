using System;

namespace ReverseProject
{
    class DateItems : IItems<DateTime>
    {
        public DateTime[] Items => new[]
        {
            new DateTime(2001, 1, 1),
            new DateTime(2002, 2, 2),
            new DateTime(2003, 3, 3),
            new DateTime(2004, 4, 4),
            new DateTime(2005, 5, 5)
        };

        public DateTime[] ReversedItems { get; set; }

        public void Reverse(DateTime[] input)
        {
            ReversedItems = Helpers.Reverse(input);
        }
    }
}
