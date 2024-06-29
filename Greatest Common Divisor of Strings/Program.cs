using System;

public class Solution
{
    public string GcdOfStrings(string str1, string str2)
    {
        if (!(str1 + str2).Equals(str2 + str1))
        {
            return "";
        }


        int gcd1 = gcd(str1.Length, str2.Length);
        return str1.Substring(0, gcd1);


    }

    public int gcd(int i, int j)
    {
        if (i > j )
        {
            if(j == 0) {
                return i;

            }
            return gcd(j, i % j);
        }
        else
        {
            if (j == 0)
            {
                return i;

            }
            return gcd(j, i % j);
        }
        
    }

    // Helper method to find GCD of two numbers


    // Main function to test the solution
    public static void Main(string[] args)
    {
        Solution solution = new Solution();

        string str1 = "ABCABC";
        string str2 = "ABC";
        Console.WriteLine(str1 + str2);
        Console.WriteLine(str2 + str1);
        Console.WriteLine("GCD of Strings: " + solution.GcdOfStrings(str1, str2)); // Output: "ABC"

        str1 = "ABABAB";
        str2 = "ABAB";
        Console.WriteLine(str1 + str2);
        Console.WriteLine(str2 + str1);
        Console.WriteLine("GCD of Strings: " + solution.GcdOfStrings(str1, str2)); // Output: "AB"

        str1 = "LEET";
        str2 = "CODE";
        Console.WriteLine(str1 + str2);
        Console.WriteLine(str2 + str1);
        Console.WriteLine("GCD of Strings: " + solution.GcdOfStrings(str1, str2)); // Output: ""

        
    }
}
