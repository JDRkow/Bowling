namespace Bowling.Domain
{
    public class Frame
    {
        public int pinsFirstThrow;
        public int pinsSecondThrow;
        public int Score;
        public Frame (int pinsFirst, int pinsSecond)
        {
            pinsFirstThrow = pinsFirst;
            pinsSecondThrow = pinsSecond;
        }
        public Frame CreateFrame()
        {
            if (pinsFirstThrow == 10)
                return new Strike();
            if ((pinsFirstThrow + pinsSecondThrow) == 10)
                return new Spare(pinsFirstThrow, pinsSecondThrow);
            return new Open(pinsFirstThrow, pinsSecondThrow);
        }
        public int CalcScore()
        {
            return pinsFirstThrow + pinsSecondThrow + Score;
        }
        
        public virtual void AddBonus(Frame one, Frame two)
        {
        }
    }
}
