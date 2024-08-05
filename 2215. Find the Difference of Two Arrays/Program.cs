using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        // Example usage:
        var solution = new Solution();
        var result = solution.FindDifference(new int[] { 1, 2, 3 }, new int[] { 2, 4, 6 });

        foreach (var list in result)
        {
            Console.WriteLine("[" + string.Join(", ", list) + "]");
        }
    }

    public class Solution
    {
        public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
        {
            var set1 = new HashSet<int>(nums1);
            var set2 = new HashSet<int>(nums2);

            var result1 = set1.Except(set2).ToList();
            var result2 = set2.Except(set1).ToList();

            return new List<IList<int>> { result1, result2 };
        }
    }
}
