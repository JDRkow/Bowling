using System;
using System.Collections.Generic;
using System.Text;

namespace Bowling.Domain
{
    class Frame
    {
        private int _pinsFirstThrow;
        private int _pinsSecondThrow;
        private int _score;
        public int FirstThrow()
        {
            return _pinsFirstThrow;
        }
        public int SecondThrow()
        {
            return _pinsSecondThrow;
        }
        public Frame Add(int first, int second)
        {
            if (first == 10)
                return new Frame();//strike
            if ((first + second) == 10)
                return new Frame();//spare
            return new Frame();//open
        }
        public int Score()
        {
            return _pinsFirstThrow + _pinsSecondThrow + _score;
        }
        public void Bonus(int points)
        {
            _score += points;
        }
    }
}
