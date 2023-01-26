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



class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        // Write your code here
        BubbleSort(n, a);
    }

    private static void BubbleSort(int n, List<int> a)
    {
        // Track number of elements swapped during a single array traversal
        int numberOfSwaps = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n - 1; j++)
            {
                // Swap adjacent elements if they are in decreasing order
                if (a[j] > a[j + 1])
                {
                    var swappedElements = swap(a[j], a[j + 1]);
                    a[j] = swappedElements[0];
                    a[j+1] = swappedElements[1];
                    numberOfSwaps++;
                }
            }

            // If no elements were swapped during a traversal, array is sorted
            if (numberOfSwaps == 0)
            {
                break;
            }
        }

        PrintStatus(numberOfSwaps, a);
    }

    private static int[] swap(int v1, int v2)
    {
        var aux = v1;
        v1 = v2;
        v2 = aux;

        int[] arr = new int[2];
        arr[0] = v1;
        arr[1] = v2;

        return arr;
    }

    private static void PrintStatus(int n,List<int> a)
    {
        Console.WriteLine(
            $"Array sorted in {n} swaps.\n" +
            $"First element: {a.First()}\n" +
            $"Last element: {a.Last()}");
    }
}
