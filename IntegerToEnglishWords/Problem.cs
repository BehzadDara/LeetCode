namespace IntegerToEnglishWords;

public static class Problem
{
    public static string Solve(int num)
    {
        if (num == 0) return "Zero";

        string words = "";

        if ((num / 1000000000) > 0)
        {
            words += Solve(num / 1000000000) + " Billion ";
            num %= 1000000000;
        }

        if ((num / 1000000) > 0)
        {
            words += Solve(num / 1000000) + " Million ";
            num %= 1000000;
        }

        if ((num / 1000) > 0)
        {
            words += Solve(num / 1000) + " Thousand ";
            num %= 1000;
        }

        if ((num / 100) > 0)
        {
            words += Solve(num / 100) + " Hundred ";
            num %= 100;
        }

        if (num > 0)
        {
            var unitsMap = new[] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten",
            "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };

            var tensMap = new[] { "Zero", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

            if (num < 20)
                words += unitsMap[num];
            else
            {
                words += tensMap[num / 10];
                if ((num % 10) > 0)
                    words += " " + unitsMap[num % 10];
            }
        }

        return words.TrimEnd(' ');
    }
}
