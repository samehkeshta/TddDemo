using Bowling;
using Xunit;

namespace BowlingUnitTests
{
    public class BowlingTests
    {
        private readonly Game _game;

        public BowlingTests()
        {
            _game = new Game();
        }

        [Fact]
        public void RollZero_ScoreIsZero()
        {
            _game.Roll(0);
            Assert.Equal(0, _game.Score());
        }

        [Fact]
        public void OpenFrame_AddsPins()
        {
            _game.Roll(4);
            _game.Roll(2);
            Assert.Equal(6, _game.Score());
        }

        [Fact]
        public void Spare_AddsNextBall()
        {
            _game.Roll(4);
            _game.Roll(6);
            _game.Roll(3);
            _game.Roll(0);
            Assert.Equal(16, _game.Score());
        }

        [Fact]
        public void TenInTwoFrames_IsNotASpare()
        {
            _game.Roll(3);
            _game.Roll(6);
            _game.Roll(4);
            _game.Roll(2);
            Assert.Equal(15, _game.Score());
        }

        [Fact]
        public void Strike_AddsNextTwoBalls()
        {
            _game.Roll(10);
            _game.Roll(3);
            _game.Roll(2);
            Assert.Equal(20, _game.Score());
        }

        [Fact]
        public void PerfectGame_ScoreIs300()
        {
            for (int i = 0; i < 12; i++)
            {
                _game.Roll(10);
            }

            Assert.Equal(300, _game.Score());
        }
    }
}