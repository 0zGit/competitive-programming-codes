using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

class Solution
{
    static void Main(String[] args)
    {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";


        // Declare second integer, double, and String variables.
        int myI;
        double myD;
        string myS;
        // Read and save an integer, double, and String to your variables.
        myI = int.Parse(Console.ReadLine());
        myD = double.Parse(Console.ReadLine());
        myS = Console.ReadLine();
        // Print the sum of both integer variables on a new line.
        Console.WriteLine(myI + i);
        // Print the sum of the double variables on a new line.
        double sum = myD + d;
        Console.WriteLine(String.Format("{0:0.0}", sum));
        // Concatenate and print the String variables on a new line
        Console.WriteLine(s + myS);
        // The 's' variable above should be printed first.

    }
}