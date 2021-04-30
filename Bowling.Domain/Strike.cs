namespace Bowling.Domain
{
    class Strike : Frame
    {
        public Strike() : base(10, 0) { }
        public override void AddBonus(Frame one, Frame two)
        {
            Score += (one.pinsFirstThrow == 10) ? (one.pinsFirstThrow + two.pinsFirstThrow) : (one.pinsFirstThrow + one.pinsSecondThrow);
        }
    }
}
