using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Please insert the First Word");
        string word1 = Console.ReadLine();
        Console.WriteLine("Please Insert the Second Word");
        string word2 = Console.ReadLine(); // Reading the second word

        Solution solution = new Solution();
        string merged = solution.MergeAlternately(word1, word2);
        Console.WriteLine("Merged result: " + merged);
    }
}

public class Solution
{
    public string MergeAlternately(string word1, string word2)
    {
        int len1 = word1.Length;
        int len2 = word2.Length;

        char[] output = new char[len1 + len2];
        int i = 0; int j = 0; int k = 0;
        while (i < len1 && j < len2)
        {
            output[k++] = word1[i++];
            output[k++] = word2[j++];
        }
        if (len1 > len2)
        {
            while (i < len1)
            {
                output[k++] = word1[i++];
            }

        }
        else
        {
            while (j < len2)
            {
                output[k++] = word2[j++];
            }
        }
        return new string(output);
    }
}
