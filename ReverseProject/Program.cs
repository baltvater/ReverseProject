using System;

namespace ReverseProject
{
    class Program
    {
        static void Main(string[] args)
        {
            IItems<int> intArray = new IntItems();
            intArray.Reverse(intArray.Items);
            Helpers.WriteItOut(intArray.ReversedItems);

            IItems<string> strArray = new StringItems();
            strArray.Reverse(strArray.Items);
            Helpers.WriteItOut(strArray.ReversedItems);

            IItems<DateTime> dateArray = new DateItems();
            dateArray.Reverse(dateArray.Items);
            Helpers.WriteItOut(dateArray.ReversedItems);

            Console.Read();
        }
    }
}
