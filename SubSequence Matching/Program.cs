using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Solution solution = new Solution();
        string s = "Asc";
        string t = "Astc";
        bool isSubsequence = solution.IsSubsequence(s, t);
        Console.WriteLine($"Is '{s}' a subsequence of '{t}'? {isSubsequence}");
    }

    public class Solution
    {
        public bool IsSubsequence(string s, string t)
        {
            int sPointer = 0;
            int tPointer = 0;
            int sLength = s.Length;
            int tLength = t.Length;

            while (sPointer < sLength && tPointer < tLength)
            {
                if (s[sPointer] == t[tPointer])
                {
                    sPointer++;
                }
                tPointer++;
            }

            return sPointer == sLength;
        }
    }
}
