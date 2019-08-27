using System;
using System.Collections.Generic;
using System.Text;

namespace Game101
{
    class normalFrame : Frame
    {
        /**
         * Normal Frame inherent the abstract class frame and need to implement all the methods
         * 
         * SCORE= amount of points we did till now
         * roll_1=how many pins fell in the first roll
         * roll_2=how many pins fell in the second roll
         * */
       private int roll_1, roll_2;
       private int SCORE;
        //constructor recieves the points we did till now in the game and the 2 rolls information
        public normalFrame(int i,int j,int score)
        {
            roll_1 = i;
            roll_2 = j;
            this.SCORE = score;
        }
        //return the point we did in the current frame
        public override int frameScore()
        {
            return roll_1 + roll_2;
        }
        //reuts false because no spare was made
        public override bool spare()
        {
            return false;
        }
        //returns false because no strike as made
        public override bool strike()
        {
            return false;
        }

        //return the points we did till now 
        public override int pointsTillNow()
        {
            return SCORE;
        }
        //returns  frame information
        public override string toString()
        {
            return "Normal Frame " + roll_1+","+roll_2 + " Score => " + this.SCORE;
        }

        public override string rollsToString()
        {
            return "| " + this.roll_1 + " , " + this.roll_2 + " |";
        }
    }
}
