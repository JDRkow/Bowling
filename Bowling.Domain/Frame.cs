namespace Bowling.Domain
{
    public class Frame
    {
        protected int _pinsFirstThrow;
        protected int _pinsSecondThrow;
        protected int _score;
        public Frame (int pinsFirstThrow, int pinsSecondThrow)
        {
            _pinsFirstThrow = pinsFirstThrow;
            _pinsSecondThrow = pinsSecondThrow;
        }
        public int FirstThrow()
        {
            return _pinsFirstThrow;
        }
        public int SecondThrow()
        {
            return _pinsSecondThrow;
        }
        public Frame Create()
        {
            if (_pinsFirstThrow == 10)
                return new Strike();
            if ((_pinsFirstThrow + _pinsSecondThrow) == 10)
                return new Spare(_pinsFirstThrow, _pinsSecondThrow);
            return new Open(_pinsFirstThrow, _pinsSecondThrow);
        }
        public int Score()
        {
            return _pinsFirstThrow + _pinsSecondThrow + _score;
        }
        public virtual void Bonus(Frame one, Frame two)
        {
        }
        public void Bonus(int points)
        {
            _score += points;
        }
    }
}
