using System.Collections.Generic;
using System.Linq;

namespace Bowling.Domain
{
    public class Game
    {
        public Game()
        {

        }
        private List<Frame> frames = new List<Frame>();
        
        public void Throw(int first, int second)
        {
            frames.Add(new Frame(first, second).CreateFrame());
        }
        public int CalcScore()
        {
            frames.Add(new Frame(0, 0));
            frames.Add(new Frame(0, 0));
            frames.Count();
            for (int i = 0; i < frames.Count()-2; i++)
            {
                frames[i].AddBonus(frames[i + 1], frames[i + 2]);
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
