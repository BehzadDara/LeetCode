namespace Candy;

public static class Problem
{
    public static int Solve(int[] ratings)
    {
        var result = new int[ratings.Length];
        var value = 1;

        for (int i = 0; i < ratings.Length - 1; i++)
        {
            result[i] = value;
            if (ratings[i] < ratings[i + 1])
            {
                value++;
            }
            else if (ratings[i] == ratings[i + 1])
            {
                value = 1;
            }
            else
            {
                value = 1;

                var j = i;
                var tmpValue = 1;
                while (j >= 0 && ratings[j] > ratings[j + 1] && result[j] == tmpValue)
                {
                    result[j]++;
                    tmpValue++;
                    j--;
                }
            }
        }
        result[ratings.Length - 1] = value;

        return result.Sum();
    }
}
