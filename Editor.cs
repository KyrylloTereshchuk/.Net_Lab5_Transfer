using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class Editor
    {
        private List<IFigure> figures;
        private Stack<List<IFigureSnapshot>> snapshots;

        public Editor()
        {
            figures = new List<IFigure>();
            snapshots = new Stack<List<IFigureSnapshot>>();
        }

        public void AddFigure(IFigure figure)
        {
            figures.Add(figure);
        }

        public void DeleteFigure(IFigure figure)
        {
            figures.Remove(figure);
        }

        public void CreateSnapshot()
        {
            var snapshot = figures.Select(figure => figure.CreateSnapshot()).ToList();
            snapshots.Push(snapshot);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Знімок зроблено\n");
            Console.ResetColor();
        }

        public void RestoreSnapshot()
        {
            if (snapshots.Count > 0)
            {
                var snapshot = snapshots.Pop();
                for (int i = 0; i < figures.Count; i++)
                {
                    figures[i].Restore(snapshot[i]);
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Знімок відновлено\n");
            Console.ResetColor();
        }

        public List<IFigure> GetFigures()
        {
            return figures;
        }
    }
}
