namespace CodeTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] height = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            //int[] height = {1, 1};

            int left = 0, right = height.Length - 1;
            int maxAmount = 0;

            while (left < right)
            {
                int minimum = Math.Min(height[left], height[right]);

                maxAmount = Math.Max(maxAmount, minimum * (right - left));
                if (height[left] < height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            Console.WriteLine($"Max amount of water O(n): {maxAmount}");
            Console.ReadKey();
        }
    }
}