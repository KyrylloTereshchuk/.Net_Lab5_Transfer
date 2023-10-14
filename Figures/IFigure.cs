using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public interface IFigure
    {
        void Move(int deltaX, int deltaY);
        void ChangeColor(string color);
        IFigureSnapshot CreateSnapshot();
        void Restore(IFigureSnapshot snapshot);
    }
}
