namespace Bowling.Domain
{
    class Strike : Frame
    {
        public Strike() : base(10, 0) { }
        public override void AddBonus(Frame one, Frame two)
        {
            Score += (one.PinsFirstThrow == 10) ? (one.PinsFirstThrow + two.PinsFirstThrow) : (one.PinsFirstThrow + one.PinsSecondThrow);
        }
    }
}
