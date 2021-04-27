using System;
using System.Collections.Generic;

namespace Bowling.Domain
{
    public class Game
    {
        private List<Frame> frames = new List<Frame>();
        
        public void Throw(int first, int second)
        {
            frames.Add(new Frame(first, second).Create(first, second));
        }
        public int Score()
        {
            frames.Add(new Frame(0, 0));
            frames.Add(new Frame(0, 0));
            for (int i = 0; i < 10; i++)
                frames[i].Bonus(frames[i + 1], frames[i + 2]);

            int counter = 0;
            frames.ForEach(frame => counter += frame.Score());
            return counter;
        }

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Hello World!");
        //}
        static void Main(string[] args)
        {

        }
    }
}
