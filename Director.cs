using System;
using System.Collections.Generic;

namespace hilo_program
{
    public class Director
    {
        Card card = new Card();

        bool isPlaying;

        int score = 300;

        int previousNum = 1;

        int nextCardNum = 1;

        string guess = "idk";
        public void StartGame()
        {
            
            previousNum = card.NextCardNum();

            while (isPlaying)
            {
                ChangeGuessing(previousNum);

                nextCardNum = card.NextCardNum();

                DoUpdates1(guess, previousNum, nextCardNum);

                DoOutputs();

                DoUpdates2();
            }
        }

        public void ChangeGuessing(int cardNum)
        {
            
            Console.WriteLine($"\nThe card is: {cardNum}");

            Console.WriteLine("Higher or lower? [h/l]");

            guess = Console.ReadLine();
            
        }

        public void DoUpdates1(string guess, int previousNum, int nextCardNum)
        {
            int points = card.GetPoints(guess, previousNum, nextCardNum);

            score += points;

            if (score <= 0)
            {
                isPlaying = false;
            }

        }

        public void DoOutputs()
        {
            Console.WriteLine($"Next card was: {nextCardNum}");

            Console.WriteLine($"Your score is: {score}");

            if (!isPlaying)
            {
                return;
            }
            else
            {
                Console.WriteLine("Play again? [y/n]");

                string again = Console.ReadLine();
                
                if (again == "n")
                {
                    isPlaying = false;
                }
            }

        }

        public void DoUpdates2()
        {
            previousNum = nextCardNum;
        }
    }
}
