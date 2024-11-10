namespace PermutationSequence;

public static class Problem
{
    public static string Solve(int n, int k)
    {
        if (n == 1)
            return "1";

        var nextBase = Factorial(n - 1);

        var digit = Math.Ceiling((double)k / nextBase);
        if (digit == 0)
            digit = n;

        var result = digit.ToString();

        var tmpResult = Solve(n - 1, k % nextBase);
        foreach (char c in tmpResult)
        {
            var tmpDigit = int.Parse(c.ToString());

            if (tmpDigit >= digit)
                result += tmpDigit + 1;
            else
                result += tmpDigit;
        }

        return result;
    }

    static int Factorial(int n)
    {
        var result = 1;

        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }

        return result;
    }
}
