using System;
namespace MoveDot.View
{
    public class ScreenPaddingCalculator
    {
        public static int GetScreenPadding(int position, int screenSize)
        {
            screenSize = screenSize == 0 ? 1 : screenSize;

            var screenPosition = 0;
            if (position < 0)
            {
                if (Math.Abs(position) % screenSize == 0)
                {
                    screenPosition = 0;
                }
                else
                {
                    screenPosition = screenSize - (Math.Abs(position) % screenSize);
                }
            }
            else
            {
                screenPosition = position % screenSize;
            }

            return screenPosition; 
        }
    }
}