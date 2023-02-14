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
        List<string> names = new();
        int N = Convert.ToInt32(Console.ReadLine().Trim());

        for (int NItr = 0; NItr < N; NItr++)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            string firstName = firstMultipleInput[0];

            string emailID = firstMultipleInput[1];

            
            if (IsGmailAccount(emailID))
                names.Add(firstName);
        }

        names.Sort();
        foreach(var input in names)
            Console.WriteLine(input);
    }

    public static bool IsGmailAccount(string emailID)
    {
        var split = emailID.Split('@');
        
        foreach(string input in split)
        {
            if(input == "gmail.com")
                return true;
        }

        return false;
    }
}
