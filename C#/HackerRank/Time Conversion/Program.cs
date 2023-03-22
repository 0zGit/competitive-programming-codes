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
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
        string s_hour = s.Substring(0, 2);
        string pm_am = s.Substring(8);

        if (s_hour == "12")
        {
            return pm_am == "PM" ?
                s.Substring(0, 8) : $"00{s.Substring(2, 6)}";
        }

        Dictionary<string, string> hours = new()
        {
            { "01", "13" },
            { "02", "14" },
            { "03", "15" },
            { "04", "16" },
            { "05", "17" },
            { "06", "18" },
            { "07", "19" },
            { "08", "20" },
            { "09", "21" },
            { "10", "22" },
            { "11", "23" },
        };

        if (pm_am == "PM")
        {
            hours.TryGetValue(s_hour, out string hour);
            return $"{hour}{s.Substring(2, 6)}";
        }
        else
        {
            return s.Substring(0, 8);
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
