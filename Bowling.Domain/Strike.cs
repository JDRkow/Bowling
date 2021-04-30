namespace Bowling.Domain
{
    class Strike : Frame
    {
        public Strike() : base(10, 0) { }
        public override void AddBonus(Frame one, Frame two)
        {
            Score += (one.pinsFirstThrow == 10) ? +10 + two.pinsFirstThrow : +one.pinsFirstThrow + one.pinsSecondThrow;
        }
    }
}
