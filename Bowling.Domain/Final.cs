using System;
using System.Collections.Generic;
using System.Text;

namespace Bowling.Domain
{
    class Final : Frame
    {
        private int _pinsThirdThrow;
        public Final(int pinsFirstThrow, int pinsSecondThrow, int pinsThirdThrow) : base(pinsFirstThrow, pinsSecondThrow)
        {
            _pinsThirdThrow = pinsThirdThrow;
        }
        public override void AddBonus(Frame one, Frame two)
        {
            Score += _pinsThirdThrow;
        }
    }
}
