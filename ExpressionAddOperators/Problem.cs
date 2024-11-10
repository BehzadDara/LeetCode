namespace ExpressionAddOperators;

public static class Problem
{
    public static IList<string> Solve(string num, int target)
    {
        return Solve("", num, target);
    }

    static IList<string> Solve(string answer, string num, int target)
    {
        if (num.Length == 1)
        {
            if (int.Parse(num) == target)
            {
                return [answer];
            }
            return [];
        }

        var result = new List<string>();

        var multiple = (int.Parse(num[0].ToString()) * int.Parse(num[1].ToString())).ToString() + num[2..num.Length];
        var multipleTmp = string.IsNullOrEmpty(answer) ? num[0].ToString() : answer;
        result.AddRange(Solve(multipleTmp + "*" + num[1], multiple, target));

        var sum = (int.Parse(num[0].ToString()) + int.Parse(num[1].ToString())).ToString() + num[2..num.Length];
        var sumTmp = string.IsNullOrEmpty(answer) ? num[0].ToString() : answer;
        result.AddRange(Solve(sumTmp + "+" + num[1], sum, target));

        if (int.Parse(num[0].ToString()) - int.Parse(num[1].ToString()) >= 0)
        {
            var minus = (int.Parse(num[0].ToString()) - int.Parse(num[1].ToString())).ToString() + num[2..num.Length];
            var minusTmp = string.IsNullOrEmpty(answer) ? num[0].ToString() : answer;
            result.AddRange(Solve(minusTmp + "-" + num[1], minus, target));
        }

        return result;
    }
}
