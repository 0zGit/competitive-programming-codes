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

        Console.WriteLine(GetConsecutives1sInBinary(n));
    }

    private static int GetConsecutives1sInBinary(int n)
    {
        const int b = 2;
        int pow = 1;
        int res = 1;
        int exp = 0;

        // Get pow value and expoent number
        for (int i = exp; res < n; i++)
        {
            res = int.Parse(Math.Pow(b, i).ToString());
            pow = res;
            exp = i;
        }


        int aux = 0;
        int res2, count = 0;
        int prevCount = 0;


        // Start comparisons...
        // if pow value is equal to our number n, it means one number 1 in binary
        if (pow == n) return 1;

        else // pow is greater than n
        {
            // check witch antecessor value sum is equal to our number n
            for (int i = exp; i >= 0; i--)
            {
                res2 = int.Parse(Math.Pow(b, i).ToString());
                aux += res2;
                if (aux > n)
                {
                    if (prevCount < count)
                        prevCount = count;
                    aux -= res2;
                    count = 0;
                }
                else
                {
                    count++;
                }
                if (aux == n) break;
            }
        }

        return prevCount > count ? prevCount : count;
    }
}
