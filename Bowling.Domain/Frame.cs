namespace Bowling.Domain
{
    public class Frame
    {
        public int PinsFirstThrow;
        public int PinsSecondThrow;
        public int Score;
        public Frame (int pinsFirst, int pinsSecond)
        {
            PinsFirstThrow = pinsFirst;
            PinsSecondThrow = pinsSecond;
        }
        public Frame CreateFrame()
        {
            if (PinsFirstThrow == 10)
                return new Strike();
            if ((PinsFirstThrow + PinsSecondThrow) == 10)
                return new Spare(PinsFirstThrow, PinsSecondThrow);
            return new Plain(PinsFirstThrow, PinsSecondThrow);
        }
        public int CalcScore()
        {
            return PinsFirstThrow + PinsSecondThrow + Score;
        }
        
        public virtual void AddBonus(Frame one, Frame two)
        {
        }
    }
}
