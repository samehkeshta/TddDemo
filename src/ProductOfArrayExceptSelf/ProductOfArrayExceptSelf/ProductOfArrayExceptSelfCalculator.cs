namespace ProductOfArrayExceptSelf
{
    /// <summary>
    /// https://leetcode.com/problems/product-of-array-except-self/
    /// </summary>
    public class ProductOfArrayExceptSelfCalculator
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            if (nums.Length < 2) throw new Exception("Array Length should be greater than or equal 2.");

            var answers = new int[nums.Length];
            var prefixProduct = 1;

            for (int i = 0; i < nums.Length; i++)
            {
                answers[i] = prefixProduct;

                prefixProduct *= nums[i];
            }

            var suffixProduct = 1;

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                answers[i] *= suffixProduct;

                suffixProduct *= nums[i];
            }

            return answers;
        }
    }
}