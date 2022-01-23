using System;
using Xunit;

namespace ProductOfArrayExceptSelfUnitTests
{
    public class ProductOfArrayExceptSelfCalculatorTests
    {
        private ProductOfArrayExceptSelfCalculator _productOfArrayExceptSelfCalculator;

        public ProductOfArrayExceptSelfCalculatorTests()
        {
            _productOfArrayExceptSelfCalculator = new ProductOfArrayExceptSelfCalculator();
        }

        [Theory]
        [InlineData(new int[] { })]
        [InlineData(new int[] { 5 })]
        public void ArrayHaveLessThan2Items_ThrowsException(int[] nums)
        {
            Assert.Throws<Exception>(() => _productOfArrayExceptSelfCalculator.ProductExceptSelf(nums));
        }

        [Fact]
        public void ArrayHave2Items_ReturnsTheArrayReverse()
        {
            var nums = new int[] { 1, 2 };

            var result = _productOfArrayExceptSelfCalculator.ProductExceptSelf(nums);

            Assert.Equal(new int[] { 2, 1 }, result);
        }

        [Fact]
        public void ArrayHavePositiveItems_ReturnsCorrectArray()
        {
            var nums = new int[] { 1, 2, 3, 4 };

            var result = _productOfArrayExceptSelfCalculator.ProductExceptSelf(nums);

            Assert.Equal(new int[] { 24, 12, 8, 6 }, result);
        }

        [Fact]
        public void ArrayHaveNegativeItems_ReturnsCorrectArray()
        {
            var nums = new int[] { -1, 1, 0, -3, 3 };

            var result = _productOfArrayExceptSelfCalculator.ProductExceptSelf(nums);

            Assert.Equal(new int[] { 0, 0, 9, 0, 0 }, result);
        }
    }
}