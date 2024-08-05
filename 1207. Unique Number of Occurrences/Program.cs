using System.Numerics;
using System.Collections.Generic;
internal class Program
{
    private static void Main(string[] args)
    {
        Solution solution = new Solution();
        int[] ints = {1,1,2,2,2,3};
        bool solved = solution.UniqueOccurrences(ints);
        Console.WriteLine(solved);
    }
    public class Solution
    {
        public bool UniqueOccurrences(int[] arr)
        {
           Dictionary<int,int> dic = new Dictionary<int,int>();
            foreach (int i in arr)
            {
                if (dic.ContainsKey(i))
                    dic[i]++;
                else dic[i] = 1;
            }

            HashSet<int> list = new HashSet<int>(dic.Values);
            return list.Count == dic.Count;
        }
    }
}