using Bowling.Domain;
using Xunit;

namespace Bowling.Test
{
    public class BowlingGameTests
    {
        protected Game game { get; }
        public BowlingGameTests()
        {
            game = new Game();
        }
        [Fact]
        public void TestFirstStrikeThrow()
        {
            game.Throw(10, 0);
            Assert.Equal(10, game.CalcScore());
        }
        [Fact]
        public void TestSrikePlusFirstThrow()
        {
            game.Throw(10, 0);
            game.Throw(7, 0);
            Assert.Equal(24, game.CalcScore());
        }
        [Fact]
        public void TestStrikePlusSpare()
        {
            game.Throw(10, 0);
            game.Throw(7, 3);
            Assert.Equal(30 , game.CalcScore());
        }
        [Fact]
        public void TestStrikePlusSparePlusOpen()
        {
            game.Throw(10, 0);
            game.Throw(7, 3);
            game.Throw(7, 0);
            Assert.Equal(44 , game.CalcScore());
        }
        [Fact]
        public void TestStrikePlusSparePlusOpenThrow()
        {
            game.Throw(10, 0);
            game.Throw(7, 3);
            game.Throw(7, 2);
            Assert.Equal(46 , game.CalcScore());
        }
        [Fact]
        public void TestSpareThenStrike()
        {
            game.Throw(10, 0);
            game.Throw(7, 3);
            game.Throw(7, 2);
            game.Throw(9, 1);
            game.Throw(10,0);
            Assert.Equal(76 , game.CalcScore());
        }
        [Fact]
        public void TestRowStrikes()
        {
            game.Throw(10, 0);
            game.Throw(7, 3);
            game.Throw(7, 2);
            game.Throw(9, 1);
            game.Throw(10, 0);
            game.Throw(10, 0);
            game.Throw(10, 0);
            Assert.Equal(126 , game.CalcScore());
        }
        [Fact]
        public void TsetWeakThrow()
        {
            game.Throw(10, 0);
            game.Throw(7, 3);
            game.Throw(7, 2);
            game.Throw(9, 1);
            game.Throw(10, 0);
            game.Throw(10, 0);
            game.Throw(10, 0);
            game.Throw(2, 3);
            Assert.Equal(138 , game.CalcScore());
        }
        [Fact]
        public void TestSparePlusOpen()
        {
            game.Throw(10, 0);
            game.Throw(7, 3);
            game.Throw(7, 2);
            game.Throw(9, 1);
            game.Throw(10, 0);
            game.Throw(10, 0);
            game.Throw(10, 0);
            game.Throw(2, 3);
            game.Throw(6, 4);
            game.Throw(7, 0);
            Assert.Equal(162 , game.CalcScore());
        }
        [Fact]
        public void TestSpareAtEnd()
        {
            game.Throw(10, 0);
            game.Throw(7, 3);
            game.Throw(7, 2);
            game.Throw(9, 1);
            game.Throw(10, 0);
            game.Throw(10, 0);
            game.Throw(10, 0);
            game.Throw(2, 3);
            game.Throw(6, 4);
            game.Throw(7, 3);
            Assert.Equal(165 , game.CalcScore());
        }
        [Fact]
        public void TestEndGame()
        {
            game.Throw(10, 0);
            game.Throw(7, 3);
            game.Throw(7, 2);
            game.Throw(9, 1);
            game.Throw(10, 0);
            game.Throw(10, 0);
            game.Throw(10, 0);
            game.Throw(2, 3);
            game.Throw(6, 4);
            game.LastThrow(7, 3, 3);
            Assert.Equal(168 , game.CalcScore());            
        }
        [Fact]
        public void AllStrikes()
        {
            for (int i = 0; i < 12; i++)
            {
                game.Throw(10, 0);
            }
            Assert.Equal(330, game.CalcScore());
        }
    }
}