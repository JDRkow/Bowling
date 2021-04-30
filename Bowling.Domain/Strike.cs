namespace Bowling.Domain
{
    class Strike : Frame
    {
        public Strike() : base(10, 0) { }
        public override void AddBonus(Frame one, Frame two)
        {
            _CalcScore += (one._pinsFirstThrow == 10) ? +10 + two._pinsFirstThrow : +one._pinsFirstThrow + one._pinsSecondThrow;
        }
    }
}
