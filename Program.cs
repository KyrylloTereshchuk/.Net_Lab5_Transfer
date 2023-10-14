using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Editor editor = new Editor();

            Circle circle = new Circle();
            Triangle triangle = new Triangle();
            circle.Draw(50, 50, 30, "червоний", editor);
            triangle.Draw(10, 10, 20, 20, 30, 30, "синій", editor);


                 editor.CreateSnapshot();

            circle.Move(10, 10);

                 editor.CreateSnapshot();


            triangle.ChangeColor("зелений");

            Console.WriteLine("Стан фігур після двох змін:");

            foreach (var figure in editor.GetFigures()) //Виводимо стан фігур після змін
            {
                Console.WriteLine(figure.ToString());
            }

            Console.WriteLine("Повернення на крок назад:");
            editor.RestoreSnapshot();

            foreach (var figure in editor.GetFigures()) // Виводимо стан фігур після повернення на один крок назад
            {
                Console.WriteLine(figure.ToString());
            }

            Console.WriteLine("Повернення на 2 кроки назад:");
            editor.RestoreSnapshot();

            foreach (var figure in editor.GetFigures()) // Виводимо стан фігур пвсля повернення на два кроки назад
            {
                Console.WriteLine(figure.ToString());
            }

            Console.WriteLine("Видалимо коло:");
            editor.DeleteFigure(circle);

            foreach (var figure in editor.GetFigures()) // Виводимо стан фігур після видалення однієї фігури
            {
                Console.WriteLine(figure.ToString());
            }
        }
    }
}
