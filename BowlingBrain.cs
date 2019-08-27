using System;
using System.Collections.Generic;
using System.Text;

namespace Game101
{
    public class BowlingBrain
    {
        /**
         * SCORE= Total game score
         * index = puts the roll inside the array
         * rolls[] = saves all the rolls
         * FULLPINS = const number can be changed
         * FrameGame = list of frames to save each frame depends on the rollings
         * */
        private int SCORE;
        private int index = 0;
        private int [] rolls = new int [21];
        public const int FULLPINS = 10;
        private List<Frame> FrameGame;

        // function recieves an array list of rolling game and adds it to the rolling array;
        public void rollGame(params int[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                rolls[index++] = list[i];
            }
        }
        //main function that runs over the rolling array checks is spare/strike or normal add updates the MAIN SCORE
        //this function also create the FRAMEGAME with the corresponding class
        public int score()
        {
            FrameGame = new List<Frame>();
            int cursor = 0;
            for(int frame = 0; frame < 10; frame++)
            {
                if (isSpare(cursor))//spare
                {
                    SCORE += FULLPINS + rolls[cursor + 2];
                    cresteSpareFrame(rolls[cursor], rolls[cursor + 1], SCORE);
                    cursor += 2;
                }
                else if (isStrike(cursor))//strike
                {
                    SCORE += FULLPINS + rolls[cursor + 1] + rolls[cursor + 2];
                    cresteStrikeFrame(SCORE);
                    cursor++;
                }
                else
                {
                    SCORE += rolls[cursor] + rolls[cursor + 1];
                    cresteNormalFrame(rolls[cursor], rolls[cursor + 1], SCORE);
                    cursor += 2;
                }
            }
            return SCORE;
        }
        //prints each frame using the class toString() function and the rolling game
        public void gameTostring()
        {
            foreach (var FRAME in this.FrameGame)
            {
                Console.Write(FRAME.rollsToString());
            }
            Console.WriteLine();
            int frame = 0;
            foreach (var FRAME in this.FrameGame)
            {
                frame++;
                Console.WriteLine("Frame "+frame+"  : " +FRAME.toString());
            }

        }
        //creates a strikeframe add ads it to the list
        private void cresteStrikeFrame(int Full_SCORE) {

           FrameGame.Add( new StrikeFrame(Full_SCORE));
        }
        //creates a SpareFrame and adds it to the list
        private void cresteSpareFrame(int roll_1, int roll_2, int Full_SCORE) {

            FrameGame.Add(new SpareFrame(roll_1,roll_2,Full_SCORE));
        }
        //creates a normal frame and adds it to the list
        private void cresteNormalFrame(int roll_1, int roll_2, int Full_SCORE ) {

            FrameGame.Add(new normalFrame(roll_1,roll_2,Full_SCORE));
        }
        //checks if we have a strike with the index on the rolling array
        private bool isStrike(int cursor)
        {
            return rolls[cursor] == FULLPINS;
        }
        //checks if we have a spare with the index on the rolling array
        private bool isSpare(int cursor)
        {
            return rolls[cursor] + rolls[cursor + 1] == FULLPINS;
        }
    }
}
