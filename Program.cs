namespace MaximumCountPositiveIntegerNegativeInteger
{
    internal class Program
    {

        public class MaximumCountPositiveIntegerNegativeInteger
        {
            private int BinarySearch(int[] nums, bool isMinimumPositive = false)
            {
                int leftIdx = 0;
                int rightIdx = nums.Length - 1;
                while(leftIdx <= rightIdx)
                {
                    int middleIdx = leftIdx + (rightIdx - leftIdx) / 2;
                    if (isMinimumPositive)
                    {
                        if (nums[middleIdx] > 0)
                        {
                            rightIdx = middleIdx - 1;
                        }
                        else
                        {
                            leftIdx = middleIdx + 1;
                        }
                    }
                    else
                    {
                        if (nums[middleIdx] < 0)
                        {
                            leftIdx = middleIdx + 1;
                        }
                        else
                        {
                            rightIdx = middleIdx - 1;
                        }
                    }
                }
                return isMinimumPositive ? leftIdx : rightIdx;
            }

            public int MaximumCount(int[] nums)
            {
                int minimumPositiveIdx = BinarySearch(nums, true);
                int maximumNegativeIdx = BinarySearch(nums);
                return Math.Max(nums.Length - minimumPositiveIdx, maximumNegativeIdx + 1);
            }
        }
        static void Main(string[] args)
        {
            MaximumCountPositiveIntegerNegativeInteger maximumCountPositiveIntegerNegativeInteger = new();
            Console.WriteLine(maximumCountPositiveIntegerNegativeInteger.MaximumCount(new int[] { -2, -1, -1, 1, 2, 3 }));
            Console.WriteLine(maximumCountPositiveIntegerNegativeInteger.MaximumCount(new int[] { -3, -2, -1, 0, 0, 1, 2 }));
            Console.WriteLine(maximumCountPositiveIntegerNegativeInteger.MaximumCount(new int[] { 5, 20, 66, 1314 }));
        }
    }
}