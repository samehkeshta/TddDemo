using Shouldly;
using System;
using Xunit;

namespace TddDemoUnitTests.ProductofArrayExceptSelf
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
            Should.Throw<Exception>(() => _productOfArrayExceptSelfCalculator.ProductExceptSelf(nums));
        }

        [Fact]
        public void ArrayHave2Items_ReturnsTheArrayReverse()
        {
            var nums = new int[] { 1, 2 };

            var result = _productOfArrayExceptSelfCalculator.ProductExceptSelf(nums);

            result.ShouldBe(new int[] { 2, 1 });
        }

        [Fact]
        public void ArrayHavePositiveItems_ReturnsCorrectArray()
        {
            var nums = new int[] { 1, 2, 3, 4 };

            var result = _productOfArrayExceptSelfCalculator.ProductExceptSelf(nums);

            result.ShouldBe(new int[] { 24, 12, 8, 6 });
        }

        [Fact]
        public void ArrayHaveNegativeItems_ReturnsCorrectArray()
        {
            var nums = new int[] { -1, 1, 0, -3, 3 };

            var result = _productOfArrayExceptSelfCalculator.ProductExceptSelf(nums);

            result.ShouldBe(new int[] { 0, 0, 9, 0, 0 });
        }
    }
}