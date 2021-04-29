namespace Bowling.Domain
{
    class Spare : Frame
    {
        public Spare(int first, int second) : base(first, second) { }

        public override void AddBonus(Frame one, Frame two)
        {
            _CalcScore += one.FirstThrow();
        }
    }
}
