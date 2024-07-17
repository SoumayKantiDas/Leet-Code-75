using System;
using System.Collections.Generic;

public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        List<int> nonZeroElements = new List<int>();

        
        foreach (int num in nums)
        {
            if (num != 0)
            {
                nonZeroElements.Add(num);
            }
        }

       
        for (int i = 0; i < nonZeroElements.Count; i++)
        {
            nums[i] = nonZeroElements[i];
        }

      
        for (int i = nonZeroElements.Count; i < nums.Length; i++)
        {
            nums[i] = 0;
        }
    }
}

class Program
{
    static void Main()
    {
        int[] nums = { 0, 1, 0, 3, 12 };

        Solution solution = new Solution();
        solution.MoveZeroes(nums);

        Console.WriteLine("The array after moving zeroes:");
        Console.WriteLine(string.Join(",", nums));
    }
}
