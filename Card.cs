using System;

namespace hilo_program
{
    public class Card
    {
        public int randomCard = 1;

        public int points = 300;

        public Card()
        {

        }

        public int NextCardNum()
        {
            Random randomGenerator = new Random();

            randomCard = randomGenerator.Next(1, 14);

            return randomCard;
        }

        public int GetPoints(string guess, int previousNum, int currentNum)
        {
            bool correct = false;

            if (((guess == "h") && (previousNum < currentNum)) || ((guess == "l") && (previousNum > currentNum)))
            {
                correct = true;
            }
            if (correct)
            {
                return 100;
            }
            else
            {
                return -75;
            }
        }
    }
}