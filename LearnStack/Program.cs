using System;
using System.Collections.Generic;

namespace LearnStack
{
    class Program
    {
        static void Main(string[] args)
        {
            //last in first out
            Stack<String> pancakes = new Stack<string>();

            pancakes.Push("first pancake made");
            pancakes.Push("second pancake made");
            pancakes.Push("third pancake made");

            foreach (var pancake in pancakes)
            {
                Console.WriteLine(pancake);            }

        }




    }
}
