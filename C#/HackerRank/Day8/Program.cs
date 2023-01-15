using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        var n = int.Parse(Console.ReadLine());

        Dictionary<string, string> phoneBook = new();

        for(int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().ToLower().Split(' ');
            phoneBook.Add(input[0], input[1]);
        }

        string? name;
        do
        {
            name = Console.ReadLine();

            if (name != null)
            {
                if (phoneBook.TryGetValue(name, out var value))
                    Console.WriteLine($"{name}={value}");
                else
                    Console.WriteLine("Not found");
            }
        } while (name != null);
    }
}