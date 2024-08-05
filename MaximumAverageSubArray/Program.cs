internal class Program
{
    private static void Main(string[] args)
    {
        Solution solution = new Solution();
        int[] nums = { 5, -6, 7, 8, 9, 10, -2 };
        int k = 5;

        double maxAverage = solution.FindMaxAverage(nums, k);

        Console.WriteLine(maxAverage);
    }
}

public class Solution
{
    public double FindMaxAverage(int[] nums, int k)
    {
        int n = nums.Length;
        if (n == 0 || k > n) return 0.0;

     
        double sum = 0;
        for (int i = 0; i < k; i++)
        {
            sum += nums[i];
        }

    
        double maxSum = sum;

        for (int i = k; i < n; i++)
        {
     
            sum += nums[i] - nums[i - k];
      
            if (sum > maxSum)
            {
                maxSum = sum;
            }
        }

      
        return maxSum / k;
    }
}
