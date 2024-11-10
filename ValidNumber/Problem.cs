namespace ValidNumber;

public static class Problem
{
    public static bool Solve(string s)
    {
        var hasE = false;
        var hasDot = false;

        for (int i = 0; i < s.Length; i++)
        {
            switch (s[i])
            {
                case '+':
                case '-':
                    if ((i > 0 && !IsE(s[i - 1])) || i == s.Length - 1)
                        return false;
                    break;
                case 'e':
                case 'E':
                    if (hasE ||
                        i == 0 || !IsDigitOrDot(s[i - 1]) ||
                        i == s.Length - 1 || !IsDigitOrSign(s[i + 1])
                        )
                        return false;
                    hasE = true;
                    hasDot = true;
                    break;
                case '.':
                    if (hasDot || (
                        (i == 0 || !IsDigit(s[i - 1])) &&
                        (i == s.Length - 1 || !IsDigit(s[i + 1]))
                        ))
                        return false;
                    hasDot = true;
                    break;
                case char c when c >= '0' && c <= '9':
                    break;
                default:
                    return false;
            }

        }

        return true;
    }

    static bool IsDigitOrSign(char c)
    {
        return IsDigit(c) || c == '+' || c == '-';
    }

    static bool IsDigitOrDot(char c)
    {
        return IsDigit(c) || c == '.';
    }

    static bool IsE(char c)
    {
        return c == 'e' || c == 'E';
    }

    static bool IsDigit(char c)
    {
        return c >= '0' && c <= '9';
    }
}
