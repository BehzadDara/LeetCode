namespace ReverseInteger;

public static class Problem
{
    public static int Solve(int x)
    {
        var factor = x > 0 ? 1 : -1;
        var stringValue = x.ToString().Replace('-', ' ');

        try
        {
            var charArray = stringValue.ToCharArray();
            Array.Reverse(charArray);
            var reverse = new string(charArray);
            var integerValue = int.Parse(reverse);

            return integerValue * factor;
        }
        catch
        {
            return 0;
        }
    }
}
