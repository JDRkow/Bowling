namespace Bowling.Domain
{
    class Final : Frame
    {
        private int _pinsThirdThrow;
        public Final(int PinsFirstThrow, int PinsSecondThrow, int pinsThirdThrow) : base(PinsFirstThrow, PinsSecondThrow)
        {
            _pinsThirdThrow = pinsThirdThrow;
        }
        public override void AddBonus(Frame one, Frame two)
        {
            Score += _pinsThirdThrow;
        }
    }
}
