using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int T = int.Parse(Console.ReadLine());
        for (int i = 0; i < T; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (IsPrime(num))
                Console.WriteLine("Prime");
            else
                Console.WriteLine("Not prime");
        }
    }

    static bool IsPrime(int num)
    {
        if (num == 1)
        {
            return false;
        }

        if (num % 2 == 0)
        {
            for (int n = 2; n < num; n += 2)
            {
                if (num % n == 0)
                {
                    return false;
                }
            }
        }
        else
        {
            for (int n = 3; n < num; n += 2)
            {
                if (num % n == 0)
                {
                    return false;
                }
            }
        }

        return true;
    }
}
