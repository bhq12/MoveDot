using MoveDot.Model;
using System;
using System.Text;

namespace MoveDot.View
{
    public class ConsoleDotView : IDotView
    {
        private Dot _dot;
        private StringBuilder _stringBuilder;
        
        public ConsoleDotView(Dot dot)
        {
            _dot = dot;
            _stringBuilder = new StringBuilder();
        }

        public void Update()
        {
            var position = _dot.Position;
            var screenWidth = Console.WindowWidth;
            var screenHeight = Console.WindowHeight;

            screenHeight--;//console has bottom row dedicated to the cursor

            var screenPositionX = ScreenPaddingCalculator.GetScreenPadding(position.X, screenWidth);
            
            //x is left padded, whereas y is "top-padded", so we want screenheight - bottompadding
            var screenPositionY = (screenHeight - 1) - ScreenPaddingCalculator.GetScreenPadding(position.Y, screenHeight);
            
            for (int i = 0; i < screenHeight; i++)
            {
                if (i == screenPositionY)
                {
                    var stringSize = screenPositionX + 1;
                    Console.WriteLine(".".PadLeft(stringSize));
                }
                else
                {
                    Console.WriteLine("");
                }
            }            
        }
    }
}