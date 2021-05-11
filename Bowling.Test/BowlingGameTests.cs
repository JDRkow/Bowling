using Bowling.Domain;
using Xunit;

namespace Bowling.Test
{
    public class BowlingGameTests
    {
        protected Game Game { get; }
        public BowlingGameTests()
        {
            Game = new Game();
        }
        [Fact]
        public void TestFirstStrikeThrow()
        {
            Game.Throw(10, 0);
            Assert.Equal(10, Game.CalcScore());
        }
        [Fact]
        public void TestSrikePlusFirstThrow()
        {
            Game.Throw(10, 0);
            Game.Throw(7, 0);
            Assert.Equal(24, Game.CalcScore());
        }
        [Fact]
        public void TestStrikePlusSpare()
        {
            Game.Throw(10, 0);
            Game.Throw(7, 3);
            Assert.Equal(30 , Game.CalcScore());
        }
        [Fact]
        public void TestStrikePlusSparePlusOpen()
        {
            Game.Throw(10, 0);
            Game.Throw(7, 3);
            Game.Throw(7, 0);
            Assert.Equal(44 , Game.CalcScore());
        }
        [Fact]
        public void TestStrikePlusSparePlusOpenThrow()
        {
            Game.Throw(10, 0);
            Game.Throw(7, 3);
            Game.Throw(7, 2);
            Assert.Equal(46 , Game.CalcScore());
        }
        [Fact]
        public void TestSpareThenStrike()
        {
            Game.Throw(10, 0);
            Game.Throw(7, 3);
            Game.Throw(7, 2);
            Game.Throw(9, 1);
            Game.Throw(10,0);
            Assert.Equal(76 , Game.CalcScore());
        }
        [Fact]
        public void TestRowStrikes()
        {
            Game.Throw(10, 0);
            Game.Throw(7, 3);
            Game.Throw(7, 2);
            Game.Throw(9, 1);
            Game.Throw(10, 0);
            Game.Throw(10, 0);
            Game.Throw(10, 0);
            Assert.Equal(126 , Game.CalcScore());
        }
        [Fact]
        public void TsetWeakThrow()
        {
            Game.Throw(10, 0);
            Game.Throw(7, 3);
            Game.Throw(7, 2);
            Game.Throw(9, 1);
            Game.Throw(10, 0);
            Game.Throw(10, 0);
            Game.Throw(10, 0);
            Game.Throw(2, 3);
            Assert.Equal(138 , Game.CalcScore());
        }
        [Fact]
        public void TestSparePlusOpen()
        {
            Game.Throw(10, 0);
            Game.Throw(7, 3);
            Game.Throw(7, 2);
            Game.Throw(9, 1);
            Game.Throw(10, 0);
            Game.Throw(10, 0);
            Game.Throw(10, 0);
            Game.Throw(2, 3);
            Game.Throw(6, 4);
            Game.Throw(7, 0);
            Assert.Equal(162 , Game.CalcScore());
        }
        [Fact]
        public void TestSpareAtEnd()
        {
            Game.Throw(10, 0);
            Game.Throw(7, 3);
            Game.Throw(7, 2);
            Game.Throw(9, 1);
            Game.Throw(10, 0);
            Game.Throw(10, 0);
            Game.Throw(10, 0);
            Game.Throw(2, 3);
            Game.Throw(6, 4);
            Game.Throw(7, 3);
            Assert.Equal(165 , Game.CalcScore());
        }
        [Fact]
        public void TestEndGame()
        {
            Game.Throw(10, 0);
            Game.Throw(7, 3);
            Game.Throw(7, 2);
            Game.Throw(9, 1);
            Game.Throw(10, 0);
            Game.Throw(10, 0);
            Game.Throw(10, 0);
            Game.Throw(2, 3);
            Game.Throw(6, 4);
            Game.LastThrow(7, 3, 3);
            Assert.Equal(168 , Game.CalcScore());            
        }
        [Fact]
        public void AllStrikes()
        {
            for (int i = 0; i < 12; i++)
            {
                Game.Throw(10, 0);
            }
            Assert.Equal(330, Game.CalcScore());
        }
    }
}