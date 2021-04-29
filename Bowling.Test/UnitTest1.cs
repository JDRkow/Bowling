using Bowling.Domain;
using Xunit;

namespace Bowling.Test
{
    public class UnitTest1
    {
        protected Game game = new Game();
        [Fact]
        public void TestFirstStrikeThrow()
        {
            game.Throw(10, 0);
            Assert.True(10 == game.Score());
        }
        [Fact]
        public void TestSrikePlusFirstThrow()
        {
            game.Throw(10, 0);
            game.Throw(7, 0);
            Assert.True(24 == game.Score());
        }
        [Fact]
        public void TestStrikePlusSpare()
        {
            game.Throw(10, 0);
            game.Throw(7, 3);
            Assert.True(30 == game.Score());
        }
        [Fact]
        public void TestStrikePlusSparePlusOpen()
        {
            game.Throw(10, 0);
            game.Throw(7, 3);
            game.Throw(7, 0);
            Assert.True(44 == game.Score());
        }
        [Fact]
        public void TestStrikePlusSparePlusOpenThrow()
        {
            game.Throw(10, 0);
            game.Throw(7, 3);
            game.Throw(7, 2);
            Assert.True(46 == game.Score());
        }
        [Fact]
        public void TestSpareThenStrike()
        {
            game.Throw(10, 0);
            game.Throw(7, 3);
            game.Throw(7, 2);
            game.Throw(9, 1);
            game.Throw(10,0);
            Assert.True(76 == game.Score());
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
            Assert.True(126 == game.Score());
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
            Assert.True(138 == game.Score());
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
            Assert.True(162 == game.Score());
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
            Assert.True(165 == game.Score());
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
            game.Throw(7, 3);
            game.Throw(3, 0);
            Assert.True(168 == game.Score());            
        }
    }
}