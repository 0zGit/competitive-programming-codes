using System;
using System.Collections.Generic;
using System.IO;

class Solution
{
    //Write your code here
    internal string stack = "";
    internal string queue = "";

    internal void pushCharacter(char ch)
    {
        stack += ch;
    }
    internal void enqueueCharacter(char ch)
    {
        queue += ch;
    }
    internal char popCharacter()
    {
        return stack.ElementAt(stack.Length - 1);
    }
    internal char dequeueCharacter()
    {
        return queue.ElementAt(0);
    }

    static void Main(String[] args)
    {
        // read the string s.
        string s = Console.ReadLine();

        // create the Solution class object p.
        Solution obj = new Solution();

        // push/enqueue all the characters of string s to stack.
        foreach (char c in s)
        {
            obj.pushCharacter(c);
            obj.enqueueCharacter(c);
        }

        bool isPalindrome = true;

        // pop the top character from stack.
        // dequeue the first character from queue.
        // compare both the characters.
        for (int i = 0; i < s.Length / 2; i++)
        {
            if (obj.popCharacter() != obj.dequeueCharacter())
            {
                isPalindrome = false;

                break;
            }
        }

        // finally print whether string s is palindrome or not.
        if (isPalindrome)
        {
            Console.Write("The word, {0}, is a palindrome.", s);
        }
        else
        {
            Console.Write("The word, {0}, is not a palindrome.", s);
        }
    }
}