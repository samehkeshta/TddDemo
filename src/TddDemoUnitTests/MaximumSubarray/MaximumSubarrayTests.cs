using Shouldly;
using Xunit;

namespace TddDemoUnitTests.MaximumSubarray
{
    public class MaximumSubarrayTests
    {
        private readonly MaximumSubarray _maximumSubarray;

        public MaximumSubarrayTests()
        {
            _maximumSubarray = new MaximumSubarray();
        }

        [Fact]
        public void ArrayHaveOneItem_ReturnTheItemValue()
        {
            var result = _maximumSubarray.MaxSubArray(new int[] { 1 });

            result.ShouldBe(1);
        }

        [Fact]
        public void ArrayHaveMoreThaneOneItem_ReturnTheMaxSubArraySum()
        {
            var result = _maximumSubarray.MaxSubArray(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 });

            result.ShouldBe(6);
        }
    }
}