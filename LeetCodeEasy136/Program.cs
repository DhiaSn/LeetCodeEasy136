namespace LeetCodeEasy136
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result1 = Solution.SingleNumber([2, 2, 1]);
            if (result1 != 1)
            {
                Console.WriteLine($"result1 is: {result1} instead of 1");
                return;
            }
            int result2 = Solution.SingleNumber([4, 1, 2, 1, 2]);
            if (result2 != 4)
            {
                Console.WriteLine($"result2 is: {result2} instead of 4");
                return;
            }

            int result3 = Solution.SingleNumber([1]);
            if (result3 != 1)
            {
                Console.WriteLine($"result3 is: {result3} instead of 1");
                return;
            }

            Console.WriteLine($"it works perfectly!");
        }
    }
}
