using System.Text;

namespace ZigzagConversion;

public static class Problem
{
    public static string Solve(string s, int numRows)
    {
        if (numRows == 1)
            return s;

        var stringBuilders = new StringBuilder[numRows];

        for (int i = 0; i < numRows; i++)
        {
            stringBuilders[i] = new StringBuilder();
        }

        var index = 0;
        while (index < s.Length)
        {
            for (int i = 0; i < numRows; i++)
            {
                if (index + i < s.Length)
                {
                    stringBuilders[i].Append(s[index + i]);
                }
            }
            for (int i = numRows; i < 2 * (numRows - 1); i++)
            {
                if (index + i < s.Length)
                {
                    stringBuilders[2 * (numRows - 1) - i].Append(s[index + i]);
                }
            }

            index += 2 * (numRows - 1);
        }

        return string.Join("", stringBuilders.Select(x => x));
    }
}
