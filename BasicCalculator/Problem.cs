namespace BasicCalculator;

public static class Problem
{
    public static int Solve(string s)
    {
        var stack = new Stack<int>();

        var tmpNumber = 0;
        var tmpFactor = 1;

        for (var i = 0; i < s.Length; i ++)
        {
            switch (s[i])
            {
                case ' ':
                    continue;
                case '(':
                    var startIndex = i;

                    var counter = 1;
                    while (true)
                    {
                        i++;
                        if (s[i] == '(')
                        {
                            counter++;
                        }
                        else if (s[i] == ')')
                        {
                            counter--;
                            if (counter == 0)
                            {
                                var tmpResult = Solve(s.Substring(startIndex + 1, i - startIndex - 1));

                                stack.Push(tmpFactor * tmpResult);
                                tmpFactor = 1;
                                break;
                            }
                        }
                    }

                    break;
                case '+':
                    stack.Push(tmpFactor * tmpNumber);

                    tmpFactor = 1;
                    tmpNumber = 0;
                    break;
                case '-':
                    stack.Push(tmpFactor * tmpNumber);

                    tmpFactor = -1;
                    tmpNumber = 0;
                    break;
                default:
                    tmpNumber = tmpNumber * 10 + (s[i] - '0');
                    break;
            }
        }
        stack.Push(tmpFactor * tmpNumber);

        return CalculateStack(stack);
    }

    public static int CalculateStack(Stack<int> stack)
    {
        var result = 0;
        while (stack.Count > 0)
        {
            var item = stack.Pop();
            result += item;
        }
        return result;
    }
}
