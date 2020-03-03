using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometri_inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figure> figures = new List<Figure>();
            // Create Square 
            Square square = new Square();
            square.SideA = 10;
            square.Name = "Square";
            figures.Add(square);

            // Create Rectangle
            Rectangle rect = new Rectangle();
            rect.SideA = 10;
            rect.Name = "Rectangle";
            figures.Add(rect);

            // Create Trapez
            Trapez trap = new Trapez();
            trap.SideA = 10;
            trap.SideB = 9;
            trap.SideC = 8;
            trap.SideD = 9;
            trap.Name = "Trapez";
            figures.Add(trap);

            // Create Parallelogram
            Parallelogram para = new Parallelogram();
            para.SideA = 3;
            para.SideB = 5;
            para.Angle = 20;
            para.Name = "Parallelogram";
            figures.Add(para);

            // Create Triangle
            Triangle triangle = new Triangle();
            triangle.SideA = 10;
            triangle.SideB = 5;
            triangle.SideC = 10;
            triangle.Name = "Triangle";
            figures.Add(triangle);

            foreach (Figure fig in figures)
            {
                Console.WriteLine("{0} has area: {1} and perimeter: {2}", fig.Name, fig.GetArea(), fig.GetPerimeter());
            }
            Console.ReadKey();
        }
    }
}
