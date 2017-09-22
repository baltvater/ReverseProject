using System;

namespace ReverseProject
{
    class Program
    {
        static void Main(string[] args)
        {
            IItems<int> intArray = new IntItems();
            intArray.Reverse(intArray.Items);
            intArray.WriteItOut(intArray.ReversedItems);

            IItems<string> strArray = new StringItems();
            strArray.Reverse(strArray.Items);
            strArray.WriteItOut(strArray.ReversedItems);

            IItems<DateTime> dateArray = new DateItems();
            dateArray.Reverse(dateArray.Items);
            dateArray.WriteItOut(dateArray.ReversedItems);

            IItems<Cat> catArray = new CatItems();
            catArray.Reverse(catArray.Items);
            catArray.WriteItOut(catArray.ReversedItems);

            Console.Read();
        }
    }
}
