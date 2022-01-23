namespace BowlingUnitTests
{
    public class Game
    {
        private int _currentBall = 0;
        private int[] _rolled = new int[22];

        public void Roll(int pins)
        {
            _rolled[_currentBall] = pins;
            _currentBall++;
        }

        public int Score()
        {
            var score = 0;
            var thisBall = 0;

            for (int i = 0; i < 10; i++)
            {
                if (IsStrike(thisBall))
                {
                    score += CalculateStrikeScore(thisBall);
                    thisBall++;
                }
                else if (IsSpare(thisBall))
                {
                    score += CalculateSpareScore(thisBall);
                    thisBall += 2;
                }
                else
                {
                    score += CalculateOpenFrameScore(thisBall);
                    thisBall += 2;
                }
            }

            return score;
        }

        private int CalculateOpenFrameScore(int thisBall)
        {
            return _rolled[thisBall] + _rolled[thisBall + 1];
        }

        private int CalculateSpareScore(int thisBall)
        {
            return 10 + _rolled[thisBall + 2];
        }

        private int CalculateStrikeScore(int thisBall)
        {
            return 10 + _rolled[thisBall + 1] + _rolled[thisBall + 2];
        }

        private bool IsSpare(int thisBall)
        {
            return _rolled[thisBall] + _rolled[thisBall + 1] == 10;
        }

        private bool IsStrike(int thisBall)
        {
            return _rolled[thisBall] == 10;
        }
    }
}
