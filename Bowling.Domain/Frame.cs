using System;
using System.Collections.Generic;
using System.Text;

namespace Bowling.Domain
{
    class Frame
    {
        private int _pinsFirstThrow;
        private int _pinsSecondThrow;
        protected int _score;
        protected Frame (int pinsFirstThrow, int pinsSecondThrow)
        {
            _pinsFirstThrow = pinsFirstThrow;
            _pinsSecondThrow = pinsSecondThrow;
        }
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
                return new Strike();//strike
            if ((first + second) == 10)
                return new Spare();//spare
            return new Open();//open
        }
        public int Score()
        {
            return _pinsFirstThrow + _pinsSecondThrow + _score;
        }
        public virtual void Bonus(Frame one, Frame two)
        {
        }
        public void Bonus(int points)
        {
            _score += points;
        }
    }
}
