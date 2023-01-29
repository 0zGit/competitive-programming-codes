using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
using System.Runtime.CompilerServices;

class Solution
{
    public static void Main(string[] args)
    {

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < 6; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList()
                .Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int sum = 0, k = 0, j;
        int middle = 1;
        List<int> hourglasses = new List<int>();

        for (int l = 0; l < 4; l++)
        {
            for (int hourglass = 0; hourglass < 4; hourglass++)
            {
                for (j = k; j < k + 3; j++)
                {
                    sum += arr[l][j];
                }
                sum += arr[middle][j / 2];
                for (j = k; j < k + 3; j++)
                {
                    sum += arr[l + 2][j];
                }
                hourglasses.Add(sum);
                sum = 0;
                middle++;
                k++;
            }
            middle = 1;
            k = 0;
        }

        Console.WriteLine(Math.Max(hourglasses.Max(),hourglasses.Min() * -1));
    }
}
