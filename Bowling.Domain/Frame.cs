using System;
using System.Collections.Generic;
using System.Text;

namespace Bowling.Domain
{
    public class Frame
    {
        protected int _pinsFirstThrow;
        protected int _pinsSecondThrow;
        protected int _score;
        public Frame (int pinsFirstThrow, int pinsSecondThrow)
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
        public Frame Create(int first, int second)
        {
            if (first == 10)
                return new Strike();
            if ((first + second) == 10)
                return new Spare(first, second);
            return new Open(first, second);
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
