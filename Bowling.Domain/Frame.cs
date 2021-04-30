namespace Bowling.Domain
{
    public class Frame
    {
        public int _pinsFirstThrow;
        public int _pinsSecondThrow;
        public int _CalcScore;
        public Frame (int pinsFirstThrow, int pinsSecondThrow)
        {
            _pinsFirstThrow = pinsFirstThrow;
            _pinsSecondThrow = pinsSecondThrow;
        }
        public Frame CreateFrame()
        {
            if (_pinsFirstThrow == 10)
                return new Strike();
            if ((_pinsFirstThrow + _pinsSecondThrow) == 10)
                return new Spare(_pinsFirstThrow, _pinsSecondThrow);
            return new Open(_pinsFirstThrow, _pinsSecondThrow);
        }
        public int CalcScore()
        {
            return _pinsFirstThrow + _pinsSecondThrow + _CalcScore;
        }
        public virtual void AddBonus(Frame one, Frame two)
        {
        }
        public void AddBonus(int points)
        {
            _CalcScore += points;
        }
    }
}
