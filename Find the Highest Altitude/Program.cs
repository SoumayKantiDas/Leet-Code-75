internal class Program
{
    private static void Main(string[] args)
    {
        Solution solution = new Solution();

        int[] arrr = [-5, 1, 5, 0, -7];

        int d = solution.LargestAltitude(arrr);

        Console.WriteLine(d);
    }
    public class Solution
    {
        public int LargestAltitude(int[] gain)
        {
            int max = 0;
            int current = 0;    

            foreach (int i in gain)
            {
                current += i;

                if (current > max)
                {
                    max = current;
                }
            }
            return max;
        }
    }
}