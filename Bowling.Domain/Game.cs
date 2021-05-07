using System.Collections.Generic;
using System.Linq;

namespace Bowling.Domain
{
    public class Game
    {
        private readonly List<Frame> frames = new List<Frame>();
        
        public void Throw(int first, int second)
        {
            frames.Add(new Frame(first, second).CreateFrame());
        }
        public void LastThrow(int first, int second, int third)
        {
            frames.Add(new Final(first, second, third));
        }
        public int CalcScore()
        {
            var framesLenght = frames.Count();
            for (int i = 0; i <= framesLenght-1; i++)
            {
                if (i <= framesLenght - 3)
                    frames[i].AddBonus(frames[i + 1], frames[i + 2]);
                if (i == framesLenght - 2)
                    frames[i].AddBonus(frames[i + 1], new Frame(0, 0));
                if (i == framesLenght-1)
                    frames[i].AddBonus(new Frame(0, 0), new Frame(0, 0));
            }
            int counter = 0;
            frames.ForEach(frame => counter += frame.CalcScore());
            return counter;
        }

        static void Main(string[] args)
        {

        }
    }
}
