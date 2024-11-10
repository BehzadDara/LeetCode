namespace LargestRectangleArea;

public static class Problem
{
    public static int Solve(int[] heights)
    {
        var furthestHigherLeftNeighbor = new int[heights.Length];
        var furthestHigherRightNeighbor = new int[heights.Length];

        for (int i = 0; i < heights.Length; i++)
        {
            var left = i;
            while (left > 0 && heights[left - 1] >= heights[i])
            {
                left = furthestHigherLeftNeighbor[left - 1];
            }
            furthestHigherLeftNeighbor[i] = left;
        }
        for (int i = heights.Length - 1; i >= 0; i--)
        {
            var right = i;
            while (right < heights.Length - 1 && heights[right + 1] >= heights[i])
            {
                right = furthestHigherRightNeighbor[right + 1];
            }
            furthestHigherRightNeighbor[i] = right;
        }

        var result = 0;

        for (int i = 0; i < heights.Length; i++)
        {
            result = Math.Max(result, heights[i] * (furthestHigherRightNeighbor[i] - furthestHigherLeftNeighbor[i] + 1));
        }

        return result;
    }

}
