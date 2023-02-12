using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        List<int> actualReturnDate = new();
        List<int> expectedReturnDate = new();

        string[] inputs = Console.ReadLine().TrimEnd().Split(' ');
        actualReturnDate = inputs.Select(Int32.Parse).ToList();

        inputs = Console.ReadLine().TrimEnd().Split(' ');
        expectedReturnDate = inputs.Select(Int32.Parse).ToList();

        Console.WriteLine(CalculateFee(actualReturnDate, expectedReturnDate));
    }

    static int CalculateFee(List<int> actual, List<int> expected)
    {
        int dayReturned = actual.ElementAt(0);
        int monthReturned = actual.ElementAt(1);
        int yearReturned = actual.ElementAt(2);

        int dayDue = expected.ElementAt(0);
        int monthDue = expected.ElementAt(1);
        int yearDue = expected.ElementAt(2);

        if (yearDue == yearReturned)
        {
            if (monthReturned <= monthDue)
            {
                if (dayReturned <= dayDue)
                {
                    return 0;
                }
                else
                    return (dayReturned - dayDue) * 15;
            }
            else
                return (monthReturned - monthDue) * 500;
        }
        else if (yearReturned < yearDue)
            return 0;
        else
            return 10000;
    }
}
