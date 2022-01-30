using System;

using System.Collections.Generic;

namespace hilo_program
{
    public class Player
    {
        public bool _isPlayer = true;
        
        public int _score = 300;

        public int _previousNum = 0;

        public int _currentNum = 14;

        public bool _guessHigher = true;

        public bool _again = true;

        public bool _gameOver = false;

        public void GetGuessing()
        {
            Console.WriteLine($"\nThe card is: {_previousNum}");

            Console.WriteLine("Higher or lower? [h/l]");

            string guess = Console.ReadLine();

            if (guess == "h")
            {
                _guessHigher = true;
            }
            else
            {
                _guessHigher = false;
            }
        }

        public int GetPoints()
        {
            bool correct = false;

            if (((_guessHigher) && (_previousNum < _currentNum)) || ((!_guessHigher) && (_previousNum > _currentNum)))
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