namespace TrappingRainWater;

public static class Problem
{
    public static int Solve(int[] height)
    {
        var result = 0;

        var end = 0;
        while (end < height.Length - 1)
        {
            var begin = end;

            while (begin < height.Length - 1 && height[begin] <= height[begin + 1])
                begin++;
            end = begin + 1;

            while (end < height.Length - 1 && height[end] >= height[end + 1])
                end++;

            while (end < height.Length - 1 && height[end] <= height[end + 1])
                end++;

            var tmp = end;
            while (tmp < height.Length - 1)
            {
                tmp++;
                if (height[end] <= height[begin] && height[end] <= height[tmp])
                {
                    end = tmp;
                }
            }

            if (end > height.Length - 1)
                break;

            var minHeight = Math.Min(height[begin], height[end]);
            for (int i = begin + 1; i < end; i++)
            {
                if (minHeight - height[i] > 0)
                    result += minHeight - height[i];
            }
        }

        return result;
    }
}
