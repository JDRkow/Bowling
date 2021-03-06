using System;
using System.Collections.Generic;
using System.Text;

namespace Bowling.Domain
{
    class Spare : Frame
    {
        public Spare(int first, int second) : base(first, second) { }

        public override void Bonus(Frame one, Frame two)
        {
            _score += one.FirstThrow();
        }
    }
}
