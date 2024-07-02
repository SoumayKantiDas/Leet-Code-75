using System;
using System.Collections.Generic;

public class Solution
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        // Step 1: Find the maximum number of candies any kid currently has
        int maxCandies = candies[0];
        int lengthOfCandies = candies.Length;

        for (int i = 1; i < lengthOfCandies; i++)
        {
            if (candies[i] > maxCandies)
            {
                maxCandies = candies[i];
            }
        }

        // Step 2: Create the result list and check each kid
        IList<bool> result = new List<bool>();
        for (int i = 0; i < lengthOfCandies; i++)
        {
            if (candies[i] + extraCandies >= maxCandies)
            {
                result.Add(true);
            }
            else
            {
                result.Add(false);
            }
        }

        return result;
    }
}

public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();

        // Example 1
        int[] candies1 = { 2, 3, 5, 1, 3 };
        int extraCandies1 = 3;
        IList<bool> result1 = solution.KidsWithCandies(candies1, extraCandies1);
        Console.WriteLine(string.Join(", ", result1)); // Output: True, True, True, False, True

        // Example 2
        int[] candies2 = { 4, 2, 1, 1, 2 };
        int extraCandies2 = 1;
        IList<bool> result2 = solution.KidsWithCandies(candies2, extraCandies2);
        Console.WriteLine(string.Join(", ", result2)); // Output: True, False, False, False, False

        // Example 3
        int[] candies3 = { 12, 1, 12 };
        int extraCandies3 = 10;
        IList<bool> result3 = solution.KidsWithCandies(candies3, extraCandies3);
        Console.WriteLine(string.Join(", ", result3)); // Output: True, False, True
    }
}
