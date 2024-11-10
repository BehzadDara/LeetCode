namespace FirstMissingPositive;

public static class Problem
{
    public static int Solve(int[] nums)
    {
        var areNumbersExist = new bool[nums.Length];

        foreach (var num in nums.Where(x => x > 0 && x <= nums.Length))
            areNumbersExist[num - 1] = true;

        foreach (var isNumberExist in areNumbersExist.Select((value, index) => new { index, value }))
        {
            if (!isNumberExist.value)
                return isNumberExist.index + 1;
        }
        return nums.Length + 1;
    }
}
