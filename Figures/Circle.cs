using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class Circle : IFigure
    {
        private int centerX;
        private int centerY;
        private int radius;
        private string color;

        public void Draw(int centerX, int centerY, int radius, string color, Editor editor)
        {
            this.centerX = centerX;
            this.centerY = centerY;
            this.radius = radius;
            this.color = color;

            editor.AddFigure(this);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Намальовано коло з координатами ({centerX}, {centerY}), радіусом {radius}, кольором {color}\n");
            Console.ResetColor();
        }

        public void Move(int deltaX, int deltaY)
        {
            centerX += deltaX;
            centerY += deltaY;
        }

        public void ChangeColor(string newColor)
        {
            color = newColor;
        }

        public IFigureSnapshot CreateSnapshot()
        {
            return new CircleSnapshot(centerX, centerY, radius, color);
        }

        public void Restore(IFigureSnapshot snapshot)
        {
            if (snapshot is CircleSnapshot circleSnapshot)
            {
                centerX = circleSnapshot.CenterX;
                centerY = circleSnapshot.CenterY;
                radius = circleSnapshot.Radius;
                color = circleSnapshot.Color;
            }
        }

        public override string ToString()
        {
            return $"Коло з координатами ({centerX}, {centerY}), радіусом {radius}, кольором {color}\n";
        }
    }
}
