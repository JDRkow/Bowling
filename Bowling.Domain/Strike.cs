namespace Bowling.Domain
{
    class Strike : Frame
    {
        public Strike() : base(10, 0) { }
        public override void AddBonus(Frame one, Frame two)
        {
            _CalcScore += (one.FirstThrow() == 10) ? +10 + two.FirstThrow() : +one.FirstThrow() + one.SecondThrow();
        }
    }
}
