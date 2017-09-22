using System;

namespace ReverseProject
{
    class Helpers
    {
        internal static T[] Reverse<T>(T[] input)
        {
            T[] output = new T[input.Length];
            var j = 0;
            for (var i = input.Length - 1; i >= 0; i--)
            {
                output[j] = input[i];
                j++;
            }

            return output;
        }

        internal static void WriteItOut<T>(T[] input)
        {
            foreach (var i in input)
            {
                Console.WriteLine(i);
            }
        }
    }
}
