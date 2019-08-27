using System;
using System.Collections.Generic;
using System.Text;

namespace Game101
{
    class StrikeFrame : Frame
    {
        /**
         * Strike Frame inherent the abstract class frame and need to implement all the methods
         * 
         * SCORE= amount of points we did till now
         * */
        private int SCORE;

        //constructor recieves the points we did till now in the game 
        public StrikeFrame(int SCORE)
        {
            this.SCORE = SCORE;
        }
        //how many points we did derived from the bowling Game public FULLPINS so we can change the settings of the game to more or less pins 
        public override int frameScore()
        {
            return BowlingBrain.FULLPINS;
        }
        //return the points we did till now 
        public override int pointsTillNow()
        {
            return this.SCORE;
        }

        public override string rollsToString()
        {
            return "| " + BowlingBrain.FULLPINS + " ,  X "  + " |";
        }

        //we are in strike class this function return false
        public override bool spare()
        {
          return false;
        }
        //we are in strike class this function return true
        public override bool strike()
        {
            return true;
        }
        //returns  frame information
        public override string toString()
        {
            return "Strike " + BowlingBrain.FULLPINS + " Score => " + this.SCORE;
        }
    }
}
