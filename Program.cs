using System;
using System.Collections.Generic;

namespace Random_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Random random = new Random();
            List<int> numbers = new List<int> {
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
            };
            
            for (int i = 0; i < numbers.Count; i++)
            {
                if (i == numbers[i]) {
                    Console.WriteLine($"Numbers list contains {i}");
                } else {
                    Console.WriteLine($"numbers list does not contain {i}");
                }

            }
        }
                // Deterßmine if the current loop index is contained inside of the `numbers` list. Print a message to the console indicating whether the index is in the list.
    }
}
