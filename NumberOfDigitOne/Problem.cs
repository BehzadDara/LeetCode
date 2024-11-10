namespace NumberOfDigitOne;

public static class Problem
{
    public static int Solve(int n)
    {
        var result = 0;

        for (var i = 1; i <= n; i *= 10)
        {
            var before = n / i;
            var current = before % 10;

            if (current == 0)
            {
                result += (before / 10) * i;
            }
            else if (current == 1)
            {
                var after = n % i;
                result += (before / 10) * i + (after + 1);
            }
            else
            {
                result += (before / 10 + 1) * i;
            }
        }

        return result;
    }
}
