using System;
public interface AdvancedArithmetic
{
    int divisorSum(int n);
}

public class Calculator : AdvancedArithmetic
{
    public int divisorSum(int n)
    {
        int sum = 0;
        for(int divisor = 1; divisor <= n; divisor++)
        {
            if (n % divisor == 0)
                sum += divisor;
        }

        return sum;
    }
}

class Solution
{
    static void Main(string[] args)
    {
        int n = Int32.Parse(Console.ReadLine());
        AdvancedArithmetic myCalculator = new Calculator();
        int sum = myCalculator.divisorSum(n);
        Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum);
    }
}