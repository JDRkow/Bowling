using Bowling.Domain;
using System;
using Xunit;

//

namespace Bowling.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var game = new Game();
            for (int i=0; i < 10; i++)
            {
                game.Throw(1, 1);
            }
            Assert.True(20 == game.Score());
            
        }
    }
}