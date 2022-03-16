namespace TddDemoUnitTests.MaximumSubarray
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-subarray/
    /// </summary>
    public class MaximumSubarray
    {
        public int MaxSubArray(int[] nums)
        {
            var maxSum = nums[0];
            var currentSum = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                currentSum += nums[i];

                if (currentSum < maxSum)
                {
                    currentSum = 0;
                }
                else
                {
                    maxSum = currentSum;
                }
            }

            return maxSum;
        }
    }
}