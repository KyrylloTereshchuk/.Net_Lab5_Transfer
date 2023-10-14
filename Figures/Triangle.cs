using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class Triangle : IFigure
    {
        private int x1, y1, x2, y2, x3, y3;
        private string color;

        public void Draw(int x1, int y1, int x2, int y2, int x3, int y3, string color, Editor editor)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.x3 = x3;
            this.y3 = y3;
            this.color = color;

            editor.AddFigure(this);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Намальовано трикутник з координатами вершин ({x1}, {y1}), ({x2}, {y2}), ({x3}, {y3}), кольором {color}\n");
            Console.ResetColor();
        }

        public void Move(int deltaX, int deltaY)
        {
            x1 += deltaX;
            y1 += deltaY;
            x2 += deltaX;
            y2 += deltaY;
            x3 += deltaX;
            y3 += deltaY;
        }

        public void ChangeColor(string newColor)
        {
            color = newColor;
        }

        public IFigureSnapshot CreateSnapshot()
        {
            return new TriangleSnapshot(x1, y1, x2, y2, x3, y3, color);
        }

        public void Restore(IFigureSnapshot snapshot)
        {
            if (snapshot is TriangleSnapshot triangleSnapshot)
            {
                x1 = triangleSnapshot.X1;
                y1 = triangleSnapshot.Y1;
                x2 = triangleSnapshot.X2;
                y2 = triangleSnapshot.Y2;
                x3 = triangleSnapshot.X3;
                y3 = triangleSnapshot.Y3;
                color = triangleSnapshot.Color;
            }
        }

        public override string ToString()
        {
            return $"Трикутник з координатами вершин ({x1}, {y1}), ({x2}, {y2}), ({x3}, {y3}), кольором {color}\n";
        }
    }
}
