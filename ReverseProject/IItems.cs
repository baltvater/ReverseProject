namespace ReverseProject
{
    interface IItems<T>
    {
        T[] Items { get; }

        T[] ReversedItems { get; }

        void Reverse(T[] input);

        void WriteItOut(T[] input);
    }
}
