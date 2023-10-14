using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class TriangleSnapshot : IFigureSnapshot
    {
        public int X1 { get; }
        public int Y1 { get; }
        public int X2 { get; }
        public int Y2 { get; }
        public int X3 { get; }
        public int Y3 { get; }
        public string Color { get; }

        public TriangleSnapshot(int x1, int y1, int x2, int y2, int x3, int y3, string color)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
            X3 = x3;
            Y3 = y3;
            Color = color;
        }
    }
}
