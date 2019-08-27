using System;
using Xunit;
using Game101;

namespace BowlingTest
{
    /**
     * unit test for the bowling brain
     * we run different game to see if the score matches what we are supposed to 
     * */
    public class UnitTest1
    {
        BowlingBrain game = new BowlingBrain();

        [Fact]
        public void zeroPinDown()
        {
            game.rollGame(0,0,  0,0,  0,0,  0,0,  0,0,  0,0,  0,0,  0,0,  0,0,  0,0);
            Assert.Equal(0,game.score());
        }

        [Fact]
        public void onlyOnes()
        {
            game.rollGame( 1,1,  1,1,  1,1,  1,1,  1,1,  1,1,  1,1,  1,1  ,1,1,  1,1);
            Assert.Equal(20, game.score());
        }

        [Fact]
        public void spareFollowedByNothing()
        {
            game.rollGame(1,1,  1,1,  1,1,  1,1,  1,1,  5,5,  1,1,  1,1,  1,1,  1,1);
            Assert.Equal(29, game.score());
        }

        [Fact]
        public void strikeFollowedByNothing()
        {
            game.rollGame(10, 3,3 ,1,1, 1,1, 1,1, 1,5, 5,1, 1,1, 1,1, 1,1);
            Assert.Equal(46, game.score());
        }

        [Fact]
        public void fullStrike()
        {
            game.rollGame(10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 ,10);
            Assert.Equal(300, game.score());
        }

        [Fact]
        public void StrikeFollowedBySpare()
        {
            game.rollGame(10, 5,5, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10);
            Assert.Equal(280, game.score());
        }

    }
   
}
