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

class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        int positives = 0, negatives = 0, zeros = 0;
        int arr_size = arr.Count;

        foreach (var i in arr)
        {
            if (i > 0)
            {
                positives++;
            }
            else if (i < 0)
            {
                negatives++;
            }
            else
            {
                zeros++;
            }
        }

        decimal zeros_ratio = zeros / arr_size;
        decimal negative_ratio = negatives / arr_size;
        decimal positive_ratio = positives / arr_size;

        Console.WriteLine($"{positive_ratio.ToString("0.000000")}\n{negative_ratio.ToString("0.000000")}\n{zeros_ratio.ToString("0.000000")}");
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
