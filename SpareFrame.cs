using System;
using System.Collections.Generic;
using System.Text;

namespace Game101
{
    class SpareFrame : Frame
    {

        /**
         * Spare Frame inherent the abstract class frame and need to implement all the methods
         * 
         * SCORE= amount of points we did till now
         * roll_1=how many pins fell in the first roll
         * roll_2=how many pins fell in the second roll
         * */

        private int roll_1,roll_2,SCORE;
        //constructor recieves the points we did till now in the game and the 2 rolls information
        public SpareFrame(int roll_1,int roll_2,int ScoreGame)
        {
            this.SCORE = ScoreGame;
            this.roll_1 = roll_1;
            this.roll_2 = roll_2;
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
            return "| " + this.roll_1 + " , " + this.roll_2 + " |";
        }

        //we are in Spare class this function return true
        public override bool spare()
        {
            return true;
        }
        //we are in spare class this function return false
        public override bool strike()
        {
            return false;
        }
        //returns  frame information
        public override string toString()
        {
            return "Spare " + roll_1 + "," + roll_2 + " Score => " + this.SCORE;
        }
    }
}
