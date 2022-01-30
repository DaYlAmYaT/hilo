using System;

using System.Collections.Generic;

namespace hilo_program
{
    public class Director
    {
        Card card = new Card();

        Player player = new Player();

        public void StartGame()
        {   
            player._previousNum = card.GetCardNum();

            while (player._isPlayer && !player._gameOver)
            {
                player.GetGuessing();

                player._currentNum = card.GetNextCardNum(player._previousNum, player._currentNum);

                DoUpdates();

                DoOutputs();
            }

            EndGameMessage();
        }

        public void DoUpdates()
        {
            int points = player.GetPoints();

            player._score += points;

            if (player._score <= 0)
            {
                player._gameOver = true;
            }
        }

        public void DoOutputs()
        {
            Console.WriteLine($"Next card was: {player._currentNum}");

            Console.WriteLine($"Your score is: {player._score}");

            if (!player._isPlayer || player._gameOver)
            {
                return;
            }
            else
            {
                Console.WriteLine("Play again? [y/n]");

                string userInput = Console.ReadLine();

                if (userInput != "y")
                {
                    player._isPlayer = false;
                }

                player._previousNum = player._currentNum;
            }

        }

        public void EndGameMessage()
        {
            if (player._gameOver)
            {
                Console.WriteLine("\nGame Over!");
            }
            else
            {
                Console.WriteLine("\nNice Job!");
            }

            Console.WriteLine("Thanks for playing!");
        }
    }
}
