﻿using System;

namespace ReverseProject
{
    class IntItems : IItems<int>
    {
        public int[] Items { get => new[] { 1, 2, 3, 4, 5 }; }

        public int[] ReversedItems { get; set; }

        public void Reverse(int[] input)
        {
            ReversedItems = Helpers.Reverse(input);
        }

        public void WriteItOut(int[] input)
        {
            foreach (var i in input)
            {
                Console.WriteLine(i);
            }
        }
    }
}
