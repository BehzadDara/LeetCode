namespace EarliestPossibleDayOfFullBloom;

public static class Problem
{
    public static int Solve(int[] plantTime, int[] growTime)
    {
        var result = 0;

        var list = new List<Tuple<int, int>>();
        for (int i = 0; i < plantTime.Length; i++)
        {
            list.Add(Tuple.Create(plantTime[i], growTime[i]));
        }
        list = list.OrderByDescending(x => x.Item2).ToList();

        var day = 0;
        foreach (var item in list)
        {
            day += item.Item1;
            result = Math.Max(result, day + item.Item2);
        }

        return result;
    }
}
