using System;
using System.Collections.Generic;
using System.Text;

namespace Bowling.Domain
{
    class Strike : Frame
    {
        public Strike() : base(10, 0) { }
        public override void Bonus(Frame one, Frame two)
        {
            _score += (one.FirstThrow() == 10) ? +10 + two.FirstThrow() : +one.FirstThrow() + one.SecondThrow();
        }
    }
}
