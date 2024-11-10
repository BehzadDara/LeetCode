namespace Shared.Helpers;

public static class PrintHelper
{
    public static void Print(this IList<int> list)
    {
        Console.WriteLine(string.Join(", ", list));
    }

    public static void Print(this IList<IList<int>> list)
    {
        foreach (var item in list)
        {
            item.Print();
        }
    }
}