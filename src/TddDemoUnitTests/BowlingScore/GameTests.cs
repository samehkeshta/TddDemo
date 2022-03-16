using Shouldly;
using Xunit;

namespace TddDemoUnitTests.BowlingScore
{
    public class GameTests
    {
        private readonly Game _game;

        public GameTests()
        {
            _game = new Game();
        }

        [Fact]
        public void RollZero_ScoreIsZero()
        {
            _game.Roll(0);
            _game.Score().ShouldBe(0);
        }

        [Fact]
        public void OpenFrame_AddsPins()
        {
            _game.Roll(4);
            _game.Roll(2);
            _game.Score().ShouldBe(6);
        }

        [Fact]
        public void Spare_AddsNextBall()
        {
            _game.Roll(4);
            _game.Roll(6);
            _game.Roll(3);
            _game.Roll(0);
            _game.Score().ShouldBe(16);
        }

        [Fact]
        public void TenInTwoFrames_IsNotASpare()
        {
            _game.Roll(3);
            _game.Roll(6);
            _game.Roll(4);
            _game.Roll(2);
            _game.Score().ShouldBe(15);
        }

        [Fact]
        public void Strike_AddsNextTwoBalls()
        {
            _game.Roll(10);
            _game.Roll(3);
            _game.Roll(2);
            _game.Score().ShouldBe(20);
        }

        [Fact]
        public void PerfectGame_ScoreIs300()
        {
            for (int i = 0; i < 12; i++)
            {
                _game.Roll(10);
            }

            _game.Score().ShouldBe(300);
        }
    }
}