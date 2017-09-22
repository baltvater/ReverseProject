using System;

namespace ReverseProject
{
    class Program
    {
        static void Main(string[] args)
        {
            DoThatThing(new IntItems());
            DoThatThing(new StringItems());
            DoThatThing(new DateItems());
            DoThatThing(new CatItems());
            Console.Read();
        }

        static void DoThatThing<T>(IItems<T> items)
        {
            items.Reverse(items.Items);
            items.WriteItOut(items.ReversedItems);
        }
    }
}
