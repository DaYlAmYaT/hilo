using System;

namespace hilo_program
{
    public class Card
    {
        public int randomCard = 1;

        public Card()
        {

        }


        public int GetCardNum()
        {
            Random randomGenerator = new Random();

            randomCard = randomGenerator.Next(1, 14);

            return randomCard;
        }


        public int GetNextCardNum(int previousNum, int nextCardNum)
        {
            do
            {
                nextCardNum = GetCardNum();

            } while (previousNum == nextCardNum);

            return nextCardNum;
        }
    }
}