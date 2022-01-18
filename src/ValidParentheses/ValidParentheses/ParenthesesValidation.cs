namespace ValidParentheses
{
    public class ParenthesesValidation
    {
        private readonly char _leftCircleBracket = '(';
        private readonly char _rightCircleBracket = ')';

        private readonly char _leftSquareBracket = '[';
        private readonly char _rightSquareBracket = ']';

        private readonly char _leftCurlyBracket = '{';
        private readonly char _rightCurlyBracket = '}';

        public bool Validate(string s)
        {
            var stack = new Stack<char>();

            foreach (var c in s)
            {
                if (c == _leftCircleBracket || c == _leftSquareBracket || c == _leftCurlyBracket)
                {
                    stack.Push(c);
                    continue;
                }
                
                if (stack.Count == 0)
                {
                    return false;
                }

                var topChar = stack.Pop();

                if (c == _rightCircleBracket && topChar == _leftCircleBracket)
                {
                    continue;
                }

                if (c == _rightSquareBracket && topChar == _leftSquareBracket)
                {
                    continue;
                }

                if (c == _rightCurlyBracket && topChar == _leftCurlyBracket)
                {
                    continue;
                }

                return false;
            }

            return stack.Count == 0;
        }
    }
}