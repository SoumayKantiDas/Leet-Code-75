internal class Program
{
    private static void Main(string[] args)
    {
        Solution solution = new Solution();

        int[] flowerbed1 = { 1, 0, 0, 0, 1 };
        int n1 = 1;
        Console.WriteLine(solution.CanPlaceFlowers(flowerbed1, n1));  // Output: true

        int[] flowerbed2 = { 1, 0, 0, 0, 1 };
        int n2 = 2;
        Console.WriteLine(solution.CanPlaceFlowers(flowerbed2, n2));  // Output: false
    }

    public class Solution
    {
        public bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            int length = flowerbed.Length;
            int probableSit = 0;

            for (int i = 0; i < length; i++)
            {
                if (flowerbed[i] == 0)
                {
                    bool emptyPrev = false;
                    bool emptyNext = false;

                  
                    if (flowerbed[i - 1] == 0)
                    {
                        emptyPrev = true;
                    }

                    
                    if ( flowerbed[i + 1] == 0)
                    {
                        emptyNext = true;
                    }

                    
                    if (emptyPrev && emptyNext)
                    {
                        flowerbed[i] = 1;
                        probableSit++;
                        i++; 
                    }
                }
            }

            return probableSit >= n;
        }
    }
}
