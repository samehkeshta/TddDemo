using ValidParentheses;
using Xunit;

namespace ValidParenthesesUnitTests
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
            
            Assert.True(result);
        }

        [Theory]
        [InlineData("([])")]
        [InlineData("()[{}]")]
        [InlineData("[(()[]){()}]")]
        public void OpenBrackets_MustBeClosedInTheCorrectOrder(string s)
        {
            var result = _parenthesesValidation.Validate(s);

            Assert.True(result);
        }

        [Theory]
        [InlineData("(]")]
        [InlineData("[(()()}]")]
        [InlineData("[()()]{")]
        [InlineData("}(){")]
        public void InvalidOpenBrackets_MustReturnFalse(string s)
        {
            var result = _parenthesesValidation.Validate(s);

            Assert.False(result);
        }
    }
}