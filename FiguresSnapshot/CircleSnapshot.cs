using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class CircleSnapshot : IFigureSnapshot
    {
        public int CenterX { get; }
        public int CenterY { get; }
        public int Radius { get; }
        public string Color { get; }

        public CircleSnapshot(int centerX, int centerY, int radius, string color)
        {
            CenterX = centerX;
            CenterY = centerY;
            Radius = radius;
            Color = color;
        }
    }
}
