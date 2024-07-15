using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Please enter the string:");
        string s = Console.ReadLine();
        Solution solution = new Solution();
        string output = solution.ReverseVowels(s);
        Console.WriteLine("Output: " + output);
    }

    public class Solution
    {
        public string ReverseVowels(string s)
        {
            int length = s.Length;
            char[] sArray = s.ToCharArray();
            int[] vowelIndices = new int[length];
            char[] vowels = new char[length];
            int vowelCount = 0;

       
            for (int i = 0; i < length; i++)
            {
                if (IsVowel(sArray[i]))
                {
                    vowelIndices[vowelCount] = i;
                    vowels[vowelCount] = sArray[i];
                    vowelCount++;
                }
            }

            Array.Reverse(vowels, 0, vowelCount);

            for (int i = 0; i < vowelCount; i++)
            {
                sArray[vowelIndices[i]] = vowels[i];
            }

            return new string(sArray);
        }

        private bool IsVowel(char c)
        {
            return "AEIOUaeiou".IndexOf(c) >= 0;
        }
    }
}
