using MoveDot.Model;
using System;
using System.Text;

namespace MoveDot.View
{
    public class ConsoleDotView : IDotView
    {
        private Dot _dot;
        
        public ConsoleDotView(Dot dot)
        {
            _dot = dot;
        }

        public void Update()
        {
            var position = _dot.Position;
            var width = Console.WindowWidth;
            var height = Console.WindowHeight;

            for (int i = 0; i < height; i++)
            {
                if (i == position.Y % height)
                {
                    var line = new String(' ', position.X - 1) + "." + new String(' ', width - position.X);
                    Console.WriteLine(line);
                }
                else
                {
                    Console.WriteLine(new String(' ', width));
                }
            }
        }
    }
}