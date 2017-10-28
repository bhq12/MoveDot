using System;
using System.Data;
using System.Xml.Xsl.Runtime;
using MoveDot.Model;

namespace MoveDot.View
{
    public class SimpleDotView : IDotView
    {
        private Dot _dot;
        public SimpleDotView(Dot dot)
        {
            _dot = dot;
        }

        public void Update()
        {
            var position = _dot.Position;
            Console.WriteLine("Dot: (" + position.X + "," + position.Y + ")");
        }
    }
}