using System.Collections.Generic;
using System.Linq;

namespace Bowling.Domain
{
    public class Game
    {
        private readonly List<Frame> frames = new List<Frame>();
        
        public void Throw(int First, int Second)
        {
            frames.Add(new Frame(First, Second).CreateFrame());
        }
        public void LastThrow(int First, int Second, int Third)
        {
            frames.Add(new Final(First, Second, Third));
        }
        public int CalcScore()
        {
            var FramesLenght = frames.Count();
            for (int i = 0; i <= FramesLenght-1; i++)
            {
                if (i <= FramesLenght - 3)
                    frames[i].AddBonus(frames[i + 1], frames[i + 2]);
                if (i == FramesLenght - 2)
                    frames[i].AddBonus(frames[i + 1], new Frame(0, 0));
                if (i == FramesLenght-1)
                    frames[i].AddBonus(new Frame(0, 0), new Frame(0, 0));
            }
            int Counter = 0;
            frames.ForEach(frame => Counter += frame.CalcScore());
            return Counter;
        }

        static void Main()
        {

        }
    }
}
