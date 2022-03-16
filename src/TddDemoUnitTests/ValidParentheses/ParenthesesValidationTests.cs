using Shouldly;
using Xunit;

namespace TddDemoUnitTests.ValidParentheses
{
    public class ParenthesesValidationTests
    {
        private readonly ParenthesesValidation _parenthesesValidation;

        public ParenthesesValidationTests()
        {
            _parenthesesValidation = new ParenthesesValidation();
        }

        [Theory]
        [InlineData("()")]
        [InlineData("[]")]
        [InlineData("{}")]
        [InlineData("()[]")]
        [InlineData("(){}")]
        [InlineData("[]()")]
        [InlineData("[]{}")]
        [InlineData("{}[]")]
        [InlineData("{}()")]
        [InlineData("()[]{}")]
        [InlineData("(){}[]")]
        [InlineData("[](){}")]
        [InlineData("[]{}()")]
        [InlineData("{}[]()")]
        [InlineData("{}()[]")]
        public void OpenBrackets_MustBeClosedByTheSameTypeOfBrackets(string s)
        {
            var result = _parenthesesValidation.Validate(s);

            result.ShouldBeTrue();
        }

        [Theory]
        [InlineData("([])")]
        [InlineData("()[{}]")]
        [InlineData("[(()[]){()}]")]
        public void OpenBrackets_MustBeClosedInTheCorrectOrder(string s)
        {
            var result = _parenthesesValidation.Validate(s);

            result.ShouldBeTrue();
        }

        [Theory]
        [InlineData("(]")]
        [InlineData("[(()()}]")]
        [InlineData("[()()]{")]
        [InlineData("}(){")]
        public void InvalidOpenBrackets_MustReturnFalse(string s)
        {
            var result = _parenthesesValidation.Validate(s);

            result.ShouldBeFalse();
        }
    }
}