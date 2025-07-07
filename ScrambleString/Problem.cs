
namespace ScrambleString;

public static class Problem
{
    private static readonly Dictionary<(string, string), bool> _memo = [];

    public static bool Solve(string s1, string s2)
    {
        _memo.Clear();
        return IsScramble(s1, s2);
    }

    private static bool IsScramble(string s1, string s2)
    {
        if (s1.Equals(s2))
            return true;

        if (s1.Length != s2.Length)
            return false;

        var key = (s1, s2);
        if (_memo.TryGetValue(key, out bool cached))
            return cached;

        if (!HasSameCharacters(s1, s2))
        {
            _memo[key] = false;
            return false;
        }

        for (int i = 1; i < s1.Length; i++)
        {
            if (IsScramble(s1[..i], s2[..i]) && IsScramble(s1[i..], s2[i..]))
            {
                _memo[key] = true;
                return true;
            }

            if (IsScramble(s1[..i], s2[^i..]) && IsScramble(s1[i..], s2[..^i]))
            {
                _memo[key] = true;
                return true;
            }
        }

        _memo[key] = false;
        return false;
    }

    private static bool HasSameCharacters(string s1, string s2)
    {
        if (s1.Length != s2.Length)
            return false;

        int[] count = new int[26];
        for (int i = 0; i < s1.Length; i++)
        {
            count[s1[i] - 'a']++;
            count[s2[i] - 'a']--;
        }

        return count.All(x => x == 0);
    }
}
