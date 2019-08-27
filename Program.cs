using System;

namespace Game101
{
    class Program
    {
        //main class to see the printing information of different games and the points in each different frame
        static void Main(string[] args)
        {
            BowlingBrain game = new BowlingBrain();
 
            game.rollGame(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 5, 5, 1, 1, 1, 1, 1, 1, 1, 1);
            Console.WriteLine("Game Final Score : " + game.score());
            game.gameTostring();
            Console.WriteLine("\n");

            game = new BowlingBrain();
            game.rollGame(10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10);

            Console.WriteLine("Game Final Score : " + game.score());
            game.gameTostring();
            Console.WriteLine("\n");

            game = new BowlingBrain();
            game.rollGame(10, 5, 5, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10);

            Console.WriteLine("Game Final Score : " + game.score());
            game.gameTostring();
            Console.WriteLine("\n");

            Console.ReadKey();
        }

    }
}
