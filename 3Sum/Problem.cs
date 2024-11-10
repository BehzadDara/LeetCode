namespace _3Sum;

public static class Problem
{
    public static IList<IList<int>> Solve(int[] nums)
    {
        var result = new List<IList<int>>();

        var orderedNums = nums.Order().ToList();

        for (int i = 0; i < orderedNums.Count - 2; i++)
        {
            if (i > 0 && orderedNums[i - 1] == orderedNums[i])
            {
                break;
            }
            if (orderedNums[i] > 0)
            {
                break;
            }

            for (int j = i + 1; j < orderedNums.Count - 1; j++)
            {
                if (i != j - 1 && orderedNums[j - 1] == orderedNums[j])
                {
                    break;
                }

                if (orderedNums[i] + orderedNums[j] > 0)
                {
                    break;
                }

                for (int k = j + 1; k < orderedNums.Count; k++)
                {
                    if (j != k - 1 && orderedNums[k - 1] == orderedNums[k])
                    {
                        break;
                    }

                    var sum = orderedNums[i] + orderedNums[j] + orderedNums[k];

                    if (sum == 0)
                    {
                        result.Add(
                        [
                            orderedNums[i],
                        orderedNums[j],
                        orderedNums[k]
                        ]);
                    }

                    else if (sum > 0)
                    {
                        break;
                    }
                }
            }
        }

        return result;
    }
}
