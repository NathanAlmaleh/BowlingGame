using System;
using System.Collections.Generic;
using System.Text;

namespace Game101
{
    /* abstract class of frame 
     * each derrived class from this class will need to implement the methods that are writin in this abstract class
     * frameScore      => the total point in the current frame 
     * spare           => is it a spare frame
     * strike          =>   is it a strike frame
     * pointsTillNow   => total amount of points we did till now in the full game
     * toString        => prints the information about the current frame 
     **/
    abstract class Frame
    { 
        public abstract int frameScore();
        public abstract bool spare();
        public abstract bool strike();
        public abstract int pointsTillNow();
        public abstract string toString();
        public abstract string rollsToString();
    }
}
